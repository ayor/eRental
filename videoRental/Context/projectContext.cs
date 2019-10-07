using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using videoRental.Models;

namespace videoRental.Context
{
    public class projectContext : DbContext
    {
        public projectContext(DbContextOptions<projectContext> options) : base(options)
        {
        }
        public DbSet<CustomerModel> customers { get; set; }
        public DbSet<videoModel> videos { get; set; }
        public DbSet<checkOutModel> CheckOutModels { get; set; }
    }
}
