using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 5 + 7;
            sum++;
            int difference = 5;
            difference -= 3;
            int product = 11;
            int ans = product * 2;

            int a = 17;
            int b = 4;
            int roundedAns = 17 / 4;
            int remainder = 17 % 4;

            Console.WriteLine(sum);  //13
            Console.WriteLine(difference); // 2
            Console.WriteLine(ans); // ans 22
            //String comprehension
            Console.WriteLine($"{a}/{b} is {roundedAns} remainder {remainder}");
        }
    }
}
