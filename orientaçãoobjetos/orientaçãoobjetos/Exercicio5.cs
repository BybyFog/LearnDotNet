using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientaçãoobjetos
{
    internal class Exercicio5 : Base
    {
        public void Run()
        {     

                      
            /*        operadores lógicos
             <
            >
            <=
            >=
            ==
            !=

            &&

            ||
              10    >=    20
            valor sinal valor


            10    >=    20     || ou &&     30    >=    20
            valor sinal valor    porta     valor sinal valor

             */
            int x = 155, y = 5 , z= 2;      // aqui foi declarada uma variável do tipo int, e foi atribuido no nome, os seus valores 


            if (y < z)                        // caiu 
            {
                Console.WriteLine(" Caiu no if");    // representação de um if encadeado ( composto)
            }
            else if (x >= y || z >= x)             // para que seja o && os dois tem que dar verdadeiro
            {
                Console.WriteLine(" Caiu no else if"  );    // para que seja verdadeiro "||" um tem que dar verdadeiro
            }
            else
            {
                Console.WriteLine( "Caiu no else" );
            }            
        }
    }
}
