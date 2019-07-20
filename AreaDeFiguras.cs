//By Yure Pablo em 13/07/2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreadeFiguras
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                Console.WriteLine("ÁREAS DE FIGURAS GEOMÉTRICAS!");
                Console.WriteLine("Digite o número correspondente: ");
                Console.WriteLine("1 - Triângulo, 2 - Quadrado, 3 - Circunferência, 4 - Trapézio, 5 - Sair");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Informe a base e a altura do triângulo: ");
                        double b = double.Parse(Console.ReadLine());
                        double h = double.Parse(Console.ReadLine());
                        Triangulo t = new Triangulo(b, h);
                        Console.WriteLine("A área é: " + t.CalcularArea());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Informe o lado do quadrado: ");
                        double l = double.Parse(Console.ReadLine());
                        Quadrado q = new Quadrado(l);
                        Console.WriteLine("A área é: " + q.CalcularArea());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Informe o raio da circunferência: ");
                        double r = double.Parse(Console.ReadLine());
                        Circunferencia c = new Circunferencia(r);
                        Console.WriteLine("A área é: " + c.CalcularArea());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Informe a base maior, base menor e a altura do trapézio: ");
                        double B = double.Parse(Console.ReadLine());
                        b = double.Parse(Console.ReadLine());
                        h = double.Parse(Console.ReadLine());
                        Trapezio tp = new Trapezio(B, b, h);
                        Console.WriteLine("A área é: " + tp.CalcularArea());
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.ReadKey();
                        break;
                    default:
                        while ((op<1) || (op > 5))
                        {
                            Console.WriteLine("Está errado, digite número válido!");
                            op = int.Parse(Console.ReadLine());
                        }
                        Console.Clear();
                        break;
                }
            } while (op<5);
            
        }
    }

    class Triangulo
    {
        double b; //base do triângulo
        double h; // altura do triângulo

        public Triangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }
        public double CalcularArea()
        {
            return (b * h) / 2;
        }
    }

    class Quadrado
    {
        double l; //lado do quadrado

        public Quadrado (double l)
        {
            this.l = l;
        }

        public double CalcularArea()
        {
            return (l * l);
        }
    }

    class Circunferencia
    {
        double r; //raio da circunferência

        public Circunferencia(double r)
        {
            this.r = r;
        }

        public double CalcularArea()
        {
            return (Math.PI * r * r);
        }
    }

    class Trapezio
    {
        double B; //Base maior
        double b; //Base menor
        double h; //altura

        public Trapezio(double B, double b, double h)
        {
            this.B = B;
            this.b = b;
            this.h = h;
        }

        public double CalcularArea()
        {
            return (B + b) * h / 2;
        }
    }
}
