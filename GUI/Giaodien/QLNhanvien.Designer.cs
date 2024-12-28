namespace DOAN1.Giaodien
{
    partial class QLNhanvien
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
            this.dgvQLnv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtTennv = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.datebirth = new System.Windows.Forms.DateTimePicker();
            this.dateworking = new System.Windows.Forms.DateTimePicker();
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedSDT = new System.Windows.Forms.MaskedTextBox();
            this.radnam = new System.Windows.Forms.RadioButton();
            this.radnu = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.cbchucvu = new System.Windows.Forms.ComboBox();
            this.Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLnv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLnv
            // 
            this.dgvQLnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLnv.Location = new System.Drawing.Point(12, 284);
            this.dgvQLnv.Name = "dgvQLnv";
            this.dgvQLnv.RowHeadersWidth = 51;
            this.dgvQLnv.RowTemplate.Height = 24;
            this.dgvQLnv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLnv.Size = new System.Drawing.Size(997, 217);
            this.dgvQLnv.TabIndex = 0;
            this.dgvQLnv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLnv_CellClick);
            this.dgvQLnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "MaNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "TenNV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngay sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gioi tinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "SDT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Dia chi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngay vao lam";
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(146, 28);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(287, 22);
            this.txtManv.TabIndex = 2;
            // 
            // txtTennv
            // 
            this.txtTennv.Location = new System.Drawing.Point(146, 59);
            this.txtTennv.Name = "txtTennv";
            this.txtTennv.Size = new System.Drawing.Size(287, 22);
            this.txtTennv.TabIndex = 2;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(146, 194);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(287, 22);
            this.txtDC.TabIndex = 2;
            // 
            // datebirth
            // 
            this.datebirth.Location = new System.Drawing.Point(146, 130);
            this.datebirth.Name = "datebirth";
            this.datebirth.Size = new System.Drawing.Size(287, 22);
            this.datebirth.TabIndex = 3;
            // 
            // dateworking
            // 
            this.dateworking.Location = new System.Drawing.Point(146, 226);
            this.dateworking.Name = "dateworking";
            this.dateworking.Size = new System.Drawing.Size(287, 22);
            this.dateworking.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(28, 520);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(99, 39);
            this.Add.TabIndex = 4;
            this.Add.Text = "Them";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(146, 520);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(99, 39);
            this.Edit.TabIndex = 4;
            this.Edit.Text = "Sua";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(268, 520);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(99, 39);
            this.Del.TabIndex = 4;
            this.Del.Text = "Xoa";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(722, 256);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSeacrh_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(654, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tim kiem";
            // 
            // maskedSDT
            // 
            this.maskedSDT.Location = new System.Drawing.Point(146, 162);
            this.maskedSDT.Mask = "(999) 000-0000";
            this.maskedSDT.Name = "maskedSDT";
            this.maskedSDT.Size = new System.Drawing.Size(287, 22);
            this.maskedSDT.TabIndex = 5;
            // 
            // radnam
            // 
            this.radnam.AutoSize = true;
            this.radnam.Location = new System.Drawing.Point(165, 96);
            this.radnam.Name = "radnam";
            this.radnam.Size = new System.Drawing.Size(57, 20);
            this.radnam.TabIndex = 6;
            this.radnam.TabStop = true;
            this.radnam.Text = "Nam";
            this.radnam.UseVisualStyleBackColor = true;
            // 
            // radnu
            // 
            this.radnu.AutoSize = true;
            this.radnu.Location = new System.Drawing.Point(297, 94);
            this.radnu.Name = "radnu";
            this.radnu.Size = new System.Drawing.Size(45, 20);
            this.radnu.TabIndex = 6;
            this.radnu.TabStop = true;
            this.radnu.Text = "Nu";
            this.radnu.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(537, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Chuc vu";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1291, 497);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(287, 22);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "da";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(537, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tai khoan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Mat khau";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(647, 28);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(287, 22);
            this.txttk.TabIndex = 2;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(647, 60);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(287, 22);
            this.txtmk.TabIndex = 2;
            // 
            // cbchucvu
            // 
            this.cbchucvu.FormattingEnabled = true;
            this.cbchucvu.Location = new System.Drawing.Point(647, 92);
            this.cbchucvu.Name = "cbchucvu";
            this.cbchucvu.Size = new System.Drawing.Size(287, 24);
            this.cbchucvu.TabIndex = 7;
            this.cbchucvu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(910, 520);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(99, 39);
            this.Thoat.TabIndex = 4;
            this.Thoat.Text = "Thoat";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // QLNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 581);
            this.Controls.Add(this.cbchucvu);
            this.Controls.Add(this.radnu);
            this.Controls.Add(this.radnam);
            this.Controls.Add(this.maskedSDT);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dateworking);
            this.Controls.Add(this.datebirth);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtTennv);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtManv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvQLnv);
            this.Name = "QLNhanvien";
            this.Text = "QLNhanvien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLNhanvien_FormClosing);
            this.Load += new System.EventHandler(this.QLNhanvien_Load);
            this.Click += new System.EventHandler(this.QLNhanvien_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQLnv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtTennv;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.DateTimePicker datebirth;
        private System.Windows.Forms.DateTimePicker dateworking;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedSDT;
        private System.Windows.Forms.RadioButton radnam;
        private System.Windows.Forms.RadioButton radnu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.ComboBox cbchucvu;
        private System.Windows.Forms.Button Thoat;
    }
}