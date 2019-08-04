using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SevenKnightsAI.Classes.Imaging
{
    public class LockBitmap
    {
        public LockBitmap(Bitmap source)
        {
            this.source = source;
        }

        public Color GetPixel(int x, int y)
        {
            Color result = Color.Empty;
            int num = Depth / 8;
            int num2 = (y * Width + x) * num;
            if (num2 > Pixels.Length - num)
            {
                throw new IndexOutOfRangeException();
            }
            if (Depth == 32)
            {
                byte blue = Pixels[num2];
                byte green = Pixels[num2 + 1];
                byte red = Pixels[num2 + 2];
                byte alpha = Pixels[num2 + 3];
                result = Color.FromArgb(alpha, red, green, blue);
            }
            if (Depth == 24)
            {
                byte blue2 = Pixels[num2];
                byte green2 = Pixels[num2 + 1];
                byte red2 = Pixels[num2 + 2];
                result = Color.FromArgb(red2, green2, blue2);
            }
            if (Depth == 8)
            {
                byte b = Pixels[num2];
                result = Color.FromArgb(b, b, b);
            }
            return result;
        }

        public void LockBits()
        {
            try
            {
                Width = source.Width;
                Height = source.Height;
                int num = Width * Height;
                Rectangle rect = new Rectangle(0, 0, Width, Height);
                Depth = Image.GetPixelFormatSize(source.PixelFormat);
                if (Depth != 8 && Depth != 24 && Depth != 32)
                {
                    throw new ArgumentException("Only 8, 24 and 32 bpp images are supported.");
                }
                bitmapData = source.LockBits(rect, ImageLockMode.ReadWrite, source.PixelFormat);
                int num2 = Depth / 8;
                Pixels = new byte[num * num2];
                Iptr = bitmapData.Scan0;
                Marshal.Copy(Iptr, Pixels, 0, Pixels.Length);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SetPixel(int x, int y, Color color)
        {
            int num = Depth / 8;
            int num2 = (y * Width + x) * num;
            if (Depth == 32)
            {
                Pixels[num2] = color.B;
                Pixels[num2 + 1] = color.G;
                Pixels[num2 + 2] = color.R;
                Pixels[num2 + 3] = color.A;
            }
            if (Depth == 24)
            {
                Pixels[num2] = color.B;
                Pixels[num2 + 1] = color.G;
                Pixels[num2 + 2] = color.R;
            }
            if (Depth == 8)
            {
                Pixels[num2] = color.B;
            }
        }

        public void UnlockBits()
        {
            try
            {
                Marshal.Copy(Pixels, 0, Iptr, Pixels.Length);
                source.UnlockBits(bitmapData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Depth
        {
            get;

            private set;
        }

        public int Height
        {
            get;

            private set;
        }

        public byte[] Pixels;

        public int Width
        {
            get;

            private set;
        }

        private BitmapData bitmapData;

        private IntPtr Iptr = IntPtr.Zero;

        private Bitmap source;
    }
}