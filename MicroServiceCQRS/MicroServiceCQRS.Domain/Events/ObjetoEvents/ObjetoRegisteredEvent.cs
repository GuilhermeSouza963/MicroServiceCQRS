using MicroServiceCQRS.CrossCutting.Utils.Messaging;
using System;

namespace MicroServiceCQRS.Domain.Events.ObjetoEvents
{
    public class ObjetoRegisteredEvent : Event
    {
        public ObjetoRegisteredEvent(Guid id, int? objetoIdPai, int? objetoIdPaiPrincipal, short objetoTipoId, short? modeloId, string titulo, string descricao, string conteudo, DateTime dataExibirInicio, DateTime? dataExibirFim, short ordem, int? situacaoId, int pessoaId, bool? urgente, DateTime? dataAula, int statusId, string usuario, DateTime criadoEm, DateTime atualizadoEm)
        {
            Id = id;
            ObjetoIdPai = objetoIdPai;
            ObjetoIdPaiPrincipal = objetoIdPaiPrincipal;
            ObjetoTipoId = objetoTipoId;
            ModeloId = modeloId;
            Titulo = titulo;
            Descricao = descricao;
            Conteudo = conteudo;
            DataExibirInicio = dataExibirInicio;
            DataExibirFim = dataExibirFim;
            Ordem = ordem;
            SituacaoId = situacaoId;
            PessoaId = pessoaId;
            Urgente = urgente;
            DataAula = dataAula;
            StatusId = statusId;
            Usuario = usuario;
            CriadoEm = criadoEm;
            AtualizadoEm = atualizadoEm;
        }
        Guid Id { get; set; }
        public int ObjetoId { get; private set; } // ObjetoID (Primary key)
        public int? ObjetoIdPai { get; private set; } // ObjetoIDPai
        public int? ObjetoIdPaiPrincipal { get; private set; } // ObjetoIDPai
        public short ObjetoTipoId { get; private set; } // ObjetoTipoID
        public short? ModeloId { get; private set; } // ModeloId
        public string Titulo { get; private set; } // Titulo (length: 256)
        public string Descricao { get; private set; } // Descricao (length: 512)
        public string Conteudo { get; private set; } // Conteudo (length: 2147483647)
        public DateTime DataExibirInicio { get; private set; } // DataExibirInicio
        public DateTime? DataExibirFim { get; private set; } // DataExibirFim
        public short Ordem { get; private set; } // Ordem
        public int? SituacaoId { get; private set; } // SituacaoId

        public int PessoaId { get; private set; } // SituacaoId

        public bool? Urgente { get; private set; }
        public DateTime? DataAula { get; private set; }

        //LOG
        public int StatusId { get; private set; } // StatusID
        public string Usuario { get; private set; } // Usuario (length: 64)
        public DateTime CriadoEm { get; private set; } // CriadoEm
        public DateTime AtualizadoEm { get; private set; } // AtualizadoEm
    }
}
