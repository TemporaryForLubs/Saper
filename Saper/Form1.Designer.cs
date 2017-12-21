using System.Windows.Forms;

namespace Saper
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
            if (exitFromMenu)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            else
            {
                DialogResult res = MessageBox.Show("", "Хотите выйти?", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    if (disposing && (components != null))
                    {
                        components.Dispose();
                    }
                    base.Dispose(disposing);
                }
            }
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
            this.дополнительноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.НовичёкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.УмелецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПрофессионалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОсобыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ВыходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c = new System.Windows.Forms.ToolStripMenuItem();
            this.КакигратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОпрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дополнительноToolStripMenuItem,
            this.c});
            this.menuStrip1.Location = new System.Drawing.Point(0, 397);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(611, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // дополнительноToolStripMenuItem
            // 
            this.дополнительноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.toolStripSeparator2,
            this.НовичёкToolStripMenuItem,
            this.УмелецToolStripMenuItem,
            this.ПрофессионалToolStripMenuItem,
            this.ОсобыйToolStripMenuItem,
            this.toolStripSeparator1,
            this.ВыходToolStripMenuItem});
            this.дополнительноToolStripMenuItem.Name = "дополнительноToolStripMenuItem";
            this.дополнительноToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.дополнительноToolStripMenuItem.Text = "Игра";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ToolStripMenuItem.Text = "Новая игра    ctrl+N";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(219, 6);
            // 
            // НовичёкToolStripMenuItem
            // 
            this.НовичёкToolStripMenuItem.Checked = true;
            this.НовичёкToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.НовичёкToolStripMenuItem.Name = "НовичёкToolStripMenuItem";
            this.НовичёкToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.НовичёкToolStripMenuItem.Text = "Новичёк";
            this.НовичёкToolStripMenuItem.Click += new System.EventHandler(this.НовичёкToolStripMenuItem_Click);
            // 
            // УмелецToolStripMenuItem
            // 
            this.УмелецToolStripMenuItem.Name = "УмелецToolStripMenuItem";
            this.УмелецToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.УмелецToolStripMenuItem.Text = "Умелец";
            this.УмелецToolStripMenuItem.Click += new System.EventHandler(this.УмелецToolStripMenuItem_Click);
            // 
            // ПрофессионалToolStripMenuItem
            // 
            this.ПрофессионалToolStripMenuItem.Name = "ПрофессионалToolStripMenuItem";
            this.ПрофессионалToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ПрофессионалToolStripMenuItem.Text = "Профессионал";
            this.ПрофессионалToolStripMenuItem.Click += new System.EventHandler(this.ПрофессионалToolStripMenuItem_Click);
            // 
            // ОсобыйToolStripMenuItem
            // 
            this.ОсобыйToolStripMenuItem.Name = "ОсобыйToolStripMenuItem";
            this.ОсобыйToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ОсобыйToolStripMenuItem.Text = "Особый";
            this.ОсобыйToolStripMenuItem.Click += new System.EventHandler(this.ОсобыйToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // ВыходToolStripMenuItem
            // 
            this.ВыходToolStripMenuItem.Name = "ВыходToolStripMenuItem";
            this.ВыходToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ВыходToolStripMenuItem.Text = "Выход         Alt+F4";
            this.ВыходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
            // 
            // c
            // 
            this.c.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.КакигратьToolStripMenuItem,
            this.ОпрограммеToolStripMenuItem});
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(114, 24);
            this.c.Text = "Информация";
            // 
            // КакигратьToolStripMenuItem
            // 
            this.КакигратьToolStripMenuItem.Name = "КакигратьToolStripMenuItem";
            this.КакигратьToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.КакигратьToolStripMenuItem.Text = "Как играть";
            this.КакигратьToolStripMenuItem.Click += new System.EventHandler(this.КакигратьToolStripMenuItem_Click);
            // 
            // ОпрограммеToolStripMenuItem
            // 
            this.ОпрограммеToolStripMenuItem.Name = "ОпрограммеToolStripMenuItem";
            this.ОпрограммеToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.ОпрограммеToolStripMenuItem.Text = "О программе";
            this.ОпрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОпрограммеToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Saper.Properties.Resources.bomb;
            this.pictureBox1.Location = new System.Drawing.Point(201, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапер";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem дополнительноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem c;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem НовичёкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem УмелецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПрофессионалToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ВыходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ОсобыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem КакигратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ОпрограммеToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBox1;
    }
}

