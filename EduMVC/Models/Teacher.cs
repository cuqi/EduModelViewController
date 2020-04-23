using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace EduMVC.Models
{
    public class Teacher
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public String FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public String LastName { get; set; }

        [StringLength(50)]
        public String Degree { get; set; }

        [StringLength(25)]
        public String AcademicRank { get; set; }

        [StringLength(10)]
        public String OfficeNumber { get; set; }

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }

        public ICollection<Course> Professor { get; set; }
        public ICollection<Course> Assistant { get; set; }
    }
}
