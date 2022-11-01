using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace developerspro
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String sobrenome;
            Console.WriteLine("Escreva seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("EScreva seu sobrenome");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Nome comleto");
            Console.WriteLine(nome + "" + sobrenome);
            Console.ReadKey();
            


        }
    }
}
