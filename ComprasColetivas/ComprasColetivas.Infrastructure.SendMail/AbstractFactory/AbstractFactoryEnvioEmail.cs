using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Infrastructure.SendMail.EnvioEmail.Interfaces;

namespace ComprasColetivas.Infrastructure.SendMail.AbstractFactory
{
    public abstract class AbstractFactoryEnvioEmail
    {
        public abstract IEnviarEmailMalaDireta criarEnvioEmailMalaDireta();
    }
}
