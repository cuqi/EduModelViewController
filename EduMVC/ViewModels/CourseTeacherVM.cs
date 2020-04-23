using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using EduMVC.Models;

namespace EduMVC.ViewModels
{
    public class CourseTeacherVM
    {
        public IList<Course> Courses { get; set; }
        public string CourseTitle { get; set; }
        public int CourseSemester { get; set; }
        public string CourseProgramme { get; set; }

    }
}
