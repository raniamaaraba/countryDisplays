namespace countryDisplays
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.usaButton = new System.Windows.Forms.RadioButton();
            this.mexicoButton = new System.Windows.Forms.RadioButton();
            this.canadaButton = new System.Windows.Forms.RadioButton();
            this.japanButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.imageVisibleCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(209, 180);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Flags Around the World";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // usaButton
            // 
            this.usaButton.AutoSize = true;
            this.usaButton.Location = new System.Drawing.Point(28, 94);
            this.usaButton.Name = "usaButton";
            this.usaButton.Size = new System.Drawing.Size(155, 19);
            this.usaButton.TabIndex = 1;
            this.usaButton.TabStop = true;
            this.usaButton.Text = "United States of America";
            this.usaButton.UseVisualStyleBackColor = true;
            this.usaButton.CheckedChanged += new System.EventHandler(this.usaButton_CheckedChanged);
            // 
            // mexicoButton
            // 
            this.mexicoButton.AutoSize = true;
            this.mexicoButton.Location = new System.Drawing.Point(28, 119);
            this.mexicoButton.Name = "mexicoButton";
            this.mexicoButton.Size = new System.Drawing.Size(64, 19);
            this.mexicoButton.TabIndex = 2;
            this.mexicoButton.TabStop = true;
            this.mexicoButton.Text = "Mexico";
            this.mexicoButton.UseVisualStyleBackColor = true;
            this.mexicoButton.CheckedChanged += new System.EventHandler(this.mexicoButton_CheckedChanged);
            // 
            // canadaButton
            // 
            this.canadaButton.AutoSize = true;
            this.canadaButton.Location = new System.Drawing.Point(28, 144);
            this.canadaButton.Name = "canadaButton";
            this.canadaButton.Size = new System.Drawing.Size(65, 19);
            this.canadaButton.TabIndex = 3;
            this.canadaButton.TabStop = true;
            this.canadaButton.Text = "Canada";
            this.canadaButton.UseVisualStyleBackColor = true;
            this.canadaButton.CheckedChanged += new System.EventHandler(this.canadaButton_CheckedChanged);
            // 
            // japanButton
            // 
            this.japanButton.AutoSize = true;
            this.japanButton.Location = new System.Drawing.Point(28, 169);
            this.japanButton.Name = "japanButton";
            this.japanButton.Size = new System.Drawing.Size(55, 19);
            this.japanButton.TabIndex = 4;
            this.japanButton.TabStop = true;
            this.japanButton.Text = "Japan";
            this.japanButton.UseVisualStyleBackColor = true;
            this.japanButton.CheckedChanged += new System.EventHandler(this.japanButton_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(326, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(709, 434);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(555, 488);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 15);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "By: Rania Maaraba";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textVisibleCheckBox
            // 
            this.textVisibleCheckBox.AutoSize = true;
            this.textVisibleCheckBox.Location = new System.Drawing.Point(28, 446);
            this.textVisibleCheckBox.Name = "textVisibleCheckBox";
            this.textVisibleCheckBox.Size = new System.Drawing.Size(84, 19);
            this.textVisibleCheckBox.TabIndex = 8;
            this.textVisibleCheckBox.Text = "Text Visible";
            this.textVisibleCheckBox.UseVisualStyleBackColor = true;
            this.textVisibleCheckBox.CheckedChanged += new System.EventHandler(this.textVisibleCheckBox_CheckedChanged);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(953, 471);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(82, 32);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(953, 509);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 32);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // imageVisibleCheckBox
            // 
            this.imageVisibleCheckBox.AutoSize = true;
            this.imageVisibleCheckBox.Location = new System.Drawing.Point(28, 471);
            this.imageVisibleCheckBox.Name = "imageVisibleCheckBox";
            this.imageVisibleCheckBox.Size = new System.Drawing.Size(96, 19);
            this.imageVisibleCheckBox.TabIndex = 11;
            this.imageVisibleCheckBox.Text = "Image Visible";
            this.imageVisibleCheckBox.UseVisualStyleBackColor = true;
            this.imageVisibleCheckBox.CheckedChanged += new System.EventHandler(this.imageVisibleCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 578);
            this.Controls.Add(this.imageVisibleCheckBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.textVisibleCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.japanButton);
            this.Controls.Add(this.canadaButton);
            this.Controls.Add(this.mexicoButton);
            this.Controls.Add(this.usaButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private RadioButton usaButton;
        private RadioButton mexicoButton;
        private RadioButton canadaButton;
        private RadioButton japanButton;
        private PictureBox pictureBox1;
        private Label messageLabel;
        private Label label1;
        private CheckBox textVisibleCheckBox;
        private Button printButton;
        private Button exitButton;
        private CheckBox imageVisibleCheckBox;
    }
}