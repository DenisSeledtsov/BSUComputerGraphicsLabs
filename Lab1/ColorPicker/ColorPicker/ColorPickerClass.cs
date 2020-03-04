using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
    class ColorPickerClass : Panel
    {
        private Bitmap _canvas;
        private Graphics _graphicsBuffer;
        private LinearGradientBrush _lgbSpectrum, _lgbFade;
        private Color _selectedColor;

        public event EventHandler ColorPicked;

        public ColorPickerClass()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | 
                ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);

            UpdateBackBuffer();
            UpdateGradient();
        }
        
        private void OnColorPicked()
        {
            if (ColorPicked != null)
            {
                ColorPicked(this, EventArgs.Empty);
            }
        }

        private void UpdateBackBuffer()
        {
            if (!this.Width.Equals(0))
            {
                _canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
                _graphicsBuffer = Graphics.FromImage(_canvas);
            }
        }

        private void UpdateGradient()
        {
            // Update spectrum
            _lgbSpectrum = new LinearGradientBrush(Point.Empty, new Point(this.ClientSize.Width, 0), Color.Wheat, Color.Wheat);
            ColorBlend spectrumBlend = new ColorBlend();
            spectrumBlend.Colors = new Color[] { Color.Violet, Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Indigo, Color.Gray };
            spectrumBlend.Positions = new float[] { 0, 1/8f, 2/8f, 3/8f, 4/8f, 5/8f, 6/8f, 1 };
            _lgbSpectrum.InterpolationColors = spectrumBlend;

            // Update overlay
            _lgbFade = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.White, 90F);
            ColorBlend fadeBlend = new ColorBlend();
            fadeBlend.Colors = new Color[] { Color.Black, Color.Transparent, Color.White };
            fadeBlend.Positions = new float[] { 0, 0.5F, 1 };
            _lgbFade.InterpolationColors = fadeBlend;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateBackBuffer();
            UpdateGradient();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _graphicsBuffer.FillRectangle(_lgbSpectrum, this.ClientRectangle);
            _graphicsBuffer.FillRectangle(_lgbFade, this.ClientRectangle);
            e.Graphics.DrawImageUnscaled(_canvas, Point.Empty);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            Point pos = this.PointToClient(Cursor.Position);
            _selectedColor = _canvas.GetPixel(pos.X, pos.Y);
            OnColorPicked();
        }

        public Color SelectedColor
        {
            get { return _selectedColor; }
        }
    }
}
