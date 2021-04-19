using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16wzorow
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

                pictureBox3.Image = new Bitmap(szer, wys);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                pictureBox2.Load(openFileDialog1.FileName);

                szer = pictureBox1.Image.Width;

                wys = pictureBox1.Image.Height;

                pictureBox3.Image = new Bitmap(szer, wys);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    r = (k1.R + k2.R);

                    b = (k1.B + k2.B);

                    g = (k1.G + k2.G);



                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();
        }
        private void button5_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);

                    r = (int)((k1.R - k2.R));

                    g = (int)((k1.G - k2.G));

                    b = (int)((k1.B - k2.B));

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, g, b));



                }

            }

            pictureBox3.Refresh();

        }



        private void button6_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    if (k1.R < k2.R)

                    {

                        r = (k2.R - k1.R);

                    }

                    else

                    {

                        r = (k1.R - k2.R);

                    }



                    if (k1.G < k2.G)

                    {

                        g = (k2.G - k1.G);

                    }

                    else

                    {

                        g = (k1.G - k2.G);

                    }

                    if (k1.B < k2.B)

                    {

                        b = (k2.B - k1.B);

                    }

                    else

                    {

                        b = (k1.B - k2.B);

                    }

                    b3.SetPixel(x, y, Color.FromArgb(r, g, b));

                }

            }

            pictureBox3.Refresh();

        }



        private void button7_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    r = (k1.R * k2.R) / 255;

                    b = (k1.B * k2.B) / 255;

                    g = (k1.G * k2.G) / 255;

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();

        }



        private void button8_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);





                    r = k1.R + k2.R - (k1.R * k2.R) / 255;

                    g = k1.G + k2.G - (k1.G * k2.G) / 255;

                    b = k1.B + k2.B - (k1.B * k2.B) / 255;

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();

        }



        private void button9_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    if ((255 - k1.R - k2.R) > 0)

                    {

                        r = 255 - (255 - k1.R - k2.R);

                    }

                    else

                    {

                        r = 255 - (255 - k1.R - k2.R) * (-1);

                    }



                    if ((255 - k1.G - k1.G) > 0)

                    {

                        g = 255 - (255 - k1.G - k2.G);

                    }

                    else

                    {

                        g = 255 - (255 - k1.G - k2.G) * (-1);

                    }



                    if ((255 - k1.B - k2.B) > 0)

                    {

                        b = 255 - (255 - k1.B - k2.B);

                    }

                    else

                    {

                        b = 255 - (255 - k1.B - k2.B) * (-1);

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();

        }



        private void button10_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    if (k1.R < k2.R)

                    {

                        r = k1.R;

                    }

                    else

                    {

                        r = k2.R;

                    }

                    if (k1.G < k2.G)

                    {

                        g = k1.G;

                    }

                    else

                    {

                        g = k2.G;

                    }

                    if (k1.B < k2.B)

                    {

                        b = k1.B;

                    }

                    else

                    {

                        b = k2.B;

                    }

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();

        }



        private void button11_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);

                    if (k1.R < k2.R)

                    {

                        r = k2.R;

                    }

                    else

                    {

                        r = k1.R;

                    }

                    if (k1.G < k2.G)

                    {

                        g = k2.G;

                    }

                    else

                    {

                        g = k1.G;

                    }

                    if (k1.B < k2.B)

                    {

                        b = k2.B;

                    }

                    else

                    {

                        b = k1.B;

                    }



                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();

        }

        private void button12_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);





                    r = k1.R + k2.R - 2 * (k1.R * k2.R) / 255;

                    g = k1.G + k2.G - 2 * (k1.G * k2.G) / 255;

                    b = k1.B + k2.B - 2 * (k1.B * k2.B) / 255;

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();

        }

        private void button13_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);





                    if (k1.R < 128)

                    {

                        r = 2 * k1.R * k2.R / 255;

                    }

                    else

                    {

                        r = 255 - 2 * ((255 - k1.R) * (255 - k2.R)) / 255;

                    }



                    if (k1.G < 128)

                    {

                        g = 2 * k1.G * k2.G / 255;

                    }

                    else

                    {

                        g = 255 - 2 * ((255 - k1.G) * (255 - k2.G)) / 255;

                    }



                    if (k1.B < 128)

                    {

                        b = 2 * k1.B * k2.B / 255;

                    }

                    else

                    {

                        b = 255 - 2 * ((255 - k1.B) * (255 - k2.B)) / 255;

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();



        }





        private void button14_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);





                    if (k2.R == 0)

                    {

                        r = 2 * k1.R * k2.R / 255;

                    }

                    else

                    {

                        r = 255 - 2 * ((255 - k1.R) * (255 - k2.R)) / 255;

                    }



                    if (k2.G == 0)

                    {

                        g = 2 * k1.G * k2.G / 255;

                    }

                    else

                    {

                        g = 255 - 2 * ((255 - k1.G) * (255 - k2.G)) / 255;

                    }



                    if (k2.B == 0)

                    {

                        b = 2 * k1.B * k2.B / 255;

                    }

                    else

                    {

                        b = 255 - 2 * ((255 - k1.B) * (255 - k2.B)) / 255;

                    }



                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();



        }



        private void button15_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);





                    if (k2.R < 128)

                    {

                        r = (2 * k1.R * k2.R + (k1.R * k1.R) * (255 - 2 * k2.R)) / 255;

                    }

                    else

                    {

                        r = (k1.R * (2 * k2.R - 255) + (2 * k1.R * (255 - k2.R))) / 255;



                    }



                    if (k1.G < 128)

                    {

                        g = (2 * k1.G * k2.G + (k1.G * k1.G) * (255 - 2 * k2.G)) / 255;

                    }

                    else

                    {

                        g = (k1.G * (2 * k2.G - 255) + (2 * k1.G * (255 - k2.G))) / 255;

                    }



                    if (k1.B < 128)

                    {

                        b = (2 * k1.B * k2.B + (k1.B * k1.B) * (255 - 2 * k2.B)) / 255;

                    }

                    else

                    {

                        b = (k1.B * (2 * k2.B - 255) + (2 * k1.B * (255 - k2.B))) / 255;

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();



        }



        private void button16_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);

                    if (k2.R == 255)

                    {

                        r = 255;

                    }

                    else if (k2.R == 0)

                    {

                        r = 255;

                    }

                    else

                    {

                        r = (int)((k1.R * 255 / (255 - k2.R)));

                    }

                    if (k2.G == 255)

                    {

                        g = 255;

                    }

                    else if (k2.G == 0)

                    {

                        g = 255;

                    }

                    else

                    {

                        g = (int)((k1.G * 255 / (255 - k2.G)));

                    }

                    if (k2.B == 255)

                    {

                        b = 255;

                    }

                    else if (k2.B == 0)

                    {

                        b = 255;

                    }

                    else

                    {

                        b = (int)((k1.B * 255 / (255 - k2.B)));

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();



        }



        private void button17_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    if (k2.R == 0)

                    {

                        r = 255;

                    }

                    else

                    {

                        r = (int)(255 - (((255 - k1.R) * 255) / k2.R));

                    }

                    if (k2.G == 0)

                    {

                        g = 255;

                    }

                    else

                    {

                        g = (int)(255 - (((255 - k1.G) * 255) / k2.G));

                    }

                    if (k2.B == 0)

                    {

                        b = 255;

                    }

                    else

                    {

                        b = (int)(255 - (((255 - k1.B) * 255) / k2.B));

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();



        }



        private void button18_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    if (255 - k2.R == 0)

                    {

                        r = 0;

                    }

                    else

                    {

                        r = (k1.R * k1.R) / (255 - k2.R);

                    }



                    if (255 - k2.G == 0)

                    {

                        g = 0;

                    }

                    else

                    {

                        g = (k1.G * k1.G) / (255 - k2.G);

                    }



                    if (255 - k2.B == 0)

                    {

                        b = 0;

                    }

                    else

                    {

                        b = (k1.B * k1.B) / (255 - k2.B);

                    }

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();



        }

        private void button19_Click(object sender, EventArgs e)

        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Bitmap b3 = (Bitmap)pictureBox3.Image;



            Color k1, k2;

            int r, b, g;

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b1.GetPixel(x, y);

                    k2 = b2.GetPixel(x, y);



                    r = (((255 - int.Parse(textBox2.Text)) * k2.R) / 255 + (int.Parse(textBox2.Text) * k1.R) / 255);

                    g = (((255 - int.Parse(textBox2.Text)) * k2.G) / 255 + (int.Parse(textBox2.Text) * k1.G) / 255);

                    b = (((255 - int.Parse(textBox2.Text)) * k2.B) / 255 + (int.Parse(textBox2.Text) * k1.B) / 255);

                    if (r > 255) r = 255;

                    if (r < 0) r = 0;

                    if (g > 255) g = 255;

                    if (g < 0) g = 0;

                    if (b > 255) b = 255;

                    if (b < 0) b = 0;

                    b3.SetPixel(x, y, Color.FromArgb(r, b, g));

                }

            }

            pictureBox3.Refresh();



        }

        
    }

}

