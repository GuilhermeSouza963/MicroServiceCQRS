using MicroServiceCQRS.CrossCutting.Utils.Messaging;
using System;

namespace MicroServiceCQRS.Domain.Commands.DisciplinaObjetoCommands
{
    public abstract class DisciplinaObjetoCommand : Command
    {
        public Guid Id { get; protected set; }
        public int DisciplinaId { get; protected set; } // DisciplinaID (Primary key)
        public int ObjetoId { get; protected set; } // ObjetoId (Primary key)
        public short Ordem { get; protected set; } // Ordem
        public int? PesquisaId { get; protected set; } // PesquisaID
        public int StatusId { get; protected set; } // StatusID
        public string Usuario { get; protected set; } // Usuario (length: 64)
        public DateTime CriadoEm { get; protected set; } // CriadoEm
        public DateTime AtualizadoEm { get; protected set; } // AtualizadoEm
    }
}
