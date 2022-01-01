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
            var sliders = await _dbContext.Sliders.SingleOrDefaultAsync();
            var welcomes = await _dbContext.Welcomes.SingleOrDefaultAsync();
            var sliderImages = await _dbContext.SliderImages.ToListAsync();
            var noticeVideos = await _dbContext.NoticeVideos.SingleOrDefaultAsync();
            var noticeBoards= await _dbContext.NoticeBoards.ToListAsync();
            var courses= await _dbContext.Courses.ToListAsync();
            var events= await _dbContext.Events.ToListAsync();
            var categories= await _dbContext.Categories.ToListAsync();
            var courseDetails= await _dbContext.CourseDetails.ToListAsync();
            var eventDetails= await _dbContext.EventDetails.ToListAsync();

            return View(new HomeViewModel {
            Slider=sliders,
            Welcome=welcomes,
            SliderImage =sliderImages,
            NoticeVideo=noticeVideos,
            NoticeBoard= noticeBoards,
            Course=courses,
            Event=events,
            Category=categories,
            CourseDetail=courseDetails,
            EventDetail=eventDetails

            });
            
        }
    }
}
