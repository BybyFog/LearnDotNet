

using System.Text.RegularExpressions;

namespace orientaçãoobjetos
{
    internal class Areadoquadrado : Base
    {
        public void Run()
        {
            /*
                    
        // calcular à área do quadrado
        // lado * lado                                
                         
        
            double lado, area;                         // tipo e nome da variável

            lado = double.Parse(Console.ReadLine());        // entrada de dados 

            area = lado * lado;                    // execução do valor das variáveis

            Console.WriteLine("A área do quadrado é " + area);      // saída 

            // para dar espaço entre uma palavra e outra, é so dar espaço na escrita 
            //dentro das chaves

                                */


            //    calcular a area do circulo: A = pi * raio²


            //double raio, area;    

            //double PI = 3.14;// por ponto, pq a vígula só pode ser usada para alguns casos 

            // Console.Write("Digite o raio: ");
            // raio = double.Parse(Console.ReadLine());

            //  area = PI * (raio * raio);

            //      Console.WriteLine("A área do circulo é: " + area);




            // double nota, frequencia;  // verificando com boll 

            // Console.WriteLine("Verifique aqui, a sua nota e frequência: "); 

            // nota = double.Parse(Console.ReadLine()); //nesse código foi usado 
            // operadores lógicos e relacionais 
            // frequencia = double.Parse(Console.ReadLine());

            // if (nota >=7 && frequencia >=70)
            //  {
            // Console.WriteLine("Aprovado");
            //  }
            // else
            // {
            // Console.WriteLine("Reprovado");
            // }

            //        Fazer um algoritmo pode tirar carteira de motorista

            //double idade;     // pesquisar como escrever um código qu pede a idade completa

            //idade = double.parse(console.readline());

            //if (idade >= 18)
            //{
            //    console.writeline("pode tirar carteira de motorista");
            //}
            //else
            //{
            //    console.writeline("não pode tirar carteira de motorista");
            //}


            //  





            LargestPower(4);











        }


        public  int LargestPower(int n) // número inteiro 
        {    
            bool condicao = true;  
            for (int i = 0; condicao; i++)
            {
                int num = Exp(3, i);
                if (num >= n)
                {
                    return i-1;
                }
            }
            return 0;
        }

        public int Exp(int a, int b) { 
        
            if(b == 0)
                return 0;
            int count = a;
            for (int i = 0; i < b; i++)
            {
                count *= a;
            }
            return count;
        }
        public int Sum(int[] numbers)  // Nesse exercício, o esperado era ser somado somente os números 
        {                             // depois do zero que seria o menor, e o penultimo numeo antes do maior 
            if (numbers == null)
            {
                return 0;
            }

            List<int> num = numbers.ToList();   

           // if (num.Count == 0 || num.Count == 1)
            {
                return 0;
            }
            num.Sort();
            int count = 0;
            for (int i = 0; i < num.Count; i++)
            {
                if (i == 0 || i == num.Count - 1)
                {
                    continue;
                }
                count += num[i];
            }
                 // return count;   
        }
    }
}
