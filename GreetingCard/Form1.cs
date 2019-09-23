using System;
using System.Drawing;
using System.Linq;
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
            Pen cardPenWhite = new Pen(Color.White);
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

            g.DrawString("Happy", cardFrontFont, cardbBlack, 60, 60);
            g.DrawString("Meme", cardFrontFont, cardbWhite, -10, 150);
            Thread.Sleep(50);
            g.Clear(Color.Brown);
            g.DrawString("You're in a", cardFrontFont, cardbBlack, 60, 60);
            g.DrawString("Memers", cardFrontFont, cardbWhite, 300, 150);

            g.DrawString("Anonymous", cardFrontFont, cardbBlack, 60, 220);
            g.TranslateTransform(0,0 );
            g.RotateTransform(-60);
            Thread.Sleep(60);
            g.RotateTransform(-60);
            g.DrawString("Anonymous", cardFrontFont, cardbBlack, 50, 40);
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
            //Drawing the click here box
            g.FillRectangle(cardbBlack, 20, 360, 350, 70);
            g.DrawRectangle(cardPenRed, 20, 360,350, 70);
            g.DrawString("Click here", cardFrontFont, cardbWhite, 25, 345);
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SoundPlayer twinkleSound = new SoundPlayer(Properties.Resources.twinkle);
            SoundPlayer smashSound = new SoundPlayer(Properties.Resources.smash);
            Graphics g = this.CreateGraphics();
            SolidBrush cardbWhite = new SolidBrush(Color.White);
            SolidBrush cardbBlack = new SolidBrush(Color.Black);
            SolidBrush cardbGreen = new SolidBrush(Color.Green);
            SolidBrush cardbRed = new SolidBrush(Color.Red);
            SolidBrush cardbBlue = new SolidBrush(Color.Blue);
            Pen cardPenWhite = new Pen(Color.White);
            Pen cardPenBlack = new Pen(Color.Black, 3);
            Pen cardPenRed = new Pen(Color.Red, 3);
            Font cardInFont = new Font("Papyrus", 50);
            Font cardFrontFont = new Font("Comic Sans MS", 50);
            //text for inside of card
            g.Clear(Color.White);
            Thread.Sleep(400);
            //start of the front text animation
            g.DrawString("Happy", cardFrontFont, cardbWhite, -50, 60);
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

            g.DrawString("Happy", cardFrontFont, cardbBlack, 60, 60);
            g.DrawString("Meme", cardFrontFont, cardbWhite, -10, 150);
            Thread.Sleep(50);
            g.Clear(Color.Brown);
            g.DrawString("You're in ", cardFrontFont, cardbBlack, 60, 60);
            g.DrawString("Memers", cardFrontFont, cardbWhite, 300, 150);

            g.DrawString("Anonymous", cardFrontFont, cardbBlack, 60, 220);
            g.TranslateTransform(0, 0);
            g.RotateTransform(-60);
            Thread.Sleep(60);
            g.RotateTransform(-60);
            g.DrawString("Anonymous", cardFrontFont, cardbBlack, 50, 40);
            g.ResetTransform();
            //end of front of cards text drawing

            //Dawing PEpe the frog
            g.FillEllipse(cardbGreen, 500, 300, 200, 100);
            //eyes
            g.FillEllipse(cardbGreen, 285, 280, 40, 85);
            g.FillEllipse(cardbGreen, 345, 280, 40, 85);
            g.FillEllipse(cardbWhite, 350, 300, 30, 15);
            g.FillEllipse(cardbWhite, 290, 300, 30, 15);
            g.FillEllipse(cardbBlack, 355, 300, 15, 15);
            g.FillEllipse(cardbBlack, 295, 300, 15, 15);
            //Mouth
            g.FillEllipse(cardbRed, 195, 335, 100, 15);
            g.FillEllipse(cardbRed, 195, 345, 100, 15);
            g.DrawLine(cardPenBlack, 200, 347, 580, 347);
            //expression lines
            g.DrawArc(cardPenBlack, 200, 300, 60, 60, 60, 70);
            g.DrawArc(cardPenBlack, 275, 260, 60, 60, 60, 70);
            g.DrawArc(cardPenBlack, 335, 260, 60, 60, 60, 70);
            g.FillPie(cardbBlue, 335, 300, 50, 50, 60, 70);
            //smashSound.Play();
            //g.DrawString("Get clean or go mean", cardInFont, cardbBlack, 105, 345);

        }
    }
}
