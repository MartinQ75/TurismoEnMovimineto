using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoEnMovimiento.Class.Models;

namespace TurismoEnMovimiento.Class
{
    public class SolicitudGemaRepository : ISolicitudGemaRepository
    {
        private readonly TurismoEnMovimientoDB _context;

        public SolicitudGemaRepository(TurismoEnMovimientoDB context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SolicitudGemaModel>> GetAllAsync()
        {
            return await _context.SolicitudesGema.ToListAsync();
        }

        public async Task<SolicitudGemaModel?> GetByIdAsync(int id)
        {
            return await _context.SolicitudesGema.FindAsync(id);
        }

        public async Task AddAsync(SolicitudGemaModel solicitud)
        {
            await _context.SolicitudesGema.AddAsync(solicitud);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(SolicitudGemaModel solicitud)
        {
            _context.SolicitudesGema.Update(solicitud);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var solicitud = await _context.SolicitudesGema.FindAsync(id);

            if (solicitud != null)
            {
                _context.SolicitudesGema.Remove(solicitud);
                await _context.SaveChangesAsync();
            }
        }
    }
}
