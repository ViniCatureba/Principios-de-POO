using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pilares
{
    class Carro
    {
        //public / private / protected / internal (encapsulamento do c#)
        public string marca;
        private string _modelo;
        public int anoFabricacao;


        //Get e Set


        //metodos

        public void SetModelo(string mod)
        {
            if(mod=="Fiesta" || mod == "HB20")
            {
                _modelo = mod;
            }
            else
            {
                Console.WriteLine("Alteracao invalida");
            }
        }
        public string GetModelo()
        {
            return _modelo;
        }
    }
}
