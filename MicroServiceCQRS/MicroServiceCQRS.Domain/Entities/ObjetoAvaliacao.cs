using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Domain.Entities
{
    public class ObjetoAvaliacao
    {
        public int ObjetoId { get; set; } // ObjetoID (Primary key)
        public short? NroTentativa { get; set; }
        public decimal? Pontuacao { get; set; }
        public DateTime? DataExibirRespostaPadrao { get; set; }
        public bool QuestaoRandomica { get; set; }
        public bool AlternativaRandomica { get; set; }
        public bool SugerirQuestao { get; set; }
        public decimal? Expectativa { get; set; }
        public string MensagemExpectativaPositiva { get; set; }
        public string MensagemExpectativaNegativa { get; set; }
        public bool ExibirGabarito { get; set; }
        public bool ExibirQuestao { get; set; }
        public DateTime? DataExibirGabarito { get; set; }
        public DateTime? DataExibirQuestao { get; set; }
        public bool ProvaOnline { get; set; }
        public int? ModeloAvaliacaoID { get; set; }
        public bool Individual { get; set; }
        public TimeSpan? TempoDuracao { get; set; }

        public int StatusId { get; set; } // StatusID
        public string Usuario { get; set; } // Usuario (length: 64)
        public System.DateTime CriadoEm { get; set; } // CriadoEm
        public System.DateTime AtualizadoEm { get; set; } // AtualizadoEm
        
        public Objeto Objeto { get; set; } // fkObjeto_ObjetoTrabalho
    }
}
