using System;

namespace Humanoids
{
    class Human : Humanoid
    {
        public string Name {get; set;}

        public void Eat()
        {
            Console.WriteLine("Nom nom nom");
        }

        public void Sleep()
        {
            Console.WriteLine("Zzzzzzzzz.....");
        }

        public override string GetDetails()
        {
            string details = $"Name: {Name}";

            return details;
        }

    }
}