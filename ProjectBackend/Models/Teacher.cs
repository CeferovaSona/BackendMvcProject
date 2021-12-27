using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public string  FullName{ get; set; }
        public string Profession { get; set; }
        public IFormFile Photo { get; set; }
        public TeacherDetail Id { get; set; }

    }
}
