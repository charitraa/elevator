namespace ElevatorSystem
{
    partial class elevator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lift_down = new System.Windows.Forms.Timer(this.components);
            this.lift_up = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.down_right_door = new System.Windows.Forms.PictureBox();
            this.down_left_door = new System.Windows.Forms.PictureBox();
            this.lift = new System.Windows.Forms.PictureBox();
            this.display_down = new System.Windows.Forms.PictureBox();
            this.display_up = new System.Windows.Forms.PictureBox();
            this.ground_floor_btn = new System.Windows.Forms.PictureBox();
            this.first_floor_btn = new System.Windows.Forms.PictureBox();
            this.display_action = new System.Windows.Forms.PictureBox();
            this.bg_btn_plane = new System.Windows.Forms.PictureBox();
            this.go_up_btn = new System.Windows.Forms.Button();
            this.go_down_btn = new System.Windows.Forms.Button();
            this.first_floor_picture = new System.Windows.Forms.PictureBox();
            this.ground_floor_picture = new System.Windows.Forms.PictureBox();
            this.clear_log_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.log_list_box = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Door_Close = new System.Windows.Forms.Timer(this.components);
            this.Door_Open = new System.Windows.Forms.Timer(this.components);
            this.close_lift_btn = new System.Windows.Forms.Button();
            this.open_lift_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_right_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_left_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_floor_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_floor_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_action)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_btn_plane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_floor_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_floor_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lift_down
            // 
            this.lift_down.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lift_up
            // 
            this.lift_up.Tick += new System.EventHandler(this.lift_up_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ElevatorSystem.Properties.Resources._1c2cb2c1a7f458aeca9b206bfe4ea55fh1;
            this.pictureBox5.Location = new System.Drawing.Point(231, 121);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(68, 194);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ElevatorSystem.Properties.Resources._1c2cb2c1a7f458aeca9b206bfe4ea55fh1;
            this.pictureBox4.Location = new System.Drawing.Point(159, 121);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 194);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // down_right_door
            // 
            this.down_right_door.Image = global::ElevatorSystem.Properties.Resources._1c2cb2c1a7f458aeca9b206bfe4ea55fh1;
            this.down_right_door.Location = new System.Drawing.Point(231, 572);
            this.down_right_door.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.down_right_door.Name = "down_right_door";
            this.down_right_door.Size = new System.Drawing.Size(67, 191);
            this.down_right_door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.down_right_door.TabIndex = 15;
            this.down_right_door.TabStop = false;
            // 
            // down_left_door
            // 
            this.down_left_door.Image = global::ElevatorSystem.Properties.Resources._1c2cb2c1a7f458aeca9b206bfe4ea55fh1;
            this.down_left_door.Location = new System.Drawing.Point(159, 572);
            this.down_left_door.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.down_left_door.Name = "down_left_door";
            this.down_left_door.Size = new System.Drawing.Size(72, 191);
            this.down_left_door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.down_left_door.TabIndex = 14;
            this.down_left_door.TabStop = false;
            this.down_left_door.Click += new System.EventHandler(this.down_left_door_Click);
            // 
            // lift
            // 
            this.lift.Image = global::ElevatorSystem.Properties.Resources.lift_transparent;
            this.lift.Location = new System.Drawing.Point(159, 572);
            this.lift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(139, 191);
            this.lift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lift.TabIndex = 13;
            this.lift.TabStop = false;
            // 
            // display_down
            // 
            this.display_down.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display_down.Image = global::ElevatorSystem.Properties.Resources.G;
            this.display_down.Location = new System.Drawing.Point(199, 510);
            this.display_down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.display_down.Name = "display_down";
            this.display_down.Size = new System.Drawing.Size(63, 38);
            this.display_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_down.TabIndex = 12;
            this.display_down.TabStop = false;
            this.display_down.Click += new System.EventHandler(this.display_down_Click);
            // 
            // display_up
            // 
            this.display_up.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display_up.Image = global::ElevatorSystem.Properties.Resources.G;
            this.display_up.Location = new System.Drawing.Point(199, 62);
            this.display_up.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.display_up.Name = "display_up";
            this.display_up.Size = new System.Drawing.Size(63, 32);
            this.display_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_up.TabIndex = 11;
            this.display_up.TabStop = false;
            // 
            // ground_floor_btn
            // 
            this.ground_floor_btn.Image = global::ElevatorSystem.Properties.Resources.Groundfloorbutton1;
            this.ground_floor_btn.Location = new System.Drawing.Point(555, 422);
            this.ground_floor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ground_floor_btn.Name = "ground_floor_btn";
            this.ground_floor_btn.Size = new System.Drawing.Size(84, 69);
            this.ground_floor_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground_floor_btn.TabIndex = 7;
            this.ground_floor_btn.TabStop = false;
            this.ground_floor_btn.Click += new System.EventHandler(this.ground_floor_btn_Click);
            // 
            // first_floor_btn
            // 
            this.first_floor_btn.Image = global::ElevatorSystem.Properties.Resources.firstfloorbutton1;
            this.first_floor_btn.Location = new System.Drawing.Point(555, 321);
            this.first_floor_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.first_floor_btn.Name = "first_floor_btn";
            this.first_floor_btn.Size = new System.Drawing.Size(84, 65);
            this.first_floor_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.first_floor_btn.TabIndex = 6;
            this.first_floor_btn.TabStop = false;
            this.first_floor_btn.Click += new System.EventHandler(this.first_floor_btn_Click);
            // 
            // display_action
            // 
            this.display_action.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.display_action.Image = global::ElevatorSystem.Properties.Resources.G;
            this.display_action.Location = new System.Drawing.Point(531, 158);
            this.display_action.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.display_action.Name = "display_action";
            this.display_action.Size = new System.Drawing.Size(117, 110);
            this.display_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_action.TabIndex = 5;
            this.display_action.TabStop = false;
            this.display_action.Click += new System.EventHandler(this.display_action_Click);
            // 
            // bg_btn_plane
            // 
            this.bg_btn_plane.Enabled = false;
            this.bg_btn_plane.Image = global::ElevatorSystem.Properties.Resources._1c2cb2c1a7f458aeca9b206bfe4ea55fh;
            this.bg_btn_plane.Location = new System.Drawing.Point(505, 129);
            this.bg_btn_plane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bg_btn_plane.Name = "bg_btn_plane";
            this.bg_btn_plane.Size = new System.Drawing.Size(171, 603);
            this.bg_btn_plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_btn_plane.TabIndex = 4;
            this.bg_btn_plane.TabStop = false;
            this.bg_btn_plane.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // go_up_btn
            // 
            this.go_up_btn.BackgroundImage = global::ElevatorSystem.Properties.Resources.direction_north11;
            this.go_up_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.go_up_btn.Location = new System.Drawing.Point(327, 668);
            this.go_up_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_up_btn.Name = "go_up_btn";
            this.go_up_btn.Size = new System.Drawing.Size(36, 30);
            this.go_up_btn.TabIndex = 3;
            this.go_up_btn.UseVisualStyleBackColor = true;
            this.go_up_btn.Click += new System.EventHandler(this.go_up_btn_Click);
            // 
            // go_down_btn
            // 
            this.go_down_btn.BackgroundImage = global::ElevatorSystem.Properties.Resources.direction_south;
            this.go_down_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.go_down_btn.Location = new System.Drawing.Point(327, 217);
            this.go_down_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.go_down_btn.Name = "go_down_btn";
            this.go_down_btn.Size = new System.Drawing.Size(36, 32);
            this.go_down_btn.TabIndex = 2;
            this.go_down_btn.UseVisualStyleBackColor = true;
            this.go_down_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // first_floor_picture
            // 
            this.first_floor_picture.Image = global::ElevatorSystem.Properties.Resources._1c2cb2c1a7f458aeca9b206bfe4ea55f;
            this.first_floor_picture.Location = new System.Drawing.Point(23, 0);
            this.first_floor_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.first_floor_picture.Name = "first_floor_picture";
            this.first_floor_picture.Size = new System.Drawing.Size(413, 414);
            this.first_floor_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.first_floor_picture.TabIndex = 1;
            this.first_floor_picture.TabStop = false;
            this.first_floor_picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ground_floor_picture
            // 
            this.ground_floor_picture.Image = global::ElevatorSystem.Properties.Resources._1c2cb2c1a7f458aeca9b206bfe4ea55f;
            this.ground_floor_picture.Location = new System.Drawing.Point(23, 449);
            this.ground_floor_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ground_floor_picture.Name = "ground_floor_picture";
            this.ground_floor_picture.Size = new System.Drawing.Size(413, 414);
            this.ground_floor_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ground_floor_picture.TabIndex = 0;
            this.ground_floor_picture.TabStop = false;
            this.ground_floor_picture.Click += new System.EventHandler(this.ground_floor_picture_Click);
            // 
            // clear_log_btn
            // 
            this.clear_log_btn.Location = new System.Drawing.Point(893, 37);
            this.clear_log_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clear_log_btn.Name = "clear_log_btn";
            this.clear_log_btn.Size = new System.Drawing.Size(112, 34);
            this.clear_log_btn.TabIndex = 18;
            this.clear_log_btn.Text = "clear_log";
            this.clear_log_btn.UseVisualStyleBackColor = true;
            this.clear_log_btn.Click += new System.EventHandler(this.clear_log_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(1124, 39);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(112, 31);
            this.exit_btn.TabIndex = 19;
            this.exit_btn.Text = "exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // log_list_box
            // 
            this.log_list_box.FormattingEnabled = true;
            this.log_list_box.ItemHeight = 16;
            this.log_list_box.Location = new System.Drawing.Point(744, 121);
            this.log_list_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.log_list_box.Name = "log_list_box";
            this.log_list_box.Size = new System.Drawing.Size(651, 692);
            this.log_list_box.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(765, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(939, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1157, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Actions";
            // 
            // Door_Close
            // 
            this.Door_Close.Tick += new System.EventHandler(this.Door_Close_Tick);
            // 
            // Door_Open
            // 
            this.Door_Open.Tick += new System.EventHandler(this.Door_Open_Tick);
            // 
            // close_lift_btn
            // 
            this.close_lift_btn.BackgroundImage = global::ElevatorSystem.Properties.Resources.closedoorsbutton;
            this.close_lift_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close_lift_btn.Location = new System.Drawing.Point(555, 526);
            this.close_lift_btn.Name = "close_lift_btn";
            this.close_lift_btn.Size = new System.Drawing.Size(84, 66);
            this.close_lift_btn.TabIndex = 23;
            this.close_lift_btn.UseVisualStyleBackColor = true;
            this.close_lift_btn.Click += new System.EventHandler(this.close_lift_btn_Click_1);
            // 
            // open_lift_btn
            // 
            this.open_lift_btn.BackgroundImage = global::ElevatorSystem.Properties.Resources.opendoorbutton;
            this.open_lift_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open_lift_btn.Location = new System.Drawing.Point(555, 631);
            this.open_lift_btn.Name = "open_lift_btn";
            this.open_lift_btn.Size = new System.Drawing.Size(84, 67);
            this.open_lift_btn.TabIndex = 24;
            this.open_lift_btn.UseVisualStyleBackColor = true;
            this.open_lift_btn.Click += new System.EventHandler(this.open_lift_btn_Click_1);
            // 
            // elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 875);
            this.Controls.Add(this.open_lift_btn);
            this.Controls.Add(this.close_lift_btn);
            this.Controls.Add(this.go_down_btn);
            this.Controls.Add(this.go_up_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log_list_box);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.clear_log_btn);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.down_right_door);
            this.Controls.Add(this.down_left_door);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.display_down);
            this.Controls.Add(this.display_up);
            this.Controls.Add(this.ground_floor_btn);
            this.Controls.Add(this.first_floor_btn);
            this.Controls.Add(this.display_action);
            this.Controls.Add(this.bg_btn_plane);
            this.Controls.Add(this.first_floor_picture);
            this.Controls.Add(this.ground_floor_picture);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "elevator";
            this.Text = "elevator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_right_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_left_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_floor_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_floor_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_action)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_btn_plane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first_floor_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground_floor_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground_floor_picture;
        private System.Windows.Forms.PictureBox first_floor_picture;
        private System.Windows.Forms.Button go_down_btn;
        private System.Windows.Forms.Button go_up_btn;
        private System.Windows.Forms.PictureBox bg_btn_plane;
        private System.Windows.Forms.PictureBox display_action;
        private System.Windows.Forms.PictureBox first_floor_btn;
        private System.Windows.Forms.PictureBox ground_floor_btn;
        private System.Windows.Forms.PictureBox display_up;
        private System.Windows.Forms.PictureBox display_down;
        private System.Windows.Forms.PictureBox lift;
        private System.Windows.Forms.PictureBox down_left_door;
        private System.Windows.Forms.PictureBox down_right_door;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer lift_down;
        private System.Windows.Forms.Timer lift_up;
        private System.Windows.Forms.Button clear_log_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ListBox log_list_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Door_Close;
        private System.Windows.Forms.Timer Door_Open;
        private System.Windows.Forms.Button close_lift_btn;
        private System.Windows.Forms.Button open_lift_btn;
    }
}

