using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace DoAn3
{
    [Serializable]

    public partial class Form1 : Form
    {
        private DanhSachSinhVien dssv;
        private SinhVien sv;
        private int vitrihientai = 0;
        private string tenFile = "Du Lieu.Text";

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dssv = new DanhSachSinhVien();
            sv = new SinhVien();
        }
        void hienthi(DataGridView dgv, List<SinhVien> list)
        {
            dgv.DataSource = list;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                vitrihientai = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[vitrihientai];
                string masv = row.Cells[0].Value.ToString();
                string tensv = row.Cells[1].Value.ToString();
                string lopsv = row.Cells[2].Value.ToString();
                string diemtbsv = row.Cells[3].Value.ToString();
                sv = new SinhVien(masv, tensv, lopsv, diemtbsv);
                textBox1.Text = sv.Ma;
                textBox2.Text = sv.Ten;
                textBox3.Text = sv.Lop;
                textBox4.Text = sv.Diemtb;
            }
            catch(Exception error) 
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien svien = new SinhVien(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (dssv.kiemtratrungma(textBox1.Text))
            {
                MessageBox.Show("Mã này đã có", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
            }
            else
            {
                dssv.them(svien);
                hienthi(dataGridView1, dssv.Dssinhvien);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ketqua = MessageBox.Show("Bạn muốn xóa! ", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketqua == DialogResult.Yes)
            {
                dssv.xoa(vitrihientai);
                hienthi(dataGridView1, dssv.Dssinhvien);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (dssv.kiemtratrungma(textBox1.Text))
            {
                MessageBox.Show("Mã này đã có", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
            }
            else
            {
                dssv.sua(sv,vitrihientai);
                hienthi(dataGridView1, dssv.Dssinhvien);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<SinhVien> dsketqua = new List<SinhVien>();
            string[] tam = File.ReadAllLines(tenFile);
            for (int i = 0; i < tam.Length; i++)
            {
                string line = tam[i];
                string[] tam2 = line.Split("\t".ToArray(), StringSplitOptions.RemoveEmptyEntries);
                if (tam2.Length > 0)
                {
                    SinhVien sv = new SinhVien();
                    sv.Ma = tam2[0];
                    sv.Ten = tam2[1];
                    sv.Lop = tam2[2];
                    sv.Diemtb = tam2[3];
                    dsketqua.Add(sv);
                }

            }
            hienthi(dataGridView1, dsketqua);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter swt = new StreamWriter(tenFile, false, Encoding.UTF8);
            foreach (SinhVien sv in dssv.Dssinhvien)
            {
                string dong = sv.Ma + "\t" + sv.Ten + "\t" + sv.Lop + "\t" + sv.Diemtb;
                swt.WriteLine(dong);
            };
            swt.Close();
            MessageBox.Show("Đã Lưu Dữ Liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}