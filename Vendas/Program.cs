using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendas.Clientes;
using Vendas.Produtos;

namespace Vendas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa joelson = new Pessoa();
            joelson.nome = "joelson";
            DateTime dt = new DateTime(2000, 01, 13);
            Console.WriteLine(joelson.nome);
            Console.WriteLine(dt.ToString("d"));

            Cliente cliente = new Cliente();
            cliente.LimiteCredito = 2000;
            cliente.CartaoCredito = 1111;
            cliente.Contato = "11222222222";
            cliente.Status = true;
            Console.WriteLine(cliente.LimiteCredito);
            Console.WriteLine(cliente.CartaoCredito);
            Console.WriteLine(cliente.Contato);
            Console.WriteLine(cliente.Status);

            Pedido pedido = new Pedido();
            pedido.Vendedor = "cleison";
            DateTime dataPedido = DateTime.Now;
            pedido.Status = true;
            pedido.Observacoes = "Smarthfone";
            Console.WriteLine(pedido.Vendedor);
            Console.WriteLine(dataPedido.ToString("d"));
            Console.WriteLine(pedido.Status);
            Console.WriteLine(pedido.Observacoes);

            ItenPedido itenPedido = new ItenPedido();
            itenPedido.Quantidade = 2;
            itenPedido.Preco = 1200;
            Console.WriteLine(itenPedido.Quantidade);
            Console.WriteLine(itenPedido.Preco);

            Produto produto = new Produto();
            produto.NomeProduto = "galaxy s22 Ultra";
            produto.Peso = 300;
            produto.QuantidadeDisponivel = 10;
            Console.WriteLine(produto.NomeProduto);
            Console.WriteLine(produto.Peso);
            Console.WriteLine(produto.QuantidadeDisponivel);

            Console.ReadLine();
        }
    }
}
