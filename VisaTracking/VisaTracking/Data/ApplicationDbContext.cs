using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VisaTracking.Models;

namespace VisaTracking.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<VisaStatus> VisaStatuses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<ProfilePicture> ProfilePictures { get; set; }
        public DbSet<EnrollmentAttachments> EnrollmentAttachments { get; set; }
    }
}
