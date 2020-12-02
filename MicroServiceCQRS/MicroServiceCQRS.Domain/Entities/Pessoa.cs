using System;
using System.Collections.Generic;
using System.Text;

namespace MicroServiceCQRS.Domain.Entities
{
    public class Pessoa
    {
        public int PessoaId { get; set; } // PessoaID (Primary key)
        public int UsuarioId { get; set; } // UsuarioID
        public string Nome { get; set; } // Nome (length: 128)
        public string NomeExibicao { get; set; } // NomeExibicao (length: 128)
        public System.DateTime DtNascimento { get; set; } // DtNascimento
        public string Email { get; set; } // Email (length: 256)
        public string Celular { get; set; } // Celular (length: 15)
        public string Telefone { get; set; } // Telefone (length: 15)
        public string BackgroundCss { get; set; } // BackgroundColor (length: 6)
        public string Banner { get; set; } // Banner (length: 128)
        public string Foto { get; set; } // Foto (length: 256)
        public bool AutoContraste { get; set; } // AutoContraste
        public string RA { get; set; } //RA (length: 20)
        public string CPF { get; set; } //CPF (length: 11)
        public bool PrimeiroAcesso { get; set; } // PrimeiroAcesso
        public bool PrimeiroAcessoApp { get; set; } // PrimeiroAcessoApp
        public bool EnviarEmail { get; set; }
        public int StatusId { get; set; } // StatusID
        public string Usuario { get; set; } // Usuario (length: 64)
        public System.DateTime CriadoEm { get; set; } // CriadoEm
        public System.DateTime AtualizadoEm { get; set; } // AtualizadoEm   
        public string Bio { get; set; }
        public string Thumb { get; set; }
        public bool PerfilReceberEmailCriacaoMaterial { get; set; }
    }
}
