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
                    MessageBox.Show("Unknown color");
                    break;
            }
        }
    }
}
