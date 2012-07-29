using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Service.Services.Interfaces
{
    interface IServicoComprador
    {
        void CadastrarComprador(Comprador comprador);
    }
}
