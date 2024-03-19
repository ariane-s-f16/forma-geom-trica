using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace forma_geométrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escolha uma forma geometrica quadrilatera(quadrado, retangulo, trapézio e losangulo)");
            string geometrica= Console.ReadLine().ToLower();
           
           
            double altura;
            double base1;
            double base2;
            double med = 0;
            double d2;
            double d3;

            switch (geometrica) 
            {
                case "quadrado":
                    Console.WriteLine("diga a medida da base");
                     base1 = double.Parse(Console.ReadLine());
                    med = base1 * base1;

                    break;
                case "retangulo":
                    Console.WriteLine("diga a medida da base");
                    base1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("diaga a medida da altura");
                     altura = double.Parse(Console.ReadLine());

                    med = altura * base1;
                    break;
                case "trapézio":
                    Console.WriteLine("diga a medida da 1° base");
                    base1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(" Digite a medida da 2° base");
                    base2 =double.Parse(Console.ReadLine());
                    Console.WriteLine("diaga a medida da altura");
                    altura = double.Parse(Console.ReadLine());

                    med = altura * (base1+ base2)/2;
                    break;
                case "losangulo":
                    Console.WriteLine(" digite a medida da 1° diagonal");
                    d2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("digite a medida da 2° diagonal");
                    d3 = double.Parse(Console.ReadLine());

                    med = (d2 * d3) / 2;
                    break;
            }

            Console.WriteLine("a figura é um "+ geometrica+ " e sua area é " + med);
            Console.ReadKey();
        }
    }
}
