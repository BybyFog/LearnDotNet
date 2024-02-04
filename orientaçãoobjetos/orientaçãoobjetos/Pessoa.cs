using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace orientaçãoobjetos
{
    internal class Pessoa : Base
    {
        public void Run()
        {
            string nome;
            string endereco;                                          // fazer um sistema de cadastro: por nome, idade, endereço
            int idade;
                                                                          
                                                                          // foi declarado um tipo de variável, e seu nome
            Console.Write("Escreva seu Nome completo: ");    
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é:" + nome);
            Console.WriteLine("Escreva aqui seu endereço:");
            endereco = Console.ReadLine();
            Console.WriteLine("Aqui está seu endereço:"+ endereco);
            Console.WriteLine("Escreva aqui a sua idade:");                                                             // leia, o usuário terá que digitar seu nome;
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Sua idade:" + idade);



             

                                                                   // escreva, o console dará o nome da pessoa depois de digitado,
                                                                        // e aparecerá a mensagem "Bom dia"


        }
    }
}
