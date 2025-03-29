using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXs
{
    class Retangulo
    {
        private double _largula;
        private double _altura;

        public void SetLargura(double valor)
        {
            _largula = valor;
        }
        public void SetAltura(double valor) {
            _altura = valor;
        }
        public double GetLargula() { 
            return _largula;
        }
        public double GetAltura()
        {
            return _altura;
        }
        public double CalcularArea()
        {
            double area = (_largula*_altura)/2;
            return area;
        }

    }
}
