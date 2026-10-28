using QuanLyNhanVienAPI.Model;

namespace QuanLyNhanVienAPI.Services
{
    public interface INhanVienService
    {
        List<Nhanvien> laynhanvien1();
        void themnhanvien1(Nhanvien nv);
        void xoanhanvien1(Nhanvien nv);
        void suanhanvien1(Nhanvien nv);
    }
}
