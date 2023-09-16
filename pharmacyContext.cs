using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProjectITI
{
    public class pharmacyContext : DbContext
    {
        public DbSet<User> user { set; get; }
        public DbSet<Medicien> medicien { set; get; }
        public DbSet<User_mediciens> User_Mediciens { set; get; }
        public DbSet<Categary> categarie { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ALEX\\MSSQLSERVERR;Database=Pharmacy;Trusted_Connection=True;Encrypt=False");
        }
    }
}