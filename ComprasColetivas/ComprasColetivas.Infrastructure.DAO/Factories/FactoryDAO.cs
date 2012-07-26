using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Infrastructure.IDAO;
using ComprasColetivas.Infrastructure.NHDAO;

namespace ComprasColetivas.Infrastructure.DAO.Factories
{
    public class FactoryDAO : AbstractFactoryDAO
    {

        private static FactoryDAO instance;

        public static FactoryDAO getInstance
        {
            get { if (instance == null) instance = new FactoryDAO(); return instance; }
        }

        public override IAnuncianteDAO CriarAnuncianteDAO()
        {
            
            //aqui verificaremos qual o tipo de banco estamos processando pelo padrão provider
            //se sor relacional, a persistencia será do NH, caso contrario deverá retornar um DAO
            //especifico, ex: AnuncianteDAOMongo() que implementa a mesma interface IAnuncianteDAO.

            return new AnuncianteDAO();

        }


        public override IOfertaDAO CriarOfertaDAO()
        {

            //aqui verificaremos qual o tipo de banco estamos processando pelo padrão provider
            //se sor relacional, a persistencia será do NH, caso contrario deverá retornar um DAO
            //especifico, ex: OfertaDAOMongo() que implementa a mesma interface IOfertaDAO.

            return new OfertaDAO();

        }

    }
}
