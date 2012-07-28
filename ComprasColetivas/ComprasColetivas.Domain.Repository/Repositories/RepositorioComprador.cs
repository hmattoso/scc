using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;
using ComprasColetivas.Domain.Repository.Repositories.Interfaces;
using ComprasColetivas.Infrastructure.DAO.Factories;

namespace ComprasColetivas.Domain.Repository.Repositories
{
    class RepositorioComprador : RepositoryBase<Comprador>,IRepositorioComprador
    {
        public RepositorioComprador()
            : base()
        {
            dao = FactoryDAO.getInstance.CriarCompradorDAO();
        }
    }
}
