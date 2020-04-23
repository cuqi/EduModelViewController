using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace EduMVC.Models
{
    public class Enrollment
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public int StudentId { get; set; }

        [StringLength(10)]
        public String Semester { get; set; }

        public int Year { get; set; }

        public int Grade { get; set; }

        [StringLength(255)]
        public String SeminalUrl { get; set; }

        [StringLength(255)]
        public String ProjectUrl { get; set; }

        public int ExamPoints { get; set; }

        public int SeminalPoints { get; set; }

        public int ProjectPoints { get; set; }

        public int AdditionalPoints { get; set; }

        [Display(Name = "Finish Date")]
        [DataType(DataType.Date)]
        public DateTime? FinishDate { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }


    }
}
