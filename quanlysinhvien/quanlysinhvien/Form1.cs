using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace quanlysinhvien
{
    public partial class Form1 : Form
    {

        string path = "";
        DataTable tblSinhvien, tblLop;
        SqlDataAdapter daSinhvien, daLop;
        SqlConnection conn = new SqlConnection(@"Data Source=VANTAN\TRANTAN;Initial Catalog=QLSINHVIEN4;Integrated Security=True");
        BindingManagerBase DSSV;
        Image i;
        bool capNhat = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tblSinhvien = new DataTable();
            daSinhvien = new SqlDataAdapter("Select * from SINHVIEN", conn);

            daLop = new SqlDataAdapter("Select * from LOP", conn);
            tblLop = new DataTable();
            try
            {
                daSinhvien.Fill(tblSinhvien);
                daLop.Fill(tblLop);
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daSinhvien);
            loadCBOLop();
            LoadDGVSinhvien();

            txtMasv.DataBindings.Add("text", tblSinhvien, "MaSV", true);
            txtHoten.DataBindings.Add("text", tblSinhvien, "HoTen", true);
            dtNgaysinh.DataBindings.Add("text", tblSinhvien, "NgaySinh", true);
            radioNam.DataBindings.Add("checked", tblSinhvien, "GioiTinh", true);
            cmbLop.DataBindings.Add("SelectedValue", tblSinhvien, "MaLop", true);
            txtDiachi.DataBindings.Add("text", tblSinhvien, "DiaChi", true);
            pboxHinh.DataBindings.Add("ImageLocation", tblSinhvien, "Hinh", true);

            DSSV = this.BindingContext[tblSinhvien];
            enabledButton();


        }
        private void enabledButton()
        {
            btnThem.Enabled = !capNhat;
            btnXoa.Enabled = !capNhat;
            btnSua.Enabled = !capNhat;
            gthongtin.Enabled = capNhat;
            gtimkiem.Enabled = !capNhat;
            btnLuu.Enabled = capNhat;
            btnHuy.Enabled = capNhat;
            btnHinh.Enabled = capNhat;
        }

        private void radioNam_CheckedChanged(object sender, EventArgs e)
        {
            radioNu.Checked = !radioNam.Checked;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSSV.AddNew();
            capNhat = true;
            enabledButton();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSSV.EndCurrentEdit();
                daSinhvien.Update(tblSinhvien);
                tblSinhvien.AcceptChanges();
                capNhat = false;
                enabledButton();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSSV.CancelCurrentEdit();
            tblSinhvien.RejectChanges();
            capNhat = false;
            enabledButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSSV.RemoveAt(DSSV.Position);
                daSinhvien.Update(tblSinhvien);
                tblSinhvien.AcceptChanges();
            }catch(SqlException ex)
            {
                tblSinhvien.RejectChanges();
                MessageBox.Show("Xóa thất bại!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capNhat = true;
            enabledButton();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
             {
                 DataRow r = tblSinhvien.Select("select * from SINHVIEN where HoTen like '%"+txtTimkiem+"%'")[0];
                 DSSV.Position = tblSinhvien.Rows.IndexOf(r);
             }catch(Exception ex)
             {
                 MessageBox.Show("Không tìm thấy");
             }
            

        }

        private void txtTimkiem_MouseDown(object sender, MouseEventArgs e)
        {
            txtTimkiem.Text = "";
        }

        private void btnHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files|*.jpg|PNG Files|*.png|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                i = Image.FromFile(ofd.FileName);
                pboxHinh.Image = i;
            }
        }

        private void txtTimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnTimkiem_Click(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dagisSinhvien_SelectionChanged(object sender, EventArgs e)
        {
            if(capNhat)
            {
                btnHuy_Click(sender, e);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loadCBOLop()
        {
            cmbLop.DataSource = tblLop;
            cmbLop.DisplayMember = "TenLop";
            cmbLop.ValueMember = "MaLop";
        }
        private void LoadDGVSinhvien()
        {
            dagisSinhvien.AutoGenerateColumns = false;
            dagisSinhvien.DataSource = tblSinhvien;
        }
        
       
    }
}
