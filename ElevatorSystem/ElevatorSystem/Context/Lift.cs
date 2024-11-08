using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem
{
    internal class Lift { 
    public PictureBox FirstFloorLeftDoor, GroundFloorLeftDoor, FirstFloorRightDoor, GroundFloorRightDoor, liftBase, GoFirstFloor, GoDownFloor, Display,Display_up, Display_Down;
    public Timer upTimer, downTimer, closeTimer, openTimer;
    public Button RequestFirstFloor, RequestGroundFloor, DoorOpen, DoorClose;
    public ILift _CurrentState;
    public Lift(PictureBox FirstFloorLeftDoor, PictureBox leftG, PictureBox right1, PictureBox rightg, PictureBox liftBase, Timer upTimer, Timer downTimer, Timer closeTimer, Timer openTimer, PictureBox show, Button req1, Button reqG, PictureBox up, PictureBox down, Button open, Button close, PictureBox Display_Down, PictureBox Display_Up)
    {
        this.FirstFloorLeftDoor = FirstFloorLeftDoor;
        this.GroundFloorLeftDoor = leftG;
        this.FirstFloorRightDoor = right1;
        this.GroundFloorRightDoor = rightg;
        this.liftBase = liftBase;
        this.upTimer = upTimer;
        this.downTimer = downTimer;
        this.closeTimer = closeTimer;
        this.openTimer = openTimer;
        this.Display = show;
        this.RequestFirstFloor = req1;
        this.RequestGroundFloor = reqG;
        this.GoFirstFloor = up;
        this.GoDownFloor = down;
        this.DoorOpen = open;
        this.DoorClose = close;
        this.Display_Down = Display_Down;
        this.Display_up = Display_Up;
        _CurrentState = new Idle();

    }
    public void SetState(ILift state)
    {
        _CurrentState = state;
    }

    public void LiftMoveUp()
    {
        _CurrentState.LiftMoveUp(this);
    }

    public void LiftMoveDown()
    {
        _CurrentState.LiftMoveDown(this);
    }
    public void LiftOpenDoor()
    {
        _CurrentState.LiftOpenDoor(this);
    }

    public void LiftCloseDoor()
    {
        _CurrentState.LiftCloseDoor(this);
    }
}
}
