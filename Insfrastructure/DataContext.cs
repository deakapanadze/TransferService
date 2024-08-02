using Core.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Insfrastructure
{
    public  class DataContext : DbContext
    {

        public DbSet<Transfer> transfers { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DataContext() { }
    }
}
