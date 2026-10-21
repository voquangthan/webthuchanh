using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyNhanVienAPI.Model
{
    public class Nhanvien
    {
        [Column("HOTEN")]
        public string Tennv { get; set; }
        [Column("MANV")]
        public int Manv { get; set; }
        [Column("LUONG")]
        public int luong { get; set; }
    }
}
