using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Service.Services.Interfaces
{
    public interface IServicoOferta
    {
        void EnviarMalaDiretaOferta(Oferta oferta);

        void PublicarOferta(Oferta oferta);        

        double CalcularRepassePorOferta(string CodigoOferta);

        List<Oferta> PesquisarOfertaPorRegiaoDoAnunciante(string CodigoCidade);

        int TotalizarCuponsPorMes(int Mes, int Ano);

        int TotalizarCuponsPorAnunciante(string CNPJ);

        int TotalizarCuponsPorComprador(string CPF);

        void BaixarCupom(string CodigoCupom);

        List<Oferta> PesquisarPorTipoDeOferta(TipoOferta tipoOferta);

        List<Oferta> ListarTodasOfertas();

        List<Cupom> ListarCupomsPorComprador(string CPF);

        IList<Oferta> ListarOfertasPorAnunciante(string CNPJ);
    }
}
