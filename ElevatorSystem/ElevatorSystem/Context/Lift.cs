// Import required namespaces
using System.Windows.Forms; // Provides classes for creating Windows Forms applications

namespace ElevatorSystem
{
    
    // Encapsulation
    internal class Lift
    {
        // PictureBox components representing the doors and lift display elements
        public PictureBox FirstFloorLeftDoor, GroundFloorLeftDoor, FirstFloorRightDoor, GroundFloorRightDoor, liftBase, GoFirstFloor, GoDownFloor, Display, Display_up, Display_Down;

        // Timers to manage the timing of lift actions, such as moving up or down and opening or closing doors
        public Timer upTimer, downTimer, closeTimer, openTimer;

        // Buttons for requesting the lift to specific floors and controlling door operations
        public Button RequestFirstFloor, RequestGroundFloor, DoorOpen, DoorClose;

        // Field for the current state of the lift, following the state design pattern
        public ILift _CurrentState;

        // Constructor to initialize all the lift's components and set its initial state
        public Lift(PictureBox FirstFloorLeftDoor, PictureBox leftG, PictureBox right1, PictureBox rightg, PictureBox liftBase, Timer upTimer, Timer downTimer, Timer closeTimer, Timer openTimer, PictureBox show, Button req1, Button reqG, PictureBox up, PictureBox down, Button open, Button close, PictureBox Display_Down, PictureBox Display_Up)
        {
            // Assign each provided component to the corresponding field in the Lift class
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

            // Initialize the lift's state to Idle
            _CurrentState = new Idle();
        }

        // Method to set a new state for the lift
        public void SetState(ILift state) // Polymorphism:
        {
            _CurrentState = state;
        }

        // Method to command the lift to move up, triggering the appropriate state behavior
        public void LiftMoveUp()
        {
            _CurrentState.LiftMoveUp(this);
        }

        // Method to command the lift to move down, triggering the appropriate state behavior
        public void LiftMoveDown()
        {
            _CurrentState.LiftMoveDown(this);
        }

        // Method to command the lift to open its doors, triggering the appropriate state behavior
        public void LiftOpenDoor()
        {
            _CurrentState.LiftOpenDoor(this);
        }

        // Method to command the lift to close its doors, triggering the appropriate state behavior
        public void LiftCloseDoor()
        {
            _CurrentState.LiftCloseDoor(this);
        }
    }
}
