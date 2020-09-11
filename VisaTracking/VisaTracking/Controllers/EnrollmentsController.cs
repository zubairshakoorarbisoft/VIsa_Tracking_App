using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VisaTracking.Data;
using VisaTracking.Models;

namespace VisaTracking.Controllers
{
    public class EnrollmentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public EnrollmentsController(ApplicationDbContext context,
                                    IWebHostEnvironment webHostEnvironment,
                                    UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _webHostEnvironment = webHostEnvironment;
        }

        #region Private Methods

        private async Task<List<string>> UploadDocuments(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);
            var enrollmentDocumentsNames = new List<string>();
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "enrollmentDocuments");
                    var fileName = string.Concat(Stopwatch.GetTimestamp().ToString(), Guid.NewGuid().ToString() + "10___01" + formFile.FileName);
                    var fileNameWithPath = string.Concat(filePath, "\\", fileName);
                    enrollmentDocumentsNames.Add(fileName);

                    using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                }
            }
            return enrollmentDocumentsNames;
        }

        #endregion

        // GET: Enrollments
        public async Task<IActionResult> Index(bool IsShowClosed = false)
        {
            string userId = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Id;
            ViewBag.RoleName = _context.Roles.FirstOrDefault(i => i.Id == _context.UserRoles.FirstOrDefault(u => u.UserId == userId).RoleId).Name;
            if (ViewBag.RoleName == "Counselor")
            {
                var filteredEnrollments = IsShowClosed ? _context.Enrollments.Where(i => i.CreatedByEmailAddress == User.Identity.Name && i.VisaStatusId == 9).Include(e => e.VisaStatus) :
                    _context.Enrollments.Where(i => i.CreatedByEmailAddress == User.Identity.Name && i.VisaStatusId != 9).Include(e => e.VisaStatus);
                return View(await filteredEnrollments.ToListAsync());
            }
            var allEnrollments = IsShowClosed ? _context.Enrollments.Where(i => i.VisaStatusId == 9).Include(e => e.VisaStatus) :
                _context.Enrollments.Where(i => i.VisaStatusId != 9).Include(e => e.VisaStatus);
            ViewBag.IsShowClosed = IsShowClosed;
            return View(await allEnrollments.ToListAsync());
        }

        // GET: Enrollments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollments
                .Include(e => e.VisaStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enrollment == null)
            {
                return NotFound();
            }

            // Retriving Enrollment Documents

            var enrollmentDocumentsNames = _context.EnrollmentAttachments.Where(i => i.EnrollmentId == enrollment.Id)
                                            .Select(d => d.DocumentName).ToList();

            var enrollmentDocumentsPath = Path.Combine(_webHostEnvironment.WebRootPath, "enrollmentDocuments");
            DirectoryInfo dir = new DirectoryInfo(enrollmentDocumentsPath);
            FileInfo[] files = dir.GetFiles().Where(i => enrollmentDocumentsNames.Contains(i.Name)).ToArray();
            enrollment.EnrollmentAttachedDocuments = files;
            return View(enrollment);
        }

        // GET: Enrollments/Create
        [Authorize(Policy = "CreateRolePolicy")]
        public IActionResult Create()
        {
            string userId = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Id;
            ViewBag.RoleName = _context.Roles.FirstOrDefault(i => i.Id == _context.UserRoles.FirstOrDefault(u => u.UserId == userId).RoleId).Name;
            ViewData["VisaStatusId"] = new SelectList(_context.VisaStatuses, "Id", "Status");
            return View();
        }

        // POST: Enrollments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "CreateRolePolicy")]
        public async Task<IActionResult> Create(Enrollment enrollment, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                enrollment.ApplicationStartDate = DateTime.Now;
                enrollment.CreatedByEmailAddress = User.Identity.Name;
                enrollment.VisaStatusId = 1;
                _context.Add(enrollment);
                await _context.SaveChangesAsync();
                List<string> uploadedDocumentsNames = await UploadDocuments(files);
                List<EnrollmentAttachments> documentAttachements = new List<EnrollmentAttachments>();
                foreach (var fileName in uploadedDocumentsNames)
                {
                    documentAttachements.Add(new EnrollmentAttachments()
                    {
                        EnrollmentId = enrollment.Id,
                        DocumentName = fileName
                    });
                }
                await _context.EnrollmentAttachments.AddRangeAsync(documentAttachements);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            ViewData["VisaStatusId"] = new SelectList(_context.VisaStatuses, "Id", "Status", enrollment.VisaStatusId);
            TempData["SuccessMessage"] = "Enrollment added successfully.";
            return View(enrollment);
        }

        // GET: Enrollments/Edit/5
        [Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollments.FindAsync(id);
            if (enrollment == null)
            {
                return NotFound();
            }
            string userId = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Id;
            ViewBag.RoleName = _context.Roles.FirstOrDefault(i => i.Id == _context.UserRoles.FirstOrDefault(u => u.UserId == userId).RoleId).Name;
            ViewData["VisaStatusId"] = new SelectList(_context.VisaStatuses, "Id", "Status", enrollment.VisaStatusId);

            // Retriving Enrollment Documents

            var enrollmentDocumentsNames = _context.EnrollmentAttachments.Where(i => i.EnrollmentId == enrollment.Id)
                                            .Select(d => d.DocumentName).ToList();

            var enrollmentDocumentsPath = Path.Combine(_webHostEnvironment.WebRootPath, "enrollmentDocuments");
            DirectoryInfo dir = new DirectoryInfo(enrollmentDocumentsPath);
            FileInfo[] files = dir.GetFiles().Where(i => enrollmentDocumentsNames.Contains(i.Name)).ToArray();
            enrollment.EnrollmentAttachedDocuments = files;

            // Resolve the user via their email
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            // Get the roles for the user
            IList<string> roles = await _userManager.GetRolesAsync(user);
            ViewBag.UserRole = roles[0];
            enrollment.FeePaidHalf = Convert.ToInt32(enrollment.FeePaid) / 2;
            return View(enrollment);
        }

        // POST: Enrollments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "EditRolePolicy")]
        public async Task<IActionResult> Edit(int id, Enrollment enrollment, List<IFormFile> files)
        {
            if (id != enrollment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (enrollment.VisaStatusId == 9)
                    {
                        enrollment.ApplicationEndDate = DateTime.Now;
                    }
                    _context.Update(enrollment);
                    _context.Entry<Enrollment>(enrollment).Property(x => x.ApplicationStartDate).IsModified = false;
                    _context.Entry<Enrollment>(enrollment).Property(x => x.CreatedByEmailAddress).IsModified = false;
                    await _context.SaveChangesAsync();
                    if (enrollment.VisaStatusId == 9)
                    {
                        // Retriving Enrollment Documents for Deletion

                        var enrollmentDocumentsNames = _context.EnrollmentAttachments.Where(i => i.EnrollmentId == enrollment.Id)
                                                        .Select(d => d.DocumentName).ToList();
                        var enrollmentAllDocuments = _context.EnrollmentAttachments.Where(i => i.EnrollmentId == enrollment.Id);
                        _context.EnrollmentAttachments.RemoveRange(enrollmentAllDocuments);
                        await _context.SaveChangesAsync();
                        foreach (var docName in enrollmentDocumentsNames)
                        {
                            string _documentToBeDeleted = Path.Combine(_webHostEnvironment.WebRootPath, "enrollmentDocuments\\", docName);
                            if ((System.IO.File.Exists(_documentToBeDeleted)))
                            {
                                System.IO.File.Delete(_documentToBeDeleted);
                            }
                        }

                    }
                    List<string> uploadedDocumentsNames = await UploadDocuments(files);
                    List<EnrollmentAttachments> documentAttachements = new List<EnrollmentAttachments>();
                    foreach (var fileName in uploadedDocumentsNames)
                    {
                        documentAttachements.Add(new EnrollmentAttachments()
                        {
                            EnrollmentId = enrollment.Id,
                            DocumentName = fileName,
                            IsDecisionDocument = (enrollment.VisaStatusId == 9)
                        });
                    }
                    await _context.EnrollmentAttachments.AddRangeAsync(documentAttachements);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrollmentExists(enrollment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["SuccessMessage"] = "Enrollment updated successfully.";
                return RedirectToAction(nameof(Index));
            }
            ViewData["VisaStatusId"] = new SelectList(_context.VisaStatuses, "Id", "Id", enrollment.VisaStatusId);
            return View(enrollment);
        }

        // GET: Enrollments/Delete/5
        [Authorize(Policy = "DeleteRolePolicy")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollment = await _context.Enrollments
                .Include(e => e.VisaStatus)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enrollment == null)
            {
                return NotFound();
            }

            return View(enrollment);
        }

        // POST: Enrollments/Delete/5
        [Authorize(Policy = "DeleteRolePolicy")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Retriving Enrollment Documents for Deletion

            var enrollmentDocumentsNames = _context.EnrollmentAttachments.Where(i => i.EnrollmentId == id)
                                            .Select(d => d.DocumentName).ToList();

            var enrollment = await _context.Enrollments.FindAsync(id);
            _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();


            foreach (var docName in enrollmentDocumentsNames)
            {
                string _documentToBeDeleted = Path.Combine(_webHostEnvironment.WebRootPath, "enrollmentDocuments\\", docName);
                if ((System.IO.File.Exists(_documentToBeDeleted)))
                {
                    System.IO.File.Delete(_documentToBeDeleted);
                }
            }


            TempData["SuccessMessage"] = "Enrollment deleted successfully.";
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteEnrollmentDocument(string docName, int enrollmentId)
        {
            var enrollmentDocument = await _context.EnrollmentAttachments.FirstOrDefaultAsync(i => i.EnrollmentId == enrollmentId && i.DocumentName == docName);
            _context.EnrollmentAttachments.Remove(enrollmentDocument);
            await _context.SaveChangesAsync();

            string _documentToBeDeleted = Path.Combine(_webHostEnvironment.WebRootPath, "enrollmentDocuments\\", docName);
            if ((System.IO.File.Exists(_documentToBeDeleted)))
            {
                System.IO.File.Delete(_documentToBeDeleted);
            }
            TempData["SuccessMessage"] = "Document [" + docName.Split(new string[] { "10___01" }, System.StringSplitOptions.RemoveEmptyEntries)[1] + "] deleted successfully.";
            return RedirectToAction("Edit", new { id = enrollmentId });
        }

        private bool EnrollmentExists(int id)
        {
            return _context.Enrollments.Any(e => e.Id == id);
        }
    }
}
