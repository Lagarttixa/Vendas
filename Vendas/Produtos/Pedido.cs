using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Produtos
{
    public class Pedido
    {
        public DateTime DataPedido { get; set; }
        public string Vendedor { get; set; }
        public bool Status { get; set; }
        public string Observacoes { get; set; }

        public void encerrarPedido()
        { return ; }

        public void cancelarPedido()
        { return; }

        public void criarPedido()
        { return;}
    }
}
