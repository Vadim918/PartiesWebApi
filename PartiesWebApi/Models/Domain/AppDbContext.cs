using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PartiesWebApi.Models.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<GuestResponse> Parties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GuestResponse>().HasData(new GuestResponse
            {
                Id = 1,
                Name = "Oleg",
                WillAttend = true,
                PartiesName = "Birthday"
            });
        }
    }

}
