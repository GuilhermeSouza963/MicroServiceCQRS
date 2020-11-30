using FluentValidation.Results;
using MicroServiceCQRS.CrossCutting.Utils.Messaging;
using System.Threading.Tasks;

namespace MicroServiceCQRS.CrossCutting.Bus.Interfaces
{
    public interface IMediatorHandler
    {
        Task PublishEvent<T>(T @event) where T : Event;
        Task<ValidationResult> SendCommand<T>(T command) where T : Command;
    }
}
