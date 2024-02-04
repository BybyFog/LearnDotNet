using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientaçãoobjetos
{
    internal class Exercicio2 : Base
    {
        public void Run()
        {
            /* double desconto ;    // escopo

             double preco =double.Parse(Console.ReadLine());

            if(preco > 100)
            {
                desconto = preco * 0.1;   
            }

            Console.WriteLine(desconto);
            */

            //<=
            //>=


            // exercícios estrutura condiconal

            int inteiro;

            inteiro = int.Parse(Console.ReadLine());

            if (inteiro >= 0)
            {
                Console.WriteLine("Não negativo");

            }
            else
            {
                 Console.WriteLine("Negativo");

            }



        }
    }
}
