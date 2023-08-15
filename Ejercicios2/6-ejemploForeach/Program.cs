namespace ejemploForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.ForegroundColor = ConsoleColor.Cyan;

            foreach (var i in nums)
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}