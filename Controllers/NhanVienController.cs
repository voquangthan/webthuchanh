
using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVienAPI.Model;
using QuanLyNhanVienAPI.Services;

namespace QuanLyNhanVienAPI.Controllers
{
    [ApiController]
    [Route("api/nhanvien1")]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienService _sv;

        public NhanVienController(INhanVienService sv)
        {
            _sv = sv;
        }
        [HttpGet]
        public IActionResult Laynhanvien()
        {
            return Ok(_sv.laynhanvien1());
        }
        [HttpPut]
        public IActionResult Suanhanvien([FromBody] Nhanvien nv)
        {
            _sv.suanhanvien1(nv);
            return Ok(nv);
        }
        [HttpDelete]
        public IActionResult Deletenhanvien([FromBody] Nhanvien nv)
        {
            _sv.xoanhanvien1(nv);
            return Ok(nv);
        }
        [HttpPost]
        public IActionResult them([FromBody] Nhanvien nv)
        {
            _sv.themnhanvien1(nv);
            return Ok(nv);
        }
    }
}
