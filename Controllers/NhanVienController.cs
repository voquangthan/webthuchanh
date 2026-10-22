
using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVienAPI.Model;
using QuanLyNhanVienAPI.Services;

namespace QuanLyNhanVienAPI.Controllers
{
    [ApiController]
    [Route("api/nhanvien")]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienService _service;

        public NhanVienController(INhanVienService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult LayDanhSach()
        {
            var danhSach = _service.Laydanhsach();
            return Ok(danhSach);
        }
        [HttpPost]
        public IActionResult ThemNhanVien([FromBody] Nhanvien nv)
        {
            _service.Themnhanvien(nv);
            return Ok(nv);
        }
        [HttpDelete]
        public IActionResult Xoanhanvien([FromBody] Nhanvien nv)
        {
            _service.Xoanhanvien(nv);
            return Ok(nv);
        }
        [HttpPut]
        public IActionResult Suanhanvien([FromBody] Nhanvien nv)
        {
            _service.Suanhanvien(nv);
            return Ok(nv);
        }
    }
}
