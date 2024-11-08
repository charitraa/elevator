using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorSystem

{
    public partial class elevator : Form
    {


        private readonly DataSet ds = new DataSet();
        private readonly DataBase db = new DataBase();
        private readonly Lift lit;
        Log log;
        public elevator()
        {
            InitializeComponent();
            db.DisplayLog(log_list_box, ds);
            lit = new Lift(pictureBox4, down_left_door, pictureBox5, down_right_door, lift, lift_up, lift_down, Door_Close, Door_Open, display_action, go_down_btn, go_up_btn, first_floor_btn, ground_floor_btn, open_lift_btn, close_lift_btn, display_down,display_up);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void Send_Message(string message)
        {
            log = new Log(message);
            db.InsertData(log_list_box, log);
        }

        private void ground_floor_picture_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lit.SetState(new LiftMovesUp());
            lift_up.Start();
            go_down_btn.Enabled = false;
            go_up_btn.Enabled = false;
            ground_floor_btn.Enabled = false;
            first_floor_btn.Enabled = false;
            close_lift_btn.Enabled = false;
            open_lift_btn.Enabled = false;
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

        private void ground_floor_btn_Click(object sender, EventArgs e)
        {
            ground_floor_btn.BackColor = Color.Green;
            lit.SetState(new LiftMovesDown());
            lift_down.Start();
            go_down_btn.Enabled = false;
            go_up_btn.Enabled = false;
            ground_floor_btn.Enabled = false;
            first_floor_btn.Enabled = false;
            close_lift_btn.Enabled = false;
            open_lift_btn.Enabled = false;
            Send_Message("Moving Down to Ground Floor");
        }

        private void first_floor_btn_Click(object sender, EventArgs e)
        {
            first_floor_btn.BackColor = Color.Green;
            lit.SetState(new LiftMovesUp());
            lift_up.Start();
            go_down_btn.Enabled = false;
            go_up_btn.Enabled = false;
            ground_floor_btn.Enabled = false;
            first_floor_btn.Enabled = false;
            close_lift_btn.Enabled = false;
            open_lift_btn.Enabled = false;
            Send_Message("Moving Up to First Floor");
        }

        private void display_action_Click(object sender, EventArgs e)
        {

        }

        private void down_left_door_Click(object sender, EventArgs e)
        {

        }

        private void go_up_btn_Click(object sender, EventArgs e)
        {
            lit.SetState(new LiftMovesDown());
            lift_down.Start();
            go_down_btn.Enabled = false;
            go_up_btn.Enabled = false;
            ground_floor_btn.Enabled = false;
            first_floor_btn.Enabled = false;
            close_lift_btn.Enabled = false;
            open_lift_btn.Enabled = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

       

        private void clear_log_btn_Click(object sender, EventArgs e)
        {
            db.DeleteLogs(log_list_box);
        }

        private void close_lift_btn_Click_1(object sender, EventArgs e)
        {
            if (GlobalVariable.arrived_1 == true)
            {
                lit.SetState(new DoorClose1());
                Door_Close.Start();
                go_down_btn.Enabled = false;
                go_up_btn.Enabled = false;
                ground_floor_btn.Enabled = false;
                first_floor_btn.Enabled = false;

                Send_Message("Door Closing at First Floor");

            }
            else if (GlobalVariable.arrived_G == true)
            {
                lit.SetState(new DoorCloseG());
                Door_Close.Start();

                go_down_btn.Enabled = false;
                go_up_btn.Enabled = false;
                ground_floor_btn.Enabled = false;
                first_floor_btn.Enabled = false;

                Send_Message("Door Closing at Ground Floor");

            }
        }

        private void open_lift_btn_Click_1(object sender, EventArgs e)
        {
            if (GlobalVariable.arrived_1 == true)
            {
                lit.SetState(new DoorOpen1());
                Door_Open.Start();
                go_down_btn.Enabled = false;
                go_up_btn.Enabled = false;
                ground_floor_btn.Enabled = false;
                first_floor_btn.Enabled = false;

                Send_Message("Door Opening at First Floor");

            }
            else if (GlobalVariable.arrived_G == true)
            {
                lit.SetState(new DoorOpenG());
                Door_Open.Start();

                go_down_btn.Enabled = false;
                go_up_btn.Enabled = false;
                ground_floor_btn.Enabled = false;
                first_floor_btn.Enabled = false;

                Send_Message("Door Opening at Ground Floor");

            }
        }

        private void Door_Close_Tick(object sender, EventArgs e)
        {
            lit.LiftCloseDoor();
        }

        private void Door_Open_Tick(object sender, EventArgs e)
        {
            lit.LiftOpenDoor();
        }
    }
}
