namespace quanlihocsinh
{
    partial class Baocaotongkethocki
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonX7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbHockyCN = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 353);
            this.dataGridView1.TabIndex = 75;
            // 
            // buttonX7
            // 
            this.buttonX7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX7.ForeColor = System.Drawing.Color.Blue;
            this.buttonX7.Location = new System.Drawing.Point(309, 13);
            this.buttonX7.Margin = new System.Windows.Forms.Padding(4);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(151, 40);
            this.buttonX7.TabIndex = 74;
            this.buttonX7.Text = "Hiển Thị Báo Cáo";
            this.buttonX7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Học kỳ :";
            // 
            // cmbHockyCN
            // 
            this.cmbHockyCN.FormattingEnabled = true;
            this.cmbHockyCN.Location = new System.Drawing.Point(99, 20);
            this.cmbHockyCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHockyCN.Name = "cmbHockyCN";
            this.cmbHockyCN.Size = new System.Drawing.Size(160, 21);
            this.cmbHockyCN.TabIndex = 70;
            // 
            // Baocaotongkethocki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 445);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonX7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHockyCN);
            this.Name = "Baocaotongkethocki";
            this.Text = "Baocaotongkethocki";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonX7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbHockyCN;
    }
}