using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Service.Services;

namespace ComprasColetivas.Domain.Service.AbstractFactory
{
    public abstract class AbstractFactoryService
    {
        public abstract IServicoAnunciante criarServicoAnunciante();
    }
}
