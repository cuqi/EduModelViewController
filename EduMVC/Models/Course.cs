using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace EduMVC.Models
{
    public class Course
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public String Title { get; set; }

        [Required]
        public int Credits { get; set; }

        [Required]
        public int Semester { get; set; }

        [StringLength(100)]
        public String Programme { get; set; }

        [StringLength(25)]
        public String EducationLevel { get; set; }

        public int? FirstTeacherId { get; set; }

        public int? SecondTeacherId { get; set; }

        public Teacher FirstTeacher { get; set; }
        public Teacher SecondTeacher { get; set; }

        public ICollection<Enrollment> Students { get; set; }
    }
}
