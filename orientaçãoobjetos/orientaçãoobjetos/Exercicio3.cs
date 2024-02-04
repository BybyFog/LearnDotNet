using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientaçãoobjetos
{
    internal class Exercicio3 : Base
    {

        /*
         Fazer um programa para ler um número 
        inteiro e dizer se este número é par ou ímpar.         
         */
        public void Run()
        {
            int numero;

            numero = int.Parse(Console.ReadLine());

           

            if ((numero % 2) == 0)
            {
                Console.WriteLine("par");
            }
            else
            {
                Console.WriteLine("Impar");
            }



        }
    }
}
