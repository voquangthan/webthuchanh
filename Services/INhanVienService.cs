using QuanLyNhanVienAPI.Model;

namespace QuanLyNhanVienAPI.Services
{
    public interface INhanVienService
    {
        List<Nhanvien> Laydanhsach();
        void Themnhanvien(Nhanvien nv);
        void Xoanhanvien(Nhanvien nv);
        void Suanhanvien(Nhanvien nv);
    }
}
