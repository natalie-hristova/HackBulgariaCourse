using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ConsoleApplication1
{
    class GreyBmp
    {


        public static void GreyScaleImage(Bitmap input, string path)
        {
            for (int i = 0; i < input.Width; i++)
            {
                for (int j = 0; j < input.Height; j++)
                {
                    Color pixel = input.GetPixel(i, j);
                    int x = (pixel.A + pixel.B + pixel.R) / 3;
                    Color newPixel = Color.FromArgb(x, x, x);
                    input.SetPixel(i, j, newPixel);
                }
            }
            input.Save(path);
        }



        public static void ResampleImage(Bitmap bitmap, Size newSize, string savePath)
        {
            double w, h;
            w = newSize.Width / (double)bitmap.Width;
            h = newSize.Height / (double)bitmap.Height;
            Bitmap bmp2 = new Bitmap(newSize.Width, newSize.Height);
            for (int i = 0; i < bmp2.Width; i++)
            {
                for (int j = 0; j < bmp2.Height; j++)
                {
                    int oldX = (int)Math.Round(i / w);
                    int oldY = (int)Math.Round(j / h);
                    if (oldX >= bitmap.Width)
                        oldX--;
                    if (oldY >= bitmap.Height)
                        oldY--;
                    Color pix = bitmap.GetPixel(oldX, oldY);
                    bmp2.SetPixel(i, j, pix);
                }
            }
            bmp2.Save(savePath);
        }


     public static void BlurImage(Bitmap bitmap, string savePath)
        {
            Bitmap bmp2 = new Bitmap(bitmap.Width, bitmap.Height);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color pixel = bitmap.GetPixel(i, j);
                }
            }
        }

    }
}
