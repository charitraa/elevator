using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    // Class representing the lift moving down state, implementing the ILift interface
    internal class LiftMovesDown : ILift // Inheritance:
    {
        // Empty method for closing the door in the LiftMovesDown state; not applicable here
        public void LiftCloseDoor(Lift lift)
        {
        }

        // Method to handle the movement of the lift when going down
        public void LiftMoveDown(Lift lift)
        {

            // Update the display images to show the 'down' movement
            lift.Display.Image = global::ElevatorSystem.Properties.Resources.down;
            lift.Display_Down.Image = global::ElevatorSystem.Properties.Resources.down;
            lift.Display_up.Image = global::ElevatorSystem.Properties.Resources.down;

            // Move the lift down gradually until it reaches the ground floor position
            if (lift.liftBase.Top < GlobalVariable.y_down)
            {
                lift.liftBase.Top += 4; // Adjust speed by changing the increment value
            }
            else
            {
                // Set the arrival flags to true/false as appropriate
                GlobalVariable.arrived_G = true;
                GlobalVariable.arrived_1 = false;

                // Change the lift's state back to Idle after arriving
                lift.SetState(new Idle());

                // Stop the downward movement timer
                lift.downTimer.Stop();

                // Enable door open button as the lift has arrived at the ground floor
                lift.DoorOpen.Enabled = true;

                // Change the display image to show that the lift has reached the ground floor
                lift.Display.Image = global::ElevatorSystem.Properties.Resources.G;

                // Enable all other relevant buttons for user interaction
                lift.RequestFirstFloor.Enabled = true;
                lift.RequestGroundFloor.Enabled = true;
                lift.GoFirstFloor.Enabled = true;
                lift.GoDownFloor.Enabled = true;
                lift.DoorClose.Enabled = true;
                lift.DoorOpen.Enabled = true;

                // Update the display images to show the ground floor (G)
                lift.Display_up.Image = global::ElevatorSystem.Properties.Resources.G;
                lift.Display_Down.Image = global::ElevatorSystem.Properties.Resources.G;

                // Change the color of the "Go Down" button to indicate it's active
                lift.GoDownFloor.BackColor = Color.White;

                // Perform the door open action automatically after reaching the ground floor
                lift.DoorOpen.PerformClick();
            }
        }

        // Empty method for moving the lift up in the LiftMovesDown state; not applicable here
        public void LiftMoveUp(Lift lift)
        {
        }

        // Empty method for opening the door in the LiftMovesDown state; not applicable here
        public void LiftOpenDoor(Lift lift)
        {
        }
    }
}
