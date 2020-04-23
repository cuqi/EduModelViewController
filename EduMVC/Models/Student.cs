using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace EduMVC.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }

        [StringLength(10)]
        [Required]
        public String StudentId { get; set; }

        [StringLength(50)]
        [Required]
        public String FirstName { get; set; }

        [StringLength(50)]
        [Required]
        public String LastName { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int AcquiredCredits { get; set; }
        [Range(1, 8)]

        public int CurrentSemestar { get; set; }

        [StringLength(25)]
        public String EducationLevel { get; set; }

        public ICollection<Enrollment> Courses { get; set; }
    }
}
