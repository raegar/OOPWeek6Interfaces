using System;

namespace Humanoids
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Human human1 = new Human();
            human1.Name = "Kai";

            Robot robot1 = new Robot();
            robot1.Designation = "OO-P0";

            Console.WriteLine(human1.GetDetails());
            human1.Speak("Hello");
            human1.Walk();
            human1.Eat();
            human1.Sleep();

            Console.WriteLine(robot1.GetDetails());
            robot1.Speak("Hello");
            robot1.Walk();
            robot1.Recharge();
            robot1.FireLaser();

        }
    }
}
