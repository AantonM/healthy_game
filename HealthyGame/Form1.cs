using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthyGame
{
    public partial class Form1 : Form
    {

        int timeLeft;
        private Point firstPoint = new Point();
        int picID = 0;
        int Result = 0;
        string[,] images = new string[,]{
            {"1","ananas.png","h"},
            {"2","apple.png","h"},
            {"3","banana.png","h"},
            {"4","beans.png","h"},
            {"5","bread.png","h"},
            {"6","cherry.png","h"},
            {"7","chicken.png","h"},
            {"8","chips.png","u"},
            {"9","donut.png","u"},
            {"10","eggs.png","h"},
            {"11","fish.png","h"},
            {"12","hamburger.png","u"},
            {"13","hotdog.png","u"},
            {"14","ice.png","u"},
            {"15","krusha.png","h"},
            {"16","milk.png","h"},
            {"17","pie.png","u"},
            {"18","pizza.png","u"},
            {"19","popcorns.png","u"},
            {"20","strawberry.png","h"},
            {"21","tree.png","h"},
            {"22","watermellon.png","h"},
        };


       
    
        /*.........................
       Main menu -  it contains the main menu from where the user can choose to registrate or to log in.
       parameters - no.
       .........................*/
        public Form1()
        {

            InitializeComponent();
            loadImage();
            move();
            lblTime.Text = "30 seconds";
            timeLeft = 30;
            timer.Start();
        }

        public void loadImage() 
        {
            Random rnd = new Random();
            picID = rnd.Next(1, 22);
            picFood.ImageLocation = @"food\" + images[picID, 1] ;
           
        }

        public void move() 
        {
            picFood.MouseDown += (ss, ee) =>
            {
              if (ee.Button == System.Windows.Forms.MouseButtons.Left)
               {
                  firstPoint = Control.MousePosition;
               }
            };

            //everytime I move the mouse
            picFood.MouseMove += (ss, ee) =>
            {
              if (ee.Button == System.Windows.Forms.MouseButtons.Left)
               {
                 Point temp = Control.MousePosition;
                 Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);
                 picFood.Location = new Point(picFood.Location.X - res.X, picFood.Location.Y - res.Y);

                 firstPoint = temp;
               }
            };

            // when the left button is up
            picFood.MouseUp += (ss, ee) =>
            {
              if (ee.Button == System.Windows.Forms.MouseButtons.Left)
               {
                 checkLocation();
               }
            };
        
        }

        public void checkLocation()
        {

            Point HealthyPicture = picFood.Location; //the moving object
            Point HealthyLoc = picHealthy.Location;
            Point UnhealthyLoc = picUnhealthy.Location;
           

            //check if it fits the first object
            if (HealthyPicture.X > HealthyLoc.X && HealthyPicture.Y > HealthyLoc.Y && HealthyPicture.X + 84 < HealthyLoc.X + 141 && HealthyPicture.Y + 61 < HealthyLoc.Y + 123)
            {
                lblResult.Text = "Healthy";
                if (images[picID, 2] == "h")
                {
                    Result++;
                    lblScore.Text = "Score: " + Result;
                }
                else 
                {
                    if (Result > 0)
                    {
                        Result--;
                    }
                    lblScore.Text = "Score: " + Result;
                
                }

                restart();
            }
            //check if it fits the second object
            else if (HealthyPicture.X > UnhealthyLoc.X && HealthyPicture.Y > UnhealthyLoc.Y && HealthyPicture.X + 84 < UnhealthyLoc.X + 141 && HealthyPicture.Y + 61 < UnhealthyLoc.Y + 123)
            {
                lblResult.Text = "Unhealthy";
                if (images[picID, 2] == "u")
                {
                    Result++;
                    lblScore.Text = "Score: " + Result;
                }
                else
                {
                    if (Result > 0)
                    {
                        Result--;
                    }
                    lblScore.Text = "Score: " + Result;

                }
                restart();
            }
            else if (HealthyPicture.X < -30 || HealthyPicture.Y < -30 || HealthyPicture.X > 430 || HealthyPicture.Y > 380  ) {
                restart();
            }
            else
            {
                lblResult.Text = "Put the food into the bag.";

            }


        }

        public void restart()
        {
            picFood.Location = new Point(213, 16);
            loadImage(); 
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left 
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                lblTime.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show 
                // a MessageBox, and fill in the answers.
                timer.Stop();
                lblTime.Text = "Time's up!";
                DialogResult drReply;
                drReply = MessageBox.Show("Time's up!. Your score is " + Result + " points. Press 'Yes' to try again and 'No' to close the game.", "Sorry!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (drReply == DialogResult.Yes)
                {
                    this.Refresh();
                    timeLeft = 30;
                    timer.Start();
                    Result = 0;
                    lblScore.Text = "0";
                    lblResult.Text = "what kind of food it is";
                    restart();
                }
                else if (drReply == DialogResult.No) {
                    this.Close();
                }
            }
        }








    }
}
