using System;

namespace Humanoids
{
    class Cyborg : Human, IRobot, IGetDetails
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


        public override string GetDetails()
        {
            string details = $" \nDesignation: {Designation}";
            return base.GetDetails() + details;
        }
        
    }
}