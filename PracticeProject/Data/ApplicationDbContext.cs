﻿using Microsoft.EntityFrameworkCore;
using PracticeProject.Models;

namespace PracticeProject.Data
{
    public class ApplicationDbContext : DbContext  

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
    
}
