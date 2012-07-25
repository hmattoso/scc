using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Repository.AbstractFactory;
using ComprasColetivas.Domain.Repository.Repositories;

namespace ComprasColetivas.Domain.Repository.Factories
{
    
    public class FactoryRepository : AbstractFactoryRepository
    {

        private FactoryRepository() 
        {             
        }

        private static FactoryRepository instance;

        public static FactoryRepository getInstance
        {
            get 
            {
                if (instance == null) instance = new FactoryRepository();
                return instance;
            }
        }

        public override IRepositorioAnunciante criarRepositorioAnunciante()
        {
            return new RepositorioAnunciante();
        }

    }

}
