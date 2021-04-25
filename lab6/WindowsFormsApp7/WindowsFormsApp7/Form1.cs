using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{

    public partial class Form1 : Form
    {
        private int szer, wys;
        public Form1()
        {
            InitializeComponent();
        }
        int[] red = new int[256];

        int[] green = new int[256];

        int[] blue = new int[256];

        private void button1_Click(object sender, EventArgs e)
        {
           

                if (openFileDialog1.ShowDialog() == DialogResult.OK)

                {

                    pictureBox1.Load(openFileDialog1.FileName);

                    szer = pictureBox1.Image.Width;

                    wys = pictureBox1.Image.Height;

                    pictureBox2.Image = new Bitmap(szer, wys);



                }



            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Bitmap b1 = (Bitmap)pictureBox1.Image;



            Color k;





            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k = b1.GetPixel(x, y);

                    red[k.R]++;

                    green[k.G]++;

                    blue[k.B]++;

                }

            }

            chart1.Series["R"].Points.Clear();

            chart1.Series["G"].Points.Clear();

            chart1.Series["B"].Points.Clear();

            for (int i = 0; i < 256; i++)

            {

                chart1.Series["R"].Points.AddXY(i, red[i]);

                chart1.Series["G"].Points.AddXY(i, green[i]);

                chart1.Series["B"].Points.AddXY(i, blue[i]);

            }

            chart1.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap b2 = (Bitmap)pictureBox1.Image;




            Color k1;




            
            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    k1 = b2.GetPixel(x, y);

                    red[k1.R]++;

                    green[k1.G]++;

                    blue[k1.B]++;

                }

            }

            chart2.Series["R"].Points.Clear();

            chart2.Series["G"].Points.Clear();

            chart2.Series["B"].Points.Clear();

            for (int i = 0; i < 256; i++)

            {

                chart2.Series["R"].Points.AddXY(i, red[i]);

                chart2.Series["G"].Points.AddXY(i, green[i]);

                chart2.Series["B"].Points.AddXY(i, blue[i]);

            }

            chart2.Invalidate();
        
    }

        private void button4_Click(object sender, EventArgs e)
        {
            double wartosc = int.Parse(textBox1.Text);

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
                    
                    red[k.R]++;

                    green[k.G]++;

                    blue[k.B]++;


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
           

           
        

        pictureBox2.Invalidate();
          

        }

        
    
    }
}
