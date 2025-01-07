using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Do_An.DAL;
using FontAwesome.Sharp;

namespace Do_An.GUI
{
    public partial class frm_main : Form
    {
        private Panel leftBorderBtn;
        private IconButton currentBtn;
        private Form currentChildForm;
        public static DAL.NhanVien nv;
        public frm_main(DAL.NhanVien nv)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            frm_main.nv = nv;
            Decentralization();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void Decentralization()
        {
            if (nv.ChucVu.TenChucVu == "Nhân viên")
            {
                iconButton1.Enabled= false;
                iconButton4.Enabled = false;
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        private void ActiveButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableBtn();
                currentBtn = (IconButton) senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrent.IconChar = currentBtn.IconChar;
                iconCurrent.IconColor = color;
                lblCurrent.Text = currentBtn.Text;


            }
        }

        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.FromArgb(239, 232, 248);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           
        }

        private void reset()
        {
            DisableBtn();
            leftBorderBtn.Visible=false;
            iconCurrent.IconChar = IconChar.Home;
            iconCurrent.IconColor = Color.MediumPurple;
            lblCurrent.Text = "Trang chủ";
        }

        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (nv.MaChucVu == "CV02")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;

            }
            ActiveButton(sender, RGBColors.color1);

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new ThanhToan());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new Product());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (nv.MaChucVu == "CV02")
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!");
                return;

            }
            ActiveButton(sender, RGBColors.color4);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            reset();
            currentChildForm.Close();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrent_Click(object sender, EventArgs e)
        {

        }

        // Call Windows API from uer32.dll library
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); //this Handle là ID form 0x112 với 0xf012 là mã thông điệp và mã lệnh 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_main_Resize(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Height = this.Height;
                currentChildForm.Width = this.Width;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn đóng!", "Thông Báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
