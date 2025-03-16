namespace imageEnhancer
{
    partial class ImageEnhancer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.enhancedImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enhancedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.Location = new System.Drawing.Point(81, 60);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(445, 491);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 1;
            this.imageBox.TabStop = false;
            // 
            // enhancedImage
            // 
            this.enhancedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enhancedImage.Location = new System.Drawing.Point(621, 60);
            this.enhancedImage.Name = "enhancedImage";
            this.enhancedImage.Size = new System.Drawing.Size(469, 491);
            this.enhancedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enhancedImage.TabIndex = 2;
            this.enhancedImage.TabStop = false;
            this.enhancedImage.Click += new System.EventHandler(this.enhancedImage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1214, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 70);
            this.button1.TabIndex = 3;
            this.button1.Text = "adjust";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1162, 95);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(294, 69);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1162, 180);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(294, 69);
            this.trackBar2.TabIndex = 5;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(1162, 255);
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(294, 69);
            this.trackBar3.TabIndex = 6;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(1162, 330);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(294, 69);
            this.trackBar4.TabIndex = 7;
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(1162, 405);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(294, 69);
            this.trackBar5.TabIndex = 8;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar5_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1139, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "opacity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1139, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "brightness";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1139, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "contrast";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1139, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "saturation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1139, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "blur";
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(205, 583);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(157, 70);
            this.imageButton.TabIndex = 14;
            this.imageButton.Text = "upload image";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // ImageEnhancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 704);
            this.ControlBox = false;
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.enhancedImage);
            this.Controls.Add(this.imageBox);
            this.Name = "ImageEnhancer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Enhancer";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enhancedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.PictureBox enhancedImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button imageButton;
    }
}

