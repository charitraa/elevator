// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    // Class representing the door-opening state for the first floor, implementing the ILift interface
    internal class DoorOpen1 : ILift // Inheritance:
    {
        // Empty method for closing the door in the DoorOpen1 state; not applicable here
        public void LiftCloseDoor(Lift lift)
        {
        }

        // Empty method for moving the lift down in the DoorOpen1 state; not applicable here
        public void LiftMoveDown(Lift lift)
        {
        }

        // Empty method for moving the lift up in the DoorOpen1 state; not applicable here
        public void LiftMoveUp(Lift lift)
        {
        }

        // Method to handle the door-opening action for the first floor doors
        public void LiftOpenDoor(Lift lift)
        {
            // Check if the doors have not yet reached the fully open position
            if (lift.FirstFloorLeftDoor.Left > GlobalVariable.x_door_left_open && lift.FirstFloorRightDoor.Left < GlobalVariable.x_door_right_open)
            {
                // Gradually open the doors by moving the left door to the left and the right door to the right
                lift.FirstFloorLeftDoor.Left -= 7;
                lift.FirstFloorRightDoor.Left += 7;
            }
            else
            {
                // Stop the opening timer once the doors are fully open
                lift.openTimer.Stop();

                // Set the lift state to Idle, indicating no ongoing action
                lift._CurrentState = new Idle();

                // Disable control buttons to prevent further requests while the doors are open
                lift.RequestFirstFloor.Enabled = false;
                lift.RequestGroundFloor.Enabled = false;
                lift.GoFirstFloor.Enabled = false;
                lift.GoDownFloor.Enabled = false;
            }
        }
    }
}
