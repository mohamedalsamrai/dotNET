namespace day_1;

internal static class Program
{
    private static void Main(string[] args)
    {
        String? input = Console.ReadLine();
        if (input != null&&!input.Equals(string.Empty))
        {
            string[] inputArray = input.Split(",");
        }
        else
        {
            Console.WriteLine("Nothing found");
        }
    }
}