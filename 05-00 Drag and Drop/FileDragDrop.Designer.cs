namespace Lessons
{
    partial class FileDragDrop
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
            this.lboTarget = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboTarget
            // 
            this.lboTarget.FormattingEnabled = true;
            this.lboTarget.Location = new System.Drawing.Point(7, 34);
            this.lboTarget.Name = "lboTarget";
            this.lboTarget.Size = new System.Drawing.Size(649, 290);
            this.lboTarget.TabIndex = 0;
            this.lboTarget.DragDrop += new System.Windows.Forms.DragEventHandler(this.lboTarget_DragDrop);
            this.lboTarget.DragEnter += new System.Windows.Forms.DragEventHandler(this.lboTarget_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drag files from a File Explorer window and drop them into this listbox";
            // 
            // FileDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboTarget);
            this.Name = "FileDragDrop";
            this.Text = "FileDragDrop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboTarget;
        private System.Windows.Forms.Label label1;
    }
}