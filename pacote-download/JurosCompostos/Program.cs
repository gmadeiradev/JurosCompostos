using System;

namespace JurosCompostos
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital = 0.0, taxa = 0.0, mesAnterior = 0.0;
            int meses = 0;

            Console.Write("Digite o capital: R$ ");
            capital = double.Parse(Console.ReadLine());

            Console.Write("Digite a taxa (em %): ");
            taxa = double.Parse(Console.ReadLine());

            Console.Write("Digite os meses: ");
            meses = int.Parse(Console.ReadLine());

            for (int i = 1; i <= meses; i++)
            {
                double montante = capital * Math.Pow((1 + (taxa / 100)), i);
                double juros = montante - capital - mesAnterior;

                mesAnterior += juros;

                Console.WriteLine("\t|Mês: " + i + " |Capital " + capital + " |Montante: " + montante.ToString("N2") + " |Juros: " + juros.ToString("N2") + " |Mês anterior: " + mesAnterior.ToString("N2"));
            }

            Console.Write("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}