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
using System.Windows.Input;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        RGBConverter converter = new RGBConverter();

        public Form1()
        {
            InitializeComponent();
        }

        /* 
         * ColorBox update using RGB
         */
        private void UpdateColor()
        {
            Color color = Color.FromArgb(Convert.ToInt32(rValue.Text), Convert.ToInt32(gValue.Text), Convert.ToInt32(bValue.Text));
            panel1.BackColor = color;
        }

        /* 
         * Color change controllers 
         */
        private void UpdateRGB()
        {
            converter.CMYKtoRGB(float.Parse(cValue.Text)/100, float.Parse(mValue.Text)/100, float.Parse(yValue.Text)/100, float.Parse(kValue.Text)/100);

            rValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.rgb.R));
            gValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.rgb.G));
            bValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.rgb.B));
        }

        private void UpdateCMYK()
        {
            converter.RGBtoCMYK(float.Parse(rValue.Text), float.Parse(gValue.Text), float.Parse(bValue.Text));

            cValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.cmyk.C * 100));
            mValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.cmyk.M * 100));
            yValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.cmyk.Y * 100));
            kValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.cmyk.K * 100));
        }

        private void UpdateRGBfromLab()
        {
            converter.LabToRGB(float.Parse(lValue.Text), float.Parse(aValue.Text), float.Parse(bValue2.Text));

            rValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.rgb.R));
            gValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.rgb.G));
            bValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.rgb.B));
        }

        private void UpdateLAB()
        {
            converter.RGBToLab(float.Parse(rValue.Text), float.Parse(gValue.Text), float.Parse(bValue.Text));

            lValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.labS.L));
            aValue.Text = Convert.ToString(Convert.ToInt32(RGBConverter.labS.A));
            bValue2.Text = Convert.ToString(Convert.ToInt32(RGBConverter.labS.B));
        }

        /*
         * Sliders updates 
         */
        private void UpdateRGBSliders()
        {
            rSlider.Value = Convert.ToInt32(rValue.Text);
            gSlider.Value = Convert.ToInt32(gValue.Text);
            bSlider.Value = Convert.ToInt32(bValue.Text);
        }

        private void UpdateCMYKSliders()
        {
            cSlider.Value = Convert.ToInt32(cValue.Text);
            mSlider.Value = Convert.ToInt32(mValue.Text);
            ySlider.Value = Convert.ToInt32(yValue.Text);
            kSlider.Value = Convert.ToInt32(kValue.Text);
        }

        private void UpdateLabSliders()
        {
            LSlider.Value = GetInRange(Convert.ToInt32(lValue.Text));
            aSlider.Value = GetInRange(Convert.ToInt32(aValue.Text));
            bSlider2.Value = GetInRange(Convert.ToInt32(bValue2.Text));
        }

        private int GetInRange(int value)
        {
            if (value < -128)
                return -128;
            if (value > 128)
                return 128;
            return value;
        }

        /* 
         * Pick color from palette
         */
        private void ColorPickerClass1_ColorPicked(object sender, EventArgs e)
        {
            Color color = colorPickerClass1.SelectedColor;
            panel1.BackColor = color;
            rValue.Text = color.R.ToString();
            gValue.Text = color.G.ToString();
            bValue.Text = color.B.ToString();

            UpdateCMYK();
            UpdateLAB();

            UpdateRGBSliders();
            UpdateCMYKSliders();
            UpdateLabSliders();
        }

        /* 
         * Sliders update 
         */
        private void RSlider_Scroll(object sender, EventArgs e)
        {
            rValue.Text = rSlider.Value.ToString();
            UpdateCMYK();
            UpdateLAB();
        }

        private void GSlider_Scroll(object sender, EventArgs e)
        {
            gValue.Text = gSlider.Value.ToString();
            UpdateCMYK();
            UpdateLAB();
        }

        private void BSlider_Scroll(object sender, EventArgs e)
        {
            bValue.Text = bSlider.Value.ToString();
            UpdateCMYK();
            UpdateLAB();
        }

        /* 
         * Key controll 
         */
        private void RValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                if ((sender as TextBox).Text.Equals(""))
                {
                    (sender as TextBox).Text = "0";
                }
                UpdateCMYK();
                UpdateLAB();

                UpdateCMYKSliders();
                UpdateLabSliders();
                return;
            }

            if (!(e.KeyChar == 8) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void RValue_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Equals("") || (sender as TextBox).Text.Equals("-"))
            {
                (sender as TextBox).Text = "0";
                UpdateColor();
                UpdateRGBSliders();
                UpdateCMYKSliders();
                UpdateLabSliders();
            }

            UpdateRGB();
        }

        /* 
         * TextChanged 
         */
        private void RValue_TextChanged(object sender, EventArgs e)
        {
           if (!(sender as TextBox).Text.Equals(""))
            {
                if (Convert.ToInt32((sender as TextBox).Text) > 255)
                {
                    (sender as TextBox).Text = "255";
                }
                UpdateColor();

                UpdateCMYKSliders();
                UpdateLabSliders();
            }
        }

         /*
         * CMYK 
         * 
         * Sliders update
         */
        private void CSlide_Scroll(object sender, EventArgs e)
        {
            cValue.Text = cSlider.Value.ToString();
            UpdateRGB();
            UpdateLAB();
        }

        private void MSlide_Scroll(object sender, EventArgs e)
        {
            mValue.Text = mSlider.Value.ToString();
            UpdateRGB();
            UpdateLAB();
        }

        private void YSlide_Scroll(object sender, EventArgs e)
        {
            yValue.Text = ySlider.Value.ToString();
            UpdateRGB();
            UpdateLAB();
        }

        private void KSlide_Scroll(object sender, EventArgs e)
        {
            kValue.Text = kSlider.Value.ToString();
            UpdateRGB();
            UpdateLAB();
        }

        /* 
         * CMYK controller 
         */
        private void CValue_TextChanged(object sender, EventArgs e)
        {
            if (!(sender as TextBox).Text.Equals(""))
            {
                if (Convert.ToInt32((sender as TextBox).Text) > 100)
                {
                    (sender as TextBox).Text = "100";
                }
            }

            UpdateRGBSliders();
            UpdateLabSliders();
        }

        private void CValue_Enter(object sender, EventArgs e)
        {
            
        }

        private void KValue_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Equals("") || (sender as TextBox).Text.Equals("-"))
            {
                (sender as TextBox).Text = "0";
                UpdateColor();
                UpdateRGBSliders();
                UpdateCMYKSliders();
                UpdateLabSliders();
            }

            UpdateCMYK();
        }

        private void KValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                if ((sender as TextBox).Text.Equals(""))
                {
                    (sender as TextBox).Text = "0";
                }
                UpdateRGB();
                UpdateLAB();

                UpdateRGBSliders();
                UpdateLabSliders();
                return;
            }

            if (!(e.KeyChar == 8) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        /* 
         * LAB 
         */
        private void LValue_TextChanged(object sender, EventArgs e)
        {
            if (!(sender as TextBox).Text.Equals(""))
            {
                if (Convert.ToInt32((sender as TextBox).Text) > 100)
                {
                    (sender as TextBox).Text = "100";
                }
            }

            UpdateRGBSliders();
            UpdateCMYKSliders();
        }

        private void AValue_TextChanged(object sender, EventArgs e)
        {
            if (!(sender as TextBox).Text.Equals(""))
            {
                if ((sender as TextBox).Text.Length == 1 && (sender as TextBox).Text.Equals("-"))
                    return;
                if (Convert.ToInt32((sender as TextBox).Text) > 128)
                {
                    (sender as TextBox).Text = "128";
                }
                if (Convert.ToInt32((sender as TextBox).Text) < -128)
                {
                    (sender as TextBox).Text = "-128";
                }
            }

            UpdateRGBSliders();
            UpdateCMYKSliders();
        }

        /* 
         * Sliders update
         */
        private void BSlider2_Scroll(object sender, EventArgs e)
        {
            bValue2.Text = bSlider2.Value.ToString();
            UpdateRGBfromLab();
            UpdateCMYK();
        }

        private void ASlider_Scroll(object sender, EventArgs e)
        {
            aValue.Text = aSlider.Value.ToString();
            UpdateRGBfromLab();
            UpdateCMYK();
        }

        private void LSlieder_Scroll(object sender, EventArgs e)
        {
            lValue.Text = LSlider.Value.ToString();
            UpdateRGBfromLab();
            UpdateCMYK();
        }

        /* 
         * Key controll 
         */
        private void LValue_Enter(object sender, EventArgs e)
        {
            
        }

        private void AValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                if ((sender as TextBox).Text.Equals("") || (sender as TextBox).Text.Equals("-"))
                {
                    (sender as TextBox).Text = "0";
                }
                UpdateRGBfromLab();
                UpdateCMYK();

                UpdateRGBSliders();
                UpdateCMYKSliders();
                return;
            }

            if (!(e.KeyChar == 8) && !(e.KeyChar == '-') && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void LValue_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Equals("") || (sender as TextBox).Text.Equals("-"))
            {
                (sender as TextBox).Text = "0";
                UpdateColor();
                UpdateRGBSliders();
                UpdateCMYKSliders();
            }

            UpdateLAB();
        }

        private void LValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                if ((sender as TextBox).Text.Equals(""))
                {
                    (sender as TextBox).Text = "0";
                }
                UpdateRGBfromLab();
                UpdateCMYK();

                UpdateRGBSliders();
                UpdateCMYKSliders();
                return;
            }

            if (!(e.KeyChar == 8) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
