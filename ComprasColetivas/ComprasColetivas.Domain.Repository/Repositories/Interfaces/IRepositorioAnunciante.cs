using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Repository.Repositories.Interfaces
{
    public interface IRepositorioAnunciante: IRepository<Anunciante>
    {
        Anunciante ObterAnunciante(string cnpj);
    }
}
