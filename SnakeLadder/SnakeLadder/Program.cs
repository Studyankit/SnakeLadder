// See https://aka.ms/new-console-template for more information
using System;

namespace SnakeLadderSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeLadder.SnakeLadderSimulator simulator = new SnakeLadder.SnakeLadderSimulator();
            simulator.RollaDie();
            
        }
    }
}
