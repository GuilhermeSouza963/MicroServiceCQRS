using MediatR;
using System;

namespace MicroServiceCQRS.CrossCutting.Utils.Messaging
{
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
