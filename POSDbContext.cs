using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using pos_app.Models;

namespace pos_app
{
    public class POSDbContext : DbContext
    {
        public POSDbContext(DbContextOptions<POSDbContext> options)
            : base(options)
        { }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Report> Reports {get;set;}
    }
}