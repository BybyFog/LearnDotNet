using System;


using System.Globalization;


namespace exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*  string produto1 = "computador";
              string produto2 = "mesa de escritório";

              byte idade = 30;
              int codigo = 5290;
              char genero = 'M';

              double preco1 = 2100.0;
              double preco2 = 650.50;
              double medida = 53.234567;

              Console.WriteLine(produto1);
              Console.WriteLine(produto2);
              Console.WriteLine(idade);
              Console.WriteLine(codigo);  
              Console.WriteLine(genero); 

              Console.WriteLine(preco1);  
              Console.WriteLine(preco2);  
              Console.WriteLine(medida);

              Console.WriteLine($" produtos:\n {produto1} cujo preco é R$:{preco1},  {produto2} cujo preco é  R$:{preco2} reais,");
              Console.WriteLine($" registro: {idade} anos de idade, codigo {codigo} e genero: {genero} ");

              Console.WriteLine($" Medidas com oito casas decimais: {medida:F8}");
              Console.WriteLine($"Arredondado(três casas decimais): {medida:F3}");

              Console.WriteLine($"sepador decimal invariant culture: {medida.ToString("f3", CultureInfo.InvariantCulture)}");
            * /
           
            /*
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
          double n4 = 10.8 / 8.0;

            double a = 1.0, b = -3.0, c = -4.0;
            
            double delta = Math.Pow (b,  2.0) -   4.0  * a  *   c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

                */


            /*

                                string frase = Console.ReadLine();
                               string X   = Console.ReadLine ();
                               string Y   = Console.ReadLine () ;
                               string z   = Console.ReadLine () ;

                                 string s = Console.ReadLine () ;


                                 string[] v =  s.Split(' '); 3.0 4.0 5.2
                                 string a = v[0] ;
                                 string b = v[1] ;           
                                 string c =  v[2] ;

                                Console.WriteLine ( "  Você digitou:  ");
                                Console.WriteLine ( frase );
                                Console.WriteLine (X);
                                Console.WriteLine (Y);
                                Console.WriteLine (z);

                                Console.WriteLine (a);


                         /*



                              int n1 = int.Parse(Console.ReadLine());

                              Console.WriteLine("VOCÊ DIGITOU:");
                              Console.WriteLine(n1);


                         */


            /* Console.WriteLine();

             string frase = Console.ReadLine();
             string nome = Console.ReadLine();
             int n2 = 3;
             double produto = 500.50;
             string n = Console.ReadLine();

             int n1 = int.Parse(Console.ReadLine());
             double a = 1.73;

             Console.Write("Entre com seu nome completo:");
             Console.WriteLine(nome);
             Console.Write(" Quantos quartos tem na sua casa?");
             Console.WriteLine(n2);
             Console.Write(" Entre com o preço de um produto:");
             Console.WriteLine(produto);


             Console.WriteLine(nome + n1 + a.ToString("F2", CultureInfo.InvariantCulture));*/


            /*
             Console.WriteLine(" Entre com seu nome :");// L1
             string nome = Console.ReadLine(); // L2

             Console.WriteLine("Quantos quartos tem na sua casa?");//L3
             int n1 = int.Parse(Console.ReadLine());//L4

             Console.WriteLine("Entre com o preço de um produto:");//L5
             double n2 = double.Parse(Console.ReadLine());//L6


             Console.WriteLine("Entre com seu último nome , idade e altura ( mesma linha)");//L7
             string value = Console.ReadLine();//L8
             //Green 21 1.73
             Console.WriteLine(nome);
             Console.WriteLine(n1);
             Console.WriteLine(n2);
             string[] v = value.Split(' ');//L12
             Console.WriteLine(v[0]);
             Console.WriteLine(v[1]);
             Console.WriteLine(v[2]);

             */

            /*    

       double largura, comprimento, precoMetroQuadrado, area, preco;

       largura= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       comprimento= double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);  
       precoMetroQuadrado=double.Parse (Console.ReadLine (), CultureInfo.InvariantCulture);


       area = largura * comprimento;
       preco = area * precoMetroQuadrado;

       Console.WriteLine("area=" + area.ToString("F2",CultureInfo.InvariantCulture));
       Console.WriteLine("preco="+ preco.ToString("F2", CultureInfo.InvariantCulture));


       Console.ReadLine();   

             Console.WriteLine(nome);

            Console.WriteLine("Bom dia!");
            Console.Write("Boa tarde!");

            Console.Write("bom dia ");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais", nome, idade, saldo);




            idade = 32;
            saldo = 10.3256f;
            nome = "Maria";

            Console.WriteLine($"{nome} tem {idade}  anos e tem saldo igual a {saldo:F2} reais");
            Console.WriteLine(nome  +  " tem "   +   idade + "anos e tem saldo igual a " + saldo. ToString ("F2") + "reais");



            double entrada, saida;

                  int n1= int.Parse(Console.ReadLine());
                  int n2= int.Parse(Console.ReadLine());
                                                                      TENTATIVA 
           


            Console.WriteLine("n1" + n1.ToString("F",CultureInfo.InvariantCulture));
            Console.WriteLine("n2"+ n2.ToString("F",CultureInfo.InvariantCulture) );

            Console.ReadLine();              



             string entrada = Console.ReadLine();    
                string saida = Console.ReadLine();

            Console.WriteLine(" entrada");                           TENTATIVA 
            Console.WriteLine("saida");

            Console.WriteLine("entrada" + "entrada " );
            Console.WriteLine("saida");                 



             int a, b, soma;
                                                                         exercicio
                         a = int.Parse( Console.ReadLine() );
            b = int.Parse(Console.ReadLine());
                                                                   CORREÇÃO
            soma= a + b;

            Console.WriteLine("SOMA = " + soma );  




            int A, B, C, D, diferenca;



            A = int.Parse(Console.ReadLine());                       exercicio

            B = int.Parse(Console.ReadLine());                 acertei

            C = int.Parse(Console.ReadLine());

            D = int.Parse(Console.ReadLine());     
               
            diferenca = A * B - C * D;

            Console.WriteLine("DIFERENÇA =" + diferenca);


             int numero, horas;
            double valorhora, salario;
                                                                 exercicio, correto
            numero = int.Parse(Console.ReadLine());
            horas= int.Parse(Console.ReadLine());  
            valorhora= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            salario = valorhora * horas;

            Console.WriteLine("NUMBER=" + numero);  
            Console.WriteLine("SALARY=U$" +  salario.ToString(CultureInfo.InvariantCulture));




              int cod1, cod2, qntd1, qntd2;

            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');       " sempre que o usuario receber uma mensagem, 
                                                                         colocar uma string, ela atribui ao recebimento
                                                                          mas pode ser utilizada para nomes e afins"
                                                                        

            cod1 = int.Parse(valores[0]);
            qntd1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');

            cod2 = int.Parse(valores[0]);
            qntd2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);


            total = (preco1 * qntd1) + (preco2 * qntd2);

            Console.WriteLine("VALOR A PAGAR R$=" + total.ToString("F2", CultureInfo.InvariantCulture));


                               */
                                    /*

                        double a, b, c;

                        string[] valores = Console.ReadLine().Split(' ');


                        a = double.Parse(valores[0]);
                        b = double.Parse(valores[1]);
                        c = double.Parse(valores[2]);

                        //b*h/2

                        double triangulo = (a * c) / 2.0f;

                        // a=pi * r²

                        double circulo = (c * c) * Math.PI;

                        //  A=(a+b)h/2

                        double trapezio = ( (a + b) * c) / 2;

                        // l * l

                        double quadrado = b * b;

                        // A=b⋅h

                        double retangulo = a * b;


                        Console.WriteLine($@"
                        TRIANGULO: {triangulo.ToString( CultureInfo.InvariantCulture)}
                        CIRCULO: {circulo}
                        TRAPEZIO: {trapezio}
                        QUADRADO: {quadrado}
                        RETANGULO: {retangulo}
                        ");

                                */


            String[] valores = Console.ReadLine().Split(' ');






        }
                 
                 


     

       





    }
}

