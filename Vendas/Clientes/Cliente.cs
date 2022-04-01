using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Clientes

{
    public class Cliente
    {
        public double LimiteCredito { get; set; }
        public int CartaoCredito { get; set; }
        public string Contato { get; set; }
        public bool Status { get; set; }

        public double verificaCredito()
        { return LimiteCredito; }
        public int validaCartao() 
        { return CartaoCredito; }
    }

    
}
