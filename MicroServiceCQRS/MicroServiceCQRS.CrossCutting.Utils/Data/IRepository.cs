using MicroServiceCQRS.CrossCutting.Utils.Domain;
using System;

namespace MicroServiceCQRS.CrossCutting.Utils.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
