using MicroServiceCQRS.CrossCutting.Utils.Data;
using MicroServiceCQRS.Domain.Entities;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Domain.Interfaces
{
    public interface IDisciplinaObjetoRepository : IRepository<DisciplinaObjeto>
    {
        Task<DisciplinaObjeto> GetById(int disciplinaId, int objetoId);
        void Add(DisciplinaObjeto disciplinaObjeto);
    }
}
