using System;
using System.Windows.Forms;
using ThumbnailLib;

namespace FormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(new MimeTypeDisplay("Audio", "audio/mp3"));
            comboBox1.Items.Add(new MimeTypeDisplay("Image", "image/jpeg"));
            comboBox1.Items.Add(new MimeTypeDisplay("Video", "video/mp4"));
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public class MimeTypeDisplay
        {
            public string DisplayName { get; private set; }
            public string MimeType { get; private set; }

            public MimeTypeDisplay(string displayName, string mimeType)
            {
                DisplayName = displayName;
                MimeType = mimeType;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var mimeType = ((MimeTypeDisplay)comboBox1.SelectedItem).MimeType;

            var mediaInfo = new MediaInfo("Some file name", mimeType, null);

            ThumbnailerBase thumbnailer = ThumbnailerFactory.CreateThumbnailer(mediaInfo.MimeType);
            pictureBox1.Image = thumbnailer.GetThumbnail(mediaInfo);

        }
    }
}
