using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HuynhNhu_2280602251
{
    public partial class ListView2 : Form
    {
        public delegate void AddNhanVien(NhanVien nhanvien);
        public delegate void SuaNhanVien(NhanVien nhanvien);
        private NhanVien _nhanVien;
        private Mode _currentMode;

        public enum Mode
        {
            Add,
            Edit
        }

        public ListView2()
        {
            InitializeComponent();
            _currentMode = Mode.Add;
        }

        public ListView2(NhanVien nhanVien) : this()
        {
            _nhanVien = nhanVien;
            InitializeNhanVien(nhanVien);
            _currentMode = Mode.Edit;
        }

        private void InitializeNhanVien(NhanVien nhanVien)
        {
            TextBox txt = new TextBox();
            txt.Text = nhanVien.MSNV.ToString();
            txtTenNV.Text = nhanVien.TenNV;
            txtLuongCB.Text = nhanVien.LuongCB.ToString();
            txt.ReadOnly = true; 
        }

        public AddNhanVien OnAddNhanVien;
        public SuaNhanVien OnSuaNhanVien;

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (_currentMode == Mode.Add)
            {
                var nhanvien = new NhanVien(int.Parse(txtMSNV.Text), txtTenNV.Text, double.Parse(txtLuongCB.Text));
                OnAddNhanVien?.Invoke(nhanvien); 
            }
            else if (_currentMode == Mode.Edit)
            {
                _nhanVien.TenNV = txtTenNV.Text;
                _nhanVien.LuongCB = double.Parse(txtLuongCB.Text);
                OnSuaNhanVien?.Invoke(_nhanVien);
            }

            this.Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
