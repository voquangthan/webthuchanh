using Microsoft.EntityFrameworkCore;
using QuanLyNhanVienAPI.Data;
using QuanLyNhanVienAPI.Model;
using QuanLyNhanVienAPI.Services;

public class NhanVienServices : INhanVienService
{
    private readonly AppDbContext _dbContext;
    public List<Nhanvien> Laydanhsach()
    {
        return _dbContext.NHANVIEN.ToList();
    }
    // 2 dòng trên sẽ gọi đến tầng sql với điều kiện khai báo appcontext
    public NhanVienServices(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }



}