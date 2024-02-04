using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientaçãoobjetos
{
    internal class Exercicio4 : Base
    {
        public void Run()
        {
            int a, b;

            string[] valores = Console.ReadLine().Split(' ');

            a = int.Parse(valores[0]);  
            b = int.Parse(valores[1]);

            if (a<b )
            {
                if (b % a == 0)     // declaração de bool para uma expressão lógica
                {
                    Console.WriteLine(" São Multiplos");

                }                                  //Console.WriteLine(b%a);
                else
                {
                    Console.WriteLine(" Não são Multiplos");
                }
            }else
            {
                if (a % b == 0)     // declaração de bool para uma expressão lógica
                {
                    Console.WriteLine(" São Multiplos");

                }                                  //Console.WriteLine(b%a);
                else
                {
                    Console.WriteLine(" Não são Multiplos");
                }
            }




        }
    }
}
