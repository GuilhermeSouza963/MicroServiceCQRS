using System;

namespace MicroServiceCQRS.Application.ViewModels
{
    public class DisciplinaObjetoViewModel
    {
        public Guid Id { get; set; }
        public int DisciplinaId { get; set; } // DisciplinaID (Primary key)
        public int ObjetoId { get; set; } // ObjetoId (Primary key)
        public short Ordem { get; set; } // Ordem
        public int? PesquisaId { get; set; } // PesquisaID
        public int StatusId { get; set; } // StatusID
        public string Usuario { get; set; } // Usuario (length: 64)
        public DateTime CriadoEm { get; set; } // CriadoEm
        public DateTime AtualizadoEm { get; set; } // AtualizadoEm
    }
}
