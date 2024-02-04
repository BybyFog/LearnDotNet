using System;


using System.Globalization;


/*


int anos = int.Parse(Console.ReadLine());
int result = (ValorEmAno * anos);
Console.WriteLine("Batidas totais = " + result);




Console.WriteLine("------------------------------------");

*/



int cod1, qntd1, cod2, qntd2;
double preco1, preco2, resultado;

string[] Valor = Console.ReadLine().Split(' ');

cod1 = int.Parse(Valor[0]);
qntd1 = int.Parse(Valor[1]);

preco1 = double.Parse(Valor[2]);

 Valor = Console.ReadLine().Split(' ');

cod2 = int.Parse(Valor[0]);
qntd2 = int.Parse(Valor[1]);
preco2 = double.Parse(Valor[2]);


resultado = (qntd1 * preco1) + (qntd2 * preco2);

Console.WriteLine(resultado);









