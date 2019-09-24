using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace GreetingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            SoundPlayer twinkleSound = new SoundPlayer(Properties.Resources.twinkle);
            Graphics g = this.CreateGraphics();
            SolidBrush cardbWhite = new SolidBrush(Color.White);
            SolidBrush cardbBlack = new SolidBrush(Color.Black);
            SolidBrush cardbGreen = new SolidBrush(Color.Green);
            SolidBrush cardbRed = new SolidBrush(Color.Red);
            SolidBrush cardbBlue = new SolidBrush(Color.Blue);
            Pen cardPenBlack = new Pen(Color.Black,3);
            Pen cardPenRed = new Pen(Color.Red, 3);
            Font cardFrontFont = new Font("Comic Sans MS", 50);
            g.Clear(Color.LightSeaGreen);
            Thread.Sleep(400);

            //start of the front text animation
            g.DrawString("Happy",cardFrontFont, cardbWhite, -50,60);
            Thread.Sleep(50);
            g.Clear(Color.LightSeaGreen);
            Thread.Sleep(50);
            g.DrawString("Happy", cardFrontFont, cardbBlack, -10, 60);
            Thread.Sleep(50);
            twinkleSound.Play();
            g.Clear(Color.LightGreen);
            g.DrawString("Happy", cardFrontFont, cardbWhite, 100, 60);
            g.DrawString("Meme", cardFrontFont, cardbBlack, -50, 150); 
            Thread.Sleep(50);
            g.Clear(Color.OliveDrab);
            g.DrawString("Happy- no", cardFrontFont, cardbBlack, 60, 60);
            g.DrawString("Meme", cardFrontFont, cardbWhite, -10, 150);
            Thread.Sleep(50);
            g.Clear(Color.Brown);
            g.DrawString("You're in ", cardFrontFont, cardbBlack, 60, 60);
            g.DrawString("Witness", cardFrontFont, cardbWhite, 300, 150);
            g.DrawString("Protection", cardFrontFont, cardbBlack, 60, 220);
            g.RotateTransform(-60);
            Thread.Sleep(60);
            g.RotateTransform(-60);
            g.DrawString("Protection", cardFrontFont, cardbBlack, 50, 40);
            g.ResetTransform();
            //end of front of cards text drawing

            //Dawing PEpe the frog
            g.FillEllipse(cardbGreen,500,300,200,100);
            
            //eyes
            g.FillEllipse(cardbGreen, 585, 280, 40, 85);
            g.FillEllipse(cardbGreen, 645, 280, 40, 85);
            g.FillEllipse(cardbWhite, 650, 300, 30, 15);
            g.FillEllipse(cardbWhite, 590, 300, 30, 15);
            g.FillEllipse(cardbBlack, 655, 300, 15, 15);
            g.FillEllipse(cardbBlack, 595, 300, 15, 15);
           
            //Mouth
            g.FillEllipse(cardbRed, 495, 335, 100, 15);
            g.FillEllipse(cardbRed, 495, 345, 100, 15);
            g.DrawLine(cardPenBlack,500,347,580,347);
            
            //expression lines
            g.DrawArc(cardPenBlack,500, 300, 60, 60, 60,70);
            g.DrawArc(cardPenBlack, 575, 260, 60, 60, 60, 70);
            g.DrawArc(cardPenBlack, 635, 260, 60, 60, 60, 70);
            g.FillPie(cardbBlue, 635, 300, 50, 50, 60, 70);
            //End of PEPE

            //Drawing the click here box
            g.FillRectangle(cardbBlack, 20, 360, 350, 70);
            g.DrawRectangle(cardPenRed, 20, 360,350, 70);
            g.DrawString("Click here", cardFrontFont, cardbWhite, 25, 345);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SoundPlayer walkSound = new SoundPlayer(Properties.Resources.walk);
            SoundPlayer smashSound = new SoundPlayer(Properties.Resources.smash);
            SoundPlayer typeSound = new SoundPlayer(Properties.Resources.type);
            Graphics g = this.CreateGraphics();
            SolidBrush cardbWhite = new SolidBrush(Color.White);
            SolidBrush cardbBlack = new SolidBrush(Color.Black);
            SolidBrush cardbGreen = new SolidBrush(Color.Green);
            SolidBrush cardbRed = new SolidBrush(Color.Red);
            Pen cardPenBlack = new Pen(Color.Black, 3);
            Pen cardIntBlack = new Pen(Color.Black,200);
            Font cardIntFont = new Font("Papyrus", 50);
            Font cardFrontFont = new Font("Comic Sans MS", 50);

            //text for inside of card
            g.DrawString("You're in ", cardFrontFont, cardbBlack, 60, 60);
            g.DrawString("Memers", cardFrontFont, cardbWhite, 300, 150);
            Thread.Sleep(800);

            //start of the screen swipe/
            g.DrawString("You're in ", cardFrontFont, cardbBlack, 60, 60);
            g.DrawString("Memers", cardFrontFont, cardbWhite, 300, 150);
            g.DrawString("Anonymous", cardFrontFont, cardbBlack, 50, 40);
            g.ResetTransform();
            Thread.Sleep(800);
            g.DrawString("You're in ", cardFrontFont, cardbBlack, 100, 60);
            g.DrawString("Memers", cardFrontFont, cardbWhite, -10, 150);
            g.DrawString("Anonymous", cardFrontFont, cardbBlack, -10, 40);
            Thread.Sleep(500);
            g.DrawString("You're in ", cardFrontFont, cardbBlack, -10, 60);
            g.DrawString("Memers", cardFrontFont, cardbWhite, -10, 150);
            g.DrawString("Anonymous", cardFrontFont, cardbBlack, -10, 40);
            g.DrawString("You're in ", cardFrontFont, cardbBlack, 50, 60);
            g.DrawString("Memers", cardFrontFont, cardbWhite, 1000, 150);
            g.DrawString("Anonymous", cardFrontFont, cardbBlack, 200, 40);
            // End of text

            //Dawing PEpe the frog
            g.FillEllipse(cardbGreen, 500, 300, 200, 100);
            
            //eyes
            g.FillEllipse(cardbGreen, 585, 280, 40, 85);
            g.FillEllipse(cardbGreen, 645, 280, 40, 85);
            g.FillEllipse(cardbWhite, 650, 300, 30, 15);
            g.FillEllipse(cardbWhite, 590, 300, 30, 15);
            g.FillEllipse(cardbBlack, 655, 30, 15, 15);
            g.FillEllipse(cardbBlack, 595, 300, 15, 15);
            
            //Mouth
            g.FillEllipse(cardbRed, 495, 335, 100, 15);
            g.FillEllipse(cardbRed, 495, 845, 140, 15);
            g.DrawLine(cardPenBlack, 500, 347, 580, 347);
            
            //expression lines
            g.DrawArc(cardPenBlack, 500, 350, 60, 60, 60, 70);
            g.DrawArc(cardPenBlack, 575, 400, 60, 60, 60, 70);
            Thread.Sleep(50);
            g.Clear(Color.Brown);
            
            // end of screen swipe
            typeSound.Play();
            //Drawing the int text
            g.DrawString("You", cardIntFont, cardbBlack, 200, 40);
            Thread.Sleep(500);
            g.DrawString("Have", cardIntFont, cardbBlack, 340, 40);
            Thread.Sleep(500);
            g.DrawString("Violated ", cardIntFont, cardbBlack, 170,110);
            Thread.Sleep(500);
            g.DrawString("The Law", cardIntFont, cardbBlack, 440, 110);
            Thread.Sleep(500);
            g.DrawString("Serve Your Sentence...", cardIntFont, cardbBlack, 70, 190);
            Thread.Sleep(2500);
            g.Clear(Color.Gray);
            //007 shoot animation drawing
            walkSound.Play();
            g.DrawLine(cardIntBlack, 0, 0, 0, 500);
            g.DrawLine(cardIntBlack, 800, 0, 800, 500);
            g.FillRectangle(cardbGreen, 240, 125, 60, 200);
            g.FillRectangle(cardbBlack, 230, 125, 30, 30);
            g.FillEllipse(cardbRed,240,100,60,60);
            // Text
            g.DrawString("You Have", cardIntFont, cardbWhite, 200, 40);
            g.DrawString("Violated The Law ", cardIntFont, cardbWhite, 170, 110);
            g.DrawString("Serve Your Sentence...", cardIntFont, cardbWhite, 70, 190);
            //end of text

            //Shot animation/sound
            Thread.Sleep(2000);
            smashSound.Play();
            g.Clear(Color.Red);
            //end of animation
        }
    }
}
