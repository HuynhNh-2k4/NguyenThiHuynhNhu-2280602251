using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuynhNhu_2280602251
{
    public class NhanVien
    {
        public int MSNV { get; set; }
        public string TenNV { get; set; }
        public double LuongCB { get; set; }
        public NhanVien() { }

        public NhanVien(int maso, string ten, double luong)
        {
            MSNV = maso;
            TenNV = ten;
            LuongCB = luong;
        }
    }
}
