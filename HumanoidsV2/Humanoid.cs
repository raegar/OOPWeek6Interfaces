using System;

namespace Humanoids
{
    abstract class Humanoid
    {
        public virtual void Speak(string wordsToSpeak)
        {
            Console.WriteLine(wordsToSpeak);
        }

        public void Walk()
        {
            Console.WriteLine("Going for a walk");
        }
    }
}