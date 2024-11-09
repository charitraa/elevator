// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    // Class representing the door-closing state for the ground floor, implementing the ILift interface
    internal class DoorCloseG : ILift // Inheritance:
    {
        // Method to handle the door-closing action for the ground floor doors
        // Moves the lift doors towards the center until they reach the closed position
        public void LiftCloseDoor(Lift lift)
        {
            // Check if doors have not yet reached the fully closed position
            if (lift.GroundFloorLeftDoor.Left < GlobalVariable.x_door_left_close && lift.GroundFloorRightDoor.Left > GlobalVariable.x_door_right_close)
            {
                // Gradually move the left door to the right and the right door to the left to close the doors
                lift.GroundFloorLeftDoor.Left += 7;
                lift.GroundFloorRightDoor.Left -= 7;
            }
            else
            {
                // Stop the closing timer once doors are fully closed
                lift.closeTimer.Stop();

                // Set the lift state to Idle, meaning no active movement or door operation is ongoing
                lift._CurrentState = new Idle();

                // Re-enable the control buttons so users can make new requests
                lift.RequestFirstFloor.Enabled = true;
                lift.RequestGroundFloor.Enabled = true;
                lift.GoFirstFloor.Enabled = true;
                lift.GoDownFloor.Enabled = true;
            }
        }

        // Empty method for moving the lift down in the DoorCloseG state; not applicable here
        public void LiftMoveDown(Lift lift)
        {
        }

        // Empty method for moving the lift up in the DoorCloseG state; not applicable here
        public void LiftMoveUp(Lift lift)
        {
        }

        // Empty method for opening the door in the DoorCloseG state; not applicable here
        public void LiftOpenDoor(Lift lift)
        {
        }
    }
}
