using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasColetivas.Domain.Repository.Factories
{
    public class FabricaRepository<T> : IFabricaRepository<T> where T : new()
    {
        public T FabricarRepositorio()
        {
            return new T();
        }
    }
}
