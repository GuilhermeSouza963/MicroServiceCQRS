using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Domain.Entities
{
    public class ObjetoTipo
    {
        public short ObjetoTipoId { get; set; } // ObjetoTipoID (Primary key)
        public string Descricao { get; set; } // Descricao (length: 128)
        public string BackgroundCss { get; set; } // BackgroundColor (length: 56)
        public string IconeUrl { get; set; } // IconeUrl (length: 256)
        public string SaveUrl { get; set; } // SaveUrl (length: 256)
        public string ListUrl { get; set; } // ListUrl (length: 256)
        public string IndexUrl { get; set; } // IndexUrl (length: 256)
        public string Controller { get; set; } // IndexUrl (length: 256)
        public int? SituacaoId { get; set; } // SituacaoId
        public bool SaveDisciplina { get; set; } // SituacaoId
        public bool PodeCopiar { get; set; } // PodeCopiar
        public bool Popup { get; set; }
        public bool InserirCalendario { get; set; }
        public bool RequerAvaliacao { get; set; }
        public string IconeApp { get; set; }

        //LOG
        public int StatusId { get; set; } // StatusID
        public string Usuario { get; set; } // Usuario (length: 64)
        public DateTime CriadoEm { get; set; } // CriadoEm
        public DateTime AtualizadoEm { get; set; } // AtualizadoEm
    }
}
