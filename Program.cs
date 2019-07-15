using System;

namespace Calculating_Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rawScores = Scores();
            Console.WriteLine($"The score average is: {SumScores(rawScores) / 10}"); 
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
        //static void ScoreAverage(int sum)
        //{
        //    Console.WriteLine($"The average score is: {sum/10}");
        //}
        //static void PrintScores(int[] rawScores)
        //{
        //    foreach(int s in rawScores)
        //    {
        //        Console.WriteLine($"The scores are {s.ToString()}:");
        //    }
        //    return;
        //}
    }
}
