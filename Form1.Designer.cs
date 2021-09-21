namespace imageRescale
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.buttonInsta50 = new System.Windows.Forms.Button();
            this.buttonInsta90 = new System.Windows.Forms.Button();
            this.buttonInsta75 = new System.Windows.Forms.Button();
            this.buttonInsta80 = new System.Windows.Forms.Button();
            this.buttonInsta60 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelOriginalImgSize = new System.Windows.Forms.Label();
            this.buttonToLeft = new System.Windows.Forms.Button();
            this.buttonToRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(12, 81);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(100, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Enabled = false;
            this.buttonSaveImage.Location = new System.Drawing.Point(12, 142);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(100, 37);
            this.buttonSaveImage.TabIndex = 5;
            this.buttonSaveImage.Text = "Save";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(100, 37);
            this.buttonLoadImage.TabIndex = 6;
            this.buttonLoadImage.Text = "Load";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // buttonInsta50
            // 
            this.buttonInsta50.Enabled = false;
            this.buttonInsta50.Location = new System.Drawing.Point(118, 125);
            this.buttonInsta50.Name = "buttonInsta50";
            this.buttonInsta50.Size = new System.Drawing.Size(44, 22);
            this.buttonInsta50.TabIndex = 7;
            this.buttonInsta50.Text = "x0.5";
            this.buttonInsta50.UseVisualStyleBackColor = true;
            this.buttonInsta50.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonInsta90
            // 
            this.buttonInsta90.Enabled = false;
            this.buttonInsta90.Location = new System.Drawing.Point(119, 12);
            this.buttonInsta90.Name = "buttonInsta90";
            this.buttonInsta90.Size = new System.Drawing.Size(44, 22);
            this.buttonInsta90.TabIndex = 8;
            this.buttonInsta90.Text = "x0,9";
            this.buttonInsta90.UseVisualStyleBackColor = true;
            this.buttonInsta90.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonInsta75
            // 
            this.buttonInsta75.Enabled = false;
            this.buttonInsta75.Location = new System.Drawing.Point(118, 68);
            this.buttonInsta75.Name = "buttonInsta75";
            this.buttonInsta75.Size = new System.Drawing.Size(44, 22);
            this.buttonInsta75.TabIndex = 9;
            this.buttonInsta75.Text = "x0,75";
            this.buttonInsta75.UseVisualStyleBackColor = true;
            this.buttonInsta75.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonInsta80
            // 
            this.buttonInsta80.Enabled = false;
            this.buttonInsta80.Location = new System.Drawing.Point(118, 40);
            this.buttonInsta80.Name = "buttonInsta80";
            this.buttonInsta80.Size = new System.Drawing.Size(44, 22);
            this.buttonInsta80.TabIndex = 10;
            this.buttonInsta80.Text = "x0,8";
            this.buttonInsta80.UseVisualStyleBackColor = true;
            this.buttonInsta80.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonInsta60
            // 
            this.buttonInsta60.Enabled = false;
            this.buttonInsta60.Location = new System.Drawing.Point(119, 96);
            this.buttonInsta60.Name = "buttonInsta60";
            this.buttonInsta60.Size = new System.Drawing.Size(44, 22);
            this.buttonInsta60.TabIndex = 11;
            this.buttonInsta60.Text = "x0,60";
            this.buttonInsta60.UseVisualStyleBackColor = true;
            this.buttonInsta60.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Saved!";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(169, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 115);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelOriginalImgSize
            // 
            this.labelOriginalImgSize.AutoSize = true;
            this.labelOriginalImgSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOriginalImgSize.Location = new System.Drawing.Point(165, 158);
            this.labelOriginalImgSize.Name = "labelOriginalImgSize";
            this.labelOriginalImgSize.Size = new System.Drawing.Size(60, 24);
            this.labelOriginalImgSize.TabIndex = 14;
            this.labelOriginalImgSize.Text = "label2";
            this.labelOriginalImgSize.Visible = false;
            // 
            // buttonToLeft
            // 
            this.buttonToLeft.Location = new System.Drawing.Point(12, 113);
            this.buttonToLeft.Name = "buttonToLeft";
            this.buttonToLeft.Size = new System.Drawing.Size(28, 23);
            this.buttonToLeft.TabIndex = 15;
            this.buttonToLeft.Text = "<";
            this.buttonToLeft.UseVisualStyleBackColor = true;
            this.buttonToLeft.Click += new System.EventHandler(this.buttonToLeft_Click);
            // 
            // buttonToRight
            // 
            this.buttonToRight.Location = new System.Drawing.Point(84, 113);
            this.buttonToRight.Name = "buttonToRight";
            this.buttonToRight.Size = new System.Drawing.Size(28, 23);
            this.buttonToRight.TabIndex = 16;
            this.buttonToRight.Text = ">";
            this.buttonToRight.UseVisualStyleBackColor = true;
            this.buttonToRight.Click += new System.EventHandler(this.buttonToRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 185);
            this.Controls.Add(this.buttonToRight);
            this.Controls.Add(this.buttonToLeft);
            this.Controls.Add(this.labelOriginalImgSize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInsta60);
            this.Controls.Add(this.buttonInsta80);
            this.Controls.Add(this.buttonInsta75);
            this.Controls.Add(this.buttonInsta90);
            this.Controls.Add(this.buttonInsta50);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.Button buttonInsta50;
        private System.Windows.Forms.Button buttonInsta90;
        private System.Windows.Forms.Button buttonInsta75;
        private System.Windows.Forms.Button buttonInsta80;
        private System.Windows.Forms.Button buttonInsta60;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelOriginalImgSize;
        private System.Windows.Forms.Button buttonToLeft;
        private System.Windows.Forms.Button buttonToRight;
    }
}

