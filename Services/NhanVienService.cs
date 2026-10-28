using QuanLyNhanVienAPI.Data;
using QuanLyNhanVienAPI.Model;
using QuanLyNhanVienAPI.Services;

public class NhanVienServices : INhanVienService
{
    private readonly AppDbContext _app;

    public NhanVienServices(AppDbContext app)
    {
        _app = app;
    }

    public List<Nhanvien> laynhanvien1()
    {
        return _app.NHANVIEN.ToList();
    }
    public void themnhanvien1(Nhanvien n)
    {
        _app.NHANVIEN.Add(n);
        _app.SaveChanges();
    }
    public void xoanhanvien1(Nhanvien n)
    {
        _app.NHANVIEN.Remove(n);
        _app.SaveChanges();
    }
    public void suanhanvien1(Nhanvien nv)
    {
        _app.NHANVIEN.Update(nv);
        _app.SaveChanges();
    }
}