// File name: Program.cs
// Project Name: Calculating_Averages
// Author: Orndoff, Robert K.
// Date created: 07/15/2019
// Date last modified: 07/16/2019
//
// C#
using System;
using System.Collections.Generic;

namespace Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Difficulty
            LetterGrade(AverageTenScores(SumTenScores()));

            //Intermediate Difficulty
            LetterGrade(AverageAnyNumberOfScores(SumAnyNumberOfScores()));

            //Advanced Difficulty
            LetterGrade(AverageArbitraryNumberOfScores(SumArbitraryNumberOfScores()));

        }

        static int SumTenScores()
        {
            int[] scores = new int[10];
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"Enter score number {i + 1}:");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (int s in scores)
            {
                sum += s;
            }
            Console.WriteLine($"The sum of all scores is: {sum}");

            return sum;
        }

        static int AverageTenScores(int sum)
        {
            int average = sum / 10;
            Console.WriteLine($"The average of the 10 scores is: {average}");
            return average;
        }

        static void LetterGrade(int average)
        {
            if (average >= 90)
            {
                Console.WriteLine($"The letter grade average is: A");
            }
            else if (average >= 80 && average < 90)
            {
                Console.WriteLine($"The letter grade average is: B");
            }
            else if (average >= 70 && average < 80)
            {
                Console.WriteLine($"The letter grade average is: C");
            }
            else if (average >= 60 && average < 70)
            {
                Console.WriteLine($"The letter grade average is: D");
            }
            else
            {
                Console.WriteLine($"The letter grade average is: F");
            }
            return;
        }

        static Tuple<int, int[]> SumAnyNumberOfScores()
        {
            Console.WriteLine($"How many scores are there?");
            int[] scores = new int[(Convert.ToInt32(Console.ReadLine()))];
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"Enter score number {i + 1}:");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (int s in scores)
            {
                sum += s;
            }
            var scoreinfo = new Tuple<int, int[]>(sum, scores);
            return scoreinfo;
        }

        static int AverageAnyNumberOfScores(Tuple<int, int[]> scoresinfo)
        {
            int average = scoresinfo.Item1 / scoresinfo.Item2.Length;
            Console.WriteLine($"The average of the {scoresinfo.Item2.Length} score(s) is: {average}");

            return average;
        }

        static Tuple<int, List<int>> SumArbitraryNumberOfScores()
        {
            List<int> scores = new List<int>();
            string individualScore;
            do
            {
                Console.WriteLine($"Enter a new score (hit enter to stop):");
                individualScore = Console.ReadLine();
                if (!string.IsNullOrEmpty(individualScore))
                {
                    scores.Add(Convert.ToInt32(individualScore));
                }
            } while (!string.IsNullOrEmpty(individualScore));
            int sum = 0;
            foreach (int s in scores)
            {
                sum += s;
            }
            var scoreinfo = new Tuple<int, List<int>>(sum, scores);
            return scoreinfo;
        }

        static int AverageArbitraryNumberOfScores(Tuple<int, List<int>> scoreinfo)
        {
            int average = scoreinfo.Item1 / scoreinfo.Item2.Count;
            Console.WriteLine($"The average of the {scoreinfo.Item2.Count} score(s) is: {average}");

            return average;
        }
    }
}
