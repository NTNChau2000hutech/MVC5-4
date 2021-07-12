using bigschool_lap543.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bigschool_lap543.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}