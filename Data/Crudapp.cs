using Crudapp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crudapp.Data
{
    public class CrudappContext : DbContext
    {
        public CrudappContext (DbContextOptions<CrudappContext> options) : base (options)
        {

        }
        public DbSet<Movie> Movie { get; set; }
    }
}
