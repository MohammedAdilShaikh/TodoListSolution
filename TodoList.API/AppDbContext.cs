﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoList.Models;

namespace TodoList.API
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}