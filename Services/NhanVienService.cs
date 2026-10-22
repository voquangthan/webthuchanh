using QuanLyNhanVienAPI.Data;
using QuanLyNhanVienAPI.Model;
using QuanLyNhanVienAPI.Services;

public class NhanVienServices : INhanVienService
{
    private readonly AppDbContext _dbContext;

    public NhanVienServices(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Nhanvien> Laydanhsach()
    {
        return _dbContext.NHANVIEN.ToList();
    }

    public void Themnhanvien(Nhanvien nv)
    {
        _dbContext.NHANVIEN.Add(nv);
        _dbContext.SaveChanges();
    }

    public void Xoanhanvien(Nhanvien nv)
    {
        _dbContext.NHANVIEN.Remove(nv);
        _dbContext.SaveChanges();
    }
    public void Suanhanvien(Nhanvien nv)
    {
        _dbContext.NHANVIEN.Update(nv);
        _dbContext.SaveChanges();
    }
}