using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int pipeSpeed = 5;
        int gravity = 3;
        int Inscore;

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            scoreText.Text = "" + Inscore;
            
            if (pipeBottom.Left < -85)
            {
                pipeBottom.Left = 680;
                Inscore += 1;
            }
            else if (pipeTop.Left < -95)
            {
                pipeTop.Left = 685;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if (Inscore > 2)
            {
                BackColor = Color.DarkTurquoise;
            }
            if (Inscore > 4)
            {
                BackColor = Color.LightSeaGreen;
            }
            if(Inscore > 6)
            {
                BackColor = Color.DarkSlateBlue;
                
            }
            if(Inscore > 8)
            {
                BackColor = Color.DarkViolet;
            }
            if(Inscore > 10)
            {
                BackColor = Color.LightYellow;
            }
            if(Inscore >= 12)
            {
                BackColor = Color.Yellow;
            }
        }

       private void inGameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                jumping = true;
                gravity = 2;
            }
        }

        private void inGameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                jumping = true;
                gravity = -2;
            }
        }

        public Form1()
        {
            string fscore;
            fscore = Convert.ToString(Inscore);
            InitializeComponent();
            endText1.Text = "GAME OVER !";
            endText2.Text = "Your final score is: " + fscore;
            gameDesigner.Text = "Game Designed By Andrej Angelovski";
            endText1.Visible = false;
            endText2.Visible = false;
            endScore.Visible = false;
            gameDesigner.Visible = false;
            btnStart.Visible = false;
        }

        private void endGame()
        {
            gameTimer.Stop();
            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
            btnStart.Visible = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gameTimer.Equals(0);
        }
    }
}
