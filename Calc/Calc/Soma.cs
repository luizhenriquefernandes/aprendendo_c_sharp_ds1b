using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Soma
    {
        private int _num1 ;
        private int _num2;
        public Soma(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }
        public int Num1
        {
            get { return _num1; }
            set { _num1 = value; }
        }
        public int Num2
        {
            get { return _num2; }
            set { _num2 = value; }
        }
        public int Somar(int a, int b)
        {
            return a+b;
        }

    }
}
