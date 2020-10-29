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

            Cyborg cyborg1 = new Cyborg();
            cyborg1.Name = "Seven";
            cyborg1.Designation = "7 of 9";

            DisplayDetails(human1);
            DoBasicHumanoidStuff(human1);
            human1.Eat();
            human1.Sleep();

            DisplayDetails(robot1);
            DoBasicHumanoidStuff(robot1);
            robot1.Recharge();
            robot1.FireLaser();

            DisplayDetails(cyborg1);
            DoBasicHumanoidStuff(cyborg1);
            cyborg1.Recharge();
            cyborg1.FireLaser();

        }

        static void DoBasicHumanoidStuff(IHumanoid humanoid)
        {
            humanoid.Speak("Hello");
            humanoid.Walk();
        }

        static void DisplayDetails(IGetDetails detail)
        {
            Console.WriteLine(detail.GetDetails());
        }
    }
}
