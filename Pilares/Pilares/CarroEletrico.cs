using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilares
{
    class CarroEletrico : Carro2
    {
        public int bateria;
        public int tempoDeCarga;

        public override void MostrarInformacoes()
        {
            //Console.WriteLine($"Modelo: {modelo}");
            //Console.WriteLine($"Marca: {marca}");
            //Console.WriteLine($"Quilometragem: {quilometragem}");
            base.MostrarInformacoes(); //em vez de repedir novamente as informacoes do metodo na classe pai, use base para executar o codigo escrito 
            Console.WriteLine($"Bateria: {bateria}");
            Console.WriteLine($"Tempo de carga: {tempoDeCarga}");
        }
    }
}
