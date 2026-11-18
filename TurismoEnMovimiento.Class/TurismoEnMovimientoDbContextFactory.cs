using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoEnMovimiento.Class
{
    public class TurismoEnMovimientoDbContextFactory : IDesignTimeDbContextFactory<TurismoEnMovimientoDB>
    {
        TurismoEnMovimientoDB IDesignTimeDbContextFactory<TurismoEnMovimientoDB>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TurismoEnMovimientoDB>();
            optionsBuilder.UseSqlServer("Server=MQUIRINO\\SQLEXPRESS;Database=TurismoEnMovimientoDB;Trusted_Connection=True;TrustServerCertificate=True;");

            return new TurismoEnMovimientoDB(optionsBuilder.Options);
        }
    }
}
