using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Insira o nome da primeira pessoa;");
            Console.WriteLine("Nome; ");
            p1.nome=Console.ReadLine();
            Console.WriteLine("Idade; ");
            p1.idade=int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome da segunda pessoa;");
            Console.WriteLine("Nome; ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Idade; ");
            p2.idade = int.Parse(Console.ReadLine());
            if(p1.idade > p2.idade) {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else{
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }
        }
    }
}
