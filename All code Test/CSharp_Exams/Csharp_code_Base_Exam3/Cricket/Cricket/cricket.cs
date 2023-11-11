using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Cricket
    {
    public void pointscalculation(int no_of_matches)
    {
        int sum = 0;

        for (int i = 1; i <= no_of_matches; i++)
        {
            Console.Write($"Enter the score for match {i}: ");
            int score = Convert.ToInt32(Console.ReadLine());
            sum += score;
        }

        double averageofscore = (double)sum / no_of_matches;
        Console.WriteLine($"Total Points Scored: {sum}");
        Console.WriteLine($"Average Points Scored: {averageofscore}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of  matches: ");
        int no_of_matches = Convert.ToInt32(Console.ReadLine());

        Cricket cricket1 = new Cricket();
        cricket1.pointscalculation(no_of_matches);
            Console.ReadLine();
    }
}
}