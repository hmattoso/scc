using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Service.AbstractFactory;
using ComprasColetivas.Domain.Service.Services;
using ComprasColetivas.Domain.Service.Services.Interfaces;

namespace ComprasColetivas.Domain.Service.Factories
{
    public class FactoryService : AbstractFactoryService
    {

        private static FactoryService instance;

        public static FactoryService getInstance
        {
            get
            {
                if (instance == null) instance = new FactoryService();
                return instance;
            }
        }

        public override IServicoAnunciante criarServicoAnunciante()
        {
            return new ServicoAnunciante();
        }
    }
}
