using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0305
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número inteiro: ");
            int n1= int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());
            int numeros = 0;

            if (n1 > n2)
            {
                numeros = n1 - n2;
                Console.WriteLine("Os numeros inteiros compreendidos são: ");
                for (int i = 0; i < (numeros-1); i++)
                {
                    n2++;
                    Console.WriteLine(n2);
                }
            }
            else
            {
                numeros = n2 - n1;
                Console.WriteLine("Os numeros inteiros compreendidos são: ");
                for (int i = 0; i < (numeros-1); i++)
                {
                    n2--;
                    Console.WriteLine(n2);
                }
            }
            Console.ReadKey();
        }
    }
}
