using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DtoLayer.AboutDtos;
using TeaShopApi.EntiyLayer.Concrete;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult GetAboutList()
        {
            var values=_aboutService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CrateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                AboutComment=createAboutDto.AboutComment,
                AboutImage=createAboutDto.AboutImage,
            };
            _aboutService.TInsert(about);
            return Ok("Ekleme İşlemi Başarılı Bir Şekilde Gerçekleşti");
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values=_aboutService.TGetById(id);
            _aboutService.TDelete(values);
            return Ok("Silme İşlemi Gerçekleşti");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutComment = updateAboutDto.AboutComment,
                AboutImage=updateAboutDto.AboutImage,
                AboutID=updateAboutDto.AboutID,
            };
            _aboutService.TUpdate(about);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }
    }
}
