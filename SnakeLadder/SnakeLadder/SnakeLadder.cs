using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    class SnakeLadderSimulator
    {
            int startPosition = 0;
       
        public void start()
        {
            Console.WriteLine("Starting position is:" + startPosition);
        }
        public void RollaDie()
        {
            Random random = new Random();
            int die = random.Next(1,7);
            Console.WriteLine(die);
        }
    }
}

  
