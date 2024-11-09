using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    // Abstraction:
    internal interface ILift
    {
        // Method for moving the lift up; to be implemented by various lift states
        void LiftMoveUp(Lift elevator);

        // Method for moving the lift down; to be implemented by various lift states
        void LiftMoveDown(Lift elevator);

        // Method for opening the lift door; to be implemented by various lift states
        void LiftOpenDoor(Lift elevator);

        // Method for closing the lift door; to be implemented by various lift states
        void LiftCloseDoor(Lift elevator);
    }
}
