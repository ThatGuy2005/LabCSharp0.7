namespace LabCSharp0._7
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
            this.changeableText = new System.Windows.Forms.Label();
            this.bold = new System.Windows.Forms.Button();
            this.italic = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.colorInput = new System.Windows.Forms.TextBox();
            this.colorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeableText
            // 
            this.changeableText.AutoSize = true;
            this.changeableText.Location = new System.Drawing.Point(51, 195);
            this.changeableText.Name = "changeableText";
            this.changeableText.Size = new System.Drawing.Size(361, 20);
            this.changeableText.TabIndex = 0;
            this.changeableText.Text = "Hey, press the buttons to change my appearance.";
            // 
            // bold
            // 
            this.bold.Location = new System.Drawing.Point(500, 87);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(80, 41);
            this.bold.TabIndex = 1;
            this.bold.Text = "Bold";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.Location = new System.Drawing.Point(500, 164);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(80, 38);
            this.italic.TabIndex = 2;
            this.italic.Text = "Italic";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(459, 249);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(140, 49);
            this.color.TabIndex = 3;
            this.color.Text = "Change to given color";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // colorInput
            // 
            this.colorInput.Location = new System.Drawing.Point(480, 304);
            this.colorInput.Name = "colorInput";
            this.colorInput.Size = new System.Drawing.Size(100, 26);
            this.colorInput.TabIndex = 4;
            // 
            // colorText
            // 
            this.colorText.AutoSize = true;
            this.colorText.Location = new System.Drawing.Point(371, 307);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(103, 20);
            this.colorText.TabIndex = 5;
            this.colorText.Text = "Enter  a color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorText);
            this.Controls.Add(this.colorInput);
            this.Controls.Add(this.color);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.changeableText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changeableText;
        private System.Windows.Forms.Button bold;
        private System.Windows.Forms.Button italic;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.TextBox colorInput;
        private System.Windows.Forms.Label colorText;
    }
}

