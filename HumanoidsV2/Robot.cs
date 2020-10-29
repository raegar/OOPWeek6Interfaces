using System;

namespace Humanoids
{
    class Robot : Humanoid, IGetDetails
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

        public override void Speak(string wordsToSpeak)
        {
            Console.WriteLine($"Beep boop. {wordsToSpeak}");
        }

        public string GetDetails()
        {
            string details = $"Designation: {Designation}";
            return details;
        }
    }
}