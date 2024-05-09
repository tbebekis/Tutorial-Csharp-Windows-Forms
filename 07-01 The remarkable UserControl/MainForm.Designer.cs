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
            this.personUserControl1 = new Lessons.PersonUserControl();
            this.SuspendLayout();
            // 
            // personUserControl1
            // 
            this.personUserControl1.EMail = "jdoe@nowhere.com";
            this.personUserControl1.Location = new System.Drawing.Point(48, 12);
            this.personUserControl1.Name = "personUserControl1";
            this.personUserControl1.PersonName = "John Doe";
            this.personUserControl1.Phone = "111-222-333";
            this.personUserControl1.Size = new System.Drawing.Size(308, 159);
            this.personUserControl1.TabIndex = 0;
            this.personUserControl1.Title = "Customer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 283);
            this.Controls.Add(this.personUserControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private PersonUserControl personUserControl1;
    }
}

