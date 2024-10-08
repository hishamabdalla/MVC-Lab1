﻿using Microsoft.EntityFrameworkCore;

namespace MVC_Lab1.Models
{
    public class ITIEntity : DbContext
    {
        public ITIEntity()
        {
        }

        public ITIEntity(DbContextOptions<ITIEntity> options)
        : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=Hisham\SQLEXPRESS;Initial Catalog=MVCTask;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }
    }
}
