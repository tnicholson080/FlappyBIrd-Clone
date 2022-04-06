using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void timerevent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            bottompipe.Left -= pipeSpeed;
            toppipe.Left -= pipeSpeed;
            Score.Text = "Score: " + score;
          
            
            if(bottompipe.Left < -200)
            {
                bottompipe.Left = 500;
                score++;
            }
            if (toppipe.Left < -200)
            {
                toppipe.Left = 700;
                score++;
            }

            if(Bird.Bounds.IntersectsWith(bottompipe.Bounds) || Bird.Bounds.IntersectsWith(toppipe.Bounds) || Bird.Bounds.IntersectsWith(ground.Bounds) ||
                (Bird.Top < -25))
            {
                endGame();
            }

           if (score > 10)
            {   
                pipeSpeed = 10;
                bottompipe.ImageLocation = @"E:\Media\Art\Haunted Forest\tree obsticles 3.png";
                toppipe.ImageLocation = @"E:\Media\Art\Haunted Forest\tree obsticles 4.png";
                if (bottompipe.Left < -200)
                {
                   
                    bottompipe.Left = 500;
                    score++;
                }
                if (toppipe.Left < -200)
                {
                    toppipe.Left = 700;
                    score++;
                }
              
            }

        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }


        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

        }

        private void endGame()
        {
            timer.Stop();
            Score.Text += " Game Over";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
