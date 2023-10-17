using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicplayer
{
    public partial class Form1 : Form
    {
        int minX = 240, maxX = 800, minY = 30, maxY = 380;
        int count = 0;
        int[] fq = { 440, 495, 550, 587, 660, 733, 825, 895 }; 
        int duration = 600;
        int[] arrbee = new int[9] { 5, 3, 3, 4, 2, 2, 1,2,3 };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            

            this.ClientSize = new System.Drawing.Size(860, 660); 
            Do.Location = new Point(240, 390);
            Re.Location = new Point(320, 390);
            Mi.Location = new Point(400, 390);
            Fa.Location = new Point(480, 390);
            So.Location = new Point(560, 390);
            La.Location = new Point(640, 390);
            Si.Location = new Point(725, 390);
            this.KeyPreview = true;
            paintTable(arrbee,9);


        }

        private void Do_Click(object sender, EventArgs e)
        {
            Console.Beep(fq[0], duration);//發出聲音

        }

        private void Re_Click(object sender, EventArgs e)
        {
            Console.Beep(fq[1], duration);
            count += 1;
        }

        private void Mi_Click(object sender, EventArgs e)
        {
            Console.Beep(fq[2], duration);
            count += 1;
        }

        private void Fa_Click(object sender, EventArgs e)
        {
            Console.Beep(fq[3], duration);
            count += 1;
        }

        private void So_Click(object sender, EventArgs e)
        {
            Console.Beep(fq[4], duration);
            count += 1;
        }

        private void La_Click(object sender, EventArgs e)
        {
            Console.Beep(fq[5], duration);
            count += 1;
        }

        private void Si_Click(object sender, EventArgs e)
        {
            Console.Beep(fq[6], duration);
            count += 1;
        }


        void paintTable(int[] arr, int max){
            Graphics g = this.CreateGraphics();

            g.Clear(Color.White);


            for (int i = 0; i <= 7; i++)
            {
                g.DrawLine(new Pen(Color.Black), new Point(minX, minY + ((380 - 30) / 7 * i)), new Point(maxX, minY + (380 - 30) / 7 * i));
                g.DrawLine(new Pen(Color.Black), new Point(minX + ((800 - 240) / 7 * i), minY), new Point(minX + ((800 - 240) / 7 * i), maxY));
            }

            /*for (int i = count; i <=count+6; j++){
                g.FillRectangle(new SolidBrush(Color.Black), 240+80*(Array.IndexOf(step,sheet[i])), 30+50*(6-i) , 80, 50);
             }*/
            for (int i=6,j=count; i>=0 ; i--){
                if (j > max - 1)
                {
                }
                else
                {
                    g.FillRectangle(new SolidBrush(Color.Black), minX + (800 - 240) / 7 * (arr[j++] - 1), minY + (380 - 30) / 7 * i, (800 - 240) / 7, (380 - 30) / 7);
                }
            }           
        }

        private void Do_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.D1)
            {
                Do_Click(sender, e);
            } 

            if (e.KeyChar == (char)Keys.D2)
            {
                Re_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.D3)
            {
                Mi_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.D4)
            {
                Fa_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.D5)
            {
                So_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.D6)
            {
                La_Click(sender, e);
            }
            if (e.KeyChar == (char)Keys.D7)
            {
                Si_Click(sender, e);
            }
        }
    }
}
