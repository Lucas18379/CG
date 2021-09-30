using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ProcessamentoImagens
{
    class Filtros
    {
        private double pi = Math.PI;
        public Filtros()
        {
        }
        double cos(double x)
        {
            return Math.Cos(x);
        }

        double acos(double x)
        {
            return Math.Acos(x);
        }

        double sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        unsafe private byte* gotoxy(int x, int y, BitmapData bmp)
        {
            byte* aux = (byte*)bmp.Scan0.ToPointer();
            aux += y * bmp.Stride; /// linha
            aux += 3 * x; // coluna
            return aux;
        }
        
        private unsafe void HSI2RGB(double h, double s, double i, double* r, double* g, double* b)
        {
            double x = i * (1 - s);
            if (h < 2 * pi / 3)
            {
                double y = i * (1 + (s * cos(h)) / (cos(pi / 3 - h)));
                double z = 3 * i - (x + y);
                *b = x; *r = y; *g = z;
            }
            else if (h < 4 * pi / 3)
            {
                double y = i * (1 + (s * cos(h - 2 * pi / 3)) / (cos(pi / 3 - (h - 2 * pi / 3))));
                double z = 3 * i - (x + y);
                *r = x; *g = y; *b = z;
            }
            else
            {
                double y = i * (1 + (s * cos(h - 4 * pi / 3)) / (cos(pi / 3 - (h - 4 * pi / 3))));
                double z = 3 * i - (x + y);
                *r = z; *g = x; *b = y;
            }
        }

        private unsafe void RGB2HSI(double r, double g, double b, double* h, double* s, double* i)
        {
            *i = (r + g + b) / 3.0;
            double rn = r / (r + g + b);
            double gn = g / (r + g + b);
            double bn = b / (r + g + b);

            *h = acos((0.5 * ((rn - gn) + (rn - bn))) / (sqrt((rn - gn) * (rn - gn) + (rn - bn) * (gn - bn))));
            if (b > g)
            {
                *h = 2 * pi - *h;
            }

            *s = 1 - 3 * Math.Min(rn, Math.Min(gn, bn));
        }

        private unsafe void rgbTohsi(int R, int G, int B, int *H, int *S, int *I)
        {
            double r, g, b, h, s, i, RGB;
            if (R > 255) R = 255;
            else if (R < 0) R = 0;
            if (G > 255) G = 255;
            else if (G < 0) G = 0;
            if (B > 255) B = 255;
            else if (B < 0) B = 0;

            RGB = R + G + B;
            if (RGB == 0) r = g = b = 0;
            else
            {
                r = R / RGB;
                g = G / RGB;
                b = B / RGB;
            }

            double div = Math.Sqrt(Math.Pow(r - g, 2) + (r - b) * (g - b));
            if (div == 0)
                h = 0;
            else if (b <= g) 
                h = acos (0.5 * ((r - g) + (r - b)) / div);
            else 
                h = 2 * Math.PI - acos ( 0.5 * ((r - g) + (r - b)) / div);

            s = 1 - 3 * Math.Min(r, Math.Min(g, b)); 

            i = RGB / (3.0 * 255); 

            *H = (int)(h * 180 / Math.PI);
            *S = (int)(s * 100);
            *I = (int)(i * 255);
        }
        
        private unsafe void hsiTorgb(int H, int S, int I, int *R, int *G, int *B)
        {
            double r, g, b, h, s, i, x, y, z;

            h = H * pi / 180.0;
            s = S / 100.0;
            i = I / 255.0;
            
            if(h < 2*pi /  3)
            {
                x = i * (1 - s);

                y = i * (1 + s * Math.Cos(h) / Math.Cos(pi / 3 - h));

                z = 3 * i - (x + y);

                b = x;
                r = y;
                g = z;
            }
            else if(2*pi / 3 <= h && h < 4*pi / 3)
            {
                h -= 2 * pi / 3;

                x = i * (1 - s);

                y = i * (1 + s * Math.Cos(h) / Math.Cos(pi / 3 - h));

                z = 3 * i - (x + y);

                r = x;
                g = y;
                b = z;
            }
            else 
            {
                h -= 4 * pi / 3;

                x = i * (1 - s);

                y = i * (1 + s * Math.Cos(h) / Math.Cos(pi / 3 - h));

                z = 3 * i - (x + y);

                g = x;
                b = y;
                r = z;
            }

            r *= 255;
            g *= 255;
            b *= 255;
            r = r > 255 ? 255 : (r < 0 ? 0 : r);
            g = g > 255 ? 255 : (g < 0 ? 0 : g);
            b = b > 255 ? 255 : (b < 0 ? 0 : b);
            *R = (int)r;
            *G = (int)g;
            *B = (int)b;
        }
        
        public void MSI(Bitmap bmpori, Bitmap bmpdst, Bitmap bmpH, Bitmap bmpS, Bitmap bmpI, int H, int S, int I)
        {
            int width = bmpori.Width;
            int height = bmpori.Height;
            BitmapData datadst = bmpdst.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);
            BitmapData dataori = bmpori.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);
            BitmapData dataH = bmpH.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);
            BitmapData dataS = bmpS.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);
            BitmapData dataI = bmpI.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
                PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* dst, ori, ptH, ptS, ptI;
                int h, s, i, r, g, b;

                for (int y = 0; y < height; ++y)
                    for (int x = 0; x < width; ++x)
                    {
                        ori = gotoxy(x, y, dataori);

                        b = *ori;
                        g = *(ori + 1);
                        r = *(ori + 2);
                        rgbTohsi(r, g, b, &h, &s, &i);

                        h += H;
                        if (h < 0) h += 360;
                        h %= 360;

                        s += S;
                        s = s > 100 ? 100 : (s < 0 ? 0 : s);

                        i += I;
                        i = i > 255 ? 255 : (i < 0 ? 0 : i);

                        hsiTorgb(h, s, i, &r, &g, &b);

                        ptH = gotoxy(x, y, dataH);
                        *ptH = *(ptH + 1) = *(ptH + 2) = (byte)((255.0 * h) / 360);

                        ptS = gotoxy(x, y, dataS);
                        *ptS = *(ptS + 1) = *(ptS + 2) = (byte)(((255.0 * s) / 100));

                        ptI = gotoxy(x, y, dataI);
                        *ptI = *(ptI + 1) = *(ptI + 2) = (byte)i;

                        dst = gotoxy(x, y, datadst);
                        *dst = (byte)b;
                        *(dst + 1) = (byte)g;
                        *(dst + 2) = (byte)r;
                    }
            }

            bmpdst.UnlockBits(datadst);
            bmpori.UnlockBits(dataori);
            bmpH.UnlockBits(dataH);
            bmpS.UnlockBits(dataS);
            bmpI.UnlockBits(dataI);
        }

        public void convert_to_grayDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;
            Int32 gs;

            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src++); 
                        g = *(src++);
                        r = *(src++);
                        gs = (Int32)(r * 0.2990 + g * 0.5870 + b * 0.1140);
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                        *(dst++) = (byte)gs;
                    }
                    src += padding;
                    dst += padding;
                }
            }
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }
        
        public void negativoDMA(Bitmap imageBitmapSrc, Bitmap imageBitmapDest)
        {
            int width = imageBitmapSrc.Width;
            int height = imageBitmapSrc.Height;
            int pixelSize = 3;

            BitmapData bitmapDataSrc = imageBitmapSrc.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            BitmapData bitmapDataDst = imageBitmapDest.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int padding = bitmapDataSrc.Stride - (width * pixelSize);

            unsafe
            {
                byte* src1 = (byte*)bitmapDataSrc.Scan0.ToPointer();
                byte* dst = (byte*)bitmapDataDst.Scan0.ToPointer();

                int r, g, b;
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        b = *(src1++); 
                        g = *(src1++);
                        r = *(src1++);

                        *(dst++) = (byte)(255 - b);
                        *(dst++) = (byte)(255 - g);
                        *(dst++) = (byte)(255 - r);
                    }
                    src1 += padding;
                    dst += padding;
                }
            }
            imageBitmapSrc.UnlockBits(bitmapDataSrc);
            imageBitmapDest.UnlockBits(bitmapDataDst);
        }
    }
}
