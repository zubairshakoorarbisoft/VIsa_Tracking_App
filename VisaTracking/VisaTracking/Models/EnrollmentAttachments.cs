using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VisaTracking.Models
{
    public class EnrollmentAttachments
    {
        public int Id { get; set; }
        public int EnrollmentId { get; set; }
        [ForeignKey("EnrollmentId")]
        public Enrollment Enrollment { get; set; }
        public string DocumentName { get; set; }
        public bool IsDecisionDocument { get; set; }
    }
}
