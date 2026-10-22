using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyNhanVienAPI.Model
{
    public class Nhanvien
    {
        [Key]
        [Column("MANV")]
        public int Manv { get; set; }
        [Column("HOTEN")]
        public string Tennv { get; set; }
        [Column("LUONG")]
        public int luong { get; set; }
    }
}
