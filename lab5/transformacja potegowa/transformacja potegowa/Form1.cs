using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transformacja_potegowa
{
    public partial class Form1 : Form
    {
        private int szer;

        private int wys;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                pictureBox1.Load(openFileDialog1.FileName);

                szer = pictureBox1.Image.Width;

                wys = pictureBox1.Image.Height;

                pictureBox2.Image = new Bitmap(szer, wys);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k;

            int r, b, g;



            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k = b1.GetPixel(x, y);

                    if ((255 * Math.Pow(k.R / 255.0, double.Parse(textBox1.Text))) > 255)

                    {

                        r = 255;

                    }

                    else

                    {

                        r = (int)(255 * Math.Pow(k.R / 255.0, double.Parse(textBox1.Text)));

                    }



                    if ((255 * Math.Pow(k.G / 255.0, double.Parse(textBox1.Text)) > 255))

                    {

                        g = 255;

                    }

                    else

                    {

                        g = (int)(255 * Math.Pow(k.G / 255.0, double.Parse(textBox1.Text)));

                    }



                    if ((255 * Math.Pow(k.B / 255.0, double.Parse(textBox1.Text)) > 255))

                    {

                        b = 255;

                    }

                    else

                    {

                        b = (int)(255 * Math.Pow(k.B / 255.0, double.Parse(textBox1.Text)));

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;





                    b2.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

                double wartosc = int.Parse(textBox2.Text);

                Bitmap b1 = (Bitmap)pictureBox1.Image;

                Bitmap b2 = (Bitmap)pictureBox2.Image;

                Color k;

                int r, g, b;

                if (wartosc <= 0)

                {

                    wartosc = 1.0 + (wartosc / 256.0);

                }

                else

                {

                    wartosc = 256.0 / Math.Pow(2, Math.Log(257 - wartosc, 2));

                }

                for (int x = 0; x < szer; x++)

                {

                    for (int y = 0; y < wys; y++)

                    {

                        k = b1.GetPixel(x, y);



                        r = k.R;

                        g = k.G;

                        b = k.B;

                        if ((wartosc * (k.R - 127) + 127) > 255)

                        {

                            r = 255;

                        }

                        else if ((wartosc * (k.R - 127) + 127) < 0)

                        {

                            r = 0;

                        }

                        else

                        {

                            r = (int)(wartosc * (k.R - 127) + 127);

                        }



                        if ((wartosc * (k.G - 127) + 127) > 255)

                        {

                            g = 255;

                        }

                        else if ((wartosc * (k.G - 127) + 127) < 0)

                        {

                            g = 0;

                        }

                        else

                        {

                            g = (int)(wartosc * (k.G - 127) + 127);

                        }



                        if ((wartosc * (k.B - 127) + 127) > 255)

                        {

                            b = 255;

                        }

                        else if ((wartosc * (k.B - 127) + 127) < 0)

                        {

                            b = 0;

                        }

                        else

                        {

                            b = (int)(wartosc * (k.B - 127) + 127);

                        }





                        b2.SetPixel(x, y, Color.FromArgb(r, g, b));

                    }

                }

                pictureBox2.Refresh();

            }
    }
    }

