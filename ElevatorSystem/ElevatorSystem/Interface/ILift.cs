using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    internal interface ILift
 
    {
        void LiftMoveUp(Lift elevator);
        void LiftMoveDown(Lift elevator);

        void LiftOpenDoor(Lift elevator);
        void LiftCloseDoor(Lift elevator);
    }
}
