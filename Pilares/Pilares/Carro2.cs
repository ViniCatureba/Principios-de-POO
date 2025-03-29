using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares
{
    class Carro2
    {
        public string modelo;
        public string marca;
        public int quilometragem;

        public virtual void MostrarInformacoes()  //colocar virutal para que esse metodo pode ser sobrescrito
        {
            Console.WriteLine($"Modelo; {modelo}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Quilometragem: {quilometragem}");
        }


        //Um metodo com mesmo nome pode receber 
        public void MostrarInformacoes(string nome)
        {
            Console.WriteLine($"Modelo; {modelo}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Quilometragem: {quilometragem}");
            Console.WriteLine($"Nome: {nome}");
        }
    }
}
