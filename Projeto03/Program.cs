using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Selecione uma função; ");
            Console.WriteLine("1 - Pessoa mais velha");
            Console.WriteLine("2 - Média salarial");
            op = int.Parse(Console.ReadLine());
            switch (op){
                default:
                    Console.WriteLine("Opção incorreta, pressione qualquer botão para encerrar.");
                    Console.ReadLine();
                break;
                case 1:
                    Console.WriteLine("Insira o nome da primeira pessoa;");
                    Console.WriteLine("Nome; ");
                    p1.nome = Console.ReadLine();
                    Console.WriteLine("Idade; ");
                    p1.idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o nome da segunda pessoa;");
                    Console.WriteLine("Nome; ");
                    p2.nome = Console.ReadLine();
                    Console.WriteLine("Idade; ");
                    p2.idade = int.Parse(Console.ReadLine());
                    if (p1.idade > p2.idade)
                    {
                        Console.WriteLine("Pessoa mais velha: " + p1.nome);
                    }
                    else
                    {
                        Console.WriteLine("Pessoa mais velha: " + p2.nome);
                    }
                break;
                case 2:
                    Console.WriteLine("Insira o nome do primeiro funcionário;");
                    Console.WriteLine("Nome; ");
                    f1.nome = Console.ReadLine();
                    Console.WriteLine("Salário; ");
                    f1.salario = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o nome do segundo funcionário;");
                    Console.WriteLine("Nome; ");
                    f2.nome = Console.ReadLine();
                    Console.WriteLine("Salário; ");
                    f2.salario = int.Parse(Console.ReadLine());
                    int media = f2.salario + f1.salario / 2;
                    Console.WriteLine("A média salarial dos colaboradores é; " +media);
                break;
            }
            Console.WriteLine("aperte qualquer botão para encerrar.");
            Console.ReadLine();
        }
    }
}
