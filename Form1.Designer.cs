namespace _14__Praktikum
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
            this.labelInput = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonUrutkan = new System.Windows.Forms.Button();
            this.buttonReverse = new System.Windows.Forms.Button();
            this.labelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(13, 13);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(39, 17);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(16, 34);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(290, 22);
            this.textBox.TabIndex = 1;
            // 
            // buttonUrutkan
            // 
            this.buttonUrutkan.Location = new System.Drawing.Point(160, 62);
            this.buttonUrutkan.Name = "buttonUrutkan";
            this.buttonUrutkan.Size = new System.Drawing.Size(146, 23);
            this.buttonUrutkan.TabIndex = 2;
            this.buttonUrutkan.Text = "URUTKAN";
            this.buttonUrutkan.UseVisualStyleBackColor = true;
            this.buttonUrutkan.Click += new System.EventHandler(this.buttonUrutkan_Click);
            // 
            // buttonReverse
            // 
            this.buttonReverse.Location = new System.Drawing.Point(16, 62);
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(125, 23);
            this.buttonReverse.TabIndex = 3;
            this.buttonReverse.Text = "REVERSE";
            this.buttonReverse.UseVisualStyleBackColor = true;
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(16, 119);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(51, 17);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.buttonReverse);
            this.Controls.Add(this.buttonUrutkan);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonUrutkan;
        private System.Windows.Forms.Button buttonReverse;
        private System.Windows.Forms.Label labelOutput;
    }
}

