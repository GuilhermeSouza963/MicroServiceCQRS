using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Domain.Entities
{
    public class ObjetoBibliotecaVirtual
    {
        public int ObjetoId { get; set; }
        public int? PaginaInicial { get; set; }
        public int? PaginaFinal { get; set; }
        public string Paragrafo { get; set; }

        //LOG
        public int StatusId { get; set; } // StatusID
        public string Usuario { get; set; } // Usuario (length: 64)
        public DateTime CriadoEm { get; set; } // CriadoEm
        public DateTime AtualizadoEm { get; set; } // AtualizadoEm

        public Objeto Objeto { get; set; } // fkObjeto_ObjetoBibliotecaVirtual
    }
}
