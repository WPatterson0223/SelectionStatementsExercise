namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var num = new Random();
            var randomNum = num.Next(1, 4);

            Console.WriteLine("Guess a number 1-3");
            var guess = int.Parse(Console.ReadLine());

            if (guess < randomNum)
            {
                Console.WriteLine("Too Low");
            }
            else if (guess > randomNum)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
