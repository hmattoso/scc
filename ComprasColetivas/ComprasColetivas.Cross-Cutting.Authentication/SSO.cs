using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Service.Helper;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Cross_Cutting.Authentication
{
    public class SSO
    {
        public bool Autenticar(string usuario, string senha)
        {
            var usuarioAutenticado = ConsultaService.ObterUm<Login>(login => login.Usuario == usuario && login.Senha == senha);
            return (usuarioAutenticado != null);
            //TODO:Implementar SSO;
        }

    }
}
