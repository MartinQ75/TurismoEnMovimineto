using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoEnMovimiento.Class.Models;

namespace TurismoEnMovimiento.Class
{
    public interface ISolicitudGemaRepository
    {
        Task<IEnumerable<SolicitudGemaModel>> GetAllAsync();

        Task<SolicitudGemaModel?> GetByIdAsync(int id);

        Task AddAsync(SolicitudGemaModel solicitud);

        Task UpdateAsync(SolicitudGemaModel solicitud);

        Task DeleteAsync(int id);
    }
}
