
namespace InterfacePractic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray marr = new MyArray(3);
            marr.Show();
            marr.Show("Hello World");
            Console.WriteLine(marr.Max());
            Console.WriteLine(marr.Min());
            Console.WriteLine(marr.Avg());
            Console.WriteLine(marr.Search(5));
        }
    }
}
