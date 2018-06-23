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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(danhsachlop));
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyHocSinhDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHSACHHOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCSINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonX7
            // 
            this.buttonX7.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.buttonX7, "buttonX7");
            this.buttonX7.ForeColor = System.Drawing.Color.Blue;
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.UseVisualStyleBackColor = true;
            this.buttonX7.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
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
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewClass, "dataGridViewClass");
            this.dataGridViewClass.Name = "dataGridViewClass";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.UseWaitCursor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox3, "comboBox3");
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // danhsachlop
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}