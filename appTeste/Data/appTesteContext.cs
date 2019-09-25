using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace appTeste.Models
{
    public class appTesteContext : DbContext
    {
        public appTesteContext (DbContextOptions<appTesteContext> options)
            : base(options)
        {
        }
        
        public DbSet<appTeste.Models.Department> Department { get; set; }
        /*Adicionar os outros DBSets*/
        public DbSet<appTeste.Models.Seller> Seller { get; set; }
        public DbSet<appTeste.Models.SalesRecord> SalesRecord { get; set; }
    }
}
