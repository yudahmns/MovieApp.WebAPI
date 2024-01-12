using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieApp.WebAPI.Models;

    public class MovieAppContext : DbContext
    {
        public MovieAppContext (DbContextOptions<MovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<MovieApp.WebAPI.Models.Movie> Movie { get; set; } = default!;
    }
