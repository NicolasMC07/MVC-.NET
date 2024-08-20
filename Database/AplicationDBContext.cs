using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMVC.Database
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
        {

        }
    }
}