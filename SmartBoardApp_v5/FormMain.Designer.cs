namespace SmartBoardApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonList = new System.Windows.Forms.ToolStripButton();
            this.buttonOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.buttonBlankPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonPrevPage = new System.Windows.Forms.ToolStripButton();
            this.textBoxPageNumber = new System.Windows.Forms.ToolStripTextBox();
            this.buttonNextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonPencil = new System.Windows.Forms.ToolStripButton();
            this.buttonColor = new System.Windows.Forms.ToolStripButton();
            this.buttonRed = new System.Windows.Forms.ToolStripButton();
            this.buttonGreen = new System.Windows.Forms.ToolStripButton();
            this.buttonBlue = new System.Windows.Forms.ToolStripButton();
            this.comboBoxPencilSize = new System.Windows.Forms.ToolStripComboBox();
            this.buttonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonBigger = new System.Windows.Forms.ToolStripButton();
            this.buttonSmaller = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.buttonRotateImage = new System.Windows.Forms.ToolStripButton();
            this.buttonZoomOut = new System.Windows.Forms.ToolStripButton();
            this.buttonZoomIn = new System.Windows.Forms.ToolStripButton();
            this.buttonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonEraser = new System.Windows.Forms.ToolStripButton();
            this.buttonCopy = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonList,
            this.buttonOpenFolder,
            this.buttonBlankPage,
            this.toolStripSeparator1,
            this.buttonPrevPage,
            this.textBoxPageNumber,
            this.buttonNextPage,
            this.toolStripSeparator2,
            this.buttonPencil,
            this.buttonColor,
            this.buttonRed,
            this.buttonGreen,
            this.buttonBlue,
            this.comboBoxPencilSize,
            this.buttonAbout,
            this.toolStripSeparator3,
            this.buttonBigger,
            this.buttonSmaller,
            this.toolStripSeparator4,
            this.buttonSave,
            this.buttonRotateImage,
            this.buttonZoomOut,
            this.buttonZoomIn,
            this.buttonPaste,
            this.toolStripSeparator8,
            this.buttonEraser,
            this.buttonCopy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonList
            // 
            this.buttonList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonList.Image = ((System.Drawing.Image)(resources.GetObject("buttonList.Image")));
            this.buttonList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(29, 28);
            this.buttonList.Text = "toolStripButton1";
            this.buttonList.ToolTipText = "Show/Hide List";
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonOpenFolder.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFolder.Image")));
            this.buttonOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(29, 28);
            this.buttonOpenFolder.Text = "toolStripButton1";
            this.buttonOpenFolder.ToolTipText = "Open Folder";
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // buttonBlankPage
            // 
            this.buttonBlankPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBlankPage.Image = ((System.Drawing.Image)(resources.GetObject("buttonBlankPage.Image")));
            this.buttonBlankPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBlankPage.Name = "buttonBlankPage";
            this.buttonBlankPage.Size = new System.Drawing.Size(29, 28);
            this.buttonBlankPage.Text = "toolStripButton1";
            this.buttonBlankPage.ToolTipText = "Blank";
            this.buttonBlankPage.Click += new System.EventHandler(this.buttonBlankPage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPrevPage.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrevPage.Image")));
            this.buttonPrevPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(29, 28);
            this.buttonPrevPage.Text = "toolStripButton1";
            this.buttonPrevPage.ToolTipText = "Previous Page";
            this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
            // 
            // textBoxPageNumber
            // 
            this.textBoxPageNumber.Enabled = false;
            this.textBoxPageNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxPageNumber.Name = "textBoxPageNumber";
            this.textBoxPageNumber.Size = new System.Drawing.Size(39, 31);
            this.textBoxPageNumber.Text = "0";
            this.textBoxPageNumber.ToolTipText = "Page Number";
            this.textBoxPageNumber.TextChanged += new System.EventHandler(this.textBoxPageNumber_TextChanged);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonNextPage.Image = ((System.Drawing.Image)(resources.GetObject("buttonNextPage.Image")));
            this.buttonNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(29, 28);
            this.buttonNextPage.Text = "toolStripButton2";
            this.buttonNextPage.ToolTipText = "Next Page";
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // buttonPencil
            // 
            this.buttonPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPencil.Image = ((System.Drawing.Image)(resources.GetObject("buttonPencil.Image")));
            this.buttonPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(29, 28);
            this.buttonPencil.Text = "toolStripButton3";
            this.buttonPencil.ToolTipText = "Pencil";
            // 
            // buttonColor
            // 
            this.buttonColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonColor.Image = ((System.Drawing.Image)(resources.GetObject("buttonColor.Image")));
            this.buttonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(29, 28);
            this.buttonColor.Text = "toolStripButton4";
            this.buttonColor.ToolTipText = "Color Dialog";
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRed.Image = ((System.Drawing.Image)(resources.GetObject("buttonRed.Image")));
            this.buttonRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(29, 28);
            this.buttonRed.Text = "toolStripButton5";
            this.buttonRed.ToolTipText = "Red Pencil";
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonGreen.Image = ((System.Drawing.Image)(resources.GetObject("buttonGreen.Image")));
            this.buttonGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(29, 28);
            this.buttonGreen.Text = "toolStripButton6";
            this.buttonGreen.ToolTipText = "Green Pencil";
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBlue.Image = ((System.Drawing.Image)(resources.GetObject("buttonBlue.Image")));
            this.buttonBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(29, 28);
            this.buttonBlue.Text = "toolStripButton7";
            this.buttonBlue.ToolTipText = "Blue Pencil";
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // comboBoxPencilSize
            // 
            this.comboBoxPencilSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPencilSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28"});
            this.comboBoxPencilSize.Name = "comboBoxPencilSize";
            this.comboBoxPencilSize.Size = new System.Drawing.Size(99, 31);
            this.comboBoxPencilSize.Tag = "";
            this.comboBoxPencilSize.ToolTipText = "Pencil Size";
            this.comboBoxPencilSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxPencilSize_SelectedIndexChanged);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonAbout.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout.Image")));
            this.buttonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(29, 28);
            this.buttonAbout.Text = "toolStripButton1";
            this.buttonAbout.ToolTipText = "About";
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // buttonBigger
            // 
            this.buttonBigger.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonBigger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBigger.Image = ((System.Drawing.Image)(resources.GetObject("buttonBigger.Image")));
            this.buttonBigger.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBigger.Name = "buttonBigger";
            this.buttonBigger.Size = new System.Drawing.Size(29, 28);
            this.buttonBigger.Text = "toolStripButton1";
            this.buttonBigger.ToolTipText = "Big View";
            this.buttonBigger.Click += new System.EventHandler(this.buttonBigger_Click);
            // 
            // buttonSmaller
            // 
            this.buttonSmaller.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonSmaller.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSmaller.Image = ((System.Drawing.Image)(resources.GetObject("buttonSmaller.Image")));
            this.buttonSmaller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSmaller.Name = "buttonSmaller";
            this.buttonSmaller.Size = new System.Drawing.Size(29, 28);
            this.buttonSmaller.Text = "toolStripButton1";
            this.buttonSmaller.ToolTipText = "Small View";
            this.buttonSmaller.Click += new System.EventHandler(this.buttonSmaller_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // buttonSave
            // 
            this.buttonSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(29, 28);
            this.buttonSave.Text = "toolStripButton1";
            this.buttonSave.ToolTipText = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRotateImage
            // 
            this.buttonRotateImage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonRotateImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRotateImage.Image = ((System.Drawing.Image)(resources.GetObject("buttonRotateImage.Image")));
            this.buttonRotateImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRotateImage.Name = "buttonRotateImage";
            this.buttonRotateImage.Size = new System.Drawing.Size(29, 28);
            this.buttonRotateImage.Text = "toolStripButton1";
            this.buttonRotateImage.ToolTipText = "Rotate";
            this.buttonRotateImage.Click += new System.EventHandler(this.buttonRotateImage_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomOut.Image")));
            this.buttonZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(29, 28);
            this.buttonZoomOut.Text = "toolStripButton1";
            this.buttonZoomOut.ToolTipText = "Zoom Out";
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("buttonZoomIn.Image")));
            this.buttonZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(29, 28);
            this.buttonZoomIn.Text = "toolStripButton1";
            this.buttonZoomIn.ToolTipText = "Zoom In";
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPaste.Image = ((System.Drawing.Image)(resources.GetObject("buttonPaste.Image")));
            this.buttonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(29, 28);
            this.buttonPaste.Text = "toolStripButton1";
            this.buttonPaste.ToolTipText = "Paste";
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // buttonEraser
            // 
            this.buttonEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonEraser.Image = ((System.Drawing.Image)(resources.GetObject("buttonEraser.Image")));
            this.buttonEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(29, 28);
            this.buttonEraser.Text = "toolStripButton1";
            this.buttonEraser.ToolTipText = "Eraser";
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCopy.Image = ((System.Drawing.Image)(resources.GetObject("buttonCopy.Image")));
            this.buttonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(29, 28);
            this.buttonCopy.Text = "toolStripButton1";
            this.buttonCopy.ToolTipText = "Copy";
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1350, 699);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1800, 867);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(5, 5);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 484);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select Folder";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1800, 898);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Smart Board App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonOpenFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton buttonPencil;
        private System.Windows.Forms.ToolStripButton buttonColor;
        private System.Windows.Forms.ToolStripButton buttonRed;
        private System.Windows.Forms.ToolStripButton buttonGreen;
        private System.Windows.Forms.ToolStripButton buttonBlue;
        private System.Windows.Forms.ToolStripButton buttonAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton buttonBigger;
        private System.Windows.Forms.ToolStripButton buttonSmaller;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton buttonSave;
        private System.Windows.Forms.ToolStripButton buttonBlankPage;
        private System.Windows.Forms.ToolStripButton buttonPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton buttonEraser;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripComboBox comboBoxPencilSize;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripButton buttonList;
        public System.Windows.Forms.ToolStripButton buttonRotateImage;
        public System.Windows.Forms.ToolStripButton buttonZoomOut;
        public System.Windows.Forms.ToolStripButton buttonZoomIn;
        public System.Windows.Forms.ToolStripButton buttonCopy;
        public System.Windows.Forms.ToolStripButton buttonPrevPage;
        public System.Windows.Forms.ToolStripTextBox textBoxPageNumber;
        public System.Windows.Forms.ToolStripButton buttonNextPage;
    }
}

