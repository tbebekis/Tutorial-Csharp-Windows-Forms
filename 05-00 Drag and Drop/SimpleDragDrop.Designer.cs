namespace Lessons
{
    partial class SimpleDragDrop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleDragDrop));
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lboTarget = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(56, 12);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(319, 20);
            this.txtSource.TabIndex = 0;
            this.txtSource.Text = "Drag source";
            this.txtSource.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSource_MouseDown);
            // 
            // lboTarget
            // 
            this.lboTarget.FormattingEnabled = true;
            this.lboTarget.Location = new System.Drawing.Point(12, 129);
            this.lboTarget.Name = "lboTarget";
            this.lboTarget.Size = new System.Drawing.Size(404, 212);
            this.lboTarget.TabIndex = 1;
            this.lboTarget.DragDrop += new System.Windows.Forms.DragEventHandler(this.lboTarget_DragDrop);
            this.lboTarget.DragEnter += new System.Windows.Forms.DragEventHandler(this.lboTarget_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 78);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // SimpleDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboTarget);
            this.Controls.Add(this.txtSource);
            this.Name = "SimpleDragDrop";
            this.Text = "SimpleDragDrop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.ListBox lboTarget;
        private System.Windows.Forms.Label label1;
    }
}