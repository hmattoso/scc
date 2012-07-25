using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Service.Services
{
    public interface IServicoAnunciante
    {
        void CadastrarAnunciante(Anunciante anunciante);
    }
}
