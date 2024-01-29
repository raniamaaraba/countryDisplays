/* Project: 2.2 Flags
 * Programmer: Rania Maaraba
 * Date: September 2022
 * Description: Using radio buttons, allow the user to show an image of a specific country's flag when clicked. Also, allow the user to hide any unwanted text
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace countryDisplays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usaButton_CheckedChanged(object sender, EventArgs e)
        {
            // Display the USa flag'
            pictureBox1.Image =
                countryDisplays.Properties.Resources.usa;
            messageLabel.Text = "The United States of America.";
        }

        private void mexicoButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image =
                countryDisplays.Properties.Resources.mexico;
            messageLabel.Text = "Meixco.";
        }

        private void canadaButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image =
                countryDisplays.Properties.Resources.canada;
            messageLabel.Text = "Canada.";
        }

        private void japanButton_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image =
                countryDisplays.Properties.Resources.japan;
            messageLabel.Text = "Japan.";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = textVisibleCheckBox.Checked;
            messageLabel.Visible = textVisibleCheckBox.Checked;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction =
                System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
            

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the project.
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            imageVisibleCheckBox.Visible = true;
            textVisibleCheckBox.Visible = true;
        }

        private void imageVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = imageVisibleCheckBox.Checked;
        }
    }
}