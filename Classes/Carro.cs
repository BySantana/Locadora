using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula63_wf.Classes
{
    internal class Carro
    {
        public string Modelo { get; set; }
        string Placa { get; set; }
        public bool Status { get; set; }
        public double ValorDiario { get; set; }
        static List<Carro> Carros { get; set; }
        

        public Carro() { }
        public Carro(string modelo, string placa, bool status, double valorDiario)
        {
            Modelo = modelo;
            Placa = placa;
            Status = status;
            ValorDiario = valorDiario;
        }

        public static List<Carro> InitializeCarros()
        {
            List<Carro> carros = new List<Carro>();
            carros.Add(new Classes.Carro("Sandero", "058-F0P", true, 1000));
            carros.Add(new Classes.Carro("EcoSport", "432-34P", true, 2000));
            carros.Add(new Classes.Carro("Palio", "126-54Y", true, 800));
            carros.Add(new Classes.Carro("Civic", "950-1T0", true, 2500));
            return carros;
            
        }

        public override string ToString()
        {
            return $"{Modelo}, {Placa}, R${ValorDiario} ({Status})";
        }

    }
}
