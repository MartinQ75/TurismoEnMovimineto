using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TurismoEnMovimiento.Class.Models;

namespace TurismoEnMovimiento.Class
{
    public class TurismoEnMovimientoDB : DbContext
    {
        public TurismoEnMovimientoDB(DbContextOptions<TurismoEnMovimientoDB> options) : base(options)
        {
        }

        public DbSet<SolicitudGemaModel> SolicitudesGema { get; set; }
    }
}
