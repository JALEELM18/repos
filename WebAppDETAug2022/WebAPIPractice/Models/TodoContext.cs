﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebAPIPractice.Models
{
    public class TodoContext : DbContext
    {
       
            public TodoContext(DbContextOptions<TodoContext> options)
                : base(options)
            {
            }

            public DbSet<ToDoItem> TodoItems { get; set; } = null!;
        
    }
}
