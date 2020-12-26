using System;
using Lab10Dll;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            var mat1 = new Matrix();
            var mat2 = new Matrix();

            mat1.LoadMatrix("mat1.txt");
            mat2.LoadMatrix("mat2.txt");

            Console.WriteLine("Произведение диагонали первой матрицы: " + mat1.DiagonalProduct());
            Console.WriteLine("Сумма элементов второй матрицы: " + mat2.SumOfAllElements());

            Console.ReadKey();
        }
    }
}
