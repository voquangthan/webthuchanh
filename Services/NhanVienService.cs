using Microsoft.AspNetCore.Routing.Template;
using System.Security.Cryptography.X509Certificates;

namespace QuanLyNhanVienAPI.Services
{
    public class NhanVienService : INhanVienService
    {
        private static List<string> danhsach = new List<string>
        {
               "nguyen van a",
               "nguyen van b"
        };

        public void Themnhanvien(string ten)
        {
            danhsach.Add(ten);
        }
        public void Xoanhanvien(string ten)
        {
            danhsach.Remove(ten);
        }
        public List<string> Laydanhsach()
        {
            return danhsach;
        }
        public bool Suanhanvien(int index, string ten)
        {
            if (index >= 0 && index < danhsach.Count)
            {
                danhsach[index] = ten;
                return true;
            }
            return false;
        }
    }
}
