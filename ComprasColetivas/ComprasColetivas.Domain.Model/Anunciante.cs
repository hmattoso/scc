
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace ComprasColetivas.Domain.Model
{
    public class Anunciante : Pessoa
    {
        public virtual string CNPJ { get; set; }
        public virtual string NomeFantasia { get; set; }
        public virtual string InscricaoMunicipal { get; set; }
        public virtual string InscricaoEstadual { get; set; }
        public virtual string WebSite { get; set; }
        
        private string regexEmail = @"^([\w\-]+\.)*[\w\- ]+@([\w\- ]+\.)+([\w\-]{2,3})$";
        private string regexCnpj = @"^\d{3}.?\d{3}.?\d{3}/?\d{3}-?\d{2}$";

        public Anunciante(string cnpj, string nomeFantasia, string nome, string inscricaoMunicipal, string inscricaoEstadual, string webSite)
        {
            this.CNPJ = cnpj;
            this.NomeFantasia = nomeFantasia;
            this.Nome = nome;
            this.InscricaoMunicipal = inscricaoMunicipal;
            this.InscricaoEstadual = inscricaoEstadual;
            this.WebSite = webSite;
        }

        public virtual bool IsEmailValido(string email)
        {
            return Regex.Match(email, regexEmail).Success;

        }

        public virtual bool IsCNPJValido(string cnpj)
        {
            return Regex.Match(cnpj, regexCnpj).Success;
        }

        public Anunciante() { }
    }
}
