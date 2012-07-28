using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Service.Services.Interfaces
{
    public interface IServicoOferta
    {

        void PublicarOferta(Oferta oferta);

        void EnviarMalaDiretaOferta();

        void CalcularRepassePorOferta(string CodigoOferta);

        void PesquisarPorRegiaoDoAnunciante(string CodigoCidade);

        void TotalizarCuponsPorMes(int Mes, int Ano);

        void TotalizarCuponsPorAnunciante(string CNPJ);

        void TotalizarCuponsPorComprador(string CPF);

        void BaixarCupom(string CodigoCupom);


    }
}
