namespace quanlihocsinh
{
    partial class tiepnhanhocsinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeInput1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxX2 = new System.Windows.Forms.RadioButton();
            this.checkBoxX1 = new System.Windows.Forms.RadioButton();
            this.textBoxdiachi = new System.Windows.Forms.TextBox();
            this.textBoxTenhs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonthem = new System.Windows.Forms.Button();
            this.quanLyHocSinhDataSet = new quanlihocsinh.QuanLyHocSinhDataSet();
            this.hOCSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCSINHTableAdapter = new quanlihocsinh.QuanLyHocSinhDataSetTableAdapters.HOCSINHTableAdapter();
            this.tableAdapterManager = new quanlihocsinh.QuanLyHocSinhDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocSinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxemail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimeInput1);
            this.groupBox1.Controls.Add(this.checkBoxX2);
            this.groupBox1.Controls.Add(this.checkBoxX1);
            this.groupBox1.Controls.Add(this.textBoxdiachi);
            this.groupBox1.Controls.Add(this.textBoxTenhs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(378, 249);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // textBoxemail
            // 
            this.textBoxemail.Location = new System.Drawing.Point(135, 197);
            this.textBoxemail.Name = "textBoxemail";
            this.textBoxemail.Size = new System.Drawing.Size(195, 20);
            this.textBoxemail.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Email:";
            // 
            // dateTimeInput1
            // 
            this.dateTimeInput1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeInput1.Location = new System.Drawing.Point(137, 110);
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(193, 20);
            this.dateTimeInput1.TabIndex = 78;
            this.dateTimeInput1.Value = new System.DateTime(1990, 10, 12, 2, 48, 0, 0);
            // 
            // checkBoxX2
            // 
            this.checkBoxX2.Location = new System.Drawing.Point(219, 77);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.Size = new System.Drawing.Size(58, 21);
            this.checkBoxX2.TabIndex = 77;
            this.checkBoxX2.TabStop = true;
            this.checkBoxX2.Text = "Nữ";
            this.checkBoxX2.UseVisualStyleBackColor = true;
            // 
            // checkBoxX1
            // 
            this.checkBoxX1.Location = new System.Drawing.Point(137, 77);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.Size = new System.Drawing.Size(76, 21);
            this.checkBoxX1.TabIndex = 76;
            this.checkBoxX1.TabStop = true;
            this.checkBoxX1.Text = "Nam";
            this.checkBoxX1.UseVisualStyleBackColor = true;
            // 
            // textBoxdiachi
            // 
            this.textBoxdiachi.Location = new System.Drawing.Point(135, 155);
            this.textBoxdiachi.Name = "textBoxdiachi";
            this.textBoxdiachi.Size = new System.Drawing.Size(195, 20);
            this.textBoxdiachi.TabIndex = 61;
            // 
            // textBoxTenhs
            // 
            this.textBoxTenhs.Location = new System.Drawing.Point(137, 37);
            this.textBoxTenhs.Name = "textBoxTenhs";
            this.textBoxTenhs.Size = new System.Drawing.Size(163, 20);
            this.textBoxTenhs.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tên học sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Địa chỉ:";
            // 
            // buttonthem
            // 
            this.buttonthem.Location = new System.Drawing.Point(268, 280);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(90, 37);
            this.buttonthem.TabIndex = 10;
            this.buttonthem.Text = "Thêm";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // quanLyHocSinhDataSet
            // 
            this.quanLyHocSinhDataSet.DataSetName = "QuanLyHocSinhDataSet";
            this.quanLyHocSinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOCSINHBindingSource
            // 
            this.hOCSINHBindingSource.DataMember = "HOCSINH";
            this.hOCSINHBindingSource.DataSource = this.quanLyHocSinhDataSet;
            // 
            // hOCSINHTableAdapter
            // 
            this.hOCSINHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOCAOTONGKETHOCKYTableAdapter = null;
            this.tableAdapterManager.BAOCAOTONGKETMONTableAdapter = null;
            this.tableAdapterManager.DANHSACHHOCSINHTableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = this.hOCSINHTableAdapter;
            this.tableAdapterManager.KHOITableAdapter = null;
            this.tableAdapterManager.KQ_HOC_KY_MON_HOCTableAdapter = null;
            this.tableAdapterManager.KQ_HOC_KY_TONG_HOPTableAdapter = null;
            this.tableAdapterManager.LOAIDIEMTableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NAMHOCTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHANLOPTableAdapter = null;
            this.tableAdapterManager.THAMSOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = quanlihocsinh.QuanLyHocSinhDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tiepnhanhocsinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonthem);
            this.Name = "tiepnhanhocsinh";
            this.Text = "tiepnhanhocsinh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocSinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxemail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeInput1;
        private System.Windows.Forms.RadioButton checkBoxX2;
        private System.Windows.Forms.RadioButton checkBoxX1;
        private System.Windows.Forms.TextBox textBoxdiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonthem;
        private QuanLyHocSinhDataSet quanLyHocSinhDataSet;
        private System.Windows.Forms.BindingSource hOCSINHBindingSource;
        private QuanLyHocSinhDataSetTableAdapters.HOCSINHTableAdapter hOCSINHTableAdapter;
        private QuanLyHocSinhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBoxTenhs;
        private System.Windows.Forms.Label label7;
    }
}