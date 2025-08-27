using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testeTecnicoStart.Model
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto(string marca, string modelo, int ano, int cilindradas)
            : base(marca, modelo, ano)
        {
            Cilindradas = cilindradas;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Moto: {Marca} {Modelo}, {Ano}, {Cilindradas} cc.");
        }
    }
}