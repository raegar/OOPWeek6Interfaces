using System;

namespace Humanoids
{
    class Human : IHumanoid, IGetDetails
    {
        public string Name {get; set;}

        public void Speak(string wordsToSpeak)
        {
            Console.WriteLine(wordsToSpeak);
        }

        public void Walk()
        {
            Console.WriteLine("Going for a walk");
        }


        public void Eat()
        {
            Console.WriteLine("Nom nom nom");
        }

        public void Sleep()
        {
            Console.WriteLine("Zzzzzzzzz.....");
        }

        public string GetDetails()
        {
            string details = $"Name: {Name}";

            return details;
        }

    }
}