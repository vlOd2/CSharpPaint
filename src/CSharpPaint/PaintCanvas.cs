using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/*
 * PaintCanvas
 * Written by vlOd (vlad@xomi.xyz) 
 */

namespace CSharpPaint
{
    /// <summary>
    /// A canvas that is used for painting
    /// </summary>
    public class PaintCanvas : UserControl
    {
        public PictureBox PaintFrame;
        public Bitmap PaintFrameBitmap;
        public Graphics PaintFrameGraphics;
        private readonly Random rnd = new Random();
        private int frameSizeX = 0;
        private int frameSizeY = 0;

        /// <summary>
        /// The width of the frame
        /// </summary>
        public int FrameSizeX { get => frameSizeX; }
        /// <summary>
        /// The height of the frame
        /// </summary>
        public int FrameSizeY { get => frameSizeY; }

        /// <summary>
        /// Initializes the frame
        /// </summary>
        public void InitFrame(int sizeX, int sizeY) 
        {
            frameSizeX = sizeX;
            frameSizeY = sizeY;

            PaintFrameBitmap = new Bitmap(frameSizeX, frameSizeY);
            PaintFrameGraphics = Graphics.FromImage(PaintFrameBitmap);
            PaintFrameGraphics.Clear(Color.White);

            PaintFrame = new PictureBox
            {
                Image = PaintFrameBitmap,
                Size = new Size(frameSizeX, frameSizeY),
                Location = new Point(0, 0),
            };

            Controls.Add(PaintFrame);
        }

        /// <summary>
        /// Resizes the frame
        /// </summary>
        public void ResizeFrame(int newX, int newY) 
        {
            if (PaintFrameBitmap == null) return;

            int orgSizeX = frameSizeX;
            int orgSizeY = frameSizeY;
            Bitmap orgImage = PaintFrameBitmap;

            frameSizeX = newX;
            frameSizeY = newY;

            PaintFrameBitmap = new Bitmap(frameSizeX, frameSizeY);
            PaintFrameGraphics = Graphics.FromImage(PaintFrameBitmap);
            PaintFrameGraphics.Clear(Color.White);
            PaintFrameGraphics.DrawImageUnscaled(orgImage, 0, 0, orgSizeX, orgSizeY);

            PaintFrame.Size = new Size(frameSizeX, frameSizeY);
            PaintFrame.Image = PaintFrameBitmap;
        }

        /// <summary>
        /// Clears the frame
        /// </summary>
        public void ClearFrame() 
        {
            PaintFrameGraphics.Clear(Color.White);
            PaintFrame.Image = PaintFrameBitmap;
        }

        /// <summary>
        /// Gets the specified pixel's color value
        /// </summary>
        public Color GetPixel(int x, int y) 
        {
            x = Math.Min(Math.Max(x, 0), frameSizeX - 1);
            y = Math.Min(Math.Max(y, 0), frameSizeY - 1);
            return PaintFrameBitmap.GetPixel(x, y);
        }

        /// <summary>
        /// Sets the specified pixel using the specified RGB value
        /// </summary>
        public void SetPixel(int x, int y, int r, int g, int b) 
        {
            x = Math.Min(Math.Max(x, 0), frameSizeX - 1);
            y = Math.Min(Math.Max(y, 0), frameSizeY - 1);

            PaintFrameBitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
            PaintFrame.Image = PaintFrameBitmap;
        }

        /// <summary>
        /// Sets the specified pixel using the specified color
        /// </summary>
        public void SetPixel(int x, int y, Color c)
        {
            SetPixel(x, y, c.R, c.G, c.B);
        }

        /// <summary>
        /// Draws an area with the specified size around the specified pixel
        /// </summary>
        public void DrawArea(int x, int y, int r, int g, int b, int size) 
        {
            for (int y2 = 0; y2 < size; y2++)
            {
                for (int x2 = 0; x2 < size; x2++)
                {
                    SetPixel(x2 + x, y2 + y, r, g, b);
                }
            }

            SetPixel(x, y, r, g, b);
        }

        /// <summary>
        /// Draws an area with the specified size around the specified pixel
        /// </summary>
        public void DrawArea(int x, int y, Color c, int size)
        {
            DrawArea(x, y, c.R, c.G, c.B, size);
        }

        /// <summary>
        /// Fills the frame with random data
        /// </summary>
        public void FillWithGarbage()
        {
            for (int y = 0; y < frameSizeX; y++)
            {
                for (int x = 0; x < frameSizeY; x++)
                {
                    SetPixel(x, y, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }
        }

        /// <summary>
        /// Event fired when the control has been loaded
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            InitFrame(Size.Width, Size.Height);
            base.OnLoad(e);
        }

        /// <summary>
        /// Event fired when the control has been resized
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            ResizeFrame(Size.Width, Size.Height);
            base.OnResize(e);
        }
    }
}