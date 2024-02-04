using System.Formats.Asn1;
using System.Globalization;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            int numero1;
            int numero2;

            numero1 = 10;
            numero2 = 20;

            int resultado = numero1 + numero2;

            Console.WriteLine(resultado);

            Console.WriteLine("---------------------------------"); 
            */

            /*

            double um;
            double dois;

            um = double.Parse(Console.ReadLine());
            dois = double.Parse(Console.ReadLine());               //  inicio           PSEUDOCÓDIGO

                                                                    //  ler numero1
                                                                    // ler numero2
                                                                    
                                                                    // numero1 = input do usuário
                                                                    // numero2 = input do usuário

                                                                     // escreva > numero1 + numero2
           
            Console.WriteLine(um + dois);

            */

            /*
            int a1;
            int a2; 

            a1 = int.Parse(Console.ReadLine());
            a2 = int. Parse(Console.ReadLine());

            Console.WriteLine(a1 - a2); 

            */



            /*
            double b1;
            double b2;
            double b3;

            b1 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());      
            b3 = double.Parse(Console.ReadLine());  

            Console.WriteLine( b1 * b2 * b3 );

            */


            /*


            int c1;
            int c2;
            
            c1 = int.Parse(Console.ReadLine());
            c2 = int.Parse(Console.ReadLine()); 

            Console.WriteLine(c1 / c2);

            */

            /*

                int d1;

                d1 = int.Parse(Console.ReadLine());


                Console.WriteLine(d1 * d1); 

                */


            // prova estrutura sequencial ( entrada do usuário)
            /*
          double cod1, num1, cod2, num2;  // declarei que terá numeros inteiros
          double preco1, preco2, resultado;       // declarei que terá números quebrados 

          string[] valor = Console.ReadLine().Split(' ');

          cod1 = int.Parse(valor[0]);   // esse int. parse, está dizendo que pode
          num1 = int.Parse(valor[1]);   //  ser atribuido numero a string, tipo uma 
          preco1 = double.Parse(valor[2]);  // conversão.

          valor = Console.ReadLine().Split(' ');

          cod2 = int.Parse(valor[0]); 
          num2 = int.Parse(valor[1]); 
          preco2 = double.Parse(valor[2]);

          resultado = (preco1 * num1) + (preco2 * num2);  

          Console.WriteLine(resultado.ToString());  // coloco entre parênteses o que eu quero
                 */

            // exercicio 1.2

            // formula area = pi* raio²
            // valor de pi = 3.14
            // area = 3.14 * raio2 = 6,28.

            /*

          double pi = 3.14;       // ler o valor do raio, e depois mostrar a area 
          double raio;             // com 4 casas decimais 
          double area;

          raio = double.Parse(Console.ReadLine());

          area = pi * (raio * raio);   // nesse caso o valor do raio foi calculado 
                                         // primeiro, isso fica indicado pela pres
                                         // ença dos parenteses 

          Console.WriteLine(" Saída=" + area.ToString("F4"));


           */



            //faça um algoritimo para descobrir se um numero é par ou impar 


            /*
        int valor1;

        valor1 = int.Parse(Console.ReadLine());

        int result = valor1 % 2;         // pode ser feito deste maneira tbm

        Console.WriteLine(result==0);  // condição, é quando vc quer saber se uma 
                           */            // coisa é True ou False



            //faça um algoritomo que coloque todos os numeros pares de 1 a 10 na tela

            /*

            int par1, par2, par3, par4, par5;

            par1 = 2;
            par2 = 4;
            par3 = 6;
            par4 = 8;
            par5 = 10;

            Console.WriteLine(par1);
            Console.WriteLine(par2);
            Console.WriteLine(par3);
            Console.WriteLine(par4);
            Console.WriteLine(par5);
                                          */



            //faça um algoritomo que coloque todos os numeros impares de 1 a 10 na tela


            /*    int imp1, imp2, imp3, imp4, imp5;

                imp1 = 1;
                imp2 = 3;
                imp3 = 5;
                imp4 = 7;
                imp5 = 9;



                Console.Write(imp1 + " " + imp2 + " " + imp3+ " " + imp4+ " " + imp5);*/

            // para dar um espaçamento entre os números, por as aspas duplas, elas significam
            // que existe um espaço vazio no meio do código



            // faça uma tabuada, que imprima os valores de 1 ao 10    5 x 1 = 5

            /*
          int a;
          a = int.Parse(Console.ReadLine());

          Console.WriteLine(a + " x 1 = " + a  * 1  );   
          Console.WriteLine(a + " x 2 = " + a * 2  );   
                                                        */


            // pseudocodigo : tem um inicio e fim.

            //        TESTE DE MESA  

            int a, b, c;

            //            variáveis 
            //   A       B          C                    MENS

            //   1       2          3         N É POSSÍVEL FORMAR UM TR                                                              
            //   3       4          5        TRIANGULO ESCALENO       
            //   2       2          4       N É POSSIVEL FORMAR UM TRIANGULO
            //   4       4          4      TRIANGULO EQUILATERO
            //   5       3          3     TRIANGULO ISOSCELES  

            // EXERCÍCIO DE IF estrutura conicional

            // MEDIA DE APROVEITAMENTO = N1 + N2 * N3 * 3 + MEDIA DOS EXERCÍCIOS

            /*
            double MediaDeAproveitamento;
            double N1, N2,N3;
            double Mediadosexercicios;

            N1 = double.Parse(Console.ReadLine());  
            N2 = double.Parse(Console.ReadLine());  
            N3 = double.Parse(Console.ReadLine());  
            Mediadosexercicios = double.Parse(Console.ReadLine());

            MediaDeAproveitamento = (N1 + (N2 * 2) + (N3 * 3) + Mediadosexercicios) / 7;

            Console.WriteLine(MediaDeAproveitamento);

            if (MediaDeAproveitamento >= 9.0)
            {
                Console.WriteLine("A");

            }


            if (MediaDeAproveitamento >= 7.5 && MediaDeAproveitamento < 9.0)
            {
                Console.WriteLine("B");

            }

            if (MediaDeAproveitamento >= 6.0 && MediaDeAproveitamento < 7.5)
            {
                Console.WriteLine("C");      IF SIMPLES
            }

            if (MediaDeAproveitamento < 6.0)
            {
                Console.WriteLine("d");
            }
                       */


            // exercio 3
            /*
double mediafinal;
double n1, n2, n3;

mediafinal = double.Parse(Console.ReadLine());  
n1 = double.Parse(Console.ReadLine());
n2 = double.Parse(Console.ReadLine());  
n3 = double.Parse(Console.ReadLine());

mediafinal = ((n1 * 2) + (n2 * 3) +( n3 * 5)) / 10;

Console.WriteLine(mediafinal);
                         */




            //  Algoritmo que contem erros;    estrutura condicional
            // identifique os erros no algoritmo.
              
            string nome, sexo;          /*         // IF COMPOSTO
            double altura;
            double pesoideal;

            nome = Console.ReadLine();
            sexo = Console.ReadLine();

            altura = double.Parse(Console.ReadLine());


            if (sexo == "m")
            {
                pesoideal = ((72.7 * altura) - 58);
            }
            else
            {
                pesoideal = ((62.1 * altura) - 44.7);  VALOR ATRIBUIDO


            }

            Console.WriteLine(pesoideal);
                   */







        }   
    }
}



// primeiro de tudo, temos que ver o que buscamos ao escrevermos o código:
// qual será a funcionalida dele, o que ele irá abrangir? feito isso, 
// o próximo passo é vermos que tipo de váriavel ela será, e é claro não podemos 
// esquecer de darmos nome a ela, uns fazem conforme o pedido de anunciado, 
// outros só escolhem qualquer coisa, e é isso. Mas é claro que não é muito bacana
// porque pode ser complicado na hora de encontrar possíveis erros no código. 
// próximo passo, atribua valor a sua variável ( àquela que vc tinha que por um nome )
// esse valor, é o que vc quer que o computador, ou usuário te forneça. E o último passo é rodar.