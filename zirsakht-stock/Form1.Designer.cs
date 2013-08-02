namespace zirsakht_stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.فایلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ورودبهانبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجازانبارToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.گزارشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کاردکسToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.فایلToolStripMenuItem,
            this.گزارشToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // فایلToolStripMenuItem
            // 
            this.فایلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ورودبهانبارToolStripMenuItem,
            this.خروجازانبارToolStripMenuItem,
            this.خروجToolStripMenuItem});
            this.فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            this.فایلToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.فایلToolStripMenuItem.Text = "فایل";
            // 
            // ورودبهانبارToolStripMenuItem
            // 
            this.ورودبهانبارToolStripMenuItem.Name = "ورودبهانبارToolStripMenuItem";
            this.ورودبهانبارToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ورودبهانبارToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ورودبهانبارToolStripMenuItem.Text = "ورود به انبار";
            this.ورودبهانبارToolStripMenuItem.Click += new System.EventHandler(this.ورودبهانبارToolStripMenuItem_Click);
            // 
            // خروجازانبارToolStripMenuItem
            // 
            this.خروجازانبارToolStripMenuItem.Name = "خروجازانبارToolStripMenuItem";
            this.خروجازانبارToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.خروجازانبارToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.خروجازانبارToolStripMenuItem.Text = "خروج از انبار";
            this.خروجازانبارToolStripMenuItem.Click += new System.EventHandler(this.خروجازانبارToolStripMenuItem_Click);
            // 
            // خروجToolStripMenuItem
            // 
            this.خروجToolStripMenuItem.Name = "خروجToolStripMenuItem";
            this.خروجToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.خروجToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.خروجToolStripMenuItem.Text = "خروج";
            this.خروجToolStripMenuItem.Click += new System.EventHandler(this.خروجToolStripMenuItem_Click);
            // 
            // گزارشToolStripMenuItem
            // 
            this.گزارشToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.کاردکسToolStripMenuItem});
            this.گزارشToolStripMenuItem.Name = "گزارشToolStripMenuItem";
            this.گزارشToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.گزارشToolStripMenuItem.Text = "گزارش";
            // 
            // کاردکسToolStripMenuItem
            // 
            this.کاردکسToolStripMenuItem.Name = "کاردکسToolStripMenuItem";
            this.کاردکسToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.کاردکسToolStripMenuItem.Text = "کاردکس";
            this.کاردکسToolStripMenuItem.Click += new System.EventHandler(this.کاردکسToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 568);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem فایلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ورودبهانبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجازانبارToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem گزارشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem کاردکسToolStripMenuItem;

    }
}

