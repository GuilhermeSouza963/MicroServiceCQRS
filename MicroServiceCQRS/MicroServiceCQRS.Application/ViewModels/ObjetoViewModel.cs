using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MicroServiceCQRS.Application.ViewModels
{
    public class ObjetoViewModel
    {
        public Guid Id { get; set; }
        public int ObjetoId { get; set; } // ObjetoID (Primary key)
        public int? ObjetoIdPai { get; set; } // ObjetoIDPai
        public int? ObjetoIdPaiPrincipal { get; set; } // ObjetoIDPai
        public short ObjetoTipoId { get; set; } // ObjetoTipoID
        public short? ModeloId { get; set; } // ModeloId

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(2)]
        [MaxLength(256)]
        [DisplayName("Titulo")]
        public string Titulo { get; set; } // Titulo (length: 256)
        public string Descricao { get; set; } // Descricao (length: 512)
        public string Conteudo { get; set; } // Conteudo (length: 2147483647)
        public DateTime DataExibirInicio { get; set; } // DataExibirInicio
        public DateTime? DataExibirFim { get; set; } // DataExibirFim
        public short Ordem { get; set; } // Ordem
        public int? SituacaoId { get; set; } // SituacaoId

        public int PessoaId { get; set; } // SituacaoId

        public bool? Urgente { get; set; }
        public DateTime? DataAula { get; set; }

        //LOG
        public int StatusId { get; set; } // StatusID
        public string Usuario { get; set; } // Usuario (length: 64)
        public DateTime CriadoEm { get; set; } // CriadoEm
        public DateTime AtualizadoEm { get; set; } // AtualizadoEm   

        public bool PossuiAnexo { get; set; }
    }
}
