using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Infrastructure.IDAO;

namespace ComprasColetivas.Infrastructure.DAO
{
    public abstract class AbstractFactoryDAO
    {
        public abstract IAnuncianteDAO CriarAnuncianteDAO();
        public abstract IOfertaDAO CriarOfertaDAO();
        public abstract ICompradorDAO CriarCompradorDAO();
    }
}
