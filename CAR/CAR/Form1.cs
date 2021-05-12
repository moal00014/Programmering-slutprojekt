using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Bil { Left, Right, None}

        int speed = 5;
        Bil bil = Bil.None; 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerAction_Tick(object sender, EventArgs e)
        {
            Line1.Top += speed;
            Line2.Top += speed;
            Line3.Top += speed;
            Line4.Top += speed;
            Line5.Top += speed;
            Line6.Top += speed;
            Line7.Top += speed;
            Line8.Top += speed;
            Line9.Top += speed;

            if (Line1.Top > panel.Height) Line1.Top = -Line1.Height;
            if (Line2.Top > panel.Height) Line2.Top = -Line2.Height;
            if (Line3.Top > panel.Height) Line3.Top = -Line3.Height;
            if (Line4.Top > panel.Height) Line4.Top = -Line4.Height;
            if (Line5.Top > panel.Height) Line5.Top = -Line5.Height;
            if (Line6.Top > panel.Height) Line6.Top = -Line6.Height;
            if (Line7.Top > panel.Height) Line7.Top = -Line7.Height;
            if (Line8.Top > panel.Height) Line8.Top = -Line8.Height;
            if (Line9.Top > panel.Height) Line9.Top = -Line9.Height;

            if (bil == Bil.Left)
                Spelare.Left -= speed;

            if (bil == Bil.Right)
                Spelare.Left += speed;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
                bil = Bil.Left;
            else if (e.KeyData == Keys.Right)
                bil = Bil.Right;
            else bil = Bil.None; 
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            bil = Bil.None; 
        }
    }
}
