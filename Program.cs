using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero, modulo;
            Console.Write("Digite um número: ");
            numero = Convert.ToDecimal(Console.ReadLine());
            modulo = numero % 2;
            if (modulo == 0)
            {
                Console.Write("O número digitado é PAR");
            }else
            {
                Console.Write("O número digitado é ÍMPAR");
            }

            Console.ReadLine();
        }
    }
}
