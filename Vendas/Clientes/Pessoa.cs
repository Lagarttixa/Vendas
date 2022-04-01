using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Clientes
{
    public class Pessoa
    {
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }

        public int GetCalculaIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.DayOfYear - dataNascimento.DayOfYear;
            return idade;
        } 
        
    }
}
