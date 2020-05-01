using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vamos calcular a velocidade média?");
            Console.WriteLine(" pressione enter para continuar:");
            Console.ReadKey();

            Console.WriteLine("Informe a distância percorrida em metros.");
            double espaço = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tempo gasto em segundos.");
            double tempo = double.Parse(Console.ReadLine());

            Console.Write("Sua velocidade média é: ");
            double result = (espaço / tempo);
            Console.Write( result);
            Console.WriteLine(" m/s.");

            Console.ReadKey();
        }
    }
}
