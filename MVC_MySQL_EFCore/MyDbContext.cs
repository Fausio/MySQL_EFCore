﻿using Microsoft.EntityFrameworkCore;
using MVC_MySQL_EFCore.Models;

namespace MVC_MySQL_EFCore
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Person> People { get; set; }
    }
}
