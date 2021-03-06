﻿using VisaTracking.Models;
using VisaTracking.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VisaTracking.Data;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace VisaTracking.Controllers
{
    [Authorize(Roles = "Super Admin")]
    public class AdministrationController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdministrationController(RoleManager<IdentityRole> roleManager,
                                        UserManager<IdentityUser> userManager,
                                        ApplicationDbContext context,
                                        SignInManager<IdentityUser> signInManager,
                                        IWebHostEnvironment webHostEnvironment
                                        )
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
        }

        #region Private Methods
        private string UploadedFile(SignUpViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "profileImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        #endregion

        #region role management
        public IActionResult RolesList()
        {
            return View(_roleManager.Roles);
        }
        [HttpGet]
        public IActionResult UsersList()
        {
            return View(_userManager.Users);
        }
        //[HttpGet]
        //public IActionResult CreateRole()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        //{
        //    if (ModelState.IsValid && model != null)
        //    {
        //        IdentityRole role = new IdentityRole()
        //        {
        //            Name = model.Name
        //        };
        //        IdentityResult result = await _roleManager.CreateAsync(role);

        //        if (result.Succeeded)
        //        {
        //            TempData["SuccessMessage"] = "Role added successfully.";
        //            return RedirectToAction("RolesList", "Administration");
        //        }
        //        else
        //        {
        //            foreach (IdentityError error in result.Errors)
        //            {
        //                ModelState.AddModelError("", error.Description);
        //            }
        //            return View(model);
        //        }
        //    }
        //    return View();
        //}

        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"No Role found against this { id} Role Id";
                return View("NotFound");
            }
            EditRoleViewModel editRole = new EditRoleViewModel()
            {
                Id = role.Id,
                Name = role.Name
            };
            editRole.Users = new List<string>();
            foreach (var user in _userManager.Users)
            {
                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    editRole.Users.Add(user.UserName);
                }
            }
            return View(editRole);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.Id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"No Role found against this { model.Id} Role Id";
                return View("NotFound");
            }

            role.Name = model.Name;
            IdentityResult result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Role updated successfully.";
                return RedirectToAction("RolesList");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"No Role found against this {id} Role Id";
                return View("NotFound");
            }

            IdentityResult result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                TempData["SuccessMessage"] = "Role deleted successfully.";
                return RedirectToAction("RolesList");
            }
            else
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return RedirectToAction("RolesList");
            }
        }
        [HttpGet]
        public async Task<IActionResult> AddEditUsersInRole(string roleId)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"No Role found against this {roleId} Role Id";
                return View("NotFound");
            }
            ViewBag.Role = role;
            List<UserRoleViewModel> UserRoles = new List<UserRoleViewModel>();

            foreach (var user in _userManager.Users)
            {
                UserRoleViewModel UserRole = new UserRoleViewModel()
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    IsSelected = await _userManager.IsInRoleAsync(user, role.Name)
                };
                UserRoles.Add(UserRole);
            }

            return View(UserRoles);
        }
        [HttpPost]
        public async Task<IActionResult> AddEditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var EditRoleFromUserId = TempData["EditRoleFromUserId"];
            IdentityRole role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"No Role found against this {roleId} Role Id";
                return View("NotFound");
            }


            for (int i = 0; i < model.Count; i++)
            {
                IdentityUser user = await _userManager.FindByIdAsync(model[i].UserId);
                IdentityResult result = null;
                if (user == null)
                {
                    ViewBag.ErrorMessage = $"No User found against this {model[i].UserId} User Id";
                    return View("NotFound");
                }
                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                    continue;

                if (result.Succeeded && (i < model.Count - 1))
                    continue;
                else
                {
                    if (EditRoleFromUserId == null)
                        return RedirectToAction("EditRole", new { id = roleId });
                    else
                    {
                        TempData["EditRoleFromUserId"] = null;
                        return RedirectToAction("EditUser", new { id = EditRoleFromUserId });
                    }
                }

            }
            if (EditRoleFromUserId == null)
                return RedirectToAction("EditRole", new { id = roleId });
            else
            {
                TempData["EditRoleFromUserId"] = null;
                return RedirectToAction("EditUser", new { id = EditRoleFromUserId });
            }
        }
        #endregion



        #region user Management

        // Applying Claims based authentication by applying Policies
        [HttpGet]
        //[Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"No User found against this { id} User Id";
                return View("NotFound");
            }
            EditUserViewModel editUser = new EditUserViewModel()
            {
                Id = user.Id,
                UserName = user.UserName
            };

            // Getting Claims
            var existingUserClaims = await _userManager.GetClaimsAsync(user);
            foreach (var claim in existingUserClaims)
            {
                editUser.claims.Add(claim.Type);
            }
            // Getting Roles
            var existingUserRoles = await _userManager.GetRolesAsync(user);
            foreach (string roleName in existingUserRoles)
            {
                editUser.roles.Add(roleName);
            }
            return View(editUser);
        }
        public IActionResult ManageRoles(string userId)
        {
            TempData["EditRoleFromUserId"] = userId;
            return View("RolesList", _roleManager.Roles);
        }
        [HttpGet]
        public async Task<IActionResult> ManageClaims(string userId)
        {
            UserClaimsViewModel userClaims = new UserClaimsViewModel();
            var user = await _userManager.FindByIdAsync(userId);
            ViewBag.User = user;
            if (user == null)
            {
                ViewBag.ErrorMessage = $"No User found against this { userId} User Id";
                return View("NotFound");
            }


            var existingUserClaims = await _userManager.GetClaimsAsync(user);
            userClaims.UserId = userId;
            foreach (var claim in ClaimsStore.AllClaims)
            {
                UserClaim userClaim = new UserClaim()
                {
                    ClaimsType = claim.Type
                };

                if (existingUserClaims.Any(c => c.Type == claim.Type))
                {
                    userClaim.IsSelected = true;
                }
                userClaims.Claims.Add(userClaim);
            }

            return View(userClaims);
        }
        [HttpPost]
        public async Task<IActionResult> ManageClaims(UserClaimsViewModel model)
        {
            UserClaimsViewModel userClaims = new UserClaimsViewModel();
            var user = await _userManager.FindByIdAsync(model.UserId);
            ViewBag.User = user;
            if (user == null)
            {
                ViewBag.ErrorMessage = $"No User found against this { model.UserId} User Id";
                return View("NotFound");
            }


            var existingUserClaims = await _userManager.GetClaimsAsync(user);
            var result = await _userManager.RemoveClaimsAsync(user, existingUserClaims);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove existing user claims");
                return View(model);
            }

            result = await _userManager.AddClaimsAsync(user, model.Claims.Where(c => c.IsSelected)
                .Select(c => new Claim(c.ClaimsType, c.ClaimsType)));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected user claims");
                return View(model);
            }

            return RedirectToAction("EditUser", new { id = model.UserId });
        }

        #endregion

        #region Add New USer by Super Admin Module

        [HttpGet]
        public IActionResult SignUp()
        {
            SignUpViewModel model = new SignUpViewModel()
            {
                UserRoles = _roleManager.Roles.ToList()
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.EmailAddress, Email = model.EmailAddress, EmailConfirmed = true };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // Adding User in to the Role he/she selected
                    IdentityRole role = await _roleManager.FindByIdAsync(model.RoleId.ToString());
                    var createRoleResult = await _userManager.AddToRoleAsync(user, role.Name);
                    if (createRoleResult.Succeeded)
                    {
                        switch (model.RoleId)
                        {
                            case 1:
                                model.Claims.Add(new UserClaim { ClaimsType = "Create Role" });
                                model.Claims.Add(new UserClaim { ClaimsType = "Edit Role" });
                                model.Claims.Add(new UserClaim { ClaimsType = "Delete Role" });
                                break;
                            case 2:
                                model.Claims.Add(new UserClaim { ClaimsType = "Edit Role" });
                                model.Claims.Add(new UserClaim { ClaimsType = "Delete Role" });
                                break;
                            case 3:
                                model.Claims.Add(new UserClaim { ClaimsType = "Create Role" });
                                model.Claims.Add(new UserClaim { ClaimsType = "Edit Role" });
                                break;
                            case 4:
                                model.Claims.Add(new UserClaim { ClaimsType = "Edit Role" });
                                break;
                            case 5:
                                model.Claims.Add(new UserClaim { ClaimsType = "Edit Role" });
                                model.Claims.Add(new UserClaim { ClaimsType = "Delete Role" });
                                break;
                        }

                        // Adding Claims for the user been created
                        var claimsResult = await _userManager.AddClaimsAsync(user,
                            model.Claims.Select(c => new Claim(c.ClaimsType, c.ClaimsType)));

                        string uniqueFileName = UploadedFile(model);
                        _context.ProfilePictures.Add(new ProfilePicture()
                        {
                            UserId = user.Id,
                            ProfilePictureName = uniqueFileName
                        });
                        await _context.SaveChangesAsync();
                        TempData["SuccessMessage"] = "User added successfully.";
                        return RedirectToAction("UsersList");
                    }
                    else
                    {
                        foreach (var error in result.Errors
                            )
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                        model.UserRoles = _roleManager.Roles.ToList();
                        return View(model);
                    }
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    model.UserRoles = _roleManager.Roles.ToList();
                    return View(model);
                }
            }
            else
            {
                model.UserRoles = _roleManager.Roles.ToList();
                return View(model);
            }
        }

        #endregion
    }


}