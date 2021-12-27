﻿using Microsoft.EntityFrameworkCore;
using ProjectBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
            public DbSet<Slider> Sliders { get; set; }
            public DbSet<Welcome> Welcomes { get; set; }
    }
}