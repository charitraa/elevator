// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    // Class representing the door-closing state for the lift, implementing the ILift interface
    // Inheritance:
    internal class DoorClose1 : ILift // Inheritance:
    {
        // Method to handle the door-closing action
        // Moves the lift doors towards the center until they reach the closed position
        public void LiftCloseDoor(Lift lift)
        {
            // Check if doors have not yet reached the fully closed position
            if (lift.FirstFloorLeftDoor.Left < GlobalVariable.x_door_left_close && lift.FirstFloorRightDoor.Left > GlobalVariable.x_door_right_close)
            {
                // Move the left door to the right and the right door to the left to close the doors
                lift.FirstFloorLeftDoor.Left += 7;
                lift.FirstFloorRightDoor.Left -= 7;
            }
            else
            {
                // Stop the closing timer as doors are fully closed
                lift.closeTimer.Stop();

                // Set the lift state to Idle, indicating no active movement or door operation
                lift._CurrentState = new Idle();

                // Re-enable control buttons so users can request the lift again
                lift.RequestFirstFloor.Enabled = true;
                lift.RequestGroundFloor.Enabled = true;
                lift.GoFirstFloor.Enabled = true;
                lift.GoDownFloor.Enabled = true;
            }
        }

        // Empty method for moving the lift down in the DoorClose1 state; not applicable here
        public void LiftMoveDown(Lift lift)
        {
        }

        // Empty method for moving the lift up in the DoorClose1 state; not applicable here
        public void LiftMoveUp(Lift lift)
        {
        }

        // Empty method for opening the door in the DoorClose1 state; not applicable here
        public void LiftOpenDoor(Lift lift)
        {
        }
    }
}
