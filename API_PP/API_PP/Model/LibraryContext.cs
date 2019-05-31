﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_PP.Model
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
                                    : base(options)
        {

        }
        public DbSet<Teams> Team { get; set; }
        public DbSet<Speler> spelers { get; set; }

        public DbSet<Speler2> Speler { get; set; }

        public DbSet<Club> Clubs { get; set; }
    }
}
