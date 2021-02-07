using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird
{
    public partial class Form1 : Form
    {
       // Form1 frm = new Form1();
        Random rnd = new Random();
        int pipespeed = 4;
        int upspeed = 7;
        int downspeed = 8;
        bool up = false;
       public int score = 0;
        bool start = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void TimerupdateEvent(object sender, EventArgs e)
        {

            
                Score.Text = "score : " + score;
                PipeUp.Left -= pipespeed;
                PipeDown.Left -= pipespeed;
                if (PipeDown.Left <= -140)
                {
               
                    score++;
                if (score % 10 == 0 && score != 0)
                    pipespeed += 3;
                    PipeDown.Height = rnd.Next(250) + 50;
                    PipeDown.Left = 900;
                   
                }
                if (PipeUp.Left <= -140)
                {
                    score++;
                if (score % 10 == 0 && score != 0)
                    pipespeed += 3;
                PipeUp.Top = 120+ PipeDown.Height;
                PipeUp.Left = 900;
               // PipeUp.Location=new Point(PipeUp.Left,258);
                
                   

                }

                if (up)
                {
                if (BirdPicture.Top!=0)
                    BirdPicture.Top -= upspeed;
                 
                }
                else { BirdPicture.Top += downspeed; }




                if ((BirdPicture.Bounds.IntersectsWith(PipeUp.Bounds) || BirdPicture.Bounds.IntersectsWith(PipeDown.Bounds)) || BirdPicture.Bounds.IntersectsWith(ground.Bounds))
                {
                    EndGame();
                }
            
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            up = true;
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            up = false;
        }
         void EndGame()
        {
            GameTimer.Stop();
            GameTimer.Enabled = false;
            Score.Text = "Your Score is " + score + " click here to restart the game";
            
        }

        private void Score_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       
    }
}
