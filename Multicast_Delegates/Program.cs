using Multicast_Delegates.Services;
using System;

namespace Delegates
{
    class Program
    {
        delegate void NumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            NumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            
            op(a, b);
        }
    }
}