namespace Selection_Statement_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 7;

            Console.WriteLine("Guess my favorite number.");

            FavNumber(favNumber);



        }
        public static void FavNumber(int favNumber)
        {
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == 7)
            {
                Console.WriteLine("Great job!");
            }
            else if (userInput > 7)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("Too low");
            }
        }
    }
}