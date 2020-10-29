using System;

namespace Humanoids
{
    class Robot : IHumanoid, IRobot, IGetDetails
    {
        public string Designation {get; set;}

        public void Recharge()
        {
            Console.WriteLine("Charging...");
        }

        public void FireLaser()
        {
            Console.WriteLine("Firing mah laser");
        }

        public void Speak(string wordsToSpeak)
        {
            Console.WriteLine($"Beep boop. {wordsToSpeak}");
        }

        public void Walk()
        {
            Console.WriteLine("Going for a walk");
        }

        public string GetDetails()
        {
            string details = $"Designation: {Designation}";
            return details;
        }
    }
}