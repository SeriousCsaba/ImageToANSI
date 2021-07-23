using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ImageToANSI
{
    public partial class FormMain : Form
    {
        Size Console = new Size(80, 25);
        Size oldSize;
        ANSI[] ansi;
        int ansiWidth;

        public FormMain()
        {
            InitializeComponent();
            oldSize = Size;
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
        }

        void ConsoleWidthChanged(object sender, EventArgs e)
        {
            while ((int)numericConsoleWidth.Value * 8 + 150 < 280)
                numericConsoleWidth.Value++;

            if (Console.Width < (int)numericConsoleWidth.Value)
                Height++;
            else if (Console.Width > (int)numericConsoleWidth.Value)
                Height--;
            Console.Width = (int)numericConsoleWidth.Value;
            if (pictureBoxTemplate.Image != null)
                LoadImage();
            FormResized(null, null);
        }

        void ConsoleHeightChanged(object sender, EventArgs e)
        {
            if (Console.Height < (int)numericConsoleHeight.Value)
                Width++;
            else if (Console.Height > (int)numericConsoleHeight.Value)
                Width--;
            Console.Height = (int)numericConsoleHeight.Value;
            if (pictureBoxTemplate.Image != null)
                LoadImage();
            FormResized(null, null);
        }

        void CutoffChanged(object sender, EventArgs e)
        {
            if (pictureBoxTemplate.Image != null)
                LoadImage();
            labelCutoff.Text = trackBarCutoff.Value * 10 + "%";
        }

        void ReloadImage(object sender, EventArgs e)
        {
            if (pictureBoxTemplate.Image != null)
                LoadImage();
        }

        void OpenClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("Resize console size to image size?", "Console size", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Bitmap bitmap = (Bitmap)Image.FromFile(openFileDialog.FileName);
                    numericConsoleWidth.Value = bitmap.Width;
                    numericConsoleHeight.Value = (int)Math.Ceiling(bitmap.Height / 2f);
                }
                LoadImage();
            }
        }

        void SaveClick(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog.FileName).ToLower() == ".ans")
                {
                    string result = "";
                    for (int i = 0; i < ansi.Length; i++)
                    {
                        result += ansi[i];
                        if ((i + 1) % ansiWidth == 0)
                            result += ANSI.NewLine(i / ansiWidth + 2);
                    }
                    result += ANSI.Reset;
                    File.WriteAllText(saveFileDialog.FileName, result, Encoding.Default);
                }
                else
                    pictureBoxTemplate.Image.Save(saveFileDialog.FileName);
            }
        }

        void CloseClick(object sender, EventArgs e)
        {
            buttonSave.Visible = false;
            buttonClose.Visible = false;
            pictureBoxTemplate.Image = null;
            GC.Collect();
        }

        void LoadImage()
        {
            buttonOpen.Enabled = false;
            buttonSave.Enabled = false;
            buttonClose.Enabled = false;

            if (File.Exists(openFileDialog.FileName))
            {
                buttonSave.Visible = false;
                Bitmap bitmap = (Bitmap)Image.FromFile(openFileDialog.FileName);
                if (radioButtonCenter.Checked)
                    bitmap = bitmap.ResizeToCenter(Console.Width, Console.Height * 2);
                if (bitmap.Height % 2 == 1)
                    bitmap = bitmap.Resize(bitmap.Width, bitmap.Height + 1);
                if (checkBoxPreview.Checked)
                {
                    Bitmap template = new Bitmap(Console.Width * 8, Console.Height * 2 * 8);
                    for (int y = 0; y < bitmap.Height; y++)
                        for (int x = 0; x < bitmap.Width; x++)
                            for (int j = 0; j < 8; j++)
                                for (int i = 0; i < 8; i++)
                                    if (x < Console.Width && y < Console.Height * 2)
                                        template.SetPixel(i + (8 * x), j + (8 * y), bitmap.GetPixel(x, y));
                    pictureBoxTemplate.Image = template;
                }
                else
                {
                    ansi = new ANSI[bitmap.Width * bitmap.Height / 2];
                    for (int y = 0; y < bitmap.Height; y += 2)
                        for (int x = 0; x < bitmap.Width; x++)
                        {
                            Type color8 = typeof(Color8);
                            if (colorMode2.Checked)
                                color8 = typeof(Color8Balanced);
                            else if (colorMode3.Checked)
                                color8 = typeof(Color8HSV);
                            else if (colorMode4.Checked)
                                color8 = typeof(Color8HSB);
                            Color8 top = (Color8)Activator.CreateInstance(color8, new object[] { bitmap.GetPixel(x, y), radioButton8Colors.Checked });
                            Color8 bottom = (Color8)Activator.CreateInstance(color8, new object[] { bitmap.GetPixel(x, y + 1), radioButton8Colors.Checked });
                            if (top.Equals(bottom))
                            {
                                if (top.Intensity <= trackBarCutoff.Value / 10f)
                                    ansi[y / 2 * bitmap.Width + x] = new ANSI(ANSI.EMPTY, new Color8(Color.Black, radioButton8Colors.Checked), null);
                                else
                                    ansi[y / 2 * bitmap.Width + x] = new ANSI(ANSI.FULL, top, null);
                            }
                            else
                            {
                                if (top.Intensity <= trackBarCutoff.Value / 10f && bottom.Intensity <= trackBarCutoff.Value / 10f)
                                    ansi[y / 2 * bitmap.Width + x] = new ANSI(ANSI.EMPTY, new Color8(Color.Black, radioButton8Colors.Checked), null);
                                else if (top.Intensity >= bottom.Intensity)
                                    ansi[y / 2 * bitmap.Width + x] = new ANSI(ANSI.TOP, top, bottom);
                                else
                                    ansi[y / 2 * bitmap.Width + x] = new ANSI(ANSI.BOTTOM, bottom, top);
                            }
                        }
                    ansiWidth = bitmap.Width;

                    Bitmap template = new Bitmap(Console.Width * 8, Console.Height * 2 * 8);
                    for (int y = 0; y < bitmap.Height; y += 2)
                        for (int x = 0; x < bitmap.Width; x++)
                            for (int j = 0; j < 8; j++)
                                for (int i = 0; i < 8; i++)
                                    if (x < Console.Width && y < Console.Height * 2)
                                    {
                                        template.SetPixel(i + (8 * x), j + (8 * y), ansi[y / 2 * bitmap.Width + x].Top);
                                        template.SetPixel(i + (8 * x), j + (8 * (y + 1)), ansi[y / 2 * bitmap.Width + x].Bottom);
                                    }
                    pictureBoxTemplate.Image = template;

                    buttonSave.Visible = true;
                    buttonClose.Visible = true;
                }

                bitmap.Dispose();
            }
            buttonOpen.Enabled = true;
            buttonSave.Enabled = true;
            buttonClose.Enabled = true;
        }

        void FormResized(object sender, EventArgs e)
        {
            if (oldSize.Width != Width && oldSize.Height != Height)
                if (Math.Abs(oldSize.Width - Width) < Math.Abs(oldSize.Height - Height))
                    Size = new Size(oldSize.Width, Height);
                else
                    Size = new Size(Width, oldSize.Height);

            while (pictureBoxTemplate.Width < Console.Width)
                Width++;
            while (pictureBoxTemplate.Height < Console.Height * 2)
                Height++;

            Point direction = Point.Empty;
            if (oldSize.Width > Width)
                direction = new Point(0, -1);
            else if (oldSize.Width < Width)
                direction = new Point(0, 1);
            else if (oldSize.Height > Height)
                direction = new Point(-1, 0);
            else if (oldSize.Height < Height)
                direction = new Point(1, 0);

            if (direction != Point.Empty)
                while (Math.Abs(pictureBoxTemplate.Width * (Console.Height * 2 / (float)Console.Width) - pictureBoxTemplate.Height) > 1)
                    Size = new Size(Width + direction.X, Height + direction.Y);

            oldSize = Size;
        }
    }
}
