using System;
using ComprasColetivas.Domain.Model;
using System.Collections.Generic;
namespace ComprasColetivas.Infrastructure.SendMail.EnvioEmail.Interfaces
{
    public interface IEnviarEmailMalaDireta
    {
        void EnviarEmail(Oferta oferta, List<Comprador> compradores);
    }
}
