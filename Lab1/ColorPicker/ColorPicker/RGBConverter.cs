using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorPicker
{
    public class RGBConverter
    {
        public struct RGB
        {
            public float R;
            public float G;
            public float B;
        }

        public struct CMYK
        {
            public float C;
            public float M;
            public float Y;
            public float K;
        }

        public struct LAB
        {
            public float L;
            public float A;
            public float B;
        }

        public static CMYK cmyk = new CMYK();
        public static RGB rgb = new RGB();
        public static LAB labS = new LAB();

        public void RGBtoCMYK(float R, float G, float B)
        {
            cmyk.K = Math.Min(1-R/255, Math.Min(1-G/255, 1-B/255));
            if (cmyk.K > 0.99999) cmyk.K = 0.99999f;

            cmyk.C = (1 - R / 255 - cmyk.K) / (1 - cmyk.K);
            cmyk.M = (1 - G / 255 - cmyk.K) / (1 - cmyk.K);
            cmyk.Y = (1 - B / 255 - cmyk.K) / (1 - cmyk.K);

            if (cmyk.C < 0) cmyk.C = 0;
            if (cmyk.M < 0) cmyk.M = 0;
            if (cmyk.Y < 0) cmyk.Y = 0;

            if (cmyk.C > 1) cmyk.C = 1;
            if (cmyk.M > 1) cmyk.M = 1;
            if (cmyk.Y > 1) cmyk.Y = 1;
        }

        public void CMYKtoRGB(float C, float M, float Y, float K)
        {
            rgb.R = 255 * (1 - C) * (1 - K);
            rgb.G = 255 * (1 - M) * (1 - K);
            rgb.B = 255 * (1 - Y) * (1 - K);
        }

        public void RGBToLab(float R, float G, float B)
        {
            float[] xyz = new float[3];
            float[] lab = new float[3];
            float[] rgb = new float[] { R/255.0f, G/255.0f, B/255.0f };

            for (int i = 0; i < 3; i++)
            {
                if (rgb[i] > .04045f)
                {
                    rgb[i] = (float)Math.Pow((rgb[i] + .055) / 1.055, 2.4);
                }
                else
                {
                    rgb[i] = rgb[i] / 12.92f;
                }
                rgb[i] *= 100;
            }

            xyz[0] = ((rgb[0] * .4124f) + (rgb[1] * .3576f) + (rgb[2] * .1805f));
            xyz[1] = ((rgb[0] * .2126f) + (rgb[1] * .7152f) + (rgb[2] * .0722f));
            xyz[2] = ((rgb[0] * .0193f) + (rgb[1] * .1192f) + (rgb[2] * .9505f));

            xyz[0] /= 95.047f;
            xyz[1] /= 100f;
            xyz[2] /= 108.883f;

            for(int i = 0; i < 3; i++)
            {
                if (xyz[i] > .008856f)
                {
                    xyz[i] = (float)Math.Pow(xyz[i], 1.0 / 3.0);
                }
                else
                {
                    xyz[i] = (xyz[i] * 7.787f) + (16.0f / 116.0f);
                }
            }

            lab[0] = (116.0f * xyz[1]) - 16.0f;
            lab[1] = 500.0f * (xyz[0] - xyz[1]);
            lab[2] = 200.0f * (xyz[1] - xyz[2]);

            labS.L = lab[0];
            labS.A = lab[1];
            labS.B = lab[2];
        }

        private int GetInRangeRGB(int value)
        {
            if (value < 0)
                return 0;
            if (value > 255)
                return 255;
            return value;
        }

        public void LabToRGB(float L, float a, float b)
        {
            float[] xyz = new float[3];
            float[] lab = new float[3] { L, a, b};
            float[] rgb_cur = new float[3];

            xyz[1] = ((lab[0] + 16) / 116);
            xyz[0] = lab[1]/500f + xyz[1];
            xyz[2] = xyz[1] - lab[2] / 200f;

            for (int i = 0; i < 3; i++)
            {
                if ((float)Math.Pow(xyz[i], 3) >= .008856f)
                {
                    xyz[i] = (float)Math.Pow(xyz[i], 3);
                }
                else
                {
                    xyz[i] = (xyz[i] - 16/116f)/7.787f;
                }

                xyz[i] /= 100;
            }

            xyz[0] *= 95.047f;
            xyz[1] *= 100f;
            xyz[2] *= 108.883f;

            rgb_cur[0] = ((xyz[0] * 3.2406f) + (xyz[1] * -1.5372f) + (xyz[2] * -0.4986f));
            rgb_cur[1] = ((xyz[0] * -0.9689f) + (xyz[1] * 1.8758f) + (xyz[2] * 0.0415f));
            rgb_cur[2] = ((xyz[0] * 0.0557f) + (xyz[1] * -0.2040f) + (xyz[2] * 1.0570f));

            for (int i = 0; i < 3; i++)
            {
                if (rgb_cur[i] >= .0031308f)
                {
                    rgb_cur[i] = 1.055f*(float)Math.Pow(rgb_cur[i], 1/2.4f) - 0.055f;
                }
                else
                {
                    rgb_cur[i] = rgb_cur[i] * 12.92f;
                }
                rgb_cur[i] *= 255;
                rgb_cur[i] = GetInRangeRGB(Convert.ToInt32(rgb_cur[i]));
            }

            rgb.R = rgb_cur[0];
            rgb.G = rgb_cur[1];
            rgb.B = rgb_cur[2];
        }
    }
}
