using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Repository.Repositories;

namespace ComprasColetivas.Domain.Repository.AbstractFactory
{
    public abstract class AbstractFactoryRepository
    {
        public abstract IRepositorioAnunciante criarRepositorioAnunciante();
    }
}
