// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    // Idle state class implementing the ILift interface
    // Inheritance:
    internal class Idle : ILift // Inheritance:
    {
        // Method to handle closing the door while in Idle state
        // Currently empty, as no specific action occurs in this state
        public void LiftCloseDoor(Lift lift)
        {
        }

        // Method to handle moving the lift down while in Idle state
        // Currently empty, as no specific action occurs in this state
        public void LiftMoveDown(Lift lift)
        {
        }

        // Method to handle moving the lift up while in Idle state
        // Currently empty, as no specific action occurs in this state
        public void LiftMoveUp(Lift lift)
        {
        }

        // Method to handle opening the door while in Idle state
        // Currently empty, as no specific action occurs in this state
        public void LiftOpenDoor(Lift lift)
        {
        }
    }
}
