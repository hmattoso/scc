
using System.Collections.Generic;
namespace ComprasColetivas.Domain.Model
{
    public class Anunciante : Pessoa
    {
        public virtual string CNPJ { get; set; }
        public virtual string NomeFantasia { get; set; }
        public virtual string InscricaoMunicipal { get; set; }
        public virtual string InscricaoEstadual { get; set; }
        public virtual string WebSite { get; set; }

        public Anunciante(string cnpj,string nomeFantasia,string nome,string inscricaoMunicipal,string inscricaoEstadual,string webSite)
        {
            this.CNPJ = cnpj;
            this.NomeFantasia = nomeFantasia;
            this.Nome = nome;
            this.InscricaoMunicipal = inscricaoMunicipal;
            this.InscricaoEstadual = inscricaoEstadual;
            this.WebSite = webSite;
        }
    }
}
