using System.Threading.Tasks;

namespace MicroServiceCQRS.CrossCutting.Utils.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
