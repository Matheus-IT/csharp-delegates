namespace Delegates
{
    public class Program
    {
        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name:");
            string name = Console.ReadLine() ?? "";
            LogDel logger = new LogDel((text) => Console.WriteLine(text));
            logger($"Hello, World! {name}");
        }
    }
}