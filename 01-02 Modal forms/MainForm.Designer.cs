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
            this.btnDialogForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDialogForm
            // 
            this.btnDialogForm.Location = new System.Drawing.Point(113, 198);
            this.btnDialogForm.Name = "btnDialogForm";
            this.btnDialogForm.Size = new System.Drawing.Size(91, 23);
            this.btnDialogForm.TabIndex = 0;
            this.btnDialogForm.Text = "btnDialogForm";
            this.btnDialogForm.UseVisualStyleBackColor = true;
            this.btnDialogForm.Click += new System.EventHandler(this.btnDialogForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 290);
            this.Controls.Add(this.btnDialogForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDialogForm;
    }
}

