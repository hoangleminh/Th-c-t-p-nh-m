namespace QUANLYNHANSU
{
    partial class MENU
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
            this.Quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.Huongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.Thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.LOGOUT = new System.Windows.Forms.ToolStripMenuItem();
            this.EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelThaotac = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Quanly,
            this.Huongdan,
            this.Thongtin,
            this.LOGOUT,
            this.EXIT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Quanly
            // 
            this.Quanly.Name = "Quanly";
            this.Quanly.Size = new System.Drawing.Size(124, 20);
            this.Quanly.Text = "QUẢN LÝ NHÂN SỰ";
            this.Quanly.Click += new System.EventHandler(this.Quanly_Click);
            // 
            // Huongdan
            // 
            this.Huongdan.Name = "Huongdan";
            this.Huongdan.Size = new System.Drawing.Size(90, 20);
            this.Huongdan.Text = "HƯỚNG DÂN";
            // 
            // Thongtin
            // 
            this.Thongtin.Name = "Thongtin";
            this.Thongtin.Size = new System.Drawing.Size(83, 20);
            this.Thongtin.Text = "THÔNG TIN";
            this.Thongtin.Click += new System.EventHandler(this.Thongtin_Click);
            // 
            // LOGOUT
            // 
            this.LOGOUT.Name = "LOGOUT";
            this.LOGOUT.Size = new System.Drawing.Size(85, 20);
            this.LOGOUT.Text = "ĐĂNG XUẤT";
            this.LOGOUT.Click += new System.EventHandler(this.LOGOUT_Click);
            // 
            // EXIT
            // 
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(59, 20);
            this.EXIT.Text = "THOÁT";
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // PanelThaotac
            // 
            this.PanelThaotac.AutoScroll = true;
            this.PanelThaotac.AutoSize = true;
            this.PanelThaotac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelThaotac.Location = new System.Drawing.Point(12, 37);
            this.PanelThaotac.Name = "PanelThaotac";
            this.PanelThaotac.Size = new System.Drawing.Size(783, 463);
            this.PanelThaotac.TabIndex = 1;
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 512);
            this.Controls.Add(this.PanelThaotac);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Quanly;
        private System.Windows.Forms.ToolStripMenuItem Huongdan;
        private System.Windows.Forms.ToolStripMenuItem Thongtin;
        private System.Windows.Forms.Panel PanelThaotac;
        private System.Windows.Forms.ToolStripMenuItem LOGOUT;
        private System.Windows.Forms.ToolStripMenuItem EXIT;
    }
}