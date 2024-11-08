using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    internal class LiftMovesDown:ILift
    {
        public void LiftCloseDoor(Lift lift)
        {
            
        }

        public void LiftMoveDown(Lift lift)
        {
            lift.liftBase.Visible = false;
            lift.Display.Image = global::ElevatorSystem.Properties.Resources.down;
            lift.Display_Down.Image = global::ElevatorSystem.Properties.Resources.down;
            lift.Display_up.Image = global::ElevatorSystem.Properties.Resources.down;

            if (lift.liftBase.Top < GlobalVariable.y_down)
            {
                lift.liftBase.Top += 4; // Adjust speed as necessary
            }
            else
            {
                GlobalVariable.arrived_G = true;
                GlobalVariable.arrived_1 = false;
                lift.SetState(new Idle());
                lift.downTimer.Stop();
                lift.DoorOpen.Enabled = true;

                lift.Display.Image = global::ElevatorSystem.Properties.Resources.G;
                lift.RequestFirstFloor.Enabled = true;
                lift.RequestGroundFloor.Enabled = true;
                lift.GoFirstFloor.Enabled = true;
                lift.GoDownFloor.Enabled = true;
                lift.DoorClose.Enabled = true;
                lift.DoorOpen.Enabled = true;
                lift.liftBase.Visible = true;
                lift.Display_up.Image = global::ElevatorSystem.Properties.Resources.G;
                lift.Display_Down.Image = global::ElevatorSystem.Properties.Resources.G;
                lift.GoDownFloor.BackColor = Color.White;
                lift.DoorOpen.PerformClick();
            }
        }

        public void LiftMoveUp(Lift lift)
        {
        }

        public void LiftOpenDoor(Lift lift)
        {
        }
    }
}
