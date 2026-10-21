using Microsoft.EntityFrameworkCore;
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
        return _dbContext.NhanViens.ToList();
    }

}