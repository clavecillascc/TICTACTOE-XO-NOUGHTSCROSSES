namespace TIC_TAC_TOE___A2___Clavecillas
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
            this.btnR2C2 = new System.Windows.Forms.Button();
            this.btnR2C3 = new System.Windows.Forms.Button();
            this.btnR3C2 = new System.Windows.Forms.Button();
            this.btnR3C3 = new System.Windows.Forms.Button();
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
            this.btnR1C1.Click += new System.EventHandler(this.btnR1C1_Click);
            // 
            // btnR1C2
            // 
            this.btnR1C2.Location = new System.Drawing.Point(93, 12);
            this.btnR1C2.Name = "btnR1C2";
            this.btnR1C2.Size = new System.Drawing.Size(75, 75);
            this.btnR1C2.TabIndex = 1;
            this.btnR1C2.Text = "TAC";
            this.btnR1C2.UseVisualStyleBackColor = true;
            this.btnR1C2.Click += new System.EventHandler(this.btnR1C2_Click);
            // 
            // btnR1C3
            // 
            this.btnR1C3.Location = new System.Drawing.Point(174, 12);
            this.btnR1C3.Name = "btnR1C3";
            this.btnR1C3.Size = new System.Drawing.Size(75, 75);
            this.btnR1C3.TabIndex = 2;
            this.btnR1C3.Text = "TOE";
            this.btnR1C3.UseVisualStyleBackColor = true;
            this.btnR1C3.Click += new System.EventHandler(this.btnR1C3_Click);
            // 
            // btnR2C1
            // 
            this.btnR2C1.Location = new System.Drawing.Point(12, 93);
            this.btnR2C1.Name = "btnR2C1";
            this.btnR2C1.Size = new System.Drawing.Size(75, 75);
            this.btnR2C1.TabIndex = 3;
            this.btnR2C1.Text = "TAC";
            this.btnR2C1.UseVisualStyleBackColor = true;
            this.btnR2C1.Click += new System.EventHandler(this.btnR2C1_Click);
            // 
            // btnR3C1
            // 
            this.btnR3C1.Location = new System.Drawing.Point(12, 174);
            this.btnR3C1.Name = "btnR3C1";
            this.btnR3C1.Size = new System.Drawing.Size(75, 75);
            this.btnR3C1.TabIndex = 4;
            this.btnR3C1.Text = "TOE";
            this.btnR3C1.UseVisualStyleBackColor = true;
            this.btnR3C1.Click += new System.EventHandler(this.btnR3C1_Click);
            // 
            // btnR2C2
            // 
            this.btnR2C2.Location = new System.Drawing.Point(93, 93);
            this.btnR2C2.Name = "btnR2C2";
            this.btnR2C2.Size = new System.Drawing.Size(75, 75);
            this.btnR2C2.TabIndex = 5;
            this.btnR2C2.Text = "NOUGHTS";
            this.btnR2C2.UseVisualStyleBackColor = true;
            this.btnR2C2.Click += new System.EventHandler(this.btnR2C2_Click);
            // 
            // btnR2C3
            // 
            this.btnR2C3.Location = new System.Drawing.Point(174, 93);
            this.btnR2C3.Name = "btnR2C3";
            this.btnR2C3.Size = new System.Drawing.Size(75, 75);
            this.btnR2C3.TabIndex = 6;
            this.btnR2C3.Text = "O";
            this.btnR2C3.UseVisualStyleBackColor = true;
            this.btnR2C3.Click += new System.EventHandler(this.btnR2C3_Click);
            // 
            // btnR3C2
            // 
            this.btnR3C2.Location = new System.Drawing.Point(93, 174);
            this.btnR3C2.Name = "btnR3C2";
            this.btnR3C2.Size = new System.Drawing.Size(75, 75);
            this.btnR3C2.TabIndex = 7;
            this.btnR3C2.Text = "X";
            this.btnR3C2.UseVisualStyleBackColor = true;
            this.btnR3C2.Click += new System.EventHandler(this.btnR3C2_Click);
            // 
            // btnR3C3
            // 
            this.btnR3C3.Location = new System.Drawing.Point(174, 174);
            this.btnR3C3.Name = "btnR3C3";
            this.btnR3C3.Size = new System.Drawing.Size(75, 75);
            this.btnR3C3.TabIndex = 8;
            this.btnR3C3.Text = "CROSSES";
            this.btnR3C3.UseVisualStyleBackColor = true;
            this.btnR3C3.Click += new System.EventHandler(this.btnR3C3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 451);
            this.Controls.Add(this.btnR3C3);
            this.Controls.Add(this.btnR3C2);
            this.Controls.Add(this.btnR2C3);
            this.Controls.Add(this.btnR2C2);
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
        private Button btnR2C2;
        private Button btnR2C3;
        private Button btnR3C2;
        private Button btnR3C3;
    }
}