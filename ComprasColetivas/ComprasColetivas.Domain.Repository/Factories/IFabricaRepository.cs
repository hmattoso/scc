using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasColetivas.Domain.Repository.Factories
{
    public interface IFabricaRepository<T>
    {
        T FabricarRepositorio();
    }
}
