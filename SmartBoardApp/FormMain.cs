using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Expression.Encoder;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.ScreenCapture;
using System.Collections.ObjectModel;
using System.Linq;

namespace SmartBoardApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        Graphics line;
        Point point1;
        Point point2;
        bool draw = false;
        Pen pencil = new Pen(Color.Red, 3);
        Color CurrentColour = Color.Red;
        float CurrentWidth = 3;

        private void Form1_Load(object sender, EventArgs e)
        {
            TransparencyKey = SystemColors.InactiveCaptionText;
            pictureBox1.BackColor = SystemColors.InactiveCaptionText;

            comboBoxPencilSize.SelectedIndex = 2;

            listBox1.Visible = false;
            
            buttonPrevPage.Enabled = false;
            buttonNextPage.Enabled = false;
            buttonCopy.Enabled = false;
            buttonZoomIn.Enabled = false;
            buttonZoomOut.Enabled = false;
            buttonRotateImage.Enabled = false;
            buttonSmaller.Enabled = false;

            buttonPauseResumeRecord.Enabled = false;

            panel1.AutoScroll = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            FormMain main = new FormMain();
            panel1.Size = new Size(main.Size.Width, main.Size.Height);
            pictureBox1.Size = new Size(panel1.Size.Width, panel1.Size.Height);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            line = CreateGraphics();
            point1 = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw == true)
            {
                line = pictureBox1.CreateGraphics();
                line.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                pencil.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                point2 = new Point(e.X, e.Y);
                line.DrawLine(pencil, point1, point2);
                point1 = point2;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            line = pictureBox1.CreateGraphics();
            line = e.Graphics;
            line.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pencil.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = null;
                listBox1.Items.Clear();

                DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] files = directoryInfo.GetFiles("*.jpg");
                foreach (FileInfo file in files)
                {
                    string[] myStrings = new string[] { file.Name };

                    foreach (string s in myStrings)
                    {
                        listBox1.Items.Add(s);
                    }
                }

                pictureBox1.ImageLocation = folderBrowserDialog1.SelectedPath + "\\" + listBox1.Items[0].ToString();
                textBoxPageNumber.Text = "0";
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }

            if (Convert.ToInt16(textBoxPageNumber.Text) == 0)
            {
                buttonPrevPage.Enabled = false;
            }
            else
            {
                buttonPrevPage.Enabled = true;
            }
            if (Convert.ToInt16(textBoxPageNumber.Text) == listBox1.Items.Count - 1)
            {
                buttonNextPage.Enabled = false;
            }
            else
            {
                buttonNextPage.Enabled = true;
            }
            
            buttonCopy.Enabled = true;
            buttonZoomIn.Enabled = true;
            buttonZoomOut.Enabled = true;
            buttonRotateImage.Enabled = true;
        }

        bool openClose = true;
        private void buttonList_Click(object sender, EventArgs e)
        {
            if (openClose)
            {
                listBox1.Visible = true;
                openClose = !openClose;
            }
            else
            {
                listBox1.Visible = false;
                openClose = !openClose;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = folderBrowserDialog1.SelectedPath + "\\" + listBox1.GetItemText(listBox1.SelectedItem);
            textBoxPageNumber.Text = listBox1.SelectedIndex.ToString();
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            textBoxPageNumber.Text = (Convert.ToInt16(textBoxPageNumber.Text) - 1).ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            textBoxPageNumber.Text = (Convert.ToInt16(textBoxPageNumber.Text) + 1).ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                CurrentColour = colorDialog1.Color;
                pencil = new Pen(CurrentColour, CurrentWidth);
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            CurrentColour = Color.Red;
            pencil = new Pen(CurrentColour, CurrentWidth);
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            CurrentColour = Color.Green;
            pencil = new Pen(CurrentColour, CurrentWidth);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            CurrentColour = Color.Blue;
            pencil = new Pen(CurrentColour, CurrentWidth);
        }

        private void comboBoxPencilSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentWidth = Convert.ToSingle(comboBoxPencilSize.Text);
            pencil = new Pen(CurrentColour, CurrentWidth);
        }

        private void buttonEraser_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Bitmap))
            {
                pictureBox1.Image = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(pictureBox1.Image, true);
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = pictureBox1.Height * 2;
            pictureBox1.Width = pictureBox1.Width * 2;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = pictureBox1.Height / 2;
            pictureBox1.Width = pictureBox1.Width / 2;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonRotateImage_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void buttonBlankPage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            listBox1.Items.Clear();

            folderBrowserDialog1.SelectedPath = Application.StartupPath;
            listBox1.Items.Add("blank.jpg");

            pictureBox1.ImageLocation = @"blank.jpg";
            textBoxPageNumber.Text = "0";
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            buttonPrevPage.Enabled = false;
            buttonNextPage.Enabled = false;
            
            buttonCopy.Enabled = true;
            buttonZoomIn.Enabled = true;
            buttonZoomOut.Enabled = true;
            buttonRotateImage.Enabled = true;
        }

        private void textBoxPageNumber_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = folderBrowserDialog1.SelectedPath + "\\" + listBox1.Items[Convert.ToInt16(textBoxPageNumber.Text)].ToString();

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            if (Convert.ToInt16(textBoxPageNumber.Text) == 0)
            {
                buttonPrevPage.Enabled = false;
            }
            else
            {
                buttonPrevPage.Enabled = true;
            }
            if (Convert.ToInt16(textBoxPageNumber.Text) == listBox1.Items.Count - 1)
            {
                buttonNextPage.Enabled = false;
            }
            else
            {
                buttonNextPage.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPEG|*.jpg;*.jpeg;*.jpe;*.jfif";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.FileName = "Untitled";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int width = pictureBox1.Size.Width;
                int height = pictureBox1.Size.Height;

                Bitmap bm = new Bitmap(width, height);
                pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, width, height));

                bm.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void buttonSmaller_Click(object sender, EventArgs e)
        {
            TransparencyKey = SystemColors.InactiveCaptionText;
            pictureBox1.BackColor = SystemColors.InactiveCaptionText;
            TopMost = false;

            listBox1.Items.Clear();
            
            buttonPrevPage.Enabled = false;
            buttonNextPage.Enabled = false;
            buttonCopy.Enabled = false;
            buttonZoomIn.Enabled = false;
            buttonZoomOut.Enabled = false;
            buttonRotateImage.Enabled = false;

            buttonSmaller.Enabled = false;
            buttonBigger.Enabled = true;

            panel1.AutoScroll = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            FormMain form1 = new FormMain();
            panel1.Size = new Size(form1.Size.Width, form1.Size.Height);
            pictureBox1.Size = new Size(panel1.Size.Width, panel1.Size.Height);
        }

        private void buttonBigger_Click(object sender, EventArgs e)
        {
            TransparencyKey = SystemColors.WindowFrame;
            pictureBox1.BackColor = SystemColors.WindowFrame;
            TopMost = true;
            pictureBox1.Image = null;
            
            buttonPrevPage.Enabled = false;
            buttonNextPage.Enabled = false;
            buttonCopy.Enabled = false;
            buttonZoomIn.Enabled = false;
            buttonZoomOut.Enabled = false;
            buttonRotateImage.Enabled = false;

            buttonSmaller.Enabled = true;
            buttonBigger.Enabled = false;

            panel1.AutoScroll = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            FormMain form1 = new FormMain();
            panel1.Size = new Size(form1.Size.Width, form1.Size.Height);
            pictureBox1.Size = new Size(panel1.Size.Width, panel1.Size.Height);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private ScreenCaptureJob job = new ScreenCaptureJob();
        private Job j = new Job();
        private void buttonStartStopRecord_Click(object sender, EventArgs e)
        {
            if (job.Status == RecordStatus.Running || job.Status == RecordStatus.Paused)
            {
                buttonPauseResumeRecord.Enabled = false;
                buttonPauseResumeRecord.Image = Image.FromFile(Application.StartupPath + "\\pause.png");

                job.Stop();
                buttonStartStopRecord.Image = Image.FromFile(Application.StartupPath + "\\wait.png");
                if (job.Status != RecordStatus.Running)
                {
                    Encode();
                }
                buttonStartStopRecord.Image = Image.FromFile(Application.StartupPath + "\\start.png");
            }
            else
            {
                StartRecording();
            }
        }

        private void StartRecording()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonPauseResumeRecord.Enabled = true;
                toolStripLabel1.Text = "   ";

                buttonStartStopRecord.Image = Image.FromFile(Application.StartupPath + "\\stop.png");


                job = new ScreenCaptureJob();

                Size workingArea = SystemInformation.WorkingArea.Size;
                //Size workingArea = SystemInformation.PrimaryMonitorSize; //Full Screen
                Rectangle captureRect = new Rectangle(0, 0, workingArea.Width - (workingArea.Width % 4), workingArea.Height - (workingArea.Height % 4));
                job.CaptureRectangle = captureRect;

                //Properties
                job.ScreenCaptureVideoProfile.FrameRate = 60;
                job.ScreenCaptureVideoProfile.Quality = 100;
                job.ScreenCaptureVideoProfile.SmoothStreaming = true;
                job.CaptureMouseCursor = true;
                job.ShowCountdown = true;
                job.ShowFlashingBoundary = true;

                job.AddAudioDeviceSource(AudioDevices());

                job.OutputPath = folderBrowserDialog1.SelectedPath + "\\";
                job.OutputScreenCaptureFileName = job.OutputPath + "ScreenCapture_" + DateTime.Today.ToString("MM-dd-yyyy ") + DateTime.Now.ToString("h.mm.ss tt") + ".xesc";

                job.Start();
            }
        }

        private EncoderDevice AudioDevices()
        {
            EncoderDevice foundDevice = null;
            Collection<EncoderDevice> audioDevices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
            try
            {
                foundDevice = audioDevices.FirstOrDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No audio device is found" + audioDevices[0].Name + ex.Message);
            }
            return foundDevice;
        }

        void Encode()
        {
            using (j = new Job())
            {
                MediaItem mediaItem = new MediaItem(job.OutputScreenCaptureFileName);
                var size = mediaItem.OriginalVideoSize;
                WindowsMediaOutputFormat format = new WindowsMediaOutputFormat();
                format.VideoProfile = new Microsoft.Expression.Encoder.Profiles.AdvancedVC1VideoProfile();
                format.AudioProfile = new Microsoft.Expression.Encoder.Profiles.WmaAudioProfile();
                format.VideoProfile.AspectRatio = new System.Windows.Size(16, 9);
                format.VideoProfile.AutoFit = true;
                if (size.Width > 1920 && size.Height > 1080)
                {
                    format.VideoProfile.Size = new Size(1920, 1080);
                    format.VideoProfile.Bitrate = new Microsoft.Expression.Encoder.Profiles.VariableUnconstrainedBitrate(6000);
                }
                else if (size.Width > 1280 && size.Height > 720)
                {
                    format.VideoProfile.Size = new Size(1280, 720);
                    format.VideoProfile.Bitrate = new Microsoft.Expression.Encoder.Profiles.VariableUnconstrainedBitrate(4000);
                }
                else
                {
                    format.VideoProfile.Size = new Size(size.Width, Size.Height);
                    format.VideoProfile.Bitrate = new Microsoft.Expression.Encoder.Profiles.VariableUnconstrainedBitrate(2000);
                }

                mediaItem.VideoResizeMode = VideoResizeMode.Letterbox;
                mediaItem.OutputFormat = format;
                j.MediaItems.Add(mediaItem);
                j.CreateSubfolder = false;
                j.OutputDirectory = folderBrowserDialog1.SelectedPath;
                j.EncodeProgress += new EventHandler<EncodeProgressEventArgs>(j_encodeProgress);
                j.Encode();
            }
        }

        private void j_encodeProgress(object sender, EncodeProgressEventArgs e)
        {
            string status = string.Format("{0:F1}%", e.Progress);
            toolStripLabel1.Text = e.CurrentPass + "/2 " + status;
            Refresh();
        }

        private void buttonPauseResumeRecord_Click(object sender, EventArgs e)
        {
            if (job.Status == RecordStatus.Paused)
            {
                job.Resume();
                buttonPauseResumeRecord.Image = Image.FromFile(Application.StartupPath + "\\pause.png");
            }
            else
            {
                job.Pause();
                buttonPauseResumeRecord.Image = Image.FromFile(Application.StartupPath + "\\resume.png");
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (job != null)
            {
                if (job.Status == RecordStatus.Running)
                {
                    job.Stop();
                }
                job.Dispose();
            }
        }
    }
}