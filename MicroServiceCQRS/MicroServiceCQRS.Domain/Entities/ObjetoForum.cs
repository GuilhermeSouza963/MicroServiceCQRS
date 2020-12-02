using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Domain.Entities
{

    public class ObjetoForum
    {
        public int ObjetoId { get; set; } // ObjetoID (Primary key)
        public bool Moderado { get; set; }
        public bool ParticipantesCriamTopico { get; set; }
        public bool ParticipacaoUnicaPorTopico { get; set; }
        public bool VisualizaPostagensAposParticipacao { get; set; }
        public bool UnicaDiscurssaoSimples { get; set; }
        public bool PodeAnexar { get; set; }
        public bool ReceberEmail { get; set; }
        public bool Avaliado { get; set; }
        public decimal? Pontuacao { get; set; }
        public string RespostaPadrao { get; set; }
        public int StatusId { get; set; } // StatusID
        public string Usuario { get; set; } // Usuario (length: 64)
        public System.DateTime CriadoEm { get; set; } // CriadoEm
        public System.DateTime AtualizadoEm { get; set; } // AtualizadoEm

        // Foreign keys

        /// <summary>
        /// Parent Objeto pointed by [ObjetoTrabalho].([ObjetoId]) (fkObjeto_ObjetoTrabalho)
        /// </summary>
        public Objeto Objeto { get; set; } // fkObjeto_ObjetoTrabalho        
    }
}
