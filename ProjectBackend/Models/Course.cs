﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public string Name{ get; set; }
        public string Image { get; set; }
        public int CourseDetaileId { get; set; }
        public virtual CourseDetail CourseDetail  { get; set; }
    }
}
