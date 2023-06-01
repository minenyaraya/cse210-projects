using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Mineny Araya", "Multiplicar");
        Console.WriteLine(a1.GetSumary());

        MathAssignment a2 = new MathAssignment("MiLy Sutter", "Fraction", "7.3", "8-19");
        Console.WriteLine(a2.GetSumary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Gordo", "European History", "The causes of world War II");
        Console.WriteLine(a3.GetSumary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}