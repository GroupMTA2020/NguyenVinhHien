using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Models
{
    class phieumuon
    {
        string MaPhieu;
        string MaDocGia;
        string MaSach;
        string Ngaymuon;
        string NgayTra;
        string TinhTrang;

        public string MaPhieu1 { get => MaPhieu; set => MaPhieu = value; }
        public string MaDocGia1 { get => MaDocGia; set => MaDocGia = value; }
        public string MaSach1 { get => MaSach; set => MaSach = value; }
        public string Ngaymuon1 { get => Ngaymuon; set => Ngaymuon = value; }
        public string NgayTra1 { get => NgayTra; set => NgayTra = value; }
        public string TinhTrang1 { get => TinhTrang; set => TinhTrang = value; }
        public phieumuon(string _MaPhieu, string _MaDocGia, string _MaSach,
           string _Ngaymuon, string _NgayTra, string _TinhTrang)
        {
            MaPhieu = _MaPhieu;
            MaDocGia = _MaDocGia;
            MaSach = _MaSach;
            Ngaymuon = _Ngaymuon;
            NgayTra = _NgayTra;
            TinhTrang = _TinhTrang;
        }
        public phieumuon(string text, string[] data)
        {
            MaPhieu = data[0];
            MaDocGia = data[1];
            MaSach = data[2];
            Ngaymuon = data[3];
            NgayTra = data[4];
            TinhTrang = data[5];
        }
        public static DataTable getTable_phieumuon()
        {
            return Models.Connection.getData("getlistphieumuon", CommandType.StoredProcedure);
        }
        public int Insertphieumuon()
        {
            string[] paras = new string[6] { "@MaPhieuMuon", "@MaDocGia", "@MaSach", "@NgayMuon", "@NgayPhaiTra", "@TinhTrang" };
            object[] values = new object[6] { MaPhieu, MaDocGia, MaSach, Ngaymuon, NgayTra, TinhTrang };
            var i = Models.Connection.ExcuteQuery("addphieumuon",
                CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int Updatephieumuon()
        {
            string[] paras = new string[6] { "@MaPhieuMuon", "@MaDocGia", "@MaSach", "@NgayMuon", "@NgayPhaiTra", "@TinhTrang" };
            object[] values = new object[6] { MaPhieu, MaDocGia, MaSach, Ngaymuon, NgayTra, TinhTrang };
            var i = Models.Connection.ExcuteQuery("editphieumuon",
                CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int Deletephieumuon()
        {
            var i = Models.Connection.ExcuteQuery("deletephieumuon",
                CommandType.StoredProcedure, new string[1] { "@MaPhieuMuon" }, new object[1] { MaPhieu });
            return i;
        }
        public static DataTable getTable_dangmuon()
        {
            return Models.Connection.getData("Dangmuon()", CommandType.StoredProcedure);
        }
        public static DataTable listmadocgia()
        {
            return Models.Connection.getData("ListMaDocGia", CommandType.StoredProcedure);
        }
        public static DataTable listmasach()
        {
            return Models.Connection.getData("ListMaSach", CommandType.StoredProcedure);
        }
    }
}
