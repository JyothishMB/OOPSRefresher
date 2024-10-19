using MediatorDemo.Infrastructure.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo.Infrastructure.Data.Contexts
{
    public class MediatorDemoContext : DbContext
    {
        public MediatorDemoContext(DbContextOptions<MediatorDemoContext> options)
            :base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
