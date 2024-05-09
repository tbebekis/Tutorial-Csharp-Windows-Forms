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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCallDllFunc = new System.Windows.Forms.Button();
            this.btnResourceString = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 93);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCallDllFunc
            // 
            this.btnCallDllFunc.Location = new System.Drawing.Point(67, 171);
            this.btnCallDllFunc.Name = "btnCallDllFunc";
            this.btnCallDllFunc.Size = new System.Drawing.Size(123, 23);
            this.btnCallDllFunc.TabIndex = 1;
            this.btnCallDllFunc.Text = "btnCallDllFunc";
            this.btnCallDllFunc.UseVisualStyleBackColor = true;
            this.btnCallDllFunc.Click += new System.EventHandler(this.btnCallDllFunc_Click);
            // 
            // btnResourceString
            // 
            this.btnResourceString.Location = new System.Drawing.Point(67, 142);
            this.btnResourceString.Name = "btnResourceString";
            this.btnResourceString.Size = new System.Drawing.Size(123, 23);
            this.btnResourceString.TabIndex = 2;
            this.btnResourceString.Text = "btnResourceString";
            this.btnResourceString.UseVisualStyleBackColor = true;
            this.btnResourceString.Click += new System.EventHandler(this.btnResourceString_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnResourceString);
            this.Controls.Add(this.btnCallDllFunc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCallDllFunc;
        private System.Windows.Forms.Button btnResourceString;


    }
}

