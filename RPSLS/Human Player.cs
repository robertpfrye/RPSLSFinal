using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    //As a developer, I want to find a way to properly incorporate inheritance into my game.
    public class Human_Player : Player
    {
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose your gesture");
            //choice = Console.ReadLine();
        }
    }
}
