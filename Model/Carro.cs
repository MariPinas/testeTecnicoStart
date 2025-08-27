using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testeTecnicoStart.Model
{
    public class Carro : Veiculo
    {
        public int Portas { get; set; }

        public Carro(string marca, string modelo, int ano, int portas)
            : base(marca, modelo, ano)
        {
            Portas = portas;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}, {Ano}, {Portas} portas.");
        }
    }
}