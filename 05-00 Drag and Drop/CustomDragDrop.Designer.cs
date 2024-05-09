namespace Lessons
{
    partial class CustomDragDrop
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
            this.lboSource = new System.Windows.Forms.ListBox();
            this.lboTarget = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboSource
            // 
            this.lboSource.FormattingEnabled = true;
            this.lboSource.Location = new System.Drawing.Point(66, 20);
            this.lboSource.Name = "lboSource";
            this.lboSource.Size = new System.Drawing.Size(257, 82);
            this.lboSource.TabIndex = 0;
            this.lboSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lboSource_MouseDown);
            // 
            // lboTarget
            // 
            this.lboTarget.FormattingEnabled = true;
            this.lboTarget.Location = new System.Drawing.Point(66, 170);
            this.lboTarget.Name = "lboTarget";
            this.lboTarget.Size = new System.Drawing.Size(257, 95);
            this.lboTarget.TabIndex = 1;
            this.lboTarget.DragDrop += new System.Windows.Forms.DragEventHandler(this.lboTarget_DragDrop);
            this.lboTarget.DragEnter += new System.Windows.Forms.DragEventHandler(this.lboTarget_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Demonstrates a custom drag and drop operation.\r\nIt passes an instance of a custom" +
                " class (Person)\r\nfrom one control to another, using a drag and drop operation";
            // 
            // CustomDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboTarget);
            this.Controls.Add(this.lboSource);
            this.Name = "CustomDragDrop";
            this.Text = "CustomDragDrop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboSource;
        private System.Windows.Forms.ListBox lboTarget;
        private System.Windows.Forms.Label label1;
    }
}