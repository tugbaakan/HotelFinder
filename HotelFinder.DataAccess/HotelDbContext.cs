using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.DataAccess
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=bissqldev1\\db;Initial Catalog=dbdwh;integrated security=SSPI;Pooling=False;Connection Reset=False;Connect Timeout=600;Application Name=BIS Winbank" );

        }

        public DbSet<Hotel> Hotels { get; set; }


    }
}
