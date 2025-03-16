using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageEnhancer
{
    public partial class ImageEnhancer : Form
    {
        public ImageEnhancer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void enhancedImage_Click(object sender, EventArgs e)
        {

        }
    }
}
