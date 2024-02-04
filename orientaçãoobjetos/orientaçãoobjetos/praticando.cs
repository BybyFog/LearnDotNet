using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace orientaçãoobjetos
{
    internal class Praticando : Base
    {
        /*

                             1.Escreva uma mensagem na tela;  ok
                          2Escreva a soma de dois numeros na tela.
             3.Dado um input idade retorne se a pessoa é idosa ou não.

                 4.receba um sinal do usuario entre +, -, * e / e receba dois numeros  depois retorne a operação pedida pelo usuario

               5.da um input do usuario sendo um numero verique se ele é divisivel por 3 se for escreva é divisivel por 3 se não escreva não é divisivel por 3

              6 escreva todos os numeros de 0 a 100 usando o for 

              7.Reescrea o exercicio 4 ultilizando switch
              8.Pense em algo que queira criar e ultilize seus conheciments para isso
*/




        // ué mas foi vc que tinha mudado/ o que que eu mudei ?
        //  é pra por aquela parada que tu me mostrou ne 

        // escreva uma mensagem na tela 

        public void Run()
        {
            // int c = int.Parse(Console.ReadLine());                   // soma de dois números 
            // int g = int.Parse(Console.ReadLine());
            questão7();

        }

        public void Exercicio1()
        {
            Console.WriteLine("Amor, eu te amoooo");              // fazer uma mensagem na tela 

        }
        public int Add(int d, int e)    // 
        {
            return d + e;
        }
        public void Idade(int a)                                   // fununciando <3  mo, ce ta bem?huehuehue to brincando com vc bobo
        {
            if (a >= 60)
            {
                Console.WriteLine("Pessoa idosa");
            }                                                // pessoa idosa ou não 
            else
            {
                Console.WriteLine("Não é pessoa idosa");


            }
        }
        public void Sinais()
        {
            string sinal = Console.ReadLine();   // receber um sinal do usuário 

            string[] numeros = Console.ReadLine().Split(' ');
            double um, dois;                                                                       // receber os numeros 

            um = double.Parse(numeros[0]);        // inicio da operação
            dois = double.Parse(numeros[1]);

            //vc esta se complicando no if
            //pens

            if (sinal == "+")  // chamar a string no if, e transformar o sinal em string, se não tiver as aspas, o sinal entra como comando, aí o codigo não roda 
            {
                Console.WriteLine(um + dois);
                return;
            }
            if (sinal == "-")
            {
                Console.WriteLine(um - dois);
                return;
            }
            if (sinal == "*")
            {
                Console.WriteLine(um * dois);

                return;
            }
            if (sinal == "/")
            {
                Console.WriteLine(um / dois);
                return;
            }
        }
        public void divisivel()
        {
            string num = Console.ReadLine();
            int numero = int.Parse(num);

            if (numero % 3 == 0)
            {
                Console.WriteLine("é divisivel por 3");
            }
            else
            {
                Console.WriteLine("Não é divisivel por 3");
            }


        }

        public void zeroACem()
        {

            for (int i = 0; i <= 100; i++)  // para aparecer o valor 100, eu usei dois operadores, menor ou igual
            {
                Console.WriteLine(i);
            }


        }
        public void Quiz()
        {
            // para rodar as subfunções, é preciso chamar a função, para a função principal 
            perguntaUm();
            perguntaDois();
            perguntaTres();
            perguntaQuatro();
            perguntaCinco();
            perguntaSeis();
           
        }

        public void perguntaUm()
        {
            string pergunta = "Qual o formato do biscoito doritos?";

            string a = "a) Redondo";
            string b = "b) Oval";
            string c = "c) Quadrado";
            string d = "d) Triangular";


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Pergunta 1: " + pergunta + "\n");  // espaçamento:
                                                                  // "\n" para dar quebra de linha, ou pode usar o console.writeline. para dar espaço no parágrafo, só por \t 
                                                                  //Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            string resposta = Console.ReadLine();



            if (resposta == "d") // "f" == "d) Triangular"
            {
                Console.WriteLine(" Resposta correta,parabéns!");
            }
            else
            {
                Console.WriteLine("Resposta incorreta!");
            }


        }
        void perguntaDois()
        {

            string pergunta = "Qual animal representa o símbolo da paz?";

            string a = "a) pomba";
            string b = "b) Gato";
            string c = "c) Cobra";
            string d = "d) Elefante";

            Console.WriteLine("Pergunta 2: " + pergunta);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            string resposta = Console.ReadLine();


            if (resposta == "a") // "f" == "d) Triangular"
            {
                Console.WriteLine(" Resposta correta,parabéns!");
            }
            else
            {
                Console.WriteLine("Resposta incorreta!");
            }



        }
        void perguntaTres()
        {
            string pergunta = "O sushi é um prato original de qual país?";

            string a = "a) Tailândia";
            string b = "b) china";
            string c = "c) japão";
            string d = "d) Coreia do sul";

            Console.WriteLine("Pergunta 3: " + pergunta);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            string resposta = Console.ReadLine();


            if (resposta == "c") // "f" == "d) Triangular"
            {
                Console.WriteLine(" Resposta correta,parabéns!");
            }
            else
            {
                Console.WriteLine("Resposta incorreta!");
            }


        }
        void perguntaQuatro()
        {
            string pergunta = "Qual animal que aparece na logotipo da ferrari?";

            string a = "a)leão";
            string b = "b) cavalo";
            string c = "c) tigre";
            string d = "d) leopardo";

            Console.WriteLine("Pergunta 4: " + pergunta);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            string resposta = Console.ReadLine();


            if (resposta == "b") // "f" == "d) Triangular"
            {
                Console.WriteLine(" Resposta correta,parabéns!");
            }
            else
            {
                Console.WriteLine("Resposta incorreta!");
            }



        }
        void perguntaCinco()
        {
            string pergunta = "Qual é o sobrenome mais comum no brasil?";


            string a = "a)silva";
            string b = "b) santos";
            string c = "c) souza";
            string d = "d) oliveira";

            Console.WriteLine("Pergunta 5: " + pergunta);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            string resposta = Console.ReadLine();


            if (resposta == "a") // "f" == "d) Triangular"
            {
                Console.WriteLine(" Resposta correta,parabéns!");
            }
            else
            {
                Console.WriteLine("Resposta incorreta!");
            }

        }
        void perguntaSeis()
        {
            string pergunta = "Qual o nome do inventor do celular?";

            string a = "a)Thomas Edison";
            string b = "b) Alexander Graham Bell";
            string c = "c) Nikola Tesla";
            string d = "d) Guglielmo Marconi";

            Console.WriteLine("Pergunta 6: " + pergunta);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            string resposta = Console.ReadLine();


            if (resposta == "b") // "f" == "d) Triangular"
            {
                Console.WriteLine(" Resposta correta,parabéns!");
            }
            else
            {
                Console.WriteLine("Resposta incorreta!");
            }
        }


        void questão7()
        {

            string sinal = Console.ReadLine();   // receber um sinal do usuário 

            string[] numeros = Console.ReadLine().Split(' ');
            double um, dois;

            um = double.Parse(numeros[0]);
            dois = double.Parse(numeros[1]);

            string resultado;


            switch (sinal)     // refiz o exercicio quatro usando o switch
            {
                case "+":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(um + dois);
                    break;
                //ta potente  o queb isso quer dizer?\ quer dizer que ta aprendendo 
                case "-":
                    Console.WriteLine(Console.ForegroundColor = ConsoleColor.Yellow);
                    Console.WriteLine(um - dois);
                    break;
                case "*":
                    Console.WriteLine(Console.ForegroundColor = ConsoleColor.Blue);
                    Console.WriteLine(um * dois);
                    break;
                case "/":
                    Console.WriteLine(Console.ForegroundColor = ConsoleColor.Magenta);
                    Console.WriteLine(um / dois);
                    break;

            }


        }
        void aprendendoW()
        {
            double x, y;
            Console.WriteLine("Digite aqui a sua senha:");  

            x = 0;  
            y = 2002;
            
            while (x != y)  
            {
                x = double.Parse(Console.ReadLine());
                if (x != y)
                {
                     Console.WriteLine("senha inválida");                    
                }
                if (x == y)
                {
                    Console.WriteLine("senha válida");
                }

            }



        }
    }

}

