namespace Lessons
{
    partial class MainForm
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
            this.pnlLime = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlGray = new System.Windows.Forms.Panel();
            this.pnlYellow = new System.Windows.Forms.Panel();
            this.pnlBlue = new System.Windows.Forms.Panel();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.pnlLime.SuspendLayout();
            this.pnlGray.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLime
            // 
            this.pnlLime.BackColor = System.Drawing.Color.Lime;
            this.pnlLime.Controls.Add(this.button1);
            this.pnlLime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLime.Location = new System.Drawing.Point(0, 212);
            this.pnlLime.Name = "pnlLime";
            this.pnlLime.Size = new System.Drawing.Size(309, 39);
            this.pnlLime.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Location = new System.Drawing.Point(222, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlGray
            // 
            this.pnlGray.Controls.Add(this.pnlYellow);
            this.pnlGray.Controls.Add(this.pnlBlue);
            this.pnlGray.Controls.Add(this.pnlGreen);
            this.pnlGray.Controls.Add(this.pnlRed);
            this.pnlGray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGray.Location = new System.Drawing.Point(0, 0);
            this.pnlGray.Name = "pnlGray";
            this.pnlGray.Size = new System.Drawing.Size(309, 212);
            this.pnlGray.TabIndex = 1;
            // 
            // pnlYellow
            // 
            this.pnlYellow.BackColor = System.Drawing.Color.Yellow;
            this.pnlYellow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlYellow.Location = new System.Drawing.Point(250, 47);
            this.pnlYellow.Name = "pnlYellow";
            this.pnlYellow.Size = new System.Drawing.Size(59, 165);
            this.pnlYellow.TabIndex = 3;
            // 
            // pnlBlue
            // 
            this.pnlBlue.BackColor = System.Drawing.Color.Blue;
            this.pnlBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBlue.Location = new System.Drawing.Point(158, 0);
            this.pnlBlue.Name = "pnlBlue";
            this.pnlBlue.Size = new System.Drawing.Size(151, 47);
            this.pnlBlue.TabIndex = 2;
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.Green;
            this.pnlGreen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlGreen.Location = new System.Drawing.Point(79, 0);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(79, 212);
            this.pnlGreen.TabIndex = 1;
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.Red;
            this.pnlRed.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRed.Location = new System.Drawing.Point(0, 0);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(79, 212);
            this.pnlRed.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 251);
            this.Controls.Add(this.pnlGray);
            this.Controls.Add(this.pnlLime);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlLime.ResumeLayout(false);
            this.pnlGray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlGray;
        private System.Windows.Forms.Panel pnlYellow;
        private System.Windows.Forms.Panel pnlBlue;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Panel pnlRed;
    }
}

