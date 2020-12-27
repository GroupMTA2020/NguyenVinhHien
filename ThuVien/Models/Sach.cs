using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien.Models
{
    public class Sach
    {
        public string Masach { get; set; }
        public string Tensach { get; set; }
        public string Tacgia { get; set; }
        public string Theloai { get; set; }
        public string Nhaxuatban { get; set; }
        public int Giasach { get; set; }
        public int Soluong { get; set; }
        public string Tinhtrang { get; set; }
        public Sach(string id,string name,string author,string type,string publisher,int price,int mount,string state)
        {
            Masach = id;
            Tensach = name;
            Tacgia = author;
            Theloai = type;
            Nhaxuatban = publisher;
            Giasach = price;
            Soluong = mount;
            Tinhtrang = state;
        }
        public Sach(string id)
        {
            Masach = id;
        }
        public static DataTable getListBook()
        {
            return Models.Connection.getData("getListBook", CommandType.StoredProcedure);
        }

        public static DataTable getTableSachById(string masach)
        {
            return Models.Connection.getData("getListBookById", CommandType.StoredProcedure,
                            new string[] { "@Masach"} , new object[1] { masach });
        }

        public static DataTable getTableSachByName(string tensach)
        {
            return Models.Connection.getData("getListBookByName", CommandType.StoredProcedure,
                            new string[] { "@Tensach" }, new object[1] { tensach });
        }

        internal static DataTable getTableSachByAuthor(string author)
        {
            return Models.Connection.getData("getListBookByAuthor", CommandType.StoredProcedure,
                            new string[] { "@Tacgia" }, new object[1] { author });
        }

        internal static DataTable getTableSachByType(string type)
        {
            return Models.Connection.getData("getListBookByType", CommandType.StoredProcedure,
                            new string[] { "@Theloai" }, new object[1] { type });
        }
        internal static DataTable getTableSachByPubliser(string nxb)
        {
            return Models.Connection.getData("getListBookByPublisher", CommandType.StoredProcedure,
                            new string[] { "@NXB" }, new object[1] { nxb });
        }
        internal static DataTable getTableSachByPrice(string price)
        {
            return Models.Connection.getData("getListBookByPrice", CommandType.StoredProcedure,
                            new string[] { "@Gia" }, new object[1] { price });
        }
        internal static DataTable getTableSachByAmount(string amount)
        {
            return Models.Connection.getData("getListBookByAmount", CommandType.StoredProcedure,
                            new string[] { "@Soluong" }, new object[1] { amount });
        }
        internal static DataTable getTableSachByState(string state)
        {
            return Models.Connection.getData("getListBookByState", CommandType.StoredProcedure,
                            new string[] { "@Tinhtrang" }, new object[1] { state });
        }

        internal int insertSach()
        {
            string[] paras = new string[8] { "@Masach", "@Tensach","@Tacgia","@Theloai","@Nhaxuatban"
                                                ,"@Giasach","@Soluong","@Tinhtrang" };
            object[] values = new object[8] { this.Masach, this.Tensach,this.Tacgia,this.Theloai ,this.Nhaxuatban
                                                ,this.Giasach, this.Soluong,this.Tinhtrang};
            var i = Connection.ExcuteQuery("insertBook",CommandType.StoredProcedure, paras, values);
            return i;
        }

        internal int updateBook()
        {
            string[] paras = new string[8] { "@Masach", "@Tensach","@Tacgia","@Theloai","@Nhaxuatban"
                                                ,"@Giasach","@Soluong","@Tinhtrang" };
            object[] values = new object[8] { this.Masach, this.Tensach,this.Tacgia,this.Theloai ,this.Nhaxuatban
                                                ,this.Giasach, this.Soluong,this.Tinhtrang};
            var i = Connection.ExcuteQuery("updateBook", CommandType.StoredProcedure, paras, values);
            return i;
        }

        internal int deleteBook()
        {
            string[] paras = new string[1] {"@Masach"};
            object[] values = new object[1] { this.Masach };
            var i = Connection.ExcuteQuery("deleteBook", CommandType.StoredProcedure, paras, values);
            return i;
        }
    }
}
