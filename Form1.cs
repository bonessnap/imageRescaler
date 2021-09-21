using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace imageRescale
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
            this.Text = "Rescaler ver.2.28";
            StartPosition = FormStartPosition.CenterScreen;
            label1.Visible = false;
        }
        Image img; // то, что мы занесём в прогу
        Image finalImg; // то, что мы вертим на хую
        bool trackBarIsMove = false;
        // меняем текст в трекбаре - меняется в текстбоксе = беск. цикл
        // а так если меняем в трекбаре - блокируем цикл
        // кароче надо

        private void buttonLoadImage_Click(object sender, EventArgs e)
        { // кнопка загрузки фотки из буффера
            if (Clipboard.ContainsImage())
            {
                loadImage();
                label1.Text = "Loaded!";
                label1.Visible = true;
                timer1.Start();
            }
            else MessageBox.Show("There is no photo");
        }

        private void loadImage()
        { // загрузка картинки с буфера
            img = Clipboard.GetImage();
            finalImg = img;
            Size s = new Size(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = resizeImage(img, s);
            labelOriginalImgSize.Text = img.Width + "x" + img.Height;
            textBox1.Text = "100";
            textBox1.Enabled = true;
            trackBar1.Enabled = true;
            buttonSaveImage.Enabled = true;
            labelOriginalImgSize.Visible = true;
            buttonInsta50.Enabled = true;
            buttonInsta60.Enabled = true;
            buttonInsta75.Enabled = true;
            buttonInsta80.Enabled = true;
            buttonInsta90.Enabled = true;
        }

        public static Image resizeImage(Image imgToResize, Size size)
        { // возвращает рескейл картинку
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        { // скролл панели
            trackBarIsMove = true;
            textBox1.Text = trackBar1.Value.ToString();
            Size s = new Size((int)(img.Width * trackBar1.Value / 100), (int)(img.Height * trackBar1.Value / 100));
            finalImg = resizeImage(img, s);
            trackBarIsMove = false;
            labelOriginalImgSize.Text = img.Width + "x" + img.Height + " => " + finalImg.Width + "x" + finalImg.Height;
        }

        private void savedText()
        {
            label1.Text = "Saved!";
            labelOriginalImgSize.Text = img.Width + "x" + img.Height + " => " + finalImg.Width + "x" + finalImg.Height;
            label1.Visible = true;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        { // сохранение фотки
            Clipboard.SetImage(finalImg);
            savedText();
        }

        private void button1_Click_1(object sender, EventArgs e)
        { // x0.5
            Size s = new Size((int)(img.Width * 50 / 100), (int)(img.Height * 50 / 100));
            finalImg = resizeImage(img, s);
            Clipboard.SetImage(finalImg);
            savedText();
        }

        private void button2_Click(object sender, EventArgs e)
        {// x0.9
            Size s = new Size((int)(img.Width * 90 / 100), (int)(img.Height * 90 / 100));
            finalImg = resizeImage(img, s);
            Clipboard.SetImage(finalImg);
            savedText();
        }

        private void button3_Click(object sender, EventArgs e)
        {// x0.75
            Size s = new Size((int)(img.Width * 75 / 100), (int)(img.Height * 75 / 100));
            finalImg = resizeImage(img, s);
            Clipboard.SetImage(finalImg);
            savedText();
        }

        private void button4_Click(object sender, EventArgs e)
        {// x0.8
            Size s = new Size((int)(img.Width * 80 / 100), (int)(img.Height * 80 / 100));
            finalImg = resizeImage(img, s);
            Clipboard.SetImage(finalImg);
            savedText();
        }

        private void button5_Click(object sender, EventArgs e)
        {// x0.60
            Size s = new Size((int)(img.Width * 60 / 100), (int)(img.Height * 60 / 100));
            finalImg = resizeImage(img, s);
            Clipboard.SetImage(finalImg);
            savedText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { // если задавать рескейл самому
            if (!trackBarIsMove)
                if (textBox1.Text != "" && Convert.ToInt32(textBox1.Text) > 4 && Convert.ToInt32(textBox1.Text) < 101)
                {
                    trackBar1.Value = Convert.ToInt32(textBox1.Text);
                    setFinalImage();
                }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        { // ввод в текстбокс цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
        private void setFinalImage()
        {
            Size s = new Size((int)(img.Width * trackBar1.Value / 100), (int)(img.Height * trackBar1.Value / 100));
            finalImg = resizeImage(img, s);
            labelOriginalImgSize.Text = img.Width + "x" + img.Height + " => " + finalImg.Width + "x" + finalImg.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer1.Stop();
        }

        private void buttonToLeft_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(trackBar1.Value);
            if(number > 5)
            {
                number--;
                trackBarIsMove = false;
                textBox1.Text = number.ToString();
                trackBar1.Value = number;
                setFinalImage();
                trackBarIsMove = true;
            }
        }

        private void buttonToRight_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(trackBar1.Value);
            if (number < 100)
            {
                number++;
                trackBarIsMove = false;
                textBox1.Text = number.ToString();
                trackBar1.Value = number;
                setFinalImage();
                trackBarIsMove = true;
            }

        }
    }
}
