using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MicroServiceCQRS.Domain.Events.DisciplinaObjetoEvents
{
    public class DisciplinaObjetoEventHandler : INotificationHandler<DisciplinaObjetoRegisteredEvent>
    {
        public Task Handle(DisciplinaObjetoRegisteredEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
