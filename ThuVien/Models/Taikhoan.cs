using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Models
{
    public class Taikhoan
    {
        public static string Madocgia { get; set; }
        public static string Tendangnhap { get; set; }
        public static string Maukhau { get; set; }
        public static string Quyen { get; set; }
        public Taikhoan()
        {
        }
        public Taikhoan(string _madocgia, string _tendangnhap, string _maukhau, string _quyen)
        {
            Madocgia = _madocgia;
            Tendangnhap = _tendangnhap;
            Maukhau = _maukhau;
            Quyen = _quyen;         
        }
        public Taikhoan(string _tendangnhap, string _maukhau, string _quyen)
        {
            Tendangnhap = _tendangnhap;
            Maukhau = _maukhau;
            Quyen = _quyen;
        }
        public Taikhoan(string[] data)
        {
            Madocgia = data[0];
            Tendangnhap = data[1];
            Maukhau = data[2];
            Quyen = data[3];
        }
        public bool Login(string tendangnhap, string matkhau)
        {
            using (var connection = Connection.Getconnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from TaiKhoan where tendangnhap= @tendangnhap and matkhau=@matkhau";
                    command.Parameters.AddWithValue("@tendangnhap", tendangnhap);
                    command.Parameters.AddWithValue("@matkhau", matkhau);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Madocgia = reader.GetString(0);
                            Tendangnhap = reader.GetString(1);
                            Maukhau = reader.GetString(2);
                            Quyen = reader.GetString(3);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        public static DataTable getTable_Taikhoan()
        {
            return Models.Connection.getData("getlisttaikhoan", CommandType.StoredProcedure);
        }
        public int InsertTaikhoan()
        {
            string[] paras = new string[4] { "@MaDocGia", "@TenDangNhap", "@MatKhau", "@Quyen" };
            object[] values = new object[4] { Madocgia, Tendangnhap, Maukhau, Quyen };
            var i = Models.Connection.ExcuteQuery("addtaikhoan",
                CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateTaikhoan()
        {
            string[] paras = new string[4] { "@MaDocGia", "@TenDangNhap", "@MatKhau", "@Quyen" };
            object[] values = new object[4] { Madocgia, Tendangnhap, Maukhau, Quyen };
            var i = Models.Connection.ExcuteQuery("Update_taikhoan",
                CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteTaikhoan()
        {
            var i = Models.Connection.ExcuteQuery("Delete_taikhoan",
                CommandType.StoredProcedure, new string[1] { "@madocgia" }, new object[1] { Madocgia });
            return i;
        }
    }
}
