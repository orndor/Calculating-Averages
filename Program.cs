// File name: Program.cs
// Project Name: Calculating Averages
// Author: Orndoff, Robert K.
// Date created: 07/15/2019
// Date last modified: 07/15/2019
//
// C#
using System;

namespace Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---===Begin Basic Difficulty===---");
            int[] rawScores = Scores();
            Console.WriteLine($"The score average is: {SumScores(rawScores) / 10}");

            Console.WriteLine("---===Begin Intermediate Difficulty===---");
            int[] advRawScores = AdvScores(new int[GetNumOfScores()]);
            int advAverage = AdvSumScores(advRawScores) / advRawScores.Length; //Needed to store this result in a variable for reference in Advanced Difficulty code below.
            Console.WriteLine($"The score average is: {advAverage}");

            Console.WriteLine("---===Begin Advanced Difficulty===---");
            LetterGrade(advAverage);
        }
        static int[] Scores()
        {
            int[] scores = new int[10];
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"Enter score number {i+1}:");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
            return scores;
        }
        static int SumScores(int[] rawScores)
        {
            int sum = 0;
            foreach(int s in rawScores)
            {
                sum += s;
            }
            Console.WriteLine($"The sum of all scores is: {sum}");
            return sum;
        }
        static int GetNumOfScores()
        {
            Console.WriteLine($"How many scores are there?");
            int numScores = Convert.ToInt32(Console.ReadLine());

            return numScores;
        }
        static int[] AdvScores(int[] advScores)
        {
            for (int i = 0; i < advScores.Length; i++)
            {
                Console.WriteLine($"Enter score number {i + 1}:");
                advScores[i] = Convert.ToInt32(Console.ReadLine());
            }
            return advScores;
        }
        static int AdvSumScores(int[] advRawScores)
        {
            int advSum = 0;
            foreach (int s in advRawScores)
            {
                advSum += s;
            }
            Console.WriteLine($"The sum of all scores is: {advSum}");
            return advSum;
        }
        static void LetterGrade(int average)
        {
            if (average > 89)
            {
                Console.WriteLine($"The letter grade average is: A");
            }
            else if (average > 79 && average < 90)
            {
                Console.WriteLine($"The letter grade average is: B");
            }
            else if (average > 69 && average < 80)
            {
                Console.WriteLine($"The letter grade average is: C");
            }
            else if (average > 59 && average < 70)
            {
                Console.WriteLine($"The letter grade average is: D");
            }
            else
            {
                Console.WriteLine($"The letter grade average is: F");
            }
            return;
        }
    }
}
