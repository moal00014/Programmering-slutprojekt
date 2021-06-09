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

        int speed = 6;
        int score = 0; 
        Random l = new Random();
        //den här är direction (riktning) till enum som gör att spelaren står stilla eftersom den rör inte sig höger eller vänster  
        Bil bil = Bil.None; 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
        //är visar linjer och att ska försvinnas och sedan synas på skärmen så att det känns att de går rör sig 
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
            //när bil nr 2 kommer till toppen 
            if (B2.Visible)
                B2.Top += speed;
            if(B2.Top> panel.Height)
            {
                //här ska bil nr 2 försvinnas 
                B2.Visible = false;
                B2.Top = -B2.Height;
                B2.Left = l.Next((panel.Width - B2.Width) / 2);
                int bil = l.Next(1, 9);
                if (bil == 1) B2.Image = Properties.Resources.Bil1;
               //här förklaras om bil nr 2 upptäcks så den ska synas på skärmen, och samma sak med andra bilar, detta är på vänstar sidan av spelet 
                else if (bil == 2) B2.Image = Properties.Resources.Bil2;
                else if (bil == 3) B2.Image = Properties.Resources.Bil3;
                else if (bil == 4) B2.Image = Properties.Resources.Bil4;
                else if (bil == 5) B2.Image = Properties.Resources.Bil5;
                else if (bil == 6) B2.Image = Properties.Resources.Bil6;
                else if (bil == 7) B2.Image = Properties.Resources.Bil7;
                else if (bil == 8) B2.Image = Properties.Resources.Bil8;
                else B2.Image = Properties.Resources.Bil9;

                //förklarar att bil nr 2 ska vara synligt eftersom det som ska ändras är platsen inom vänstra sidan 
                B2.Visible = true; 

            }

            if (B1.Visible)
                B1.Top += speed;
            if (B1.Top > panel.Height)
            {
                B1.Visible = false;
                B1.Top = -B1.Height;
                B1.Left = l.Next(panel.Width / 2, panel.Width- B1.Width);
                int bil = l.Next(1, 9);
                if (bil == 1) B1.Image = Properties.Resources.Bil1;
                //här förklaras om bil nr 2 upptäcks så den ska synas på skärmen, och samma sak med andra bilar, detta är på högra sidan av spelet 

                else if (bil == 2) B1.Image = Properties.Resources.Bil2;
                else if (bil == 3) B1.Image = Properties.Resources.Bil3;
                else if (bil == 4) B1.Image = Properties.Resources.Bil4;
                else if (bil == 5) B1.Image = Properties.Resources.Bil5;
                else if (bil == 6) B1.Image = Properties.Resources.Bil6;
                else if (bil == 7) B1.Image = Properties.Resources.Bil7;
                else if (bil == 8) B1.Image = Properties.Resources.Bil8;
                else B1.Image = Properties.Resources.Bil9;

                //förklarar att bil nr 2 ska vara synligt eftersom det som ska ändras är platsen inom högra sidan 

                B1.Visible = true;

            }
            //förklaring när man förlurar 
            if(Spelare.Bounds.IntersectsWith(B1.Bounds) || Spelare.Bounds.IntersectsWith(B2.Bounds))
            {
                timerAction.Enabled = false;
                Game_Over.Visible = true; 
            }
            //score ökar med hastigheten 
            score++;
            if (score > 500) speed = 7;
            if (score > 1000) speed = 8;
            if (score > 1500) speed = 9;
            if (score > 2000) speed = 10;
            if (score > 3000) speed = 12;
            if (score > 4000) speed = 14;
            if (score > 5000) speed = 15;

            labelSpeed.Text = "Speed: " + score; 

            if (bil == Bil.Left && Spelare.Left>0)
                Spelare.Left -= speed;
            
            if (bil == Bil.Right && Spelare.Left<panel.Width - Spelare.Width)  
                Spelare.Left += speed;

        }
        //förklaras att den kan röra sig med pilarna höger och vänster
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left)
                bil = Bil.Left;
            else if (e.KeyData == Keys.Right)
                bil = Bil.Right;
            else bil = Bil.None;
            //när det är game over, space gör att den kör om 
            if (Game_Over.Visible)
                if (e.KeyData == Keys.Space)
                {
                    Game_Over.Visible = false;
                    Spelare.Left = panel.Width / 2;
                    B2.Left = 0;
                    B1.Left = panel.Width - B2.Width;
                    speed = 5;
                    score = 0;
                    timerAction.Enabled = true;  
                }

        }
        //när man släpper pilen så spelaren stannar och inte förtsätter åka vidare höger eller vänster
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            bil = Bil.None; 
        }

        private void Game_Over_Click(object sender, EventArgs e)
        {

        }
    }
}
