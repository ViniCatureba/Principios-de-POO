using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXs
{
    class Funcionario
    {
        private double _salario;

        public void SetSlario(double valor)
        {
            _salario += valor;
        }
        public double GetSalario()
        {
            return _salario;   
        }
    }
}
