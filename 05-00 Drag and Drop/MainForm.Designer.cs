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
            this.btnSimpleDragDrop = new System.Windows.Forms.Button();
            this.btnCustomDragDrop = new System.Windows.Forms.Button();
            this.btnFileDragDrop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSimpleDragDrop
            // 
            this.btnSimpleDragDrop.Location = new System.Drawing.Point(63, 12);
            this.btnSimpleDragDrop.Name = "btnSimpleDragDrop";
            this.btnSimpleDragDrop.Size = new System.Drawing.Size(183, 23);
            this.btnSimpleDragDrop.TabIndex = 0;
            this.btnSimpleDragDrop.Text = "btnSimpleDragDrop";
            this.btnSimpleDragDrop.UseVisualStyleBackColor = true;
            this.btnSimpleDragDrop.Click += new System.EventHandler(this.btnSimpleDragDrop_Click);
            // 
            // btnCustomDragDrop
            // 
            this.btnCustomDragDrop.Location = new System.Drawing.Point(64, 40);
            this.btnCustomDragDrop.Name = "btnCustomDragDrop";
            this.btnCustomDragDrop.Size = new System.Drawing.Size(182, 23);
            this.btnCustomDragDrop.TabIndex = 1;
            this.btnCustomDragDrop.Text = "btnCustomDragDrop";
            this.btnCustomDragDrop.UseVisualStyleBackColor = true;
            this.btnCustomDragDrop.Click += new System.EventHandler(this.btnCustomDragDrop_Click);
            // 
            // btnFileDragDrop
            // 
            this.btnFileDragDrop.Location = new System.Drawing.Point(63, 69);
            this.btnFileDragDrop.Name = "btnFileDragDrop";
            this.btnFileDragDrop.Size = new System.Drawing.Size(183, 23);
            this.btnFileDragDrop.TabIndex = 2;
            this.btnFileDragDrop.Text = "btnFileDragDrop";
            this.btnFileDragDrop.UseVisualStyleBackColor = true;
            this.btnFileDragDrop.Click += new System.EventHandler(this.btnFileDragDrop_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 131);
            this.Controls.Add(this.btnFileDragDrop);
            this.Controls.Add(this.btnCustomDragDrop);
            this.Controls.Add(this.btnSimpleDragDrop);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleDragDrop;
        private System.Windows.Forms.Button btnCustomDragDrop;
        private System.Windows.Forms.Button btnFileDragDrop;
    }
}

