using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    internal class LiftMovesUp:ILift
    {
        public void LiftCloseDoor(Lift lift)
        {
            
        }

        public void LiftMoveDown(Lift lift)
        {
        }

        public void LiftMoveUp(Lift lift)
        {
            lift.liftBase.Visible = false;
            lift.Display.Image = global::ElevatorSystem.Properties.Resources.up;
            lift.Display_up.Image = global::ElevatorSystem.Properties.Resources.up;
            lift.Display_Down.Image = global::ElevatorSystem.Properties.Resources.up;

            if (lift.liftBase.Top > GlobalVariable.y_up)
            {
                lift.liftBase.Top -= 4; // Adjust speed as necessary

            }
            else
            {
                GlobalVariable.arrived_G = false;
                GlobalVariable.arrived_1 = true;
                lift.SetState(new Idle());
                lift.upTimer.Stop();
                lift.DoorOpen.Enabled = true;

                lift.Display.Image = global::ElevatorSystem.Properties.Resources._1;
                lift.Display_up.Image = global::ElevatorSystem.Properties.Resources._1;
                lift.Display_Down.Image = global::ElevatorSystem.Properties.Resources._1;
                lift.GoFirstFloor.BackColor = Color.White;
                lift.liftBase.Visible = true;
                lift.RequestFirstFloor.Enabled = true;
                lift.RequestGroundFloor.Enabled = true;
                lift.GoFirstFloor.Enabled = true;
                lift.GoDownFloor.Enabled = true;
                lift.DoorClose.Enabled = true;
                lift.DoorOpen.Enabled = true;
                lift.DoorOpen.PerformClick();
            }
        }

        public void LiftOpenDoor(Lift lift)
        {
        }
    }
}
