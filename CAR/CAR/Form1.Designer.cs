
namespace CAR
{
    partial class Form1
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
            this.panel = new System.Windows.Forms.Panel();
            this.Game_Over = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.timerAction = new System.Windows.Forms.Timer(this.components);
            this.Spelare = new System.Windows.Forms.PictureBox();
            this.B2 = new System.Windows.Forms.PictureBox();
            this.B1 = new System.Windows.Forms.PictureBox();
            this.Line9 = new System.Windows.Forms.PictureBox();
            this.Line8 = new System.Windows.Forms.PictureBox();
            this.Line7 = new System.Windows.Forms.PictureBox();
            this.Line6 = new System.Windows.Forms.PictureBox();
            this.Line5 = new System.Windows.Forms.PictureBox();
            this.Line4 = new System.Windows.Forms.PictureBox();
            this.Line3 = new System.Windows.Forms.PictureBox();
            this.Line2 = new System.Windows.Forms.PictureBox();
            this.Line1 = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Spelare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Silver;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Controls.Add(this.Game_Over);
            this.panel.Controls.Add(this.Spelare);
            this.panel.Controls.Add(this.B2);
            this.panel.Controls.Add(this.B1);
            this.panel.Controls.Add(this.Line9);
            this.panel.Controls.Add(this.Line8);
            this.panel.Controls.Add(this.Line7);
            this.panel.Controls.Add(this.Line6);
            this.panel.Controls.Add(this.Line5);
            this.panel.Controls.Add(this.Line4);
            this.panel.Controls.Add(this.Line3);
            this.panel.Controls.Add(this.Line2);
            this.panel.Controls.Add(this.Line1);
            this.panel.Location = new System.Drawing.Point(12, 55);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(606, 608);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // Game_Over
            // 
            this.Game_Over.BackColor = System.Drawing.Color.Black;
            this.Game_Over.Font = new System.Drawing.Font("Tahoma", 20F);
            this.Game_Over.ForeColor = System.Drawing.Color.Red;
            this.Game_Over.Image = global::CAR.Properties.Resources.explosion;
            this.Game_Over.Location = new System.Drawing.Point(176, 243);
            this.Game_Over.Name = "Game_Over";
            this.Game_Over.Size = new System.Drawing.Size(251, 68);
            this.Game_Over.TabIndex = 12;
            this.Game_Over.Text = "Game Over\r\n";
            this.Game_Over.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Game_Over.Visible = false;
            this.Game_Over.Click += new System.EventHandler(this.Game_Over_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelSpeed.Location = new System.Drawing.Point(286, 9);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(112, 30);
            this.labelSpeed.TabIndex = 1;
            this.labelSpeed.Text = "Speed: 0";
            this.labelSpeed.Click += new System.EventHandler(this.label1_Click);
            // 
            // timerAction
            // 
            this.timerAction.Enabled = true;
            this.timerAction.Interval = 1;
            this.timerAction.Tick += new System.EventHandler(this.timerAction_Tick);
            // 
            // Spelare
            // 
            this.Spelare.BackColor = System.Drawing.Color.Transparent;
            this.Spelare.Image = global::CAR.Properties.Resources.Bil6;
            this.Spelare.Location = new System.Drawing.Point(277, 493);
            this.Spelare.Name = "Spelare";
            this.Spelare.Size = new System.Drawing.Size(67, 113);
            this.Spelare.TabIndex = 9;
            this.Spelare.TabStop = false;
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Transparent;
            this.B2.Image = global::CAR.Properties.Resources.Bil2;
            this.B2.Location = new System.Drawing.Point(113, 139);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(57, 108);
            this.B2.TabIndex = 11;
            this.B2.TabStop = false;
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.Image = global::CAR.Properties.Resources.Bil3;
            this.B1.Location = new System.Drawing.Point(454, 290);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(55, 107);
            this.B1.TabIndex = 10;
            this.B1.TabStop = false;
            // 
            // Line9
            // 
            this.Line9.BackColor = System.Drawing.Color.Snow;
            this.Line9.Location = new System.Drawing.Point(488, 446);
            this.Line9.Name = "Line9";
            this.Line9.Size = new System.Drawing.Size(11, 132);
            this.Line9.TabIndex = 8;
            this.Line9.TabStop = false;
            // 
            // Line8
            // 
            this.Line8.BackColor = System.Drawing.Color.Snow;
            this.Line8.Location = new System.Drawing.Point(488, 225);
            this.Line8.Name = "Line8";
            this.Line8.Size = new System.Drawing.Size(11, 132);
            this.Line8.TabIndex = 7;
            this.Line8.TabStop = false;
            // 
            // Line7
            // 
            this.Line7.BackColor = System.Drawing.Color.Snow;
            this.Line7.Location = new System.Drawing.Point(488, 27);
            this.Line7.Name = "Line7";
            this.Line7.Size = new System.Drawing.Size(11, 132);
            this.Line7.TabIndex = 6;
            this.Line7.TabStop = false;
            // 
            // Line6
            // 
            this.Line6.BackColor = System.Drawing.Color.Snow;
            this.Line6.Location = new System.Drawing.Point(296, 446);
            this.Line6.Name = "Line6";
            this.Line6.Size = new System.Drawing.Size(11, 132);
            this.Line6.TabIndex = 5;
            this.Line6.TabStop = false;
            // 
            // Line5
            // 
            this.Line5.BackColor = System.Drawing.Color.Snow;
            this.Line5.Location = new System.Drawing.Point(296, 225);
            this.Line5.Name = "Line5";
            this.Line5.Size = new System.Drawing.Size(11, 132);
            this.Line5.TabIndex = 4;
            this.Line5.TabStop = false;
            // 
            // Line4
            // 
            this.Line4.BackColor = System.Drawing.Color.Snow;
            this.Line4.Location = new System.Drawing.Point(296, 27);
            this.Line4.Name = "Line4";
            this.Line4.Size = new System.Drawing.Size(11, 132);
            this.Line4.TabIndex = 3;
            this.Line4.TabStop = false;
            // 
            // Line3
            // 
            this.Line3.BackColor = System.Drawing.Color.Snow;
            this.Line3.Location = new System.Drawing.Point(113, 446);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(11, 132);
            this.Line3.TabIndex = 2;
            this.Line3.TabStop = false;
            // 
            // Line2
            // 
            this.Line2.BackColor = System.Drawing.Color.Snow;
            this.Line2.Location = new System.Drawing.Point(113, 225);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(11, 132);
            this.Line2.TabIndex = 1;
            this.Line2.TabStop = false;
            // 
            // Line1
            // 
            this.Line1.BackColor = System.Drawing.Color.Snow;
            this.Line1.Location = new System.Drawing.Point(113, 27);
            this.Line1.Name = "Line1";
            this.Line1.Size = new System.Drawing.Size(11, 132);
            this.Line1.TabIndex = 0;
            this.Line1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(630, 667);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Spelare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Line1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.PictureBox Line9;
        private System.Windows.Forms.PictureBox Line8;
        private System.Windows.Forms.PictureBox Line7;
        private System.Windows.Forms.PictureBox Line6;
        private System.Windows.Forms.PictureBox Line5;
        private System.Windows.Forms.PictureBox Line4;
        private System.Windows.Forms.PictureBox Line3;
        private System.Windows.Forms.PictureBox Line2;
        private System.Windows.Forms.PictureBox Line1;
        private System.Windows.Forms.Timer timerAction;
        private System.Windows.Forms.PictureBox Spelare;
        private System.Windows.Forms.PictureBox B2;
        private System.Windows.Forms.PictureBox B1;
        private System.Windows.Forms.Label Game_Over;
    }
}

