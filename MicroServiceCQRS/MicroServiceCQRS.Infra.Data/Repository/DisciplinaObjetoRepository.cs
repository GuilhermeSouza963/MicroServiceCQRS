using MicroServiceCQRS.CrossCutting.Utils.Data;
using MicroServiceCQRS.Domain.Entities;
using MicroServiceCQRS.Domain.Interfaces;
using MicroServiceCQRS.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Infra.Data.Repository
{
    public class DisciplinaObjetoRepository : IDisciplinaObjetoRepository
    {
        protected readonly MicroServiceCQRSContext Db;
        protected readonly DbSet<DisciplinaObjeto> DbSet;
        public DisciplinaObjetoRepository(MicroServiceCQRSContext context)
        {
            Db = context;
            DbSet = Db.Set<DisciplinaObjeto>();
        }
        public IUnitOfWork UnitOfWork => Db;
        public async Task<DisciplinaObjeto> GetById(int disciplinaId, int objetoId)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(c => c.DisciplinaId == disciplinaId && c.ObjetoId == objetoId);
        }
        public void Add(DisciplinaObjeto disciplinaObjeto)
        {
            DbSet.Add(disciplinaObjeto);
        }
        public void Dispose()
        {
            Db.Dispose();
        }


    }
}
