using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace imageEnhancer
{
    public partial class ImageEnhancer : Form
    {
        public ImageEnhancer()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar1.Value.ToString();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar2.Value.ToString();

        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label8.Text = trackBar3.Value.ToString();
        }
        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label9.Text = trackBar4.Value.ToString();
        }
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label10.Text = trackBar5.Value.ToString();
        }
        private void imageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog james = new OpenFileDialog())
            {
                if(james.ShowDialog() == DialogResult.OK)
                {
                    imageBox.Image = new Bitmap(james.FileName);
                }
            }
        }
        //gikapoy kog balik balik sa code so ga gama kog shortcut na function, dinalian man so wala na nako gi pikas class
        public static (int, int, int) Checker(int newR, int newG, int newB)
        {
            //values na gi butangan ug min max
            newR = Math.Min(255, Math.Max(0, newR));
            newG = Math.Min(255, Math.Max(0, newG));
            newB = Math.Min(255, Math.Max(0, newB));
            //values na i hatag, karon pa ni nako na discover na pwede multiple returns, lamat chatgpt sa idea  
            return (newR, newG, newB);
        }
        public static (float, float, float) Checker(float newR, float newG, float newB)
        {
            //values na gi butangan ug min max
            newR = Math.Min(255, Math.Max(0, newR));
            newG = Math.Min(255, Math.Max(0, newG));
            newB = Math.Min(255, Math.Max(0, newB));
            //values na i hatag, karon pa ni nako na discover na pwede multiple returns, lamat chatgpt sa idea  
            return (newR, newG, newB);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int opacityValue = trackBar1.Value;
            int brightnessValue = trackBar2.Value;
            float contrastValue = trackBar3.Value / 100f;
            if (contrastValue < 1)
            {
                contrastValue = 1;
            }
            int saturationValue = trackBar4.Value;
            int blurValue = trackBar5.Value;
            //libog gamay at first kay ma override ang uban function, gi huna huna pa nakog maayo
            Bitmap imageHolder = new Bitmap(imageBox.Image);
            Bitmap imageWithBlur = blurAdjuster(imageHolder, blurValue);
            Bitmap imageWithSaturation = saturationAdjuster(imageWithBlur, saturationValue);
            Bitmap imageWithContrast = contrastAdjuster(imageWithSaturation, contrastValue);
            Bitmap imageWithBrightness = brightnessAdjuster(imageWithContrast, brightnessValue);
            Bitmap imageWithOpacity = opacityAdjuster(imageWithBrightness, opacityValue);


            enhancedImage.Image = imageWithOpacity;
        }
        public static Bitmap opacityAdjuster(Bitmap bmp, int alphaValue)
        {
            int rows, cols;
            for (rows = 0; rows < bmp.Height; rows++)
            {
                for (cols = 0; cols < bmp.Width; cols++)
                {
                    Color newColor = bmp.GetPixel(cols, rows);
                    //bago pako kahibaw na naa diay alpha, change the alpha value for opacity
                    Color opacityChange = Color.FromArgb(alphaValue, newColor.R, newColor.G, newColor.B);
                    bmp.SetPixel(cols, rows, opacityChange);
                }
            }
            return bmp;
        }
        
        public static Bitmap brightnessAdjuster(Bitmap bmpBrightness, int brightValue)
        {
            int rows, cols;
            
            for(rows=0; rows < bmpBrightness.Width;rows++)
            {
                for(cols=0; cols < bmpBrightness.Height;cols++)
                {
                    //funny kaayo ang solution, add ra diay para mo mas duol sa 255(white)
                    //additional note: ayaw pag chat gpt kay hsl gihatag, ga lisod lisod
                    Color currentColor = bmpBrightness.GetPixel(rows, cols);
                    int newR = currentColor.R + (brightValue);
                    int newG = currentColor.G + (brightValue);
                    int newB = currentColor.B + (brightValue);
                    (newR, newG, newB) = Checker(newR, newG, newB);
                    Color newColor = Color.FromArgb(newR, newG, newB);
                    bmpBrightness.SetPixel(rows, cols, newColor); ;
                    
                }
            }
            
            return bmpBrightness;
        }
        public static Bitmap contrastAdjuster(Bitmap bmpContrast, float contValue)
        {
            int rows, cols;
           
            for (rows = 0; rows < bmpContrast.Height; rows++)
            {
                for (cols = 0; cols < bmpContrast.Width; cols++)
                {
                    Color newColor = bmpContrast.GetPixel(cols, rows);
                    
                    //formula found online, basta subtract current color by half of 255 and multiply by contrast plus half of 255 again
                    int newR = (int)((newColor.R - (255/2)) * contValue + (255/2));
                    newR = Math.Min(255, Math.Max(0, newR));
                    int newG = (int)((newColor.G - (255 / 2)) * contValue + (255 / 2));
                    newG = Math.Min(255, Math.Max(0, newG));
                    int newB = (int)((newColor.B - (255 / 2)) * contValue + (255 / 2));
                    newB = Math.Min(255, Math.Max(0, newB));

                    bmpContrast.SetPixel(cols, rows, Color.FromArgb(newR, newG, newB));
                }
            }
            return bmpContrast;
        }
        public static Bitmap saturationAdjuster(Bitmap bmpSaturation, float satValue)
        {
            if (satValue == 0)
            {
                return bmpSaturation;
            }
            int rows, cols;
            for (rows = 0; rows < bmpSaturation.Height; rows++)
            {
                for(cols = 0;cols < bmpSaturation.Width; cols++)
                {
                    Color newColor = bmpSaturation.GetPixel(cols, rows);
                    int newR = newColor.R;
                    int newG = newColor.G;
                    int newB = newColor.B;
                    float greyLuminance = 0.3f * newColor.R + 0.59f * newColor.G + 0.11f * newColor.B;
                    newR = (int)(greyLuminance + (newR - greyLuminance) * satValue);
                    newG = (int)(greyLuminance + (newG - greyLuminance) * satValue);
                    newB = (int)(greyLuminance + (newB - greyLuminance) * satValue);
                    //laziness by jems
                    (newR, newG, newB) = Checker(newR, newG, newB);

                    Color newColor1 = Color.FromArgb(newR, newG, newB);
                    bmpSaturation.SetPixel(cols, rows, newColor1); ;
                }
            }
            return bmpSaturation;
        }
        public static Bitmap blurAdjuster(Bitmap bmpBlur, int blurValue)
        {
            if (blurValue == 0)
            {
                return bmpBlur;
            }
            int rows, cols;
            for (rows = 1; rows < bmpBlur.Height-1; rows++)
            {
                for (cols = 1; cols < bmpBlur.Width-1; cols++)
                {
                    float[,] matrixData = new float[3,3]
                    {
                        { 0.0625f, 0.125f, 0.0625f },
                        { 0.125f, 0.25f, 0.125f },
                        { 0.0625f, 0.125f, 0.0625f }
                    };
                    float newR = 0;
                    float newG = 0;
                    float newB = 0;

                    for (int kernelRow = -1; kernelRow <= 1; kernelRow++)
                    {
                        for (int kernelCol = -1; kernelCol <= 1; kernelCol++)
                        {
                            Color pixelColor = bmpBlur.GetPixel(cols + kernelCol, rows + kernelRow);
                            float kernelValue = matrixData[kernelRow + 1, kernelCol + 1];

                            newR += (pixelColor.R * kernelValue);
                            newG += (pixelColor.G * kernelValue);
                            newB += (pixelColor.B * kernelValue);
                        }
                        (newR, newG, newB) = Checker(newR, newG, newB);

                        bmpBlur.SetPixel(cols, rows, Color.FromArgb((int)newR, (int)newG, (int)newB));
                    }
                }
            }
            return bmpBlur;
        }

    }
}
