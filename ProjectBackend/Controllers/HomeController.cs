using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.DataAccessLayer;
using ProjectBackend.Models;
using ProjectBackend.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

       

        public async Task<IActionResult> Index()
        {
            var slider = await _dbContext.Sliders.SingleOrDefaultAsync();
            var welcome = await _dbContext.Welcomes.SingleOrDefaultAsync();

            return View(new HomeViewModel {
            Slider=slider,
            Welcome=welcome
            });
            
        }
    }
}
