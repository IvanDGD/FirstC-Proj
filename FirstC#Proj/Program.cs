
using FirstC_Proj.IInterfaces.IOutput;

namespace FirstC_Proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray(5);

            arr.Show();
            arr.Show("info");

            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Avg());
            Console.WriteLine(arr.Search(1));
            Console.WriteLine(arr.Search(0));
        }
    }
}
