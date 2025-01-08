namespace Do_An.GUI
{
    partial class EditSP
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLoaiSP = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKho = new System.Windows.Forms.TextBox();
            this.txtDoViTinh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateImage = new FontAwesome.Sharp.IconButton();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.btnQuetMa = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(136)))), ((int)(((byte)(235)))));
            this.label1.Location = new System.Drawing.Point(174, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỈNH SỬA  SẢN PHẨM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(2, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 1);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sản phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(18, 109);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(276, 20);
            this.txtTenSP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(115, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã sản phẩm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(115, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 4;
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(18, 165);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(112, 20);
            this.txtMaSP.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(177, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đơn vị tính";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbLoaiSP
            // 
            this.cmbLoaiSP.FormattingEnabled = true;
            this.cmbLoaiSP.Location = new System.Drawing.Point(18, 222);
            this.cmbLoaiSP.Name = "cmbLoaiSP";
            this.cmbLoaiSP.Size = new System.Drawing.Size(134, 21);
            this.cmbLoaiSP.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số lượng trong kho";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKho
            // 
            this.txtKho.Location = new System.Drawing.Point(161, 262);
            this.txtKho.Name = "txtKho";
            this.txtKho.Size = new System.Drawing.Size(106, 20);
            this.txtKho.TabIndex = 3;
            // 
            // txtDoViTinh
            // 
            this.txtDoViTinh.Location = new System.Drawing.Point(180, 222);
            this.txtDoViTinh.Name = "txtDoViTinh";
            this.txtDoViTinh.Size = new System.Drawing.Size(115, 20);
            this.txtDoViTinh.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Loại sản phẩm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(411, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ảnh sản phẩm";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateImage);
            this.groupBox1.Controls.Add(this.picSP);
            this.groupBox1.Location = new System.Drawing.Point(414, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 181);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUpdateImage
            // 
            this.btnUpdateImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(164)))));
            this.btnUpdateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateImage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateImage.ForeColor = System.Drawing.Color.White;
            this.btnUpdateImage.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdateImage.IconColor = System.Drawing.Color.Black;
            this.btnUpdateImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateImage.Location = new System.Drawing.Point(48, 147);
            this.btnUpdateImage.Name = "btnUpdateImage";
            this.btnUpdateImage.Size = new System.Drawing.Size(112, 28);
            this.btnUpdateImage.TabIndex = 1;
            this.btnUpdateImage.Text = "Update ảnh";
            this.btnUpdateImage.UseVisualStyleBackColor = false;
            this.btnUpdateImage.Click += new System.EventHandler(this.btnUpdateImage_Click);
            // 
            // picSP
            // 
            this.picSP.Location = new System.Drawing.Point(40, 19);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(125, 122);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSP.TabIndex = 0;
            this.picSP.TabStop = false;
            this.picSP.Click += new System.EventHandler(this.picSP_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(2, 372);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 1);
            this.panel2.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Giá bán";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(85, 341);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(200, 20);
            this.txtGia.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 15;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(454, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 29);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(162)))), ((int)(((byte)(208)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 15;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(551, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 29);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã vạch";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtbarcode
            // 
            this.txtbarcode.Location = new System.Drawing.Point(180, 165);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(115, 20);
            this.txtbarcode.TabIndex = 3;
            // 
            // btnQuetMa
            // 
            this.btnQuetMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.btnQuetMa.FlatAppearance.BorderSize = 0;
            this.btnQuetMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuetMa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuetMa.ForeColor = System.Drawing.Color.White;
            this.btnQuetMa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnQuetMa.IconColor = System.Drawing.Color.Black;
            this.btnQuetMa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuetMa.Location = new System.Drawing.Point(18, 382);
            this.btnQuetMa.Name = "btnQuetMa";
            this.btnQuetMa.Size = new System.Drawing.Size(71, 26);
            this.btnQuetMa.TabIndex = 10;
            this.btnQuetMa.Text = "Quét mã";
            this.btnQuetMa.UseVisualStyleBackColor = false;
            this.btnQuetMa.Click += new System.EventHandler(this.btnQuetMa_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 301);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Giá bán";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(85, 301);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(200, 20);
            this.txtGiaNhap.TabIndex = 3;
            // 
            // EditSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 420);
            this.Controls.Add(this.btnQuetMa);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbLoaiSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.txtDoViTinh);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtKho);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "EditSP";
            this.Text = "ThemSP";
            this.Load += new System.EventHandler(this.ThemSP_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLoaiSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKho;
        private System.Windows.Forms.TextBox txtDoViTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGia;
        private FontAwesome.Sharp.IconButton btnUpdateImage;
        private System.Windows.Forms.PictureBox picSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbarcode;
        private FontAwesome.Sharp.IconButton btnQuetMa;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGiaNhap;
    }
}