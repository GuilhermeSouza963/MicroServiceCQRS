using MicroServiceCQRS.CrossCutting.Utils.Data;
using MicroServiceCQRS.Domain.Entities;
using MicroServiceCQRS.Domain.Interfaces;
using MicroServiceCQRS.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Infra.Data.Repository
{
    public class ObjetoRepository : IObjetoRepository
    {
        protected readonly MicroServiceCQRSContext Db;
        protected readonly DbSet<Objeto> DbSet;
        public ObjetoRepository(MicroServiceCQRSContext context)
        {
            Db = context;
            DbSet = Db.Set<Objeto>();
        }

        public IUnitOfWork UnitOfWork => Db;
        public async Task<IEnumerable<Objeto>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<Objeto> GetById(int objetoId)
        {
            return await DbSet.FindAsync(objetoId);
        }
        public void Add(Objeto entidade)
        {
            DbSet.Add(entidade);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
