namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = new Random();
            var randomNum = num.Next(1, 4);
            int guess;
            do
            {
                Console.WriteLine("Guess a number 1-3");
                guess = int.Parse(Console.ReadLine());

                if (guess < randomNum)
                {
                    Console.WriteLine("Too Low. Guess again.");
                }
                else if (guess > randomNum)
                {
                    Console.WriteLine("Too High. Guess again.");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            while (guess != randomNum);
        }
    }
}
