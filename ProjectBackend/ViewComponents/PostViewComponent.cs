using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.ViewComponents
{
    public class PostViewComponent:ViewComponent
    {
        private readonly AppDbContext _dbContext;
        public PostViewComponent(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
      public async Task<IViewComponentResult> InvokeAsync()
        {
            var posts = await _dbContext.Posts.Skip(3).Take(3).ToListAsync();
                return View();
        }
    }
}
