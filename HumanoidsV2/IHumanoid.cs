using System;

namespace Humanoids
{
    interface IHumanoid
    {
        void Speak(string wordsToSpeak);
        
        void Walk();
    }
}