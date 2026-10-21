namespace QuanLyNhanVienAPI.Services
{
    public interface INhanVienService
    {
        List<string> Laydanhsach();
        void Themnhanvien(string ten);
        void Xoanhanvien(string ten);
        bool Suanhanvien(int index, string ten);
    }
}
