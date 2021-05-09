using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafika___lab8
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

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k1, k2, k3, k4, k5, k6, k7, k8, k9;



            int maska1 = 0;

            int maska2 = 0;

            int maska3 = 0;

            int maska4 = 0;

            int maska5 = 1;

            int maska6 = -1;

            int maska7 = 0;

            int maska8 = 0;

            int maska9 = 0;

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

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k1, k2, k3, k4, k5, k6, k7, k8, k9;



            int maska1 = 1;

            int maska2 = 1;

            int maska3 = 1;

            int maska4 = 0;

            int maska5 = 0;

            int maska6 = 0;

            int maska7 = -1;

            int maska8 = -1;

            int maska9 = -1;

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

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k1, k2, k3, k4, k5, k6, k7, k8, k9;



            int maska1 = 1;

            int maska2 = 2;

            int maska3 = 1;

            int maska4 = 0;

            int maska5 = 0;

            int maska6 = 0;

            int maska7 = -1;

            int maska8 = -2;

            int maska9 = -1;

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



            int maska1 = 0;

            int maska2 = 0;

            int maska3 = 0;

            int maska4 = 0;

            int maska5 = 1;

            int maska6 = 0;

            int maska7 = 0;

            int maska8 = -1;

            int maska9 = 0;

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

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k1, k2, k3, k4, k5, k6, k7, k8, k9;



            int maska1 = 1;

            int maska2 = 0;

            int maska3 = -1;

            int maska4 = 1;

            int maska5 = 0;

            int maska6 = -1;

            int maska7 = 1;

            int maska8 = 0;

            int maska9 = -1;

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

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k1, k2, k3, k4, k5, k6, k7, k8, k9;



            int maska1 = 1;

            int maska2 = 0;

            int maska3 = -1;

            int maska4 = 2;

            int maska5 = 0;

            int maska6 = -2;

            int maska7 = 1;

            int maska8 = 0;

            int maska9 = -1;

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

        private void button9_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k1, k2, k3, k4, k5, k6, k7, k8, k9;



            int maska1 = 0;

            int maska2 = -1;

            int maska3 = 0;

            int maska4 = -1;

            int maska5 = 4;

            int maska6 = -1;

            int maska7 = 0;

            int maska8 = -1;

            int maska9 = 0;

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

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k;

            for (int x = 1; x < szer - 1; x++)

            {

                for (int y = 1; y < wys - 1; y++)

                {



                    List<int> r = new List<int>();

                    List<int> g = new List<int>();

                    List<int> b = new List<int>();

                    for (int i = x - 1; i < x + 1; i++)

                    {

                        for (int j = y - 1; j < y + 1; j++)

                        {

                            k = b1.GetPixel(i, j);

                            r.Add(k.R);

                            g.Add(k.G);

                            b.Add(k.B);

                        }

                    }

                    r.Sort();

                    g.Sort();

                    b.Sort();

                    b2.SetPixel(x, y, Color.FromArgb(r[0], g[0], b[0]));



                }



            }

            pictureBox2.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k;

            for (int x = 1; x < szer - 1; x++)

            {

                for (int y = 1; y < wys - 1; y++)

                {



                    List<int> r = new List<int>();

                    List<int> g = new List<int>();

                    List<int> b = new List<int>();

                    for (int i = x - 1; i < x + 1; i++)

                    {

                        for (int j = y - 1; j < y + 1; j++)

                        {

                            k = b1.GetPixel(i, j);

                            r.Add(k.R);

                            g.Add(k.G);

                            b.Add(k.B);

                        }

                    }

                    r.Sort();

                    g.Sort();

                    b.Sort();

                    b2.SetPixel(x, y, Color.FromArgb(r[r.Count - 1], g[g.Count - 1], b[b.Count - 1]));



                }



            }

            pictureBox2.Refresh();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox1.Image;

            Bitmap b2 = (Bitmap)pictureBox2.Image;

            Color k;

            for (int x = 1; x < szer - 1; x++)

            {

                for (int y = 1; y < wys - 1; y++)

                {



                    List<int> r = new List<int>();

                    List<int> g = new List<int>();

                    List<int> b = new List<int>();

                    for (int i = x - 1; i < x + 1; i++)

                    {

                        for (int j = y - 1; j < y + 1; j++)

                        {

                            k = b1.GetPixel(i, j);

                            r.Add(k.R);

                            g.Add(k.G);

                            b.Add(k.B);

                        }

                    }

                    r.Sort();

                    g.Sort();

                    b.Sort();

                    b2.SetPixel(x, y, Color.FromArgb(r[r.Count / 2], g[g.Count / 2], b[b.Count / 2]));



                }



            }

            pictureBox2.Refresh();

        
    }
    }
}
