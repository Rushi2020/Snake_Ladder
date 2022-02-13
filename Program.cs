// The player rolls the die to get a number between 1 to 6
using System;

namespace Snake_And_Ladder
{
    class Programe
    {
        public static int dieRoll()
        {
            Random random = new Random();
            int dieNumber = random.Next(1, 7);
            return dieNumber;
        }
        public static void Main(string[] args)
        {
            int position = dieRoll();
            Console.WriteLine("Position:" + position);
        }

    }

}