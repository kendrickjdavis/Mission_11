using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission_11.Models
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options) : base(options) {}

        public DbSet<Book> Books { get; set; }
    }
}

