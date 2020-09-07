using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace VisaTracking.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        [Required, Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [Required, Display(Name = "Father Name")]
        public string FatherName { get; set; }
        [Required, Display(Name = "CNIC")]
        public string CNICNumber { get; set; }
        [Display(Name = "Passport Number")]
        public string PassportNumber { get; set; }
        [Required, Display(Name = "Last Qualification")]
        public string LastQualification { get; set; }
        [Required, Display(Name = "Apply For Country")]
        public string ApplyForCountry { get; set; }
        [Display(Name = "Grades")]
        public decimal GradesObtained { get; set; }
        [Display(Name = "Preffered Course")]
        public string PrefferedCourse { get; set; }
        [Display(Name = "First University Preference")]
        public string UniversityPreference1 { get; set; }
        [Display(Name = "Second University Preference")]
        public string UniversityPreference2 { get; set; }
        [Display(Name = "Current Address")]
        public string CurrentAddress { get; set; }
        [Display(Name = "Visa Status")]
        public int VisaStatusId { get; set; }
        [Display(Name = "Applied On")]
        public DateTime ApplicationStartDate { get; set; }
        [Display(Name = "Decision On")]
        public DateTime ApplicationEndDate { get; set; }
        [ForeignKey("VisaStatusId"), Display(Name = "Status")]
        public VisaStatus VisaStatus { get; set; }
        [Display(Name = "Fee Paid")]
        public int FeePaid { get; set; }

        #region Not Mapped
        [NotMapped]
        public string Visa_Status { get; set; }
        #endregion

        #region Not Mapped
        [NotMapped]
        public FileInfo[] EnrollmentAttachedDocuments { get; set; }
        [NotMapped, Display(Name = "50% of Fee Paid")]
        public float FeePaidHalf { get; set; }
        #endregion
    }
}
