using System;
using MediatRDemo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MediatRDemo.Data.Database
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext() { }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) :
            base(options)
        { }

        public DbSet<Movie> Movies { get; set; }
    }
}

