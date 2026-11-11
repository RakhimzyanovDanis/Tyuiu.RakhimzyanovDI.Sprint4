    using Tyuiu.RakhimzyanovDI.Sprint4.Task0.V25.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint4.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };

            for (int i = 0; i <= numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }
            

            int sumResult = ds.GetSumEvenArrEl(numsArray);
            Console.WriteLine("Сумма четных элементов:"); 
            Console.WriteLine(sumResult);

        }
    }
}
