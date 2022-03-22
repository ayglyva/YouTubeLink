using MediaToolkit;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using VideoLibrary;

namespace YouTubeLink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private  void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Faylın yerini seçin z/o" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                   
                    MessageBox.Show("Video yüklənir..", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    YouTube yt = YouTube.Default;
                    Video video =  yt.GetVideo(link.Text);
                    File.WriteAllBytes(fbd.SelectedPath + @"\" + video.FullName,  video.GetBytes());
                   
                    MessageBox.Show("Video yükləndi.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Faylın yeri seçilmədi!", "Xəta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Mp3_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void Mp4_CheckedChanged(object sender, EventArgs e)
        {
            
        }
      

    }
}
