using MicroServiceCQRS.CrossCutting.Utils.Messaging;
using System;

namespace MicroServiceCQRS.Domain.Events.DisciplinaObjetoEvents
{
    public class DisciplinaObjetoRegisteredEvent : Event
    {

        public DisciplinaObjetoRegisteredEvent(Guid id, int disciplinaId, int objetoId, short ordem, int? pesquisaId, int statusId, string usuario, DateTime criadoEm, DateTime atualizadoEm)
        {
            Id = id;
            DisciplinaId = disciplinaId;
            ObjetoId = objetoId;
            Ordem = ordem;
            PesquisaId = pesquisaId;
            StatusId = statusId;
            Usuario = usuario;
            CriadoEm = criadoEm;
            AtualizadoEm = atualizadoEm;
        }

        public Guid Id { get; private set; }
        public int DisciplinaId { get; private set; } // DisciplinaID (Primary key)
        public int ObjetoId { get; private set; } // ObjetoId (Primary key)
        public short Ordem { get; private set; } // Ordem
        public int? PesquisaId { get; private set; } // PesquisaID
        public int StatusId { get; private set; } // StatusID
        public string Usuario { get; private set; } // Usuario (length: 64)
        public DateTime CriadoEm { get; private set; } // CriadoEm
        public DateTime AtualizadoEm { get; private set; } // AtualizadoEm
    }
}
