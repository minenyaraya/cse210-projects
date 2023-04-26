using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int newNumber = -1;
        while (newNumber != 0)
        {
            Console.WriteLine("Please write a number:  (or number cero = 0 to finish): ");

            string answer  = Console.ReadLine();
            newNumber = int.Parse(answer);

            if (newNumber !=0)
            {
                numbers.Add (newNumber);
            }
    
        }    
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }    
        Console.WriteLine ($"The sume is: {sum}");
 
        float average =((float)sum) / numbers.Count;
        Console.WriteLine($"Average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
            Console.Write($"This is your list: {numbers}");
             
    }   
}