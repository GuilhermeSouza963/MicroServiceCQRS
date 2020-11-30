using MicroServiceCQRS.CrossCutting.Utils.Messaging;
using System;

namespace MicroServiceCQRS.Domain.Commands.ObjetoCommands
{
    public abstract class ObjetoCommand : Command
    {
        public Guid Id { get; protected set; }
        public int ObjetoId { get; protected set; } // ObjetoID (Primary key)
        public int? ObjetoIdPai { get; protected set; } // ObjetoIDPai
        public int? ObjetoIdPaiPrincipal { get; protected set; } // ObjetoIDPai
        public short ObjetoTipoId { get; protected set; } // ObjetoTipoID
        public short? ModeloId { get; protected set; } // ModeloId
        public string Titulo { get; protected set; } // Titulo (length: 256)
        public string Descricao { get; protected set; } // Descricao (length: 512)
        public string Conteudo { get; protected set; } // Conteudo (length: 2147483647)
        public DateTime DataExibirInicio { get; protected set; } // DataExibirInicio
        public DateTime? DataExibirFim { get; protected set; } // DataExibirFim
        public short Ordem { get; protected set; } // Ordem
        public int? SituacaoId { get; protected set; } // SituacaoId

        public int PessoaId { get; protected set; } // SituacaoId

        public bool? Urgente { get; protected set; }
        public DateTime? DataAula { get; protected set; }

        //LOG
        public int StatusId { get; protected set; } // StatusID
        public string Usuario { get; protected set; } // Usuario (length: 64)
        public DateTime CriadoEm { get; protected set; } // CriadoEm
        public DateTime AtualizadoEm { get; protected set; } // AtualizadoEm
    }
}
