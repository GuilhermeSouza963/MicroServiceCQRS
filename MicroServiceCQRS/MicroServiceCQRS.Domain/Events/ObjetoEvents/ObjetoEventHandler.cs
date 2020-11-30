using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Domain.Events.ObjetoEvents
{
    public class ObjetoEventHandler : INotificationHandler<ObjetoRegisteredEvent>
    {
        public Task Handle(ObjetoRegisteredEvent notification, CancellationToken cancellationToken)
        {

            // implementar kafka para salvar no banco de leitura

            return Task.CompletedTask;
        }
    }
}
