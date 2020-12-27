using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Models
{
    class _DocGia
    {
        string MaDocGia;
        string TenDangNhap;
        string Hoten;
        string Gioitinh;
        string Namsinh;
        string Diachi;
       
        public string MaDocGia1 { get => MaDocGia; set => MaDocGia = value; }
        public string TenDangNhap1 { get => TenDangNhap; set => TenDangNhap = value; }
        public string Hoten1 { get => Hoten; set => Hoten = value; }
        public string Gioitinh1 { get => Gioitinh; set => Gioitinh = value; }
        public string Namsinh1 { get => Namsinh; set => Namsinh = value; }
        public string Diachi1 { get => Diachi; set => Diachi = value; }
        public object Madocgia { get; private set; }

        public _DocGia(string _MaDocGia, string _TenDangNhap, string _HoTen,
           string _GioiTinh, string _NamSinh, string _DiaChi)
        {
            MaDocGia = _MaDocGia;
            TenDangNhap = _TenDangNhap;
            Hoten = _HoTen;
            Gioitinh = _GioiTinh;
            Namsinh = _NamSinh;
            Diachi = _DiaChi;
        }
        public _DocGia(string text, string[] data)
        {
            MaDocGia = data[0];
            TenDangNhap = data[1];
            Hoten = data[2];
            Gioitinh = data[3];
            Namsinh = data[4];
            Diachi = data[5];

        }
        public static DataTable getTable_DocGia()
        {
            return Models.Connection.getData("getlistDocGia", CommandType.StoredProcedure);
        }
        public int InsertDocGia()
        {
            string[] paras = new string[6] { "@MaDocGia", "@TenDangNhap", " @HoTen", "@GioiTinh", " @NamSinh", " @DiaChi" };
            object[] values = new object[6] { MaDocGia, TenDangNhap, Hoten, Gioitinh, Namsinh, Diachi };
            var i = Models.Connection.ExcuteQuery("insert_DocGia",
                CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateDocGia()
        {
            string[] paras = new string[6] { "@MaDocGia", "@TenDangNhap", " @HoTen", "@GioiTinh", " @NamSinh", " @DiaChi" };
            object[] values = new object[6] { MaDocGia, TenDangNhap, Hoten, Gioitinh, Namsinh, Diachi };
            var i = Models.Connection.ExcuteQuery("Update_DocGia",
                CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteDocGia()
        {
            var i = Models.Connection.ExcuteQuery("Delete_DocGia",
                CommandType.StoredProcedure, new string[1] { "@MaDocGia" }, new object[1] { MaDocGia });
            return i;
        }
    }
}
