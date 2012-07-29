using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ComprasColetivas.Domain.Model
{
    public class Comprador : Pessoa
    {
        public virtual DateTime Nascimento { get; set; }
        public virtual string CPF { get; set; }
        public virtual string RG { get; set; }
        public virtual string OrgaoEmissor { get; set; }
        public virtual string FiliacaoPai { get; set; }
        public virtual string FiliacaoMae { get; set; }
        public virtual bool RecebeEmailOferta { get; set; }

        private string regexCpf = @"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$";
        //private string regexNascimento = @"^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02]))\/\d{4}$";

        public bool IsAniversario()
        {
            return (Nascimento.Day == DateTime.Now.Day);
        }

        public bool IsCPFValido(string cpf)
        {
            return Regex.Match(cpf, regexCpf).Success;
        }        

        public Comprador(string nome, string cpf, string filiacaoMae, string filiacaoPai, DateTime nascimento, string orgaoEmissor, bool recebeEmailOferta, string rg)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.FiliacaoMae = filiacaoMae;
            this.FiliacaoPai = filiacaoPai;
            this.Nascimento = nascimento;
            this.OrgaoEmissor = orgaoEmissor;
            this.RecebeEmailOferta = recebeEmailOferta;
            this.RG = rg;
        }
    }
}
