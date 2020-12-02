namespace MicroServiceCQRS.Domain.Entities
{
    public class ObjetoTrabalho
    {
        public int ObjetoId { get; set; } // ObjetoID (Primary key)
        public System.DateTime DataInicioEntrega { get; set; }
        public System.DateTime DataFimEntrega { get; set; }
        public System.DateTime? DataFimEntregaProrrogacao { get; set; }
        public short? NroTentativa { get; set; }
        public decimal? Pontuacao { get; set; }
        public decimal? PontuacaoProrrogada { get; set; }
        public string Observacao { get; set; }
        public bool Grupo { get; set; }
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
