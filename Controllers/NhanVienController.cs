using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVienAPI.Services;

namespace QuanLyNhanVienAPI.Controllers
{
    [ApiController]
    [Route("api/nhanvien")]
    public class NhanVienController : Controller
    {
        private readonly INhanVienService _service;

        public NhanVienController(INhanVienService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_service.Laydanhsach());
        }
        [HttpPost]
        public IActionResult ThemNhanVien([FromBody] string ten)
        {
            _service.Themnhanvien(ten);

            return Ok("Thêm nhân viên thành công");
        }
        [HttpDelete]
        public IActionResult Xoanhanvien([FromBody] string ten)
        {
            _service.Xoanhanvien(ten);
            return Ok("xoa nhan vien thanh cong");
        }
        [HttpPut]
        public IActionResult Suanhanvien(int index, [FromBody] string tenmoi)
        {
            bool kq = _service.Suanhanvien(index, tenmoi);
            if (!kq)
            {
                Ok("ko tim thay");
            }
            return Ok("da sua thanh cong");
        }
    }
}
