using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafika_lab7
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)

                {

                    pictureBox1.Load(openFileDialog1.FileName);

                    szer = pictureBox1.Image.Width;

                    wys = pictureBox1.Image.Height;

                    pictureBox2.Image = new Bitmap(szer, wys);
                }
            }
        }
        private int[] Skalowanie(int[] values)

        {

            int minValue = 0;

            for (int i = 0; i < 256; i++)

            {

                if (values[i] != 0)

                {

                    minValue = i;

                    break;

                }

            }

            int maxValue = 255;

            for (int i = 255; i >= 0; i--)

            {

                if (values[i] != 0)

                {

                    maxValue = i;

                    break;

                }

            }

            int[] result = new int[256];

            double a = 255.0 / (maxValue - minValue);

            for (int i = 0; i < 256; i++)

            {

                result[i] = (int)(a * (i - minValue));

            }



            return result;

        }

        private void button4_Click(object sender, EventArgs e)
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
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k1, k2, k3, k4, k5, k6, k7, k8, k9;



            int maska1 = 1;

            int maska2 = 1;

            int maska3 = 1;

            int maska4 = 1;

            int maska5 = 1;

            int maska6 = 1;

            int maska7 = 1;

            int maska8 = 1;

            int maska9 = 1;

            int suma_masek = maska1 + maska2 + maska3 + maska4 + maska5 + maska6 + maska7 + maska8 + maska9;



            if (suma_masek == 0) suma_masek = 1;



            for (int x = 1; x < szer - 1; x++)

            {

                for (int y = 1; y < wys - 1; y++)

                {

                    int r, g, b;

                    k1 = b1.GetPixel(x - 1, y - 1);

                    k2 = b1.GetPixel(x, y - 1);

                    k3 = b1.GetPixel(x + 1, y - 1);

                    k4 = b1.GetPixel(x - 1, y);

                    k5 = b1.GetPixel(x, y);

                    k6 = b1.GetPixel(x + 1, y);

                    k7 = b1.GetPixel(x - 1, y + 1);

                    k8 = b1.GetPixel(x, y + 1);

                    k9 = b1.GetPixel(x + 1, y + 1);



                    r = k1.R * maska1 + k2.R * maska2 + k3.R * maska3 + k4.R * maska4 + k5.R * maska5 + k6.R * maska6 + k7.R * maska7 + k8.R * maska8 + k9.R * maska9;

                    r = r / suma_masek;



                    b = k1.B * maska1 + k2.B * maska2 + k3.B * maska3 + k4.B * maska4 + k5.B * maska5 + k6.B * maska6 + k7.B * maska7 + k8.B * maska8 + k9.B * maska9;

                    b = b / suma_masek;



                    g = k1.G * maska1 + k2.G * maska2 + k3.G * maska3 + k4.G * maska4 + k5.G * maska5 + k6.G * maska6 + k7.G * maska7 + k8.G * maska8 + k9.G * maska9;

                    g = g / suma_masek;





                    if (r > 255) r = 255;

                    if (r < 0) r = 0;





                    if (g > 255) g = 255;

                    if (g < 0) g = 0;



                    if (b > 255) b = 255;

                    if (b < 0) b = 0;



                    b2.SetPixel(x, y, Color.FromArgb(r, g, b));



                }



            }

            pictureBox2.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k1, k2, k3, k4, k5, k6, k7, k8, k9;



            int maska1 = 1;

            int maska2 = 2;

            int maska3 = 1;

            int maska4 = 2;

            int maska5 = 4;

            int maska6 = 2;

            int maska7 = 1;

            int maska8 = 2;

            int maska9 = 1;

            int suma_masek = maska1 + maska2 + maska3 + maska4 + maska5 + maska6 + maska7 + maska8 + maska9;



            if (suma_masek == 0) suma_masek = 1;



            for (int x = 1; x < szer - 1; x++)

            {

                for (int y = 1; y < wys - 1; y++)

                {

                    int r, g, b;

                    k1 = b1.GetPixel(x - 1, y - 1);

                    k2 = b1.GetPixel(x, y - 1);

                    k3 = b1.GetPixel(x + 1, y - 1);

                    k4 = b1.GetPixel(x - 1, y);

                    k5 = b1.GetPixel(x, y);

                    k6 = b1.GetPixel(x + 1, y);

                    k7 = b1.GetPixel(x - 1, y + 1);

                    k8 = b1.GetPixel(x, y + 1);

                    k9 = b1.GetPixel(x + 1, y + 1);



                    r = k1.R * maska1 + k2.R * maska2 + k3.R * maska3 + k4.R * maska4 + k5.R * maska5 + k6.R * maska6 + k7.R * maska7 + k8.R * maska8 + k9.R * maska9;

                    r = r / suma_masek;



                    b = k1.B * maska1 + k2.B * maska2 + k3.B * maska3 + k4.B * maska4 + k5.B * maska5 + k6.B * maska6 + k7.B * maska7 + k8.B * maska8 + k9.B * maska9;

                    b = b / suma_masek;



                    g = k1.G * maska1 + k2.G * maska2 + k3.G * maska3 + k4.G * maska4 + k5.G * maska5 + k6.G * maska6 + k7.G * maska7 + k8.G * maska8 + k9.G * maska9;

                    g = g / suma_masek;





                    if (r > 255) r = 255;

                    if (r < 0) r = 0;





                    if (g > 255) g = 255;

                    if (g < 0) g = 0;



                    if (b > 255) b = 255;

                    if (b < 0) b = 0;



                    b2.SetPixel(x, y, Color.FromArgb(r, g, b));
              

                }
            



            }

            pictureBox2.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] LUTred = Skalowanie(red);

            int[] LUTgreen = Skalowanie(green);

            int[] LUTblue = Skalowanie(blue);

            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            int[] red1 = new int[256];

            int[] green1 = new int[256];

            int[] blue1 = new int[256];

            for (int x = 0; x < szer; x++)

            {

                for (int y = 0; y < wys; y++)

                {

                    Color k = b1.GetPixel(x, y);

                    Color newk = Color.FromArgb(LUTred[k.R], LUTgreen[k.G], LUTblue[k.B]);

                    b2.SetPixel(x, y, newk);

                    red1[newk.R]++;

                    green1[newk.G]++;

                    blue1[newk.B]++;

                }

            }

            pictureBox2.Refresh();

            chart2.Series["R"].Points.Clear();

            chart2.Series["G"].Points.Clear();

            chart2.Series["B"].Points.Clear();

            for (int i = 0; i < 256; i++)

            {

                chart2.Series["R"].Points.AddXY(i, red1[i]);

                chart2.Series["G"].Points.AddXY(i, green1[i]);

                chart2.Series["B"].Points.AddXY(i, blue1[i]);

            }

            chart2.Invalidate();
        }

       



    }
}
