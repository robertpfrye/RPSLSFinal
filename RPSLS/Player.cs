using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
    {
        //): As a developer, I want to store all of the gesture options/choices in a List<T>.
        //I want to find a way to utilize the list of gestures within my code (display gesture
        //options, assign player a gesture, etc). 
        public List<string> choice = new List<string>() {"rock", "paper", "scissors", "lizard", "spock"};
        public int score;



        public virtual void ChooseGesture()
        {
            Console.ReadLine();
        }
    }
}
