using System;
using System.Drawing;
using System.Windows.Forms;

namespace KolmVormid
{
    public partial class Vorm1 : Form
    {
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button showButton;
        private Button clearButton;
        private Button backgroundButton;
        private Button closeButton;
        private Button resizeButton;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Image _originalImage;
        private Button rotateButton;
        private Button pixelateButton;

        public Vorm1()
        {
            InitializeComponent();
            Text = "MainForm";
        }

        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pixelateButton = new Button();
            showButton = new Button();
            clearButton = new Button();
            backgroundButton = new Button();
            resizeButton = new Button();
            closeButton = new Button();
            rotateButton = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();

            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();

            // tableLayoutPanel1
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(784, 561);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;

            // pictureBox1
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(778, 498);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            // flowLayoutPanel1
            flowLayoutPanel1.Controls.Add(pixelateButton);
            flowLayoutPanel1.Controls.Add(showButton);
            flowLayoutPanel1.Controls.Add(clearButton);
            flowLayoutPanel1.Controls.Add(backgroundButton);
            flowLayoutPanel1.Controls.Add(resizeButton);
            flowLayoutPanel1.Controls.Add(closeButton);
            flowLayoutPanel1.Controls.Add(rotateButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(120, 507);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(661, 51);
            flowLayoutPanel1.TabIndex = 2;

            // pixelateButton
            pixelateButton.Location = new Point(583, 3);
            pixelateButton.Name = "pixelateButton";
            pixelateButton.Size = new Size(75, 23);
            pixelateButton.TabIndex = 6;
            pixelateButton.Text = "Pixelate";
            pixelateButton.UseVisualStyleBackColor = true;
            pixelateButton.Click += pixelateButton_Click;

            // showButton
            showButton.AutoSize = true;
            showButton.Location = new Point(489, 3);
            showButton.Name = "showButton";
            showButton.Size = new Size(88, 23);
            showButton.TabIndex = 0;
            showButton.Text = "Show a picture";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;

            // clearButton
            clearButton.AutoSize = true;
            clearButton.Location = new Point(389, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 23);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear the picture";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;

            // backgroundButton
            backgroundButton.AutoSize = true;
            backgroundButton.Location = new Point(246, 3);
            backgroundButton.Name = "backgroundButton";
            backgroundButton.Size = new Size(137, 23);
            backgroundButton.TabIndex = 2;
            backgroundButton.Text = "Set the background color";
            backgroundButton.UseVisualStyleBackColor = true;
            backgroundButton.Click += backgroundButton_Click;

            // resizeButton
            resizeButton.AutoSize = true;
            resizeButton.Location = new Point(165, 3);
            resizeButton.Name = "resizeButton";
            resizeButton.Size = new Size(75, 23);
            resizeButton.TabIndex = 4;
            resizeButton.Text = "Resize 50%";
            resizeButton.UseVisualStyleBackColor = true;
            resizeButton.Click += resizeButton_Click;

            // closeButton
            closeButton.AutoSize = true;
            closeButton.Location = new Point(84, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 3;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;

            // rotateButton
            rotateButton.Location = new Point(3, 3);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(75, 23);
            rotateButton.TabIndex = 5;
            rotateButton.Text = "Rotate";
            rotateButton.Click += rotateButton_Click;

            // flowLayoutPanel2
            flowLayoutPanel2.Controls.Add(checkBox1);
            flowLayoutPanel2.Controls.Add(checkBox2);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 507);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(111, 51);
            flowLayoutPanel2.TabIndex = 3;

            // checkBox1
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 17);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Stretch";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;

            // checkBox2
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 26);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(48, 17);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Filter";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;

            // openFileDialog1
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "All files (*.*)|*.*|JPEG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp";
            openFileDialog1.Title = "Select a picture file";

            // Vorm1
            ClientSize = new Size(784, 561);
            Controls.Add(tableLayoutPanel1);
            Name = "Vorm1";

            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var loadedImage = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = loadedImage;
                _originalImage = loadedImage;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            _originalImage = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = checkBox1.Checked ? PictureBoxSizeMode.StretchImage : PictureBoxSizeMode.Normal;
        }

        //filter
        private Image ApplyFilter(Image image)
        {
            var newImage = new Bitmap(image);
            for (int x = 0; x < newImage.Width; x++)
            {
                for (int y = 0; y < newImage.Height; y++)
                {
                    var originalColor = newImage.GetPixel(x, y);
                    int red = (int)(originalColor.R * 0.6);
                    int green = (int)(originalColor.G * 0.9);
                    int blue = (int)(originalColor.B * 0.2);
                    var filter = Color.FromArgb(red, green, blue);
                    newImage.SetPixel(x, y, filter);
                }
            }
            return newImage;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            if (checkBox2.Checked)
                pictureBox1.Image = ApplyFilter(pictureBox1.Image);
            else
                pictureBox1.Image = _originalImage;
        }


        //resize
        private bool isResized = false;
        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            if (!isResized)
            {
                int newWidth = _originalImage.Width / 2;
                int newHeight = _originalImage.Height / 2;
                pictureBox1.Image = new Bitmap(_originalImage, newWidth, newHeight);
                isResized = true;
                resizeButton.Text = "Resize 100%";
            }
            else
            {
                pictureBox1.Image = new Bitmap(_originalImage);
                isResized = false;
                resizeButton.Text = "Resize 50%";
            }
        }


        //rotate
        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Refresh();
        }


        //pixelate
        private bool isPixelated = false;
        private void pixelateButton_Click(object sender, EventArgs e)
        {
            if (_originalImage == null) return;

            if (!isPixelated)
            {
                int pixelationSize = 64;
                pictureBox1.Image = PixelateImage(_originalImage, pixelationSize);
                isPixelated = true;
                pixelateButton.Text = "Remove Pixelation";
            }
            else
            {
                pictureBox1.Image = new Bitmap(_originalImage);
                isPixelated = false;
                pixelateButton.Text = "Pixelate";
            }
        }

        private Image PixelateImage(Image original, int pixelationSize)
        {
            if (original == null) return null;

            Bitmap small = new Bitmap(pixelationSize, pixelationSize);

            using (Graphics g = Graphics.FromImage(small))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(original, 0, 0, pixelationSize, pixelationSize);
            }

            Bitmap pixelated = new Bitmap(original.Width, original.Height);

            using (Graphics g = Graphics.FromImage(pixelated))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
                g.DrawImage(small, 0, 0, original.Width, original.Height);
            }

            return pixelated;
        }
    }
}
