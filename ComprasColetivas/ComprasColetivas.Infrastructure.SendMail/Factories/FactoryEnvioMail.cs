using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Infrastructure.SendMail.EnvioEmail.Interfaces;
using ComprasColetivas.Infrastructure.SendMail.EnvioEmail;
using ComprasColetivas.Infrastructure.SendMail.AbstractFactory;

namespace ComprasColetivas.Infrastructure.SendMail.Factories
{
    public class FactoryEnvioMail: AbstractFactoryEnvioEmail
    {
        private static FactoryEnvioMail instance;

        public static FactoryEnvioMail getInstance
        {
            get
            {
                if (instance == null) instance = new FactoryEnvioMail();
                return instance;
            }
        }

        public override IEnviarEmailMalaDireta criarEnvioEmailMalaDireta()
        {
            return new EnviarEmailMalaDireta();
        }

    }
}
