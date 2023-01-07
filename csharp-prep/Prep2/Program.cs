using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What us your grade? ");
        string grade = Console.ReadLine();
        int nGrade = int.Parse(grade);
        if (nGrade >= 93)
        {
            Console.WriteLine($"Contratulation! You got an 'A', YOU PASSED THE EXAM");
        }
        else if (nGrade >= 90)
        {
            Console.WriteLine($"Contratulation! You got an 'A-', YOU PASSED THE EXAM");
        }
        else if (nGrade >= 87)
        {
            Console.WriteLine($"Contratulation! You got an 'B+', YOU PASSED THE EXAM");
        }
        else if (nGrade >= 83)
        {
            Console.WriteLine($"Well done! You got an 'B', YOU PASSED THE EXAM");
        }
        else if (nGrade >= 80)
        {
            Console.WriteLine($"Good! You got an 'B-', YOU PASSED THE EXAM");
        }
        else if (nGrade >= 77)
        {
            Console.WriteLine($" You got an 'c+', YOU CAN DO IT BETTER NEXT TIME");
        }
        else if (nGrade >= 73)
        {
            Console.WriteLine($"You got an 'c', I hope you can do it better next time");
        }
        else if (nGrade >= 70)
        {
            Console.WriteLine($"You got an 'c-', Be careful next time");
        }
        else if (nGrade >= 67)
        {
            Console.WriteLine($"You got an 'D+', You almost don't passed the exam");
        }
        else if (nGrade >= 60)
        {
            Console.WriteLine($"You got an 'D', You almost passed but we need to do a remedial test");
        }
        else
        {
            Console.WriteLine($"You got an 'F', I know next time you are going to do it well, please let me know if i can help you");
        }
    }
}

