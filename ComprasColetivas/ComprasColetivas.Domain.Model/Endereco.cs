
namespace ComprasColetivas.Domain.Model
{

    public class Endereco
    {
        public virtual string Logradouro { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string CEP { get; set; }
        public virtual string Bairro { get; set; }
        public virtual Cidade cidade { get; set; }

        public Endereco(string logradouro, string numero, string complemento, string cep, string bairro/*, Cidade cidade*/)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.CEP = cep;
            this.Bairro = bairro;
            //this.cidade = cidade;
        }

        public Endereco() { }
    }
}