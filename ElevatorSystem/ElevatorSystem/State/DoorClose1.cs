using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    internal class DoorClose1:ILift
    {
        public void LiftCloseDoor(Lift lift)
        {
            if (lift.FirstFloorLeftDoor.Left < GlobalVariable.x_door_left_close && lift.FirstFloorRightDoor.Left > GlobalVariable.x_door_right_close)
        {
                lift.FirstFloorLeftDoor.Left += 7;
                lift.FirstFloorRightDoor.Left -= 7;
            }
            else
            {
                lift.closeTimer.Stop();
                lift._CurrentState = new Idle();
                lift.RequestFirstFloor.Enabled = true;
                lift.RequestGroundFloor.Enabled = true;
                lift.GoFirstFloor.Enabled = true;
                lift.GoDownFloor.Enabled = true;
            }
        }

        public void LiftMoveDown(Lift lift)
        {
        }

        public void LiftMoveUp(Lift lift)
        {
        }

        public void LiftOpenDoor(Lift lift)
        {
        }
    }
}
