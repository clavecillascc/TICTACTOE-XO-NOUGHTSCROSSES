﻿namespace TIC_TAC_TOE___A2___Clavecillas
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
            this.btnR1C1 = new System.Windows.Forms.Button();
            this.btnR1C2 = new System.Windows.Forms.Button();
            this.btnR1C3 = new System.Windows.Forms.Button();
            this.btnR2C1 = new System.Windows.Forms.Button();
            this.btnR3C1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnR1C1
            // 
            this.btnR1C1.Location = new System.Drawing.Point(12, 12);
            this.btnR1C1.Name = "btnR1C1";
            this.btnR1C1.Size = new System.Drawing.Size(75, 75);
            this.btnR1C1.TabIndex = 0;
            this.btnR1C1.Text = "TIC";
            this.btnR1C1.UseVisualStyleBackColor = true;
            // 
            // btnR1C2
            // 
            this.btnR1C2.Location = new System.Drawing.Point(93, 12);
            this.btnR1C2.Name = "btnR1C2";
            this.btnR1C2.Size = new System.Drawing.Size(75, 75);
            this.btnR1C2.TabIndex = 1;
            this.btnR1C2.Text = "TAC";
            this.btnR1C2.UseVisualStyleBackColor = true;
            // 
            // btnR1C3
            // 
            this.btnR1C3.Location = new System.Drawing.Point(174, 12);
            this.btnR1C3.Name = "btnR1C3";
            this.btnR1C3.Size = new System.Drawing.Size(75, 75);
            this.btnR1C3.TabIndex = 2;
            this.btnR1C3.Text = "TOE";
            this.btnR1C3.UseVisualStyleBackColor = true;
            // 
            // btnR2C1
            // 
            this.btnR2C1.Location = new System.Drawing.Point(12, 93);
            this.btnR2C1.Name = "btnR2C1";
            this.btnR2C1.Size = new System.Drawing.Size(75, 75);
            this.btnR2C1.TabIndex = 3;
            this.btnR2C1.Text = "TAC";
            this.btnR2C1.UseVisualStyleBackColor = true;
            // 
            // btnR3C1
            // 
            this.btnR3C1.Location = new System.Drawing.Point(12, 174);
            this.btnR3C1.Name = "btnR3C1";
            this.btnR3C1.Size = new System.Drawing.Size(75, 75);
            this.btnR3C1.TabIndex = 4;
            this.btnR3C1.Text = "TOE";
            this.btnR3C1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnR3C1);
            this.Controls.Add(this.btnR2C1);
            this.Controls.Add(this.btnR1C3);
            this.Controls.Add(this.btnR1C2);
            this.Controls.Add(this.btnR1C1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnR1C1;
        private Button btnR1C2;
        private Button btnR1C3;
        private Button btnR2C1;
        private Button btnR3C1;
    }
}