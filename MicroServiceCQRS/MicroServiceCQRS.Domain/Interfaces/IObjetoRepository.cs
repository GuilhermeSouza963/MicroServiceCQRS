using MicroServiceCQRS.CrossCutting.Utils.Data;
using MicroServiceCQRS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Domain.Interfaces
{
    public interface IObjetoRepository : IRepository<Objeto>
    {
        Task<Objeto> GetById(int objetoId);
        Task<IEnumerable<Objeto>> GetAll();
        void Add(Objeto entidade);

    }
}
