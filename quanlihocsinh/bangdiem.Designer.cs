namespace quanlihocsinh
{
    partial class bangdiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DiemThiLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem1tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemMieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonX7 = new System.Windows.Forms.Button();
            this.cmbMonhocCN = new System.Windows.Forms.ComboBox();
            this.cmbLopCN = new System.Windows.Forms.ComboBox();
            this.cmbHockyCN = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DiemThiLai
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiemThiLai.DefaultCellStyle = dataGridViewCellStyle1;
            this.DiemThiLai.HeaderText = "Điểm Thi Lại";
            this.DiemThiLai.Name = "DiemThiLai";
            // 
            // Diem1tiet
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diem1tiet.DefaultCellStyle = dataGridViewCellStyle2;
            this.Diem1tiet.HeaderText = "Điểm 1 tiết";
            this.Diem1tiet.Name = "Diem1tiet";
            this.Diem1tiet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Diem1tiet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Diem15phut
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diem15phut.DefaultCellStyle = dataGridViewCellStyle3;
            this.Diem15phut.HeaderText = "Điểm 15 phút";
            this.Diem15phut.Name = "Diem15phut";
            // 
            // DiemMieng
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiemMieng.DefaultCellStyle = dataGridViewCellStyle4;
            this.DiemMieng.HeaderText = "Điểm Miệng";
            this.DiemMieng.Name = "DiemMieng";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.DefaultCellStyle = dataGridViewCellStyle5;
            this.HoTen.HeaderText = "Tên Học Sinh";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 150;
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHocSinh.DefaultCellStyle = dataGridViewCellStyle6;
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.Width = 130;
            // 
            // DiemThi
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiemThi.DefaultCellStyle = dataGridViewCellStyle7;
            this.DiemThi.HeaderText = "Điểm Thi";
            this.DiemThi.Name = "DiemThi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Môn học :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Học kỳ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Lớp :";
            // 
            // buttonX7
            // 
            this.buttonX7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX7.ForeColor = System.Drawing.Color.Blue;
            this.buttonX7.Location = new System.Drawing.Point(340, 70);
            this.buttonX7.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(151, 40);
            this.buttonX7.TabIndex = 56;
            this.buttonX7.Text = "Hiển Thị Danh Sách";
            this.buttonX7.UseVisualStyleBackColor = true;
            // 
            // cmbMonhocCN
            // 
            this.cmbMonhocCN.FormattingEnabled = true;
            this.cmbMonhocCN.Location = new System.Drawing.Point(100, 126);
            this.cmbMonhocCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMonhocCN.Name = "cmbMonhocCN";
            this.cmbMonhocCN.Size = new System.Drawing.Size(160, 21);
            this.cmbMonhocCN.TabIndex = 55;
            // 
            // cmbLopCN
            // 
            this.cmbLopCN.FormattingEnabled = true;
            this.cmbLopCN.Location = new System.Drawing.Point(100, 43);
            this.cmbLopCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLopCN.Name = "cmbLopCN";
            this.cmbLopCN.Size = new System.Drawing.Size(160, 21);
            this.cmbLopCN.TabIndex = 54;
            // 
            // cmbHockyCN
            // 
            this.cmbHockyCN.FormattingEnabled = true;
            this.cmbHockyCN.Location = new System.Drawing.Point(100, 85);
            this.cmbHockyCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHockyCN.Name = "cmbHockyCN";
            this.cmbHockyCN.Size = new System.Drawing.Size(160, 21);
            this.cmbHockyCN.TabIndex = 53;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 305);
            this.dataGridView1.TabIndex = 60;
            // 
            // bangdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonX7);
            this.Controls.Add(this.cmbMonhocCN);
            this.Controls.Add(this.cmbLopCN);
            this.Controls.Add(this.cmbHockyCN);
            this.Name = "bangdiem";
            this.Text = "bangdiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThiLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem1tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonX7;
        private System.Windows.Forms.ComboBox cmbMonhocCN;
        private System.Windows.Forms.ComboBox cmbLopCN;
        private System.Windows.Forms.ComboBox cmbHockyCN;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}