
namespace ImageToANSI
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.pictureBoxTemplate = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.numericConsoleWidth = new System.Windows.Forms.NumericUpDown();
            this.numericConsoleHeight = new System.Windows.Forms.NumericUpDown();
            this.groupBoxConsole = new System.Windows.Forms.GroupBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.groupBoxPos = new System.Windows.Forms.GroupBox();
            this.radioButtonCenter = new System.Windows.Forms.RadioButton();
            this.radioButtonTopLeft = new System.Windows.Forms.RadioButton();
            this.trackBarCutoff = new System.Windows.Forms.TrackBar();
            this.groupBoxCutoff = new System.Windows.Forms.GroupBox();
            this.labelCutoff = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxPreview = new System.Windows.Forms.CheckBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.colorMode4 = new System.Windows.Forms.RadioButton();
            this.colorMode3 = new System.Windows.Forms.RadioButton();
            this.colorMode2 = new System.Windows.Forms.RadioButton();
            this.colorMode1 = new System.Windows.Forms.RadioButton();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.radioButton16Colors = new System.Windows.Forms.RadioButton();
            this.radioButton8Colors = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConsoleWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConsoleHeight)).BeginInit();
            this.groupBoxConsole.SuspendLayout();
            this.groupBoxPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCutoff)).BeginInit();
            this.groupBoxCutoff.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.OpenClick);
            // 
            // pictureBoxTemplate
            // 
            this.pictureBoxTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTemplate.Location = new System.Drawing.Point(72, 149);
            this.pictureBoxTemplate.Name = "pictureBoxTemplate";
            this.pictureBoxTemplate.Size = new System.Drawing.Size(640, 400);
            this.pictureBoxTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTemplate.TabIndex = 1;
            this.pictureBoxTemplate.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PNG (*.png)|*.png|BMP (*.bmp)|*.bmp|All files (*.*)|*.*";
            this.openFileDialog.Title = "Open image";
            // 
            // numericConsoleWidth
            // 
            this.numericConsoleWidth.Location = new System.Drawing.Point(50, 19);
            this.numericConsoleWidth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericConsoleWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericConsoleWidth.Name = "numericConsoleWidth";
            this.numericConsoleWidth.Size = new System.Drawing.Size(39, 20);
            this.numericConsoleWidth.TabIndex = 6;
            this.numericConsoleWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericConsoleWidth.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericConsoleWidth.ValueChanged += new System.EventHandler(this.ConsoleWidthChanged);
            // 
            // numericConsoleHeight
            // 
            this.numericConsoleHeight.Location = new System.Drawing.Point(50, 46);
            this.numericConsoleHeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericConsoleHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericConsoleHeight.Name = "numericConsoleHeight";
            this.numericConsoleHeight.Size = new System.Drawing.Size(39, 20);
            this.numericConsoleHeight.TabIndex = 7;
            this.numericConsoleHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericConsoleHeight.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericConsoleHeight.ValueChanged += new System.EventHandler(this.ConsoleHeightChanged);
            // 
            // groupBoxConsole
            // 
            this.groupBoxConsole.Controls.Add(this.labelHeight);
            this.groupBoxConsole.Controls.Add(this.labelWidth);
            this.groupBoxConsole.Controls.Add(this.numericConsoleHeight);
            this.groupBoxConsole.Controls.Add(this.numericConsoleWidth);
            this.groupBoxConsole.Location = new System.Drawing.Point(93, 12);
            this.groupBoxConsole.Name = "groupBoxConsole";
            this.groupBoxConsole.Size = new System.Drawing.Size(98, 75);
            this.groupBoxConsole.TabIndex = 3;
            this.groupBoxConsole.TabStop = false;
            this.groupBoxConsole.Text = "Console size";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 48);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 13);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Height:";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(6, 21);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(38, 13);
            this.labelWidth.TabIndex = 4;
            this.labelWidth.Text = "Width:";
            // 
            // groupBoxPos
            // 
            this.groupBoxPos.Controls.Add(this.radioButtonCenter);
            this.groupBoxPos.Controls.Add(this.radioButtonTopLeft);
            this.groupBoxPos.Location = new System.Drawing.Point(197, 12);
            this.groupBoxPos.Name = "groupBoxPos";
            this.groupBoxPos.Size = new System.Drawing.Size(92, 75);
            this.groupBoxPos.TabIndex = 8;
            this.groupBoxPos.TabStop = false;
            this.groupBoxPos.Text = "Image position";
            // 
            // radioButtonCenter
            // 
            this.radioButtonCenter.AutoSize = true;
            this.radioButtonCenter.Location = new System.Drawing.Point(6, 48);
            this.radioButtonCenter.Name = "radioButtonCenter";
            this.radioButtonCenter.Size = new System.Drawing.Size(56, 17);
            this.radioButtonCenter.TabIndex = 10;
            this.radioButtonCenter.Text = "Center";
            this.radioButtonCenter.UseVisualStyleBackColor = true;
            this.radioButtonCenter.CheckedChanged += new System.EventHandler(this.ReloadImage);
            // 
            // radioButtonTopLeft
            // 
            this.radioButtonTopLeft.AutoSize = true;
            this.radioButtonTopLeft.Checked = true;
            this.radioButtonTopLeft.Location = new System.Drawing.Point(6, 22);
            this.radioButtonTopLeft.Name = "radioButtonTopLeft";
            this.radioButtonTopLeft.Size = new System.Drawing.Size(61, 17);
            this.radioButtonTopLeft.TabIndex = 9;
            this.radioButtonTopLeft.TabStop = true;
            this.radioButtonTopLeft.Text = "Top left";
            this.radioButtonTopLeft.UseVisualStyleBackColor = true;
            this.radioButtonTopLeft.CheckedChanged += new System.EventHandler(this.ReloadImage);
            // 
            // trackBarCutoff
            // 
            this.trackBarCutoff.LargeChange = 1;
            this.trackBarCutoff.Location = new System.Drawing.Point(4, 20);
            this.trackBarCutoff.Minimum = 1;
            this.trackBarCutoff.Name = "trackBarCutoff";
            this.trackBarCutoff.Size = new System.Drawing.Size(104, 45);
            this.trackBarCutoff.TabIndex = 12;
            this.trackBarCutoff.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarCutoff.Value = 1;
            this.trackBarCutoff.Scroll += new System.EventHandler(this.CutoffChanged);
            // 
            // groupBoxCutoff
            // 
            this.groupBoxCutoff.Controls.Add(this.labelCutoff);
            this.groupBoxCutoff.Controls.Add(this.trackBarCutoff);
            this.groupBoxCutoff.Location = new System.Drawing.Point(295, 12);
            this.groupBoxCutoff.Name = "groupBoxCutoff";
            this.groupBoxCutoff.Size = new System.Drawing.Size(114, 75);
            this.groupBoxCutoff.TabIndex = 11;
            this.groupBoxCutoff.TabStop = false;
            this.groupBoxCutoff.Text = "Intensity treshold";
            // 
            // labelCutoff
            // 
            this.labelCutoff.Location = new System.Drawing.Point(7, 51);
            this.labelCutoff.Name = "labelCutoff";
            this.labelCutoff.Size = new System.Drawing.Size(100, 15);
            this.labelCutoff.TabIndex = 8;
            this.labelCutoff.Text = "10%";
            this.labelCutoff.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 41);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // checkBoxPreview
            // 
            this.checkBoxPreview.AutoSize = true;
            this.checkBoxPreview.Location = new System.Drawing.Point(72, 126);
            this.checkBoxPreview.Name = "checkBoxPreview";
            this.checkBoxPreview.Size = new System.Drawing.Size(120, 17);
            this.checkBoxPreview.TabIndex = 22;
            this.checkBoxPreview.Text = "Show original image";
            this.checkBoxPreview.UseVisualStyleBackColor = true;
            this.checkBoxPreview.CheckedChanged += new System.EventHandler(this.ReloadImage);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "ANS (*.ans)|*.ans|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            this.saveFileDialog.Title = "Save image";
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.colorMode4);
            this.groupBoxColor.Controls.Add(this.colorMode3);
            this.groupBoxColor.Controls.Add(this.colorMode2);
            this.groupBoxColor.Controls.Add(this.colorMode1);
            this.groupBoxColor.Location = new System.Drawing.Point(415, 12);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(154, 75);
            this.groupBoxColor.TabIndex = 13;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color reduction method";
            // 
            // colorMode4
            // 
            this.colorMode4.AutoSize = true;
            this.colorMode4.Location = new System.Drawing.Point(97, 47);
            this.colorMode4.Name = "colorMode4";
            this.colorMode4.Size = new System.Drawing.Size(47, 17);
            this.colorMode4.TabIndex = 17;
            this.colorMode4.Text = "HSB";
            this.colorMode4.UseVisualStyleBackColor = true;
            this.colorMode4.CheckedChanged += new System.EventHandler(this.ReloadImage);
            // 
            // colorMode3
            // 
            this.colorMode3.AutoSize = true;
            this.colorMode3.Location = new System.Drawing.Point(97, 24);
            this.colorMode3.Name = "colorMode3";
            this.colorMode3.Size = new System.Drawing.Size(47, 17);
            this.colorMode3.TabIndex = 16;
            this.colorMode3.Text = "HSV";
            this.colorMode3.UseVisualStyleBackColor = true;
            this.colorMode3.CheckedChanged += new System.EventHandler(this.ReloadImage);
            // 
            // colorMode2
            // 
            this.colorMode2.AutoSize = true;
            this.colorMode2.Location = new System.Drawing.Point(6, 47);
            this.colorMode2.Name = "colorMode2";
            this.colorMode2.Size = new System.Drawing.Size(70, 17);
            this.colorMode2.TabIndex = 15;
            this.colorMode2.Text = "Balanced";
            this.colorMode2.UseVisualStyleBackColor = true;
            this.colorMode2.CheckedChanged += new System.EventHandler(this.ReloadImage);
            // 
            // colorMode1
            // 
            this.colorMode1.AutoSize = true;
            this.colorMode1.Checked = true;
            this.colorMode1.Location = new System.Drawing.Point(6, 24);
            this.colorMode1.Name = "colorMode1";
            this.colorMode1.Size = new System.Drawing.Size(59, 17);
            this.colorMode1.TabIndex = 14;
            this.colorMode1.TabStop = true;
            this.colorMode1.Text = "Default";
            this.colorMode1.UseVisualStyleBackColor = true;
            this.colorMode1.CheckedChanged += new System.EventHandler(this.ReloadImage);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.radioButton16Colors);
            this.groupBoxColors.Controls.Add(this.radioButton8Colors);
            this.groupBoxColors.Location = new System.Drawing.Point(575, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(85, 75);
            this.groupBoxColors.TabIndex = 18;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Color palette";
            // 
            // radioButton16Colors
            // 
            this.radioButton16Colors.AutoSize = true;
            this.radioButton16Colors.Checked = true;
            this.radioButton16Colors.Location = new System.Drawing.Point(6, 51);
            this.radioButton16Colors.Name = "radioButton16Colors";
            this.radioButton16Colors.Size = new System.Drawing.Size(68, 17);
            this.radioButton16Colors.TabIndex = 20;
            this.radioButton16Colors.TabStop = true;
            this.radioButton16Colors.Text = "16 colors";
            this.radioButton16Colors.UseVisualStyleBackColor = true;
            this.radioButton16Colors.CheckedChanged += new System.EventHandler(this.ReloadImage);
            // 
            // radioButton8Colors
            // 
            this.radioButton8Colors.AutoSize = true;
            this.radioButton8Colors.Location = new System.Drawing.Point(6, 24);
            this.radioButton8Colors.Name = "radioButton8Colors";
            this.radioButton8Colors.Size = new System.Drawing.Size(62, 17);
            this.radioButton8Colors.TabIndex = 19;
            this.radioButton8Colors.Text = "8 colors";
            this.radioButton8Colors.UseVisualStyleBackColor = true;
            this.radioButton8Colors.CheckedChanged += new System.EventHandler(this.ReloadImage);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 70);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Visible = false;
            this.buttonClose.Click += new System.EventHandler(this.CloseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(517, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Made by SeriousCsaba 2021";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.checkBoxPreview);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxCutoff);
            this.Controls.Add(this.groupBoxPos);
            this.Controls.Add(this.groupBoxConsole);
            this.Controls.Add(this.pictureBoxTemplate);
            this.Controls.Add(this.buttonOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageToAnsi";
            this.ResizeEnd += new System.EventHandler(this.FormResized);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConsoleWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericConsoleHeight)).EndInit();
            this.groupBoxConsole.ResumeLayout(false);
            this.groupBoxConsole.PerformLayout();
            this.groupBoxPos.ResumeLayout(false);
            this.groupBoxPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCutoff)).EndInit();
            this.groupBoxCutoff.ResumeLayout(false);
            this.groupBoxCutoff.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxColors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.PictureBox pictureBoxTemplate;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown numericConsoleWidth;
        private System.Windows.Forms.NumericUpDown numericConsoleHeight;
        private System.Windows.Forms.GroupBox groupBoxConsole;
        private System.Windows.Forms.GroupBox groupBoxPos;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.RadioButton radioButtonCenter;
        private System.Windows.Forms.RadioButton radioButtonTopLeft;
        private System.Windows.Forms.TrackBar trackBarCutoff;
        private System.Windows.Forms.GroupBox groupBoxCutoff;
        private System.Windows.Forms.Label labelCutoff;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxPreview;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton colorMode4;
        private System.Windows.Forms.RadioButton colorMode3;
        private System.Windows.Forms.RadioButton colorMode2;
        private System.Windows.Forms.RadioButton colorMode1;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.RadioButton radioButton16Colors;
        private System.Windows.Forms.RadioButton radioButton8Colors;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
    }
}
