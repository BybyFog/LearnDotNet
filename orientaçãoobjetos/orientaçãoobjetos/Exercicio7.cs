using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orientaçãoobjetos;

internal class Exercicio7 : Base // crie uma calculadora dividindo as operações em funções 
{
    public void Run()
    {

        Exponent(2, 10);            // para não mostrar o retorno da função, e so exibir o valor dela, é so retirar o cw

    }
    public int Add(int a, int b)            // ele vai receber dois números inteiros por parametro, e deve retornar um número inteiro
    {
        return a + b;
    }

    public int Subt(int a, int b)
    {
        return a - b;
    }
    // mo, eu quero escrever o passo a posso de uma função, tudo mesmo, como faz, o que escrever 
    public int Multiplay(int a, int b)
    {
        return a * b;
    }
    public int Divide(int a, int b)
    {
        return a / b;
    }
    public int Mod(int a, int b)
    {
        return a % b;
    }

    public int Exponent(int a, int b)
    {
        //for (iniciação; condição; incremento) // é usado a variavel index, para indicar onde ta o loping (inicialização)

        int guardar;
        guardar = 1;
        for (int i = 0; i < b; i++)  // a == 2  b==10
        {
           // Console.WriteLine(a*a);

            guardar *= a;
            Console.WriteLine(guardar);


        }



        return 544646546;
    }













}

