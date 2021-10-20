using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double salariop, va, ad, t;
           
            Console.WriteLine("Qual seu salario: ");
            salariop = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Qual valor da hora aula: ");
            va = double.Parse(Console.ReadLine());
      
            Console.WriteLine("Quantas aulas você deu: ");
            ad = double.Parse(Console.ReadLine());

          
            va = (va * ad);
            salariop = salariop + va;
            t = salariop * 0.12;
            salariop = salariop - t;

            
            Console.WriteLine("O valor do salario liquido é: " + salariop);
           






        }
    }
}
