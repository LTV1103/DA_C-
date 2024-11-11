using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DoAn3
{
    [Serializable]

    internal class SinhVien
    {
        private string _ma;
        private string _ten;
        private string _lop;
        private string _diemtb;
        public SinhVien()
        {
            this._ma = " ";
            this._ten = " "; 
            this._lop = " ";
            this._diemtb = " ";
        }
        public SinhVien(string ma, string ten, string lop, string diemtb)
        {
            this._ma = ma;
            this._ten = ten;
            this._lop = lop;
            this._diemtb = diemtb;
        }

        public string Ma { get => _ma; set => _ma = value; }
        public string Ten { get => _ten; set => _ten = value; }
        public string Lop { get => _lop; set => _lop = value; }
        public string Diemtb { get => _diemtb; set => _diemtb = value; }
    }
}
