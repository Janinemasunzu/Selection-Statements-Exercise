namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ----------Exercise 1
            var r = new Random();
            var favNumber = r.Next(1, 50);
        
         
            Console.WriteLine("Pick a number from 1 - 50");
            var userInput = int.Parse(Console.ReadLine());
            
            if (userInput < favNumber) 
            { 
                Console.WriteLine($"{userInput} is too low");

            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high");

            }
            else 
            {
             Console.WriteLine("You got it right");
            }

        }
    }
}
