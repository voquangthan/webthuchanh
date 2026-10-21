
using Microsoft.AspNetCore.Mvc;
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
    }
}
