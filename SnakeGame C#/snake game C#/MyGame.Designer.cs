/*
 * Created by SharpDevelop.
 * User: garnett
 * Date: 20.11.2010
 * Time: 12:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Snake
{
	partial class MyGame
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.MyGame_timer = new System.Windows.Forms.Timer(this.components);
			this.wait_timer = new System.Windows.Forms.Timer(this.components);
			this.joystick_timer = new System.Windows.Forms.Timer(this.components);
			this.top_menu_panel = new System.Windows.Forms.Panel();
			this.lb_point = new System.Windows.Forms.Label();
			this.lb_level = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.top_menu_panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(3000, 3000);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// MyGame_timer
			// 
			this.MyGame_timer.Interval = 100;
			this.MyGame_timer.Tick += new System.EventHandler(this.MyGame_TimerTick);
			// 
			// wait_timer
			// 
			this.wait_timer.Interval = 1;
			this.wait_timer.Tick += new System.EventHandler(this.Wait_timerTick);
			// 
			// joystick_timer
			// 
			this.joystick_timer.Enabled = true;
			this.joystick_timer.Interval = 1;
			this.joystick_timer.Tick += new System.EventHandler(this.Joystick_timerTick);
			// 
			// top_menu_panel
			// 
			this.top_menu_panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.top_menu_panel.Controls.Add(this.lb_point);
			this.top_menu_panel.Controls.Add(this.lb_level);
			this.top_menu_panel.Location = new System.Drawing.Point(12, 2);
			this.top_menu_panel.Name = "top_menu_panel";
			this.top_menu_panel.Size = new System.Drawing.Size(760, 25);
			this.top_menu_panel.TabIndex = 1;
			// 
			// lb_point
			// 
			this.lb_point.Dock = System.Windows.Forms.DockStyle.Right;
			this.lb_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_point.ForeColor = System.Drawing.Color.Blue;
			this.lb_point.Location = new System.Drawing.Point(660, 0);
			this.lb_point.Name = "lb_point";
			this.lb_point.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lb_point.Size = new System.Drawing.Size(100, 25);
			this.lb_point.TabIndex = 1;
			// 
			// lb_level
			// 
			this.lb_level.Dock = System.Windows.Forms.DockStyle.Left;
			this.lb_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_level.ForeColor = System.Drawing.Color.Blue;
			this.lb_level.Location = new System.Drawing.Point(0, 0);
			this.lb_level.Name = "lb_level";
			this.lb_level.Size = new System.Drawing.Size(100, 25);
			this.lb_level.TabIndex = 0;
			this.lb_level.Text = "MENU";
			// 
			// MyGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(784, 778);
			this.Controls.Add(this.top_menu_panel);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "MyGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Snake";
			this.Load += new System.EventHandler(this.MyGame_Form_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MyGameKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.top_menu_panel.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel top_menu_panel;
		private System.Windows.Forms.Label lb_point;
		private System.Windows.Forms.Label lb_level;
		private System.Windows.Forms.Timer MyGame_timer;
		private System.Windows.Forms.Timer joystick_timer;
		private System.Windows.Forms.Timer wait_timer;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
