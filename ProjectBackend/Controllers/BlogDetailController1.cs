using Microsoft.AspNetCore.Mvc;
using ProjectBackend.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Controllers
{
    public class BlogDetailController : Controller
    {
        private readonly AppDbContext _dbContext;
        public BlogDetailController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
