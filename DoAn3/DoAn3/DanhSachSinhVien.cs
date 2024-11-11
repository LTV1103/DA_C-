using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAn3
{
    [Serializable]

    internal class DanhSachSinhVien
    {
        private List<SinhVien> _dssinhvien;
        public DanhSachSinhVien() { Dssinhvien = new List<SinhVien> { }; }
        public DanhSachSinhVien (List<SinhVien> dssv)
        {
            this.Dssinhvien = dssv;
        }

        internal List<SinhVien> Dssinhvien { get => _dssinhvien.ToList(); set => _dssinhvien = value; }
        public void them(SinhVien sv)
        {
            this._dssinhvien.Add(sv);
        }
        public void xoa(int vitri)
        {
            this._dssinhvien.RemoveAt(vitri);

        }
        public bool kiemtratrungma(string ma)
        {
            foreach (SinhVien sv in this._dssinhvien)
            {
                if (sv.Ma.Equals(ma)) return true;
            }return false;       
        }
        public void sua(SinhVien sv , int vitri)
        {
            this._dssinhvien[vitri] = sv;
        }
    }
}
