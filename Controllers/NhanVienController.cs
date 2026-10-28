
using Microsoft.AspNetCore.Mvc;
using QuanLyNhanVienAPI.Model;
using QuanLyNhanVienAPI.Services;

namespace QuanLyNhanVienAPI.Controllers
{
    [ApiController]
    [Route("api/nhanvien1")]
    public class NhanVienController : ControllerBase
    {
        private readonly INhanVienService _service;

        public NhanVienController(INhanVienService service)
        {
            _service = service;
        }


        [HttpGet]
        // http lay
        public IActionResult LayDanhSach()
        {

            return Ok(_service.Laydanhsach());
        }
        [HttpPost]
        //them nhan vien
        // dữ li
        public IActionResult ThemNhanVien([FromBody] Nhanvien nv)
        {
            _service.Themnhanvien(nv);
            return Ok(nv);
        }
        [HttpDelete]
        //xoa
        public IActionResult Xoanhanvien([FromBody] Nhanvien nv)
        {
            _service.Xoanhanvien(nv);
            return Ok(nv);
        }
        [HttpPut]
        //sua nhan vien
        public IActionResult Suanhanvien([FromBody] Nhanvien nv)
        {
            _service.Suanhanvien(nv);
            return Ok(nv);
        }
    }
}
