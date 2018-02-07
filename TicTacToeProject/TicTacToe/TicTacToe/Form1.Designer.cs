namespace TicTacToe
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
            this.A11 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A13 = new System.Windows.Forms.Button();
            this.A23 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A33 = new System.Windows.Forms.Button();
            this.A32 = new System.Windows.Forms.Button();
            this.A31 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.EGButton = new System.Windows.Forms.Button();
            this.Draws = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.XWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(12, 12);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(92, 70);
            this.A11.TabIndex = 0;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(110, 12);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(92, 70);
            this.A12.TabIndex = 1;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A13
            // 
            this.A13.Location = new System.Drawing.Point(208, 12);
            this.A13.Name = "A13";
            this.A13.Size = new System.Drawing.Size(92, 70);
            this.A13.TabIndex = 2;
            this.A13.UseVisualStyleBackColor = true;
            this.A13.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A23
            // 
            this.A23.Location = new System.Drawing.Point(208, 88);
            this.A23.Name = "A23";
            this.A23.Size = new System.Drawing.Size(92, 70);
            this.A23.TabIndex = 5;
            this.A23.UseVisualStyleBackColor = true;
            this.A23.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(110, 88);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(92, 70);
            this.A22.TabIndex = 4;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(12, 88);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(92, 70);
            this.A21.TabIndex = 3;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A33
            // 
            this.A33.Location = new System.Drawing.Point(208, 164);
            this.A33.Name = "A33";
            this.A33.Size = new System.Drawing.Size(92, 70);
            this.A33.TabIndex = 8;
            this.A33.UseVisualStyleBackColor = true;
            this.A33.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A32
            // 
            this.A32.Location = new System.Drawing.Point(110, 164);
            this.A32.Name = "A32";
            this.A32.Size = new System.Drawing.Size(92, 70);
            this.A32.TabIndex = 7;
            this.A32.UseVisualStyleBackColor = true;
            this.A32.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A31
            // 
            this.A31.Location = new System.Drawing.Point(12, 164);
            this.A31.Name = "A31";
            this.A31.Size = new System.Drawing.Size(92, 70);
            this.A31.TabIndex = 6;
            this.A31.UseVisualStyleBackColor = true;
            this.A31.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(12, 260);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(91, 35);
            this.NGButton.TabIndex = 9;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NewGameButtonClick);
            // 
            // RButton
            // 
            this.RButton.Location = new System.Drawing.Point(111, 260);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(91, 35);
            this.RButton.TabIndex = 10;
            this.RButton.Text = "Reset";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // EGButton
            // 
            this.EGButton.Location = new System.Drawing.Point(299, 260);
            this.EGButton.Name = "EGButton";
            this.EGButton.Size = new System.Drawing.Size(91, 35);
            this.EGButton.TabIndex = 11;
            this.EGButton.Text = "Exit Game";
            this.EGButton.UseVisualStyleBackColor = true;
            this.EGButton.Click += new System.EventHandler(this.ExitButton);
            // 
            // Draws
            // 
            this.Draws.Location = new System.Drawing.Point(313, 164);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(77, 39);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "Draws: ";
            // 
            // OWin
            // 
            this.OWin.Location = new System.Drawing.Point(313, 88);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(77, 39);
            this.OWin.TabIndex = 15;
            this.OWin.Text = "O Wins: ";
            // 
            // XWin
            // 
            this.XWin.Location = new System.Drawing.Point(313, 12);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(77, 39);
            this.XWin.TabIndex = 16;
            this.XWin.Text = "X Wins: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 316);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.EGButton);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.A33);
            this.Controls.Add(this.A32);
            this.Controls.Add(this.A31);
            this.Controls.Add(this.A23);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A13);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A13;
        private System.Windows.Forms.Button A23;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A33;
        private System.Windows.Forms.Button A32;
        private System.Windows.Forms.Button A31;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button EGButton;
        private System.Windows.Forms.Label Draws;
        private System.Windows.Forms.Label OWin;
        private System.Windows.Forms.Label XWin;
    }
}

