using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace orientaçãoobjetos
{
    public class Exercicio1 : Base
    {
        public void Run()
        {
            // teste de mesa 
            //       x     y        z            resposta
            //       3     2        11              b
            //      150    3        455             c
            //       7    -1        -2              a
            //      -2     5         -5             a
            //      50     3          155           c



            int x, y, z;

            string resposta;


            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            z = (x * y) + 5;

            if (z <= 0)
            {
                resposta = "a";

            }
            else
            {
                if (z <= 100)
                {

                    resposta = "b";

                }
                else
                {
                    resposta = "c"; 
                }
            }

            Console.WriteLine( z);
            Console.WriteLine(resposta);
        }

            

    }
}