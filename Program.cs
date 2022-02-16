 
﻿// See https://aka.ms/new-console-template for more information

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

   
        public static void GamePlay()
        {
            //constants
            const int LADDER = 1;
            const int SNAKE = 2;
            const int NO_PLAY = 3;

 
            int rollTry = 0;
            int turnNumber = 1;

            DiceRolling diceRolling = new DiceRolling();
            UserInfo user1 = new UserInfo();
            UserInfo user2 = new UserInfo();


            while (diceRolling.gameEnd == false)
            {
                //variables
                int diceNumber = diceRolling.DiceRoll();
                int functionNumber = diceRolling.Function();
                //Console.WriteLine(diceNumber);
                switch (functionNumber)
                {
                    case LADDER:
                        //user.UserPosition= user.UserPosition + diceNumber <= 100? user.UserPosition: user.UserPosition + diceNumber;
                        if (turnNumber == 1 && user1.UserPosition + diceNumber <= 100)
                        {
                            user1.UserPosition += diceNumber;
                        }
                        else if (turnNumber == 2 && user2.UserPosition + diceNumber <= 100)
                        {
                            user2.UserPosition += diceNumber;
                        }
                        else
                        {
                            Console.WriteLine("max limit 100");
                        }

 

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
                        if (turnNumber == 1 && user1.UserPosition > diceNumber)
                        {
                            user1.UserPosition -= diceNumber;
                        }
                        else if (turnNumber == 2 && user2.UserPosition > diceNumber)
                        {
                            user2.UserPosition -= diceNumber;
                        }
                        else
                        {
                            Console.WriteLine("negative");
                        }
                        turnNumber = diceRolling.UserTurn(turnNumber);
                        break;
                    case NO_PLAY:
                        Console.WriteLine("no play");
                        turnNumber = diceRolling.UserTurn(turnNumber);
                        break;
                    default:
                        Console.WriteLine("default case error");
                        break;
                }
 
                if (user1.UserPosition >= 100 || user2.UserPosition >= 100)
                {
                    diceRolling.gameEnd = true;
                }

                rollTry++;
                Console.WriteLine($"position 1: {user1.UserPosition} 2: {user2.UserPosition}");
                Console.WriteLine($"no. of try: {rollTry}");

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

        }
    }
}
