using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dream_carMVC.Models;

namespace dream_carMVC.Data
{
    public class dream_carMVCdatabase : DbContext
    {
        public dream_carMVCdatabase (DbContextOptions<dream_carMVCdatabase> options)
            : base(options)
        {
        }

        public DbSet<dream_carMVC.Models.Company> Company { get; set; }

        public DbSet<dream_carMVC.Models.Dealer> Dealer { get; set; }

        public DbSet<dream_carMVC.Models.Model> Model { get; set; }

        public DbSet<dream_carMVC.Models.Specification> Specification { get; set; }
    }
}
