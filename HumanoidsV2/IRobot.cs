using System;

namespace Humanoids
{
    interface IRobot
    {
        string Designation {get; set;}

        void Recharge();

        void FireLaser();
    }
}