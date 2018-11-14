using System;
using System.Collections.Generic;

namespace lista_objeto_associacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carro> listaCarro = new List<Carro>();

            Carro carro1 = new Carro();
            Carro carro2 = new Carro();
            Carro carro3 = new Carro();

            Console.WriteLine("Digite o nome do carro: ");
            carro1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o ano do carro: ");
            carro1.anoLancamento = Int32.Parse(Console.ReadLine());
            listaCarro.Add(carro1);
            //carro1.Nome = "Gol";
            //carro1.anoLancamento = 2008; 
            //listaCarro.Add(carro1);

            Console.WriteLine("Digite o nome do carro: ");
            carro2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o ano do carro: ");
            carro2.anoLancamento = Int32.Parse(Console.ReadLine());
            listaCarro.Add(carro2);
            //carro2.Nome = "Palio";
            //carro2.anoLancamento = 2002;
            //listaCarro.Add(carro2);

            Console.WriteLine("Digite o nome do carro: ");
            carro3.Nome = Console.ReadLine();
            Console.WriteLine("Digite o ano do carro: ");
            carro3.anoLancamento = Int32.Parse(Console.ReadLine());
            listaCarro.Add(carro3);
            //carro3.Nome = "Fusca";
            //carro3.anoLancamento = 1968;
            //listaCarro.Add(carro3);

            foreach (Carro e in listaCarro)
            {
                Console.WriteLine("\n" + e.Nome + " - " + e.anoLancamento);
            }
        }
    }
}
