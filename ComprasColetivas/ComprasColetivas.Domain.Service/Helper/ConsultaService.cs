using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Repository.Repositories;
using ComprasColetivas.Domain.Repository.Factories;

namespace ComprasColetivas.Domain.Service.Helper
{
    public static class ConsultaService
    {
        
        //Como helper de consulta podemos usar qualquer repositório        
        private static IRepositorioAnunciante repo = FactoryRepository.getInstance.criarRepositorioAnunciante();
        
        public static IList<X> ObterTodos<X>(Func<X, bool> criterio)
        {
            return repo.ObterTodos<X>(criterio);
        }

        public static X ObterUm<X>(Func<X, bool> criterio)
        {
            return repo.ObterUm<X>(criterio);
        }
    }
}
