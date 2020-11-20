using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace makeChange.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUserPetition>().HasKey(sc => new { sc.ApplicationUserId, sc.PetitionId });
            // modelBuilder.Seed();
        }
        public DbSet<Petition> Petitions { get; set; }

        public DbSet<ApplicationUserPetition> ApplicationUserPetitions { get; set; }
    }
}
