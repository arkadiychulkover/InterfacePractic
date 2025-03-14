
namespace InterfacePractic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray marr = new MyArray(3);
            marr.Show();
            //Console.WriteLine(marr.Less(10));
            //Console.WriteLine(marr.Greater(10));
            //marr.ShowEven();
            //marr.ShowOdd();
            Console.WriteLine(marr.CountDistinct());
            Console.WriteLine(marr.EqualToValue(5));

            //TV tV = new TV();
            //tV.TurnOn();
            //tV.SetChannel(5);
            //tV.Show();

            //PassWordValidate passWordValidate = new PassWordValidate("123456");
            //Console.WriteLine(passWordValidate.Validate("123456"));

            //ValidateGmail validateGmail = new ValidateGmail();
            //Console.WriteLine(validateGmail.Validate("asdassd@mail.com"));
        }
    }
}
