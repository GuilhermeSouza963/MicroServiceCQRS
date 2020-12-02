using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Domain.Entities
{
    public class Modelo
    {
        public short ModeloId { get; set; } // ModeloId (Primary key)
        public short? ObjetoTipoId { get; set; } // ObjetoTipoId
        public string Descricao { get; set; } // Descricao (length: 256)
        public int StatusId { get; set; } // StatusID
        public string Usuario { get; set; } // Usuario (length: 64)
        public DateTime CriadoEm { get; set; } // CriadoEm
        public DateTime AtualizadoEm { get; set; } // AtualizadoEm

        public ObjetoTipo ObjetoTipo { get; set; }
    }
}
