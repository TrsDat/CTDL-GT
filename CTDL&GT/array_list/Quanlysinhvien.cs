using CTDL_GT.array_list;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CTDL_GT.array_list
{
    public class sinhvien
    {
        public string mssv { get; set; }
        public string hoten { get; set; }
        public string nganhhoc { get; set; }
        public diem bangdiem { get; set; }
        public sinhvien()
        {
            bangdiem = new diem();
        }
        public sinhvien(string maSV, string ten, string nganh)
        {
            mssv = maSV;
            hoten = ten;
            nganhhoc = nganh;
            bangdiem = new diem();
        }
        public void hienthi()
        {
            Console.WriteLine($"Mssv: {mssv} | Ho ten: {hoten} | Nganh hoc: {nganhhoc}");
            bangdiem.hienthi();
        }
    }
    public class diem
    {
        // Dictionary lưu trữ Key: Tên môn học (string), Value: Điểm số (double)
        public Dictionary<string,double> Monhoc { get; set; }
        public diem()
        {
            Monhoc =new Dictionary<string, double>();
        }
        public void themmonhoc(string tenmon, double diem)
        {
            if (Monhoc.ContainsKey(tenmon)) Monhoc[tenmon] = diem;
            else Monhoc.Add(tenmon, diem);
        }
        public double diemtrungbinh()
        {
            if (Monhoc.Count == 0) return 0;
            else return Math.Round(Monhoc.Values.Average(), 2);
        }
        public void hienthi()
        {
            Console.WriteLine($"Diem trung binh : {diemtrungbinh()}");
        }
    }
    internal class Quanlysinhvien
    {
        public static void Main(string[] args)
        {
            List<sinhvien> danhsach =new List<sinhvien>();

            sinhvien sv1 = new sinhvien("0001","A","Ky thuat phan mem");
            sv1.bangdiem.themmonhoc("toan", 6.7);
            sv1.bangdiem.themmonhoc("van", 4.6);
            danhsach.Add(sv1);

            sinhvien sv2 = new sinhvien("0002", "B", "Khoa hoc du lieu");
            sv2.bangdiem.themmonhoc("toan", 8.8);
            danhsach.Add(sv2);

            foreach (sinhvien sv in danhsach)
            {
                sv.hienthi();
            }
        }
    }
}
