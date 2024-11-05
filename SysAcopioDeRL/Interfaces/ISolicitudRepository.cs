using SysAcopioDeRL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SysAcopioDeRL.Interfaces
{
    public interface ISolicitudRepository : IGenericRepository<Solicitud>
    {
        Task<IEnumerable<Solicitud>> GetRecursosActivos(long idRecurso);
        Task<IEnumerable<Solicitud>> GetSolicitudesActivasAsync();
        Task<IEnumerable<Solicitud>> GetByUrgenciaAsync(byte urgencia);
        Task<IEnumerable<RecursoSolicitud>> GetRecursosSolicitudAsync(long idSolicitud);
    }

    public class solitudesRepository : ISolicitudRepository
    {
        protected readonly XDeclaration xDeclaration;
        public Task<Solicitud> AddAsync(Solicitud entity)
        {
            return Solicitud
                .Include(xDeclaration -> x.cantidad>= 0)
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Solicitud>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Solicitud> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Solicitud>> GetByUrgenciaAsync(byte urgencia)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Solicitud>> GetRecursosActivos(long idRecurso)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RecursoSolicitud>> GetRecursosSolicitudAsync(long idSolicitud)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Solicitud>> GetSolicitudesActivasAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Solicitud entity)
        {
            throw new NotImplementedException();
        }
    }
}
