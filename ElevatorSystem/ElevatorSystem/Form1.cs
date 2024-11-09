using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ElevatorSystem

{
    public partial class elevator : Form //Inherit
    {
        // Declares a read-only DataSet instance to hold data (e.g., logs or other information related to the elevator).
        private readonly DataSet ds = new DataSet();

        // Declares a read-only DataBase instance, which likely contains methods for handling data operations (like logging).
        private readonly DataBase db = new DataBase();

        // Declares a read-only Lift instance, which represents the main lift functionality in the elevator system.
        private readonly Lift lit;

        // Declares a Log instance to hold messages related to the elevator's operations.s
        Log log;
        private BackgroundWorker liftUpWorker;
        public elevator()
        {
            InitializeComponent();
            db.DisplayLog(log_list_box, ds);
            lit = new Lift(pictureBox4, down_left_door, pictureBox5, down_right_door, lift, lift_up, lift_down, Door_Close, Door_Open, display_action, go_down_btn, go_up_btn, first_floor_btn, ground_floor_btn, open_lift_btn, close_lift_btn, display_down,display_up);
            // Initialize BackgroundWorker
            liftUpWorker = new BackgroundWorker();
            liftUpWorker.DoWork += liftUpWorker_DoWork;
            liftUpWorker.RunWorkerCompleted += liftUpWorker_RunWorkerCompleted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // Delegates:
        public void Send_Message(string message)
        {
            // Creates a new Log object with the provided message.
            log = new Log(message);

            // Calls the InsertData method in the DataBase class to add the log entry to the ListBox (log_list_box).
            db.InsertData(log_list_box, log);
        }

        private void ground_floor_picture_Click(object sender, EventArgs e)
        {

        }

        // Event handler for button1 (assumed to initiate movement to the first floor)
        private void button1_Click(object sender, EventArgs e)
        {
            // Sets the lift's state to "LiftMovesUp" to handle the upward movement logic
            lit.SetState(new LiftMovesUp());

            // Starts the timer that controls the lift's upward movement
            lift_up.Start();

            // Disables control buttons to prevent other actions while the lift is moving
            go_down_btn.Enabled = false;
            go_up_btn.Enabled = false;
            ground_floor_btn.Enabled = false;
            first_floor_btn.Enabled = false;
            close_lift_btn.Enabled = false;
            open_lift_btn.Enabled = false;

            // Sends a log message indicating the lift is moving up to the first floor
            Send_Message("Moving Up to First Floor");
        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void down_close_door_Tick(object sender, EventArgs e)
        {
           
        }

        private void close_lift_btn_Click(object sender, EventArgs e)
        {

        }

        private void open_lift_btn_Click(object sender, EventArgs e)
        {
            
        }

        // Event handler for ground floor button click, initiating downward movement to ground floor
        private void ground_floor_btn_Click(object sender, EventArgs e)
        {
            // Sets the ground floor button color to green to indicate it’s active
            ground_floor_btn.BackColor = Color.Green;

            // Changes the lift's state to "LiftMovesDown" to handle downward movement logic
            lit.SetState(new LiftMovesDown());

            // Starts the timer that controls the lift’s downward movement
            lift_down.Start();

            // Disables other controls to prevent additional actions while the lift is moving
            go_down_btn.Enabled = false;
            go_up_btn.Enabled = false;
            ground_floor_btn.Enabled = false;
            first_floor_btn.Enabled = false;
            close_lift_btn.Enabled = false;
            open_lift_btn.Enabled = false;

            // Sends a log message indicating the lift is moving down to the ground floor
            Send_Message("Moving Down to Ground Floor");
        }


        // Event handler for the first floor button click, initiating upward movement to the first floor
        private void first_floor_btn_Click(object sender, EventArgs e)
        {
            // Sets the first floor button color to green to indicate it’s active
            first_floor_btn.BackColor = Color.Green;

            // Sets the lift’s state to "LiftMovesUp" to handle upward movement logic
            //lit.SetState(new LiftMovesUp());

            // Starts the timer controlling the lift’s upward movement
            //lift_up.Start();

            // Disables other buttons to prevent additional actions while the lift is moving
            go_down_btn.Enabled = false;
            go_up_btn.Enabled = false;
            ground_floor_btn.Enabled = false;
            first_floor_btn.Enabled = false;
            close_lift_btn.Enabled = false;
            open_lift_btn.Enabled = false;

            // Logs the action indicating the lift is moving up to the first floor
            Send_Message("Moving Up to First Floor");
            if (!liftUpWorker.IsBusy)
            {
                liftUpWorker.RunWorkerAsync();
            }
        }
        private void liftUpWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Set the lift state to moving up
            lit.SetState(new LiftMovesUp());

            // Move the lift up (you can add a delay or repetitive action here if needed)
            while (!GlobalVariable.arrived_1) // Assume GlobalVariable.arrived_1 becomes true when reaching the first floor
            {
                lit.LiftMoveUp(); // Calls method to move lift up
                System.Threading.Thread.Sleep(100); // Adjust delay as needed for smooth movement
            }
        }

        private void liftUpWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Re-enable controls
            go_down_btn.Enabled = true;
            go_up_btn.Enabled = true;
            ground_floor_btn.Enabled = true;
            first_floor_btn.Enabled = true;
            close_lift_btn.Enabled = true;
            open_lift_btn.Enabled = true;

            // Log arrival message
            Send_Message("Lift has arrived at the First Floor");
        }

        private void display_action_Click(object sender, EventArgs e)
        {

        }

        private void down_left_door_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the "Go Up" button, which in this case actually initiates downward movement to the ground floor
        private void go_up_btn_Click(object sender, EventArgs e)
        {
            // Sets the lift’s state to "LiftMovesDown" to handle downward movement logic
            lit.SetState(new LiftMovesDown());

            // Starts the timer controlling the lift’s downward movement
            lift_down.Start();

            // Disables other buttons to prevent conflicting actions while the lift is moving
            go_down_btn.Enabled = false;
            go_up_btn.Enabled = false;
            ground_floor_btn.Enabled = false;
            first_floor_btn.Enabled = false;
            close_lift_btn.Enabled = false;
            open_lift_btn.Enabled = false;

            // Logs the action indicating the lift is moving down to the ground floor
            Send_Message("Moving Down to Ground Floor");
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lit.LiftMoveDown();
        }

        private void lift_up_Tick(object sender, EventArgs e)
        {
            lit.LiftMoveUp();
        }

        private void down_open_door_Tick(object sender, EventArgs e)
        {
            
        }

        private void up_open_door_Tick(object sender, EventArgs e)
        {
            
        }

        private void up_close_door_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void display_down_Click(object sender, EventArgs e)
        {

        }

        // Event handler for the "Exit" button click
        private void button2_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box asking the user if they are sure they want to exit
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks "Yes" (DialogResult.Yes), the application will exit
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Close the application
            }
        }




        private void clear_log_btn_Click(object sender, EventArgs e)
        {
            db.DeleteLogs(log_list_box);
        }

        // Event handler for the "Close Lift" button click
        private void close_lift_btn_Click_1(object sender, EventArgs e)
        {
            // Check if the lift has arrived at the first floor (GlobalVariable.arrived_1 is true)
            if (GlobalVariable.arrived_1 == true)
            {
                // Set the lift's state to DoorClose1 (closing the door at first floor)
                lit.SetState(new DoorClose1());
                Door_Close.Start(); // Start the door closing animation or action

                // Disable navigation buttons while the door is closing
                go_down_btn.Enabled = false;
                go_up_btn.Enabled = false;
                ground_floor_btn.Enabled = false;
                first_floor_btn.Enabled = false;

                // Log the action of closing the door at the first floor
                Send_Message("Door Closing at First Floor");
            }
            // Check if the lift has arrived at the ground floor (GlobalVariable.arrived_G is true)
            else if (GlobalVariable.arrived_G == true)
            {
                // Set the lift's state to DoorCloseG (closing the door at ground floor)
                lit.SetState(new DoorCloseG());
                Door_Close.Start(); // Start the door closing animation or action

                // Disable navigation buttons while the door is closing
                go_down_btn.Enabled = false;
                go_up_btn.Enabled = false;
                ground_floor_btn.Enabled = false;
                first_floor_btn.Enabled = false;

                // Log the action of closing the door at the ground floor
                Send_Message("Door Closing at Ground Floor");
            }
        }


        // Event handler for the "Open Lift" button click
        private void open_lift_btn_Click_1(object sender, EventArgs e)
        {
            // Check if the lift has arrived at the first floor (GlobalVariable.arrived_1 is true)
            if (GlobalVariable.arrived_1 == true)
            {
                // Set the lift's state to DoorOpen1 (opening the door at the first floor)
                lit.SetState(new DoorOpen1());
                Door_Open.Start(); // Start the door opening animation or action

                // Disable navigation buttons while the door is opening
                go_down_btn.Enabled = false;
                go_up_btn.Enabled = false;
                ground_floor_btn.Enabled = false;
                first_floor_btn.Enabled = false;

                // Log the action of opening the door at the first floor
                Send_Message("Door Opening at First Floor");
            }
            // Check if the lift has arrived at the ground floor (GlobalVariable.arrived_G is true)
            else if (GlobalVariable.arrived_G == true)
            {
                // Set the lift's state to DoorOpenG (opening the door at the ground floor)
                lit.SetState(new DoorOpenG());
                Door_Open.Start(); // Start the door opening animation or action

                // Disable navigation buttons while the door is opening
                go_down_btn.Enabled = false;
                go_up_btn.Enabled = false;
                ground_floor_btn.Enabled = false;
                first_floor_btn.Enabled = false;

                // Log the action of opening the door at the ground floor
                Send_Message("Door Opening at Ground Floor");
            }
        }


        private void Door_Close_Tick(object sender, EventArgs e)
        {
            //call the LiftClose Door Method
            lit.LiftCloseDoor();
        }

        private void Door_Open_Tick(object sender, EventArgs e)
        {
            //call the Lift Open Door Method
            lit.LiftOpenDoor();
        }
    }
}
