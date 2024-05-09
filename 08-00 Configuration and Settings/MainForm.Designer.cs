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
            this.btnGetAppValue = new System.Windows.Forms.Button();
            this.btnGetUserValue = new System.Windows.Forms.Button();
            this.btnSetUserValue = new System.Windows.Forms.Button();
            this.edtUserValue = new System.Windows.Forms.NumericUpDown();
            this.btnUserConfigLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.edtUserValue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetAppValue
            // 
            this.btnGetAppValue.Location = new System.Drawing.Point(12, 43);
            this.btnGetAppValue.Name = "btnGetAppValue";
            this.btnGetAppValue.Size = new System.Drawing.Size(114, 23);
            this.btnGetAppValue.TabIndex = 0;
            this.btnGetAppValue.Text = "btnGetAppValue";
            this.btnGetAppValue.UseVisualStyleBackColor = true;
            this.btnGetAppValue.Click += new System.EventHandler(this.btnGetAppValue_Click);
            // 
            // btnGetUserValue
            // 
            this.btnGetUserValue.Location = new System.Drawing.Point(12, 116);
            this.btnGetUserValue.Name = "btnGetUserValue";
            this.btnGetUserValue.Size = new System.Drawing.Size(114, 23);
            this.btnGetUserValue.TabIndex = 2;
            this.btnGetUserValue.Text = "btnGetUserValue";
            this.btnGetUserValue.UseVisualStyleBackColor = true;
            this.btnGetUserValue.Click += new System.EventHandler(this.btnGetUserValue_Click);
            // 
            // btnSetUserValue
            // 
            this.btnSetUserValue.Location = new System.Drawing.Point(12, 145);
            this.btnSetUserValue.Name = "btnSetUserValue";
            this.btnSetUserValue.Size = new System.Drawing.Size(114, 23);
            this.btnSetUserValue.TabIndex = 3;
            this.btnSetUserValue.Text = "btnSetUserValue";
            this.btnSetUserValue.UseVisualStyleBackColor = true;
            this.btnSetUserValue.Click += new System.EventHandler(this.btnSetUserValue_Click);
            // 
            // edtUserValue
            // 
            this.edtUserValue.Location = new System.Drawing.Point(143, 147);
            this.edtUserValue.Name = "edtUserValue";
            this.edtUserValue.Size = new System.Drawing.Size(120, 20);
            this.edtUserValue.TabIndex = 5;
            // 
            // btnUserConfigLocation
            // 
            this.btnUserConfigLocation.Location = new System.Drawing.Point(17, 205);
            this.btnUserConfigLocation.Name = "btnUserConfigLocation";
            this.btnUserConfigLocation.Size = new System.Drawing.Size(148, 23);
            this.btnUserConfigLocation.TabIndex = 6;
            this.btnUserConfigLocation.Text = "btnUserConfigLocation";
            this.btnUserConfigLocation.UseVisualStyleBackColor = true;
            this.btnUserConfigLocation.Click += new System.EventHandler(this.btnUserConfigLocation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 283);
            this.Controls.Add(this.btnUserConfigLocation);
            this.Controls.Add(this.edtUserValue);
            this.Controls.Add(this.btnSetUserValue);
            this.Controls.Add(this.btnGetUserValue);
            this.Controls.Add(this.btnGetAppValue);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.edtUserValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetAppValue;
        private System.Windows.Forms.Button btnGetUserValue;
        private System.Windows.Forms.Button btnSetUserValue;
        private System.Windows.Forms.NumericUpDown edtUserValue;
        private System.Windows.Forms.Button btnUserConfigLocation;
    }
}

