using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabCSharp0._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Get the color from the input and change 
        private void color_Click(object sender, EventArgs e)
        {
            String colorName = colorInput.Text.ToLower();
            
            switch (colorName)
            {
                case "red":
                    changeableText.ForeColor = Color.Red;
                    break;
                case "green":
                    changeableText.ForeColor = Color.Green;
                    break;
                case "blue":
                    changeableText.ForeColor = Color.Blue;
                    break;
                default:
                    // If the color is not recognized, show a message box
                    MessageBox.Show("Unknown color");
                    break;
            }
        }

        // Toggle the italic style of the text
        private void italic_Click(object sender, EventArgs e)
        {
            if(changeableText.Font.Italic)
            {
                changeableText.Font = new Font(changeableText.Font, changeableText.Font.Style & ~FontStyle.Italic);
            }
            else
            {
                changeableText.Font = new Font(changeableText.Font, FontStyle.Italic);
            }   
        }

        // Toggle the bold style of the text
        private void bold_Click(object sender, EventArgs e)
        {
            // If bold is already applied, remove it; otherwise, apply it
            if (changeableText.Font.Bold)
            {
                changeableText.Font = new Font(changeableText.Font, changeableText.Font.Style & ~FontStyle.Bold);
            }
            else
            {
                changeableText.Font = new Font(changeableText.Font, FontStyle.Bold);
            }
        }

    }
}
