using Tyuiu.RakhimzyanovDI.Sprint4.Task1.V21.Lib;

namespace Tyuiu.RakhimzyanovDI.Sprint4.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int len;
            Console.Write("Введиет количество элементов массива");
            len = Convert.ToInt32(Console.ReadLine());

            int[] numsArry = new int[len];

            for (int i = 0; i <= len - 1; i++) 
            {
                Console.Write("Введите значение " + i + " элемента массива ");
                numsArry[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(numsArry[i] + "\t");

            }
            Console.WriteLine();
            Console.WriteLine();

             
            int res = ds.Calculate(numsArry);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }    
}
