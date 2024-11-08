using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    internal class DoorOpen1:ILift
    {
        public void LiftCloseDoor(Lift lift)
        {

        }

        public void LiftMoveDown(Lift lift)
        {
        }

        public void LiftMoveUp( Lift     lift)
        {
        }

        public void LiftOpenDoor(Lift lift)
        {
            if (lift.FirstFloorLeftDoor.Left > GlobalVariable.x_door_left_open && lift.FirstFloorRightDoor.Left < GlobalVariable.x_door_right_open)
            {
                lift.FirstFloorLeftDoor.Left -= 7;
                lift.FirstFloorRightDoor.Left += 7;
            }
            else
            {
                lift.openTimer.Stop();
                lift._CurrentState = new Idle();
                lift.RequestFirstFloor.Enabled = false;
                lift.RequestGroundFloor.Enabled = false;
                lift.GoFirstFloor.Enabled = false;
                lift.GoDownFloor.Enabled = false;
            }
        }
    }
}
