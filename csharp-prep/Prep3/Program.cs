using System;

class Program
{
    static void Main(string[] args)
    {
        Random randoGenerator = new Random();
        int magicNumber = randoGenerator.Next(1, 101), conInt=0;

        int guess = -1;
    
        while (guess != magicNumber)
        {
            Console.Write("Guess a number: ");
            guess = int.Parse(Console.ReadLine());
            

            if (magicNumber > guess)
            {
                Console.WriteLine("You need a higher number");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("You need a lower number");
            }
            else
            {
                Console.WriteLine ("This the number, Congratulations!");
                Console.WriteLine($"You tried to guess  {conInt}  times");
        
            }
            conInt++;
        
        }

    }
}