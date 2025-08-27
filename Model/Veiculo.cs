using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testeTecnicoStart.Model
{
    public abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Veiculo(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }
        public abstract void ExibirInfo();
    }
}