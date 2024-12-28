namespace DOAN1.Giaodien
{
    partial class QLSanpham
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
            this.Thoat = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvQLsp = new System.Windows.Forms.DataGridView();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSLT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Excel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLsp)).BeginInit();
            this.SuspendLayout();
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(897, 523);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(99, 39);
            this.Thoat.TabIndex = 8;
            this.Thoat.Text = "Thoat";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(268, 523);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(99, 39);
            this.Del.TabIndex = 9;
            this.Del.Text = "Xoa";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(146, 523);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(99, 39);
            this.Edit.TabIndex = 10;
            this.Edit.Text = "Sua";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(28, 523);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(99, 39);
            this.Add.TabIndex = 11;
            this.Add.Text = "Them";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(722, 259);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 22);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tim kiem";
            // 
            // dgvQLsp
            // 
            this.dgvQLsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLsp.Location = new System.Drawing.Point(12, 287);
            this.dgvQLsp.Name = "dgvQLsp";
            this.dgvQLsp.RowHeadersWidth = 51;
            this.dgvQLsp.RowTemplate.Height = 24;
            this.dgvQLsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLsp.Size = new System.Drawing.Size(984, 217);
            this.dgvQLsp.TabIndex = 5;
            this.dgvQLsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLsp_CellClick);
            this.dgvQLsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLsp_CellContentClick);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(146, 60);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(287, 22);
            this.txtTenSP.TabIndex = 14;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(146, 22);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(287, 22);
            this.txtMaSP.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "TenNV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "MaSP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "So Luong Ton";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(146, 98);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(287, 22);
            this.txtGia.TabIndex = 15;
            // 
            // txtSLT
            // 
            this.txtSLT.Location = new System.Drawing.Point(146, 136);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Size = new System.Drawing.Size(287, 22);
            this.txtSLT.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ma Loai";
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(146, 174);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(287, 24);
            this.cbLoaiSP.TabIndex = 16;
            // 
            // Excel
            // 
            this.Excel.Location = new System.Drawing.Point(394, 523);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(99, 39);
            this.Excel.TabIndex = 9;
            this.Excel.Text = "Excel";
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // QLSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 576);
            this.Controls.Add(this.cbLoaiSP);
            this.Controls.Add(this.txtSLT);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvQLsp);
            this.Name = "QLSanpham";
            this.Text = "QLSanpham";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLSanpham_FormClosing);
            this.Load += new System.EventHandler(this.QLSanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvQLsp;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSLT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Excel;
    }
}