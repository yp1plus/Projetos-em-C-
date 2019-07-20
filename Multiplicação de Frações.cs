//By Yure Pablo em 09/08/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFracao
{
    struct Fracao
    {
        public double numerador;
        public double denominador;

        public Fracao (double numerador, double denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }
        public Fracao MultiplicarFracao (Fracao f1, Fracao f2)
        {
            Fracao f3 = new Fracao(f1.numerador * f2.numerador, f1.denominador * f2.denominador);
            return f3;
        }
        static void Main(string[] args)
        {
            Fracao f1 = new Fracao(2, 4);
            Fracao f2 = new Fracao(6, 8);
            Fracao f3 = f1.MultiplicarFracao(f1, f2);
          
            Console.Write(f3.numerador + "\n" + "--" + "\n" + f3.denominador);

            Console.ReadKey();

        }
    }
}
