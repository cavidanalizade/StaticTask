namespace StaticTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Javidan";
            Console.WriteLine(a.CustomContains("ja"));
            Console.WriteLine(a.CustomContains('j'));
            int number = 32;
            Console.WriteLine(number.IsPrime());
            Console.WriteLine(number.IsPowOfTwo());
        }
    }
}