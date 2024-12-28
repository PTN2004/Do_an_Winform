namespace DOAN1.Giaodien
{
    partial class MainForm
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnThuchi = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            this.btnKhachang = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnSanpham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(786, 70);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.Location = new System.Drawing.Point(786, 25);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(99, 39);
            this.btnDangxuat.TabIndex = 9;
            this.btnDangxuat.Text = "Dang xuat";
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnThuchi
            // 
            this.btnThuchi.Location = new System.Drawing.Point(648, 25);
            this.btnThuchi.Name = "btnThuchi";
            this.btnThuchi.Size = new System.Drawing.Size(108, 68);
            this.btnThuchi.TabIndex = 3;
            this.btnThuchi.Text = "Thu chi";
            this.btnThuchi.UseVisualStyleBackColor = true;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(491, 25);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(108, 68);
            this.btnThanhtoan.TabIndex = 4;
            this.btnThanhtoan.Text = "Thanh Toan";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            // 
            // btnKhachang
            // 
            this.btnKhachang.Location = new System.Drawing.Point(334, 25);
            this.btnKhachang.Name = "btnKhachang";
            this.btnKhachang.Size = new System.Drawing.Size(108, 68);
            this.btnKhachang.TabIndex = 5;
            this.btnKhachang.Text = "QL Khach Hang";
            this.btnKhachang.UseVisualStyleBackColor = true;
            this.btnKhachang.Click += new System.EventHandler(this.btnKhachang_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Location = new System.Drawing.Point(20, 25);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(108, 68);
            this.btnNhanvien.TabIndex = 7;
            this.btnNhanvien.Text = "QL Nhan Vien";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnSanpham
            // 
            this.btnSanpham.Location = new System.Drawing.Point(177, 25);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(108, 68);
            this.btnSanpham.TabIndex = 10;
            this.btnSanpham.Text = "QL Mat hang";
            this.btnSanpham.UseVisualStyleBackColor = true;
            this.btnSanpham.Click += new System.EventHandler(this.btnSanpham_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.btnSanpham);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangxuat);
            this.Controls.Add(this.btnThuchi);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.btnKhachang);
            this.Controls.Add(this.btnNhanvien);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btnThuchi;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.Button btnKhachang;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnSanpham;
    }
}