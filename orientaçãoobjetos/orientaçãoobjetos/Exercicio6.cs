using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientaçãoobjetos
{
    internal class Exercicio6 : Base
    {
        public void Run()
        {
            // hora inicial e final 
            // cal duração do jogo ( pode ter a dura de 24h
            // min 1h max 24

            double hrInicial;//16
            double hrFinal;//2
            double result = 0;

            string[] hora = Console.ReadLine().Split(' ');

            hrInicial = double.Parse(hora[0]);          /// eu tbm quero trapar
            hrFinal = double.Parse(hora[1]);

            if (hrInicial>=hrFinal) 
            {
                result = 24 - hrInicial + hrFinal;
            }
            else
            {
                result = (hrInicial-hrFinal)*-1;
               
            }

            Console.WriteLine($"o jogo durou {result} hora(s)");
        }
    }
}
