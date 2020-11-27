using System;

namespace formula
{
    public class Formula
    {
        public string name;
        public bool usedRitchie;
        public string token;
        public Formula(string paramName, string paramUsedRitchie, string token)
        {
            this.name = paramName;
            this.usedRitchie = false;
            if (!Boolean.TryParse(paramUsedRitchie, out usedRitchie))
            {
                usedRitchie = false;
            }
            this.token = token;

        }

        public void Run()
        {

            Console.WriteLine("Running formula for testing and show rit cloud execution!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your name is {name}.");
            Console.ForegroundColor = ConsoleColor.Blue;
            if (usedRitchie)
            {
                Console.WriteLine("Congrats... You've answered that you already have used Ritchie.");
            }
            else
            {
                Console.WriteLine("So sorry. I hope you get to use Ritchie ASAP.");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The token in your credential is {token}.");
            Console.ResetColor();
        }

    }
}
