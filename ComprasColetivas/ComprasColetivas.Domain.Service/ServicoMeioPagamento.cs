using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Service
{
    public class ServicoMeioPagamento 
    {
        private Cupom cupom;

        public ServicoMeioPagamento(Cupom cupom)
        {
            this.cupom = cupom;
        }

        public void RealizarPagamento()
        {
        }
    }
}
