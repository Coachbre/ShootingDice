using System;
using System.Collections.Generic;



namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer
    {
        public string Taunt { get; }

        public void RollTaunt()
        {
            Console.WriteLine($"{Taunt}");
        }
    }
}