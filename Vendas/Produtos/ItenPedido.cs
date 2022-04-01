using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Produtos
{
    public class ItenPedido
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public int incluirItem()
        { return Quantidade++; }
        public int excluirItem()
        { return Quantidade--;}
            

        
    }
}
