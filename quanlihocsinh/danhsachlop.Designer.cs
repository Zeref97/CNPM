namespace quanlihocsinh
{
    partial class danhsachlop
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonX7 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.quanLyHocSinhDataSet = new quanlihocsinh.QuanLyHocSinhDataSet();
            this.dANHSACHHOCSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dANHSACHHOCSINHTableAdapter = new quanlihocsinh.QuanLyHocSinhDataSetTableAdapters.DANHSACHHOCSINHTableAdapter();
            this.tableAdapterManager = new quanlihocsinh.QuanLyHocSinhDataSetTableAdapters.TableAdapterManager();
            this.hOCSINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOCSINHTableAdapter = new quanlihocsinh.QuanLyHocSinhDataSetTableAdapters.HOCSINHTableAdapter();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocSinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHSACHHOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Khối:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Lớp:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 65;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonX7
            // 
            this.buttonX7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX7.ForeColor = System.Drawing.Color.Blue;
            this.buttonX7.Location = new System.Drawing.Point(331, 296);
            this.buttonX7.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(149, 27);
            this.buttonX7.TabIndex = 68;
            this.buttonX7.Text = "Hiển Thị Danh Sách";
            this.buttonX7.UseVisualStyleBackColor = true;
            this.buttonX7.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(189, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(79, 21);
            this.comboBox2.TabIndex = 69;
            // 
            // quanLyHocSinhDataSet
            // 
            this.quanLyHocSinhDataSet.DataSetName = "QuanLyHocSinhDataSet";
            this.quanLyHocSinhDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dANHSACHHOCSINHBindingSource
            // 
            this.dANHSACHHOCSINHBindingSource.DataMember = "DANHSACHHOCSINH";
            this.dANHSACHHOCSINHBindingSource.DataSource = this.quanLyHocSinhDataSet;
            // 
            // dANHSACHHOCSINHTableAdapter
            // 
            this.dANHSACHHOCSINHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAOCAOTONGKETHOCKYTableAdapter = null;
            this.tableAdapterManager.BAOCAOTONGKETMONTableAdapter = null;
            this.tableAdapterManager.DANHSACHHOCSINHTableAdapter = this.dANHSACHHOCSINHTableAdapter;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.HOCKYTableAdapter = null;
            this.tableAdapterManager.HOCSINHTableAdapter = null;
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
            // hOCSINHBindingSource
            // 
            this.hOCSINHBindingSource.DataMember = "HOCSINH";
            this.hOCSINHBindingSource.DataSource = this.quanLyHocSinhDataSet;
            // 
            // hOCSINHTableAdapter
            // 
            this.hOCSINHTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Location = new System.Drawing.Point(12, 109);
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.Size = new System.Drawing.Size(475, 180);
            this.dataGridViewClass.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Năm học:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(358, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(129, 21);
            this.comboBox3.TabIndex = 72;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 73;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(318, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Sĩ số:";
            // 
            // danhsachlop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 403);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewClass);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.buttonX7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "danhsachlop";
            this.Text = "danhsachlop";
            this.Load += new System.EventHandler(this.danhsachlop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocSinhDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHSACHHOCSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonX7;
        private System.Windows.Forms.ComboBox comboBox2;
        private QuanLyHocSinhDataSet quanLyHocSinhDataSet;
        private System.Windows.Forms.BindingSource dANHSACHHOCSINHBindingSource;
        private QuanLyHocSinhDataSetTableAdapters.DANHSACHHOCSINHTableAdapter dANHSACHHOCSINHTableAdapter;
        private QuanLyHocSinhDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource hOCSINHBindingSource;
        private QuanLyHocSinhDataSetTableAdapters.HOCSINHTableAdapter hOCSINHTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}