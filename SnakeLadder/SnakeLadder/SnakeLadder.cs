using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    class SnakeLadderSimulator
    {
        const int noPlay = 0;
        const int ladder = 1;
        const int snake = 2;

        static int playerPosition =0;

        public void SelectOption()
        {
            int die = 0;

            while (playerPosition < 100)
            {
                Random random = new Random();
            int option = random.Next(0, 3);

            die = RollaDie();

                if (option == 1)
                {
                    playerPosition = playerPosition + die;
                    Console.WriteLine("Player status is Ladder");
                    Console.WriteLine("Player position is:" + playerPosition);
                }
                else if (option == 2)
                {
                    playerPosition = playerPosition - die;
                    Console.WriteLine("Player status is Snake");
                    Console.WriteLine("Player position is:" + playerPosition);
                }
                else
                {
                    Console.WriteLine("Player status is No Play");
                    Console.WriteLine("Player position is:" + playerPosition);
                }
            }
        }
        public static int RollaDie()
        {
            Random random = new Random();
            int die = random.Next(1, 7);
            return die;
        }
    }
}

  
