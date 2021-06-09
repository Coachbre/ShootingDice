using System;
using System.Collections.Generic;



namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer  : Player
    {
        public string Taunt { get; set; }

        public override int Roll()
        {
            Console.WriteLine($"{Taunt}");
            return base.Roll();
            // base refers to the parent method- in this case Play(Player other))
        }

    }
}