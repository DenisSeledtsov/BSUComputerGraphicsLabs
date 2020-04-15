using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineDrawings
{
    public partial class Form1 : Form
    {
        readonly int width = 601;
        readonly int height = 301;
        readonly int baseWidth = 30;
        readonly int baseHeight = 15;
        readonly int diff = 20;

        int x1, x2, y1, y2, x0, y0;

        public Bitmap InitNet()
        {
            Bitmap mainBitmap = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x % diff == 0 || y % diff == 0)
                        mainBitmap.SetPixel(x, y, Color.Black);
                    else
                        mainBitmap.SetPixel(x, y, Color.White);
                }
            }
            return mainBitmap;
        }

        public Bitmap ConvertBaseToMain(Bitmap bitmap)
        {  
            Bitmap mainBitmap = InitNet();
            for (int y = 0; y < baseHeight; y++)
            {
                for (int x = 0; x < baseWidth; x++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    if (color.A == Color.Black.A)
                    {
                        for (int j = 0; j < diff; j++)
                        {
                            for (int i = 0; i < diff; i++)
                            {
                                mainBitmap.SetPixel(x * diff + i, y * diff + j, color);
                            }
                        }
                    }
                }
            }
            return mainBitmap;
        }

        public Bitmap DrawLineBresenham(Bitmap bitmap, int x0, int y0, int x1, int y1)
        {
            int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            for (; ; )
            {
                bitmap.SetPixel(x0, y0, Color.Black);
                if (x0 == x1 && y0 == y1) break;
                e2 = err;
                if (e2 > -dx) { err -= dy; x0 += sx; }
                if (e2 < dy) { err += dx; y0 += sy; }
            }
            return bitmap;
        }

        public Bitmap DrawLineDDA(Bitmap bitmap, int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;

            int steps = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);

            float Xinc = dx / (float)steps;
            float Yinc = dy / (float)steps;

            float X = x0;
            float Y = y0;
            for (int i = 0; i <= steps; i++)
            {
                bitmap.SetPixel(Convert.ToInt32(X), Convert.ToInt32(Y), Color.Black);
                X += Xinc;
                Y += Yinc;
            }
            return bitmap;
        }

        public Bitmap DrawLineStepByStep(Bitmap bitmap, int x0, int y0, int x1, int y1)
        {
            float k = ((float)(y0 - y1)) / (x0 - x1);
            float b = y0 - x0 * k;

            int dx = x1 - x0;
            int dy = y1 - y0;
            int steps = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);

            float Xinc = dx / (float)steps;
            float X = x0;
            float Y;

            for (int i = 0; i <= steps; i++)
            {
                Y = (int)((X) * k + b);
                bitmap.SetPixel((int)X, (int)Y, Color.Black);
                X += Xinc;
            }
            return bitmap;
        }

        private bool CheckBorders(int x, int y)
        {
            if (x < 0 || x >= baseWidth)
                return false;
            if (y < 0 || y >= baseHeight)
                return false;
            return true;
        }

        private void CheckValues()
        {
            if (x1 >= baseWidth)
            {
                x1 = baseWidth-1;
                x1Box.Text = (baseWidth-1).ToString();
            }
            if (x2 >= baseWidth)
            {
                x2 = baseWidth-1;
                x2Box.Text = (baseWidth - 1).ToString();
            }
            if (y1 >= baseHeight)
            {
                y1 = baseHeight-1;
                y1Box.Text = (baseHeight - 1).ToString();
            }
            if (y2 >= baseHeight)
            {
                y2 = baseHeight-1;
                y2Box.Text = (baseHeight-1).ToString();
            }
            if (x0 >= baseWidth)
            {
                x0 = baseWidth-1;
                x0Box.Text = (baseWidth - 1).ToString();
            }
            if (y0 >= baseHeight)
            {
                y0 = baseHeight-1;
                y0Box.Text = (baseHeight - 1).ToString();
            }
        }

        private void DrawCircle(Bitmap bitmap, int xc, int yc, int x, int y)
        {
            if (CheckBorders(xc + x, yc + y))
                bitmap.SetPixel(xc + x, yc + y, Color.Black);
            if (CheckBorders(xc - x, yc + y))
                bitmap.SetPixel(xc - x, yc + y, Color.Black);
            if (CheckBorders(xc + x, yc - y))
                bitmap.SetPixel(xc + x, yc - y, Color.Black);
            if (CheckBorders(xc - x, yc - y))
                bitmap.SetPixel(xc - x, yc - y, Color.Black);
            if (CheckBorders(xc + y, yc + x))
                bitmap.SetPixel(xc + y, yc + x, Color.Black);
            if (CheckBorders(xc - y, yc + x))
                bitmap.SetPixel(xc - y, yc + x, Color.Black);
            if (CheckBorders(xc + y, yc - x))
                bitmap.SetPixel(xc + y, yc - x, Color.Black);
            if (CheckBorders(xc - y, yc - x))
                bitmap.SetPixel(xc - y, yc - x, Color.Black);

        }

        public Bitmap DrawCircleBresenham(Bitmap bitmap, int xc, int yc, int r)
        {
            int x = 0, y = r;
            int d = 3 - 2 * r;
            DrawCircle(bitmap, xc, yc, x, y);
            while (y >= x)
            {
                x++;
                if (d > 0)
                {
                    y--;
                    d = d + 4 * (x - y) + 10;
                }
                else
                    d = d + 4 * x + 6;
                DrawCircle(bitmap, xc, yc, x, y);
            }
            return bitmap;
        }

        public Form1()
        {
            InitializeComponent();           
            pictureBox1.Image = InitNet();
        }

        private void Bresenhams_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(baseWidth, baseHeight);
            try
            {
                x1 = Convert.ToInt32(x1Box.Text);
                y1 = Convert.ToInt32(y1Box.Text);
                x2 = Convert.ToInt32(x2Box.Text);
                y2 = Convert.ToInt32(y2Box.Text);

                CheckValues();

                pictureBox1.Image = ConvertBaseToMain(DrawLineBresenham(bitmap, x1, y1, x2, y2));
            }
            catch (Exception) { }
            finally
            {
                bitmap.Dispose();
            }
        }

        private void DDA_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(baseWidth, baseHeight);
            try
            {
                x1 = Convert.ToInt32(x1Box.Text);
                y1 = Convert.ToInt32(y1Box.Text);
                x2 = Convert.ToInt32(x2Box.Text);
                y2 = Convert.ToInt32(y2Box.Text);

                CheckValues();

                pictureBox1.Image = ConvertBaseToMain(DrawLineDDA(bitmap, x1, y1, x2, y2));
            }
            catch (Exception) { }
            finally
            {
                bitmap.Dispose();
            }
        }

        private void StepByStep_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(baseWidth, baseHeight);
            try
            {
                x1 = Convert.ToInt32(x1Box.Text);
                y1 = Convert.ToInt32(y1Box.Text);
                x2 = Convert.ToInt32(x2Box.Text);
                y2 = Convert.ToInt32(y2Box.Text);

                CheckValues();

                pictureBox1.Image = ConvertBaseToMain(DrawLineStepByStep(bitmap, x1, y1, x2, y2));
            }
            catch (Exception) { }
            finally
            {
                bitmap.Dispose();
            }
        }

        private void Bresenhams_Circle_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(baseWidth, baseHeight);

            try
            {
                x0 = Convert.ToInt32(x0Box.Text);
                y0 = Convert.ToInt32(y0Box.Text);
                int r = Convert.ToInt32(rBox.Text);

                CheckValues();

                pictureBox1.Image = ConvertBaseToMain(DrawCircleBresenham(bitmap, x0, y0, r));
            }
            catch (Exception) { }
            finally
            {
                bitmap.Dispose();
            }
        }

        private void DigitKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
