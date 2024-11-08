using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    // Class representing the lift moving up state, implementing the ILift interface
    internal class LiftMovesUp : ILift
    {
        // Empty method for closing the door in the LiftMovesUp state; not applicable here
        public void LiftCloseDoor(Lift lift)
        {
        }

        public void LiftMoveDown(Lift lift)
        {
            
        }

        // Method to handle the movement of the lift when going up
        public void LiftMoveUp(Lift lift)
        {
            // Hide the lift base image to simulate movement
            lift.liftBase.Visible = false;

            // Update the display images to show the 'up' movement
            lift.Display.Image = global::ElevatorSystem.Properties.Resources.up;
            lift.Display_up.Image = global::ElevatorSystem.Properties.Resources.up;
            lift.Display_Down.Image = global::ElevatorSystem.Properties.Resources.up;

            // Move the lift up gradually until it reaches the first floor position
            if (lift.liftBase.Top > GlobalVariable.y_up)
            {
                lift.liftBase.Top -= 4; // Adjust speed by changing the decrement value
            }
            else
            {
                // Set the arrival flags to true/false as appropriate
                GlobalVariable.arrived_G = false;
                GlobalVariable.arrived_1 = true;

                // Change the lift's state back to Idle after arriving
                lift.SetState(new Idle());

                // Stop the upward movement timer
                lift.upTimer.Stop();

                // Enable door open button as the lift has arrived at the first floor
                lift.DoorOpen.Enabled = true;

                // Change the display image to show that the lift has reached the first floor
                lift.Display.Image = global::ElevatorSystem.Properties.Resources._1;

                // Enable all other relevant buttons for user interaction
                lift.Display_up.Image = global::ElevatorSystem.Properties.Resources._1;
                lift.Display_Down.Image = global::ElevatorSystem.Properties.Resources._1;
                lift.GoFirstFloor.BackColor = Color.White;

                // Make the lift base visible again
                lift.liftBase.Visible = true;

                // Enable all interaction buttons as needed
                lift.RequestFirstFloor.Enabled = true;
                lift.RequestGroundFloor.Enabled = true;
                lift.GoFirstFloor.Enabled = true;
                lift.GoDownFloor.Enabled = true;
                lift.DoorClose.Enabled = true;
                lift.DoorOpen.Enabled = true;

                // Automatically open the door once the lift has arrived at the first floor
                lift.DoorOpen.PerformClick();
            }
        }

        // Empty method for opening the door in the LiftMovesUp state; not applicable here
        public void LiftOpenDoor(Lift lift)
        {
        }
    }
}
