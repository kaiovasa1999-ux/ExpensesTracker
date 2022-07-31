﻿using Microsoft.EntityFrameworkCore;

namespace ExpensesTrackerMangaer.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :base(options)    
        {}
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
