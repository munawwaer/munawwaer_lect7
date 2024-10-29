namespace WindowsFormsApplication19
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.العملياتالحسابيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الجمعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الطرحToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الضربToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.القسمهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.العملياتالحسابيةToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(310, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // العملياتالحسابيةToolStripMenuItem
            // 
            this.العملياتالحسابيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الجمعToolStripMenuItem,
            this.الطرحToolStripMenuItem,
            this.الضربToolStripMenuItem,
            this.القسمهToolStripMenuItem});
            this.العملياتالحسابيةToolStripMenuItem.Name = "العملياتالحسابيةToolStripMenuItem";
            this.العملياتالحسابيةToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.العملياتالحسابيةToolStripMenuItem.Text = "العمليات الحسابية";
            // 
            // الجمعToolStripMenuItem
            // 
            this.الجمعToolStripMenuItem.Name = "الجمعToolStripMenuItem";
            this.الجمعToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.الجمعToolStripMenuItem.Text = "الجمع";
            this.الجمعToolStripMenuItem.Click += new System.EventHandler(this.butsum_click);
            // 
            // الطرحToolStripMenuItem
            // 
            this.الطرحToolStripMenuItem.Name = "الطرحToolStripMenuItem";
            this.الطرحToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.الطرحToolStripMenuItem.Text = "الطرح";
            this.الطرحToolStripMenuItem.Click += new System.EventHandler(this.butsub_click);
            // 
            // الضربToolStripMenuItem
            // 
            this.الضربToolStripMenuItem.Name = "الضربToolStripMenuItem";
            this.الضربToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.الضربToolStripMenuItem.Text = "الضرب";
            this.الضربToolStripMenuItem.Click += new System.EventHandler(this.multy_click);
            // 
            // القسمهToolStripMenuItem
            // 
            this.القسمهToolStripMenuItem.Name = "القسمهToolStripMenuItem";
            this.القسمهToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.القسمهToolStripMenuItem.Text = "القسمه";
            this.القسمهToolStripMenuItem.Click += new System.EventHandler(this.divid_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 265);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem العملياتالحسابيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الجمعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الطرحToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الضربToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem القسمهToolStripMenuItem;
    }
}

