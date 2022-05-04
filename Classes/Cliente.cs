using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula63_wf.Classes
{
    internal class Cliente
    {
        string Nome { get; set; }
        string CPF { get; set; }
        string Email { get; set; }
        uint CEP { get; set; }
        long Telefone { get; set; }

        public Cliente(string nome, string cPF, string email, uint cEP, long telefone)
        {
            Nome = nome;
            CPF = cPF;
            Email = email;
            CEP = cEP;
            Telefone = telefone;
        }

        public static List<Cliente> AdicionarCliente(string nome, string cPF, string email, uint cEP, long telefone)
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente(nome, cPF, email, cEP, telefone));
            return clientes;
        }
        public override string ToString()
        {
            return $"Nome: {Nome}, Email: {Email}";
        }


    }
}
