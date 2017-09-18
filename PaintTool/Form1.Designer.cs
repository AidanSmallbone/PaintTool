namespace PaintTool
{
    partial class Form1
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
            this.toolBoxGroup = new System.Windows.Forms.GroupBox();
            this.rectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.elipseRadioButton = new System.Windows.Forms.RadioButton();
            this.lineRadioButton = new System.Windows.Forms.RadioButton();
            this.fillRadioButton = new System.Windows.Forms.RadioButton();
            this.penRadioButton = new System.Windows.Forms.RadioButton();
            this.infoLabel = new System.Windows.Forms.Label();
            this.rectangleColorSelector = new System.Windows.Forms.ComboBox();
            this.rectangleSizeTextBox = new System.Windows.Forms.TextBox();
            this.elipseColorSelector = new System.Windows.Forms.ComboBox();
            this.elipseSizeTextBox = new System.Windows.Forms.TextBox();
            this.lineColorSelector = new System.Windows.Forms.ComboBox();
            this.lineSizeTextBox = new System.Windows.Forms.TextBox();
            this.fillColorSelector = new System.Windows.Forms.ComboBox();
            this.penColorSelector = new System.Windows.Forms.ComboBox();
            this.penSizeTextBox = new System.Windows.Forms.TextBox();
            this.paintBox = new System.Windows.Forms.PictureBox();
            this.toolBoxGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBoxGroup
            // 
            this.toolBoxGroup.Controls.Add(this.rectangleRadioButton);
            this.toolBoxGroup.Controls.Add(this.elipseRadioButton);
            this.toolBoxGroup.Controls.Add(this.lineRadioButton);
            this.toolBoxGroup.Controls.Add(this.fillRadioButton);
            this.toolBoxGroup.Controls.Add(this.penRadioButton);
            this.toolBoxGroup.Controls.Add(this.infoLabel);
            this.toolBoxGroup.Controls.Add(this.rectangleColorSelector);
            this.toolBoxGroup.Controls.Add(this.rectangleSizeTextBox);
            this.toolBoxGroup.Controls.Add(this.elipseColorSelector);
            this.toolBoxGroup.Controls.Add(this.elipseSizeTextBox);
            this.toolBoxGroup.Controls.Add(this.lineColorSelector);
            this.toolBoxGroup.Controls.Add(this.lineSizeTextBox);
            this.toolBoxGroup.Controls.Add(this.fillColorSelector);
            this.toolBoxGroup.Controls.Add(this.penColorSelector);
            this.toolBoxGroup.Controls.Add(this.penSizeTextBox);
            this.toolBoxGroup.Location = new System.Drawing.Point(12, 12);
            this.toolBoxGroup.Name = "toolBoxGroup";
            this.toolBoxGroup.Size = new System.Drawing.Size(200, 657);
            this.toolBoxGroup.TabIndex = 0;
            this.toolBoxGroup.TabStop = false;
            this.toolBoxGroup.Text = "Tools";
            // 
            // rectangleRadioButton
            // 
            this.rectangleRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.rectangleRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rectangleRadioButton.Location = new System.Drawing.Point(6, 380);
            this.rectangleRadioButton.Name = "rectangleRadioButton";
            this.rectangleRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rectangleRadioButton.Size = new System.Drawing.Size(188, 24);
            this.rectangleRadioButton.TabIndex = 18;
            this.rectangleRadioButton.TabStop = true;
            this.rectangleRadioButton.Text = "Rectangle Tool";
            this.rectangleRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rectangleRadioButton.UseVisualStyleBackColor = true;
            this.rectangleRadioButton.CheckedChanged += new System.EventHandler(this.rectangleRadioButton_Load);
            // 
            // elipseRadioButton
            // 
            this.elipseRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.elipseRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.elipseRadioButton.Location = new System.Drawing.Point(6, 283);
            this.elipseRadioButton.Name = "elipseRadioButton";
            this.elipseRadioButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.elipseRadioButton.Size = new System.Drawing.Size(188, 24);
            this.elipseRadioButton.TabIndex = 17;
            this.elipseRadioButton.TabStop = true;
            this.elipseRadioButton.Text = "Elipse Tool";
            this.elipseRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.elipseRadioButton.UseVisualStyleBackColor = true;
            this.elipseRadioButton.CheckedChanged += new System.EventHandler(this.elipseRadioButton_Load);
            // 
            // lineRadioButton
            // 
            this.lineRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lineRadioButton.Location = new System.Drawing.Point(6, 186);
            this.lineRadioButton.Name = "lineRadioButton";
            this.lineRadioButton.Size = new System.Drawing.Size(188, 24);
            this.lineRadioButton.TabIndex = 16;
            this.lineRadioButton.TabStop = true;
            this.lineRadioButton.Text = "Line Tool";
            this.lineRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lineRadioButton.UseVisualStyleBackColor = true;
            this.lineRadioButton.CheckedChanged += new System.EventHandler(this.lineRadioButton_Load);
            // 
            // fillRadioButton
            // 
            this.fillRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.fillRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.fillRadioButton.Location = new System.Drawing.Point(6, 115);
            this.fillRadioButton.Name = "fillRadioButton";
            this.fillRadioButton.Size = new System.Drawing.Size(188, 24);
            this.fillRadioButton.TabIndex = 15;
            this.fillRadioButton.TabStop = true;
            this.fillRadioButton.Text = "Fill Tool";
            this.fillRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fillRadioButton.UseVisualStyleBackColor = true;
            this.fillRadioButton.CheckedChanged += new System.EventHandler(this.fillRadioButton_Load);
            // 
            // penRadioButton
            // 
            this.penRadioButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.penRadioButton.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.penRadioButton.Location = new System.Drawing.Point(6, 19);
            this.penRadioButton.Name = "penRadioButton";
            this.penRadioButton.Size = new System.Drawing.Size(188, 24);
            this.penRadioButton.TabIndex = 0;
            this.penRadioButton.TabStop = true;
            this.penRadioButton.Text = "Pen Tool";
            this.penRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penRadioButton.UseVisualStyleBackColor = true;
            this.penRadioButton.CheckedChanged += new System.EventHandler(this.penRadioButton_Load);
            // 
            // infoLabel
            // 
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Location = new System.Drawing.Point(10, 466);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(180, 180);
            this.infoLabel.TabIndex = 14;
            this.infoLabel.Text = "Aidan\'s Paint Tool\r\n\r\nVersion 1.0\r\n\r\nReleased 9/xx/2017";
            // 
            // rectangleColorSelector
            // 
            this.rectangleColorSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleColorSelector.FormattingEnabled = true;
            this.rectangleColorSelector.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Lime",
            "Green",
            "Aqua",
            "Blue",
            "Magenta",
            "Purple"});
            this.rectangleColorSelector.Location = new System.Drawing.Point(6, 436);
            this.rectangleColorSelector.Name = "rectangleColorSelector";
            this.rectangleColorSelector.Size = new System.Drawing.Size(188, 21);
            this.rectangleColorSelector.TabIndex = 13;
            this.rectangleColorSelector.Text = "Rectangle Color";
            // 
            // rectangleSizeTextBox
            // 
            this.rectangleSizeTextBox.Location = new System.Drawing.Point(6, 410);
            this.rectangleSizeTextBox.Name = "rectangleSizeTextBox";
            this.rectangleSizeTextBox.Size = new System.Drawing.Size(188, 20);
            this.rectangleSizeTextBox.TabIndex = 12;
            this.rectangleSizeTextBox.Text = "Rectangle Size (Pixels)";
            // 
            // elipseColorSelector
            // 
            this.elipseColorSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elipseColorSelector.FormattingEnabled = true;
            this.elipseColorSelector.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Lime",
            "Green",
            "Aqua",
            "Blue",
            "Magenta",
            "Purple"});
            this.elipseColorSelector.Location = new System.Drawing.Point(6, 339);
            this.elipseColorSelector.Name = "elipseColorSelector";
            this.elipseColorSelector.Size = new System.Drawing.Size(188, 21);
            this.elipseColorSelector.TabIndex = 10;
            this.elipseColorSelector.Text = "Elipse Color";
            // 
            // elipseSizeTextBox
            // 
            this.elipseSizeTextBox.Location = new System.Drawing.Point(6, 313);
            this.elipseSizeTextBox.Name = "elipseSizeTextBox";
            this.elipseSizeTextBox.Size = new System.Drawing.Size(188, 20);
            this.elipseSizeTextBox.TabIndex = 9;
            this.elipseSizeTextBox.Text = "Elipse Size (Pixels)";
            // 
            // lineColorSelector
            // 
            this.lineColorSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineColorSelector.FormattingEnabled = true;
            this.lineColorSelector.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Lime",
            "Green",
            "Aqua",
            "Blue",
            "Magenta",
            "Purple"});
            this.lineColorSelector.Location = new System.Drawing.Point(6, 242);
            this.lineColorSelector.Name = "lineColorSelector";
            this.lineColorSelector.Size = new System.Drawing.Size(188, 21);
            this.lineColorSelector.TabIndex = 7;
            this.lineColorSelector.Text = "Line Color";
            // 
            // lineSizeTextBox
            // 
            this.lineSizeTextBox.Location = new System.Drawing.Point(6, 216);
            this.lineSizeTextBox.Name = "lineSizeTextBox";
            this.lineSizeTextBox.Size = new System.Drawing.Size(188, 20);
            this.lineSizeTextBox.TabIndex = 6;
            this.lineSizeTextBox.Text = "Line Size (Pixels)";
            // 
            // fillColorSelector
            // 
            this.fillColorSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillColorSelector.FormattingEnabled = true;
            this.fillColorSelector.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Lime",
            "Green",
            "Aqua",
            "Blue",
            "Magenta",
            "Purple"});
            this.fillColorSelector.Location = new System.Drawing.Point(6, 145);
            this.fillColorSelector.Name = "fillColorSelector";
            this.fillColorSelector.Size = new System.Drawing.Size(188, 21);
            this.fillColorSelector.TabIndex = 4;
            this.fillColorSelector.Text = "Fill Color";
            // 
            // penColorSelector
            // 
            this.penColorSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penColorSelector.FormattingEnabled = true;
            this.penColorSelector.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Lime",
            "Green",
            "Aqua",
            "Blue",
            "Magenta",
            "Purple"});
            this.penColorSelector.Location = new System.Drawing.Point(6, 74);
            this.penColorSelector.Name = "penColorSelector";
            this.penColorSelector.Size = new System.Drawing.Size(188, 21);
            this.penColorSelector.TabIndex = 2;
            this.penColorSelector.Text = "Pen Color";
            this.penColorSelector.SelectedIndexChanged += new System.EventHandler(this.penColorSelector_SelectedIndexChanged);
            // 
            // penSizeTextBox
            // 
            this.penSizeTextBox.Location = new System.Drawing.Point(6, 48);
            this.penSizeTextBox.Name = "penSizeTextBox";
            this.penSizeTextBox.Size = new System.Drawing.Size(188, 20);
            this.penSizeTextBox.TabIndex = 1;
            this.penSizeTextBox.Text = "Pen Size (Pixels)";
            // 
            // paintBox
            // 
            this.paintBox.BackColor = System.Drawing.Color.White;
            this.paintBox.Location = new System.Drawing.Point(218, 13);
            this.paintBox.Name = "paintBox";
            this.paintBox.Size = new System.Drawing.Size(1034, 657);
            this.paintBox.TabIndex = 1;
            this.paintBox.TabStop = false;
            this.paintBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paintBox_MouseDown);
            this.paintBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paintBox_MouseMove);
            this.paintBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paintBox_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.paintBox);
            this.Controls.Add(this.toolBoxGroup);
            this.Name = "Form1";
            this.toolBoxGroup.ResumeLayout(false);
            this.toolBoxGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paintBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox toolBoxGroup;
        private System.Windows.Forms.ComboBox penColorSelector;
        private System.Windows.Forms.TextBox penSizeTextBox;
        private System.Windows.Forms.ComboBox fillColorSelector;
        private System.Windows.Forms.ComboBox rectangleColorSelector;
        private System.Windows.Forms.TextBox rectangleSizeTextBox;
        private System.Windows.Forms.ComboBox elipseColorSelector;
        private System.Windows.Forms.TextBox elipseSizeTextBox;
        private System.Windows.Forms.ComboBox lineColorSelector;
        private System.Windows.Forms.TextBox lineSizeTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.RadioButton rectangleRadioButton;
        private System.Windows.Forms.RadioButton elipseRadioButton;
        private System.Windows.Forms.RadioButton lineRadioButton;
        private System.Windows.Forms.RadioButton fillRadioButton;
        private System.Windows.Forms.RadioButton penRadioButton;
        private System.Windows.Forms.PictureBox paintBox;
    }
}

