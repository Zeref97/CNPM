namespace quanlihocsinh
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
            this.components = new System.ComponentModel.Container();
            this.msBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoCuốiKìToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTổngKếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msTracuu = new System.Windows.Forms.ToolStripMenuItem();
            this.msQuyDinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.msQuanli = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTiepNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsH = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // msBaoCao
            // 
            this.msBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoCuốiKìToolStripMenuItem,
            this.báoCáoTổngKếtToolStripMenuItem});
            this.msBaoCao.Name = "msBaoCao";
            this.msBaoCao.Size = new System.Drawing.Size(77, 24);
            this.msBaoCao.Text = "Báo Cáo";
            // 
            // báoCáoCuốiKìToolStripMenuItem
            // 
            this.báoCáoCuốiKìToolStripMenuItem.Name = "báoCáoCuốiKìToolStripMenuItem";
            this.báoCáoCuốiKìToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.báoCáoCuốiKìToolStripMenuItem.Text = "Báo Cáo Tổng Kết Môn";
            this.báoCáoCuốiKìToolStripMenuItem.Click += new System.EventHandler(this.báoCáoCuốiKìToolStripMenuItem_Click);
            // 
            // báoCáoTổngKếtToolStripMenuItem
            // 
            this.báoCáoTổngKếtToolStripMenuItem.Name = "báoCáoTổngKếtToolStripMenuItem";
            this.báoCáoTổngKếtToolStripMenuItem.Size = new System.Drawing.Size(247, 24);
            this.báoCáoTổngKếtToolStripMenuItem.Text = "Báo Cáo Tổng Kết Học Kì";
            this.báoCáoTổngKếtToolStripMenuItem.Click += new System.EventHandler(this.báoCáoTổngKếtToolStripMenuItem_Click);
            // 
            // msTracuu
            // 
            this.msTracuu.Name = "msTracuu";
            this.msTracuu.Size = new System.Drawing.Size(138, 24);
            this.msTracuu.Text = "Tra Cứu Học Sinh";
            this.msTracuu.Click += new System.EventHandler(this.msTracuu_Click);
            // 
            // msQuyDinh
            // 
            this.msQuyDinh.Name = "msQuyDinh";
            this.msQuyDinh.Size = new System.Drawing.Size(86, 24);
            this.msQuyDinh.Text = "Quy Định";
            this.msQuyDinh.Click += new System.EventHandler(this.msQuyDinh_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem1,
            this.tàiKhoảnToolStripMenuItem,
            this.msQuanli,
            this.danhSáchToolStripMenuItem,
            this.msBaoCao,
            this.msTracuu,
            this.msQuyDinh});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(672, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "MenuStrip";
            // 
            // msQuanli
            // 
            this.msQuanli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTiepNhan});
            this.msQuanli.Name = "msQuanli";
            this.msQuanli.Size = new System.Drawing.Size(92, 24);
            this.msQuanli.Text = "Tiếp Nhận";
            this.msQuanli.Click += new System.EventHandler(this.msQuanli_Click);
            // 
            // tsTiepNhan
            // 
            this.tsTiepNhan.ImageTransparentColor = System.Drawing.Color.Black;
            this.tsTiepNhan.Name = "tsTiepNhan";
            this.tsTiepNhan.Size = new System.Drawing.Size(214, 24);
            this.tsTiepNhan.Text = "&Tiếp Nhận Học Sinh";
            this.tsTiepNhan.Click += new System.EventHandler(this.tsTiepNhan_Click);
            // 
            // danhSáchToolStripMenuItem
            // 
            this.danhSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchLớpToolStripMenuItem,
            this.bảngĐiểmToolStripMenuItem});
            this.danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            this.danhSáchToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.danhSáchToolStripMenuItem.Text = "Danh Sách";
            // 
            // danhSáchLớpToolStripMenuItem
            // 
            this.danhSáchLớpToolStripMenuItem.Name = "danhSáchLớpToolStripMenuItem";
            this.danhSáchLớpToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.danhSáchLớpToolStripMenuItem.Text = "Danh Sách Lớp";
            this.danhSáchLớpToolStripMenuItem.Click += new System.EventHandler(this.danhSáchLớpToolStripMenuItem_Click);
            // 
            // bảngĐiểmToolStripMenuItem
            // 
            this.bảngĐiểmToolStripMenuItem.Name = "bảngĐiểmToolStripMenuItem";
            this.bảngĐiểmToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.bảngĐiểmToolStripMenuItem.Text = "Bảng Điểm";
            this.bảngĐiểmToolStripMenuItem.Click += new System.EventHandler(this.bảngĐiểmToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsC,
            this.tsV,
            this.tsH,
            this.closeAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 92);
            // 
            // tsC
            // 
            this.tsC.Name = "tsC";
            this.tsC.Size = new System.Drawing.Size(151, 22);
            this.tsC.Text = "&Cascade";
            // 
            // tsV
            // 
            this.tsV.Name = "tsV";
            this.tsV.Size = new System.Drawing.Size(151, 22);
            this.tsV.Text = "Tile &Horizontal";
            // 
            // tsH
            // 
            this.tsH.Name = "tsH";
            this.tsH.Size = new System.Drawing.Size(151, 22);
            this.tsH.Text = "Tile &Vertical";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 330);
            this.dataGridView1.TabIndex = 7;
            // 
            // adminToolStripMenuItem1
            // 
            this.adminToolStripMenuItem1.Name = "adminToolStripMenuItem1";
            this.adminToolStripMenuItem1.Size = new System.Drawing.Size(66, 24);
            this.adminToolStripMenuItem1.Text = "Admin";
            this.adminToolStripMenuItem1.Click += new System.EventHandler(this.adminToolStripMenuItem1_Click_1);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 369);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem msBaoCao;
        private System.Windows.Forms.ToolStripMenuItem msTracuu;
        private System.Windows.Forms.ToolStripMenuItem msQuyDinh;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem msQuanli;
        private System.Windows.Forms.ToolStripMenuItem tsTiepNhan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsC;
        private System.Windows.Forms.ToolStripMenuItem tsV;
        private System.Windows.Forms.ToolStripMenuItem tsH;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoCuốiKìToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchLớpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTổngKếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}

