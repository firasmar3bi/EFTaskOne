using EFTaskOne.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTaskOne.Data
{
    internal class ApplicationDbContecxt : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=ASP9_EFTask;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Products> products { get; set; }
        
    }
}
