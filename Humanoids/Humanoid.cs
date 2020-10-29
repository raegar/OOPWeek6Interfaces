using System;

namespace Humanoids
{
    abstract class Humanoid
    {
        protected virtual void Speak(string wordsToSpeak)
        {
            Console.WriteLine(wordsToSpeak);
        }

        protected void Walk()
        {
            Console.WriteLine("Going for a walk");
        }

        protected virtual string GetDetails()
        {
            return "";
        }
    }
}