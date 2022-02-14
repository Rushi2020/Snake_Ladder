 UC-5


//Repeat till the player reaches 100 and restrict position value to get below 0 

 master
using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing Constant
            const int LADDER = 1;
            const int NOPLAY = 2;
            const int SNAKE = 3;

   UC-5
        public static void GamePlay()
        {
            //constants
            const int LADDER = 1;
            const int SNAKE = 2;
            const int NO_PLAY = 3;

            DiceRolling diceRolling = new DiceRolling();
            UserInfo user = new UserInfo();

            //variables
            int diceNumber = diceRolling.DiceRoll();
            int functionNumber = diceRolling.Function();
            Console.WriteLine(diceNumber);
            while (user.UserPosition < 100)
            {
                switch (functionNumber)
                {
                    case LADDER:
                        user.UserPosition += diceNumber;
                        break;
                    case SNAKE:
                        if (user.UserPosition > diceNumber)
                        {
                            user.UserPosition -= diceNumber;
                        }
                        else
                        {
                            user.UserPosition = 0;
                            Console.WriteLine("user position negative");
                        }
                        break;
                    case NO_PLAY:
                        Console.WriteLine("no play");
                        break;
                    default:
                        Console.WriteLine("default case error");
                        break;
                }
                Console.WriteLine(user.UserPosition);
            }

            int position = 0;

            Random random = new Random();

            int noOnDie = random.Next(1, 7);
            Console.WriteLine($"No On Die {noOnDie}");

            int options = random.Next(1, 4);

            switch (options)
            {
                case LADDER:
                    position += noOnDie;
                    break;

                case SNAKE:
                    position -= noOnDie;
                    break;

                case NOPLAY:
                    Console.WriteLine("POSITION " + position);
                    break;


            }

            Console.WriteLine("POSITION " + position);


 master
        }
    }
}
