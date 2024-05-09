namespace Lessons
{
    partial class PersonUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboBox = new System.Windows.Forms.GroupBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtPhone = new System.Windows.Forms.TextBox();
            this.edtEMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboBox
            // 
            this.gboBox.Controls.Add(this.label3);
            this.gboBox.Controls.Add(this.label2);
            this.gboBox.Controls.Add(this.label1);
            this.gboBox.Controls.Add(this.edtEMail);
            this.gboBox.Controls.Add(this.edtPhone);
            this.gboBox.Controls.Add(this.edtName);
            this.gboBox.Location = new System.Drawing.Point(13, 12);
            this.gboBox.Name = "gboBox";
            this.gboBox.Size = new System.Drawing.Size(280, 131);
            this.gboBox.TabIndex = 0;
            this.gboBox.TabStop = false;
            this.gboBox.Text = "Title";
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(79, 32);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(168, 20);
            this.edtName.TabIndex = 0;
            // 
            // edtPhone
            // 
            this.edtPhone.Location = new System.Drawing.Point(79, 58);
            this.edtPhone.Name = "edtPhone";
            this.edtPhone.Size = new System.Drawing.Size(168, 20);
            this.edtPhone.TabIndex = 1;
            // 
            // edtEMail
            // 
            this.edtEMail.Location = new System.Drawing.Point(79, 84);
            this.edtEMail.Name = "edtEMail";
            this.edtEMail.Size = new System.Drawing.Size(168, 20);
            this.edtEMail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "e-mail";
            // 
            // PersonUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gboBox);
            this.Name = "PersonUserControl";
            this.Size = new System.Drawing.Size(308, 159);
            this.gboBox.ResumeLayout(false);
            this.gboBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtEMail;
        private System.Windows.Forms.TextBox edtPhone;
        private System.Windows.Forms.TextBox edtName;
    }
}
