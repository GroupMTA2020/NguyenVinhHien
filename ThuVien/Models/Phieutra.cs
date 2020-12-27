using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Models
{
    class Phieutra
    {
        string MaPhieuTra;
        string MaPhieuMuon;
        string NgayTra;
        string TinhTrang;
        public string NgayTra1 { get => NgayTra; set => NgayTra = value; }
        public string TinhTrang1 { get => TinhTrang; set => TinhTrang = value; }
        public string MaPhieuTra1 { get => MaPhieuTra; set => MaPhieuTra = value; }
        public string MaPhieuMuon1 { get => MaPhieuMuon; set => MaPhieuMuon = value; }

        public Phieutra(string _MaPhieuTra, string _MaPhieuMuon, string _NgayTra, string _TinhTrang)
        {
            MaPhieuTra = _MaPhieuTra;
            MaPhieuMuon = _MaPhieuMuon;
            NgayTra = _NgayTra;
            TinhTrang = _TinhTrang;
        }
        public Phieutra(string text, string[] data)
        {
            MaPhieuTra = data[0];
            MaPhieuMuon = data[1];
            NgayTra = data[2];
            TinhTrang = data[3];
        }
        public static DataTable getTable_Phieutra()
        {
            return Models.Connection.getData("getlistphieutra", CommandType.StoredProcedure);
        }
        public int InsertPhieutra()
        {
            string[] paras = new string[4] { "@MaPhieuTra", "@MaPhieuMuon", "@NgayTra", "@TinhTrang" };
            object[] values = new object[4] { MaPhieuTra, MaPhieuMuon, NgayTra, TinhTrang };
            var i = Models.Connection.ExcuteQuery("addphieutra",
                CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdatePhieutra()
        {
            string[] paras = new string[4] { "@MaPhieuTra", "@MaPhieuMuon", "@NgayTra", "@TinhTrang" };
            object[] values = new object[4] { MaPhieuTra, MaPhieuMuon, NgayTra, TinhTrang };
            var i = Models.Connection.ExcuteQuery("editphieutra",
                CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeletePhieutra()
        {
            var i = Models.Connection.ExcuteQuery("deletephieutra",
                CommandType.StoredProcedure, new string[1] { "@deletephieutra" }, new object[1] { MaPhieuTra });
            return i;
        }
        public static DataTable listdangmuon()
        {
            return Models.Connection.getData("dangmuon", CommandType.StoredProcedure);
        }
    }
}
