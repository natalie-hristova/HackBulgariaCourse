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
                    int x = (pixel.G + pixel.B + pixel.R) / 3;
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
           
            int r = 0, g = 0, b = 0;
            //Color pixel = bitmap.GetPixel(0, 0);
            //bitmap.SetPixel(0, 0, pixel);
            //pixel= bitmap.GetPixel(0, bitmap.Height -1);
            //bitmap.SetPixel(0, bitmap.Size.Height - 1, pixel);
            //pixel = bitmap.GetPixel(bitmap.Width-1, bitmap.Height - 1);
            //bitmap.SetPixel(bitmap.Width - 1, bitmap.Size.Height - 1, pixel);
            //pixel = bitmap.GetPixel(bitmap.Width - 1, 0);
            //bitmap.SetPixel(bitmap.Width - 1,0, pixel);
           

            for (int i = 1; i < bitmap.Height; i++)
            {
              pixel = bitmap.GetPixel(0,i);
                bitmap.SetPixel(0, i,pixel);
                pixel = bitmap.GetPixel(bitmap.Width - 1, i);
                bitmap.SetPixel(bitmap.Width - 1, i, pixel);
            }
          
            for (int i = 1; i < bitmap.Width; i++)
            {
                pixel = bitmap.GetPixel(i, 0);
                bitmap.SetPixel(i, 0, pixel);
                pixel = bitmap.GetPixel(i, bitmap.Height - 1);
                bitmap.SetPixel(i,bitmap.Height - 1, pixel);
            }
            
            for (int i = 1; i < bitmap.Width - 1; i++)
            {
                for (int j = 1; j < bitmap.Height - 1; j++)
                {
                    for (int k = i-1; k < i + 2; k++)
                    {
                        for (int l = j-1; l < j + 2; l++)
                        {
                            r =r+ bitmap.GetPixel(k, l).R;
                            b += bitmap.GetPixel( k,l).B;
                            g += bitmap.GetPixel( k,l).G;
                           
                        }
                        
                    }
                    r /= 9;
                    b /= 9;
                    g /= 9;
                   
                    Color newPixel = Color.FromArgb(r, g, b);
                    bitmap.SetPixel(i, j, newPixel);
                    r = 0;b = 0;g = 0;
                }
            }
            bitmap.Save(savePath);
        }
    }
}

