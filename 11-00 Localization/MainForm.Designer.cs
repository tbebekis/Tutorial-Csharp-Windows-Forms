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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.αρχείοToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.εξοδοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreek = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMessage = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.αρχείοToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // αρχείοToolStripMenuItem
            // 
            resources.ApplyResources(this.αρχείοToolStripMenuItem, "αρχείοToolStripMenuItem");
            this.αρχείοToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.εξοδοςToolStripMenuItem});
            this.αρχείοToolStripMenuItem.Name = "αρχείοToolStripMenuItem";
            // 
            // εξοδοςToolStripMenuItem
            // 
            resources.ApplyResources(this.εξοδοςToolStripMenuItem, "εξοδοςToolStripMenuItem");
            this.εξοδοςToolStripMenuItem.Name = "εξοδοςToolStripMenuItem";
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGreek,
            this.mnuEnglish});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // mnuGreek
            // 
            resources.ApplyResources(this.mnuGreek, "mnuGreek");
            this.mnuGreek.Name = "mnuGreek";
            this.mnuGreek.Click += new System.EventHandler(this.mnuGreek_Click);
            // 
            // mnuEnglish
            // 
            resources.ApplyResources(this.mnuEnglish, "mnuEnglish");
            this.mnuEnglish.Name = "mnuEnglish";
            this.mnuEnglish.Click += new System.EventHandler(this.mnuEnglish_Click);
            // 
            // btnMessage
            // 
            resources.ApplyResources(this.btnMessage, "btnMessage");
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem αρχείοToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem εξοδοςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGreek;
        private System.Windows.Forms.ToolStripMenuItem mnuEnglish;
        private System.Windows.Forms.Button btnMessage;
    }
}

