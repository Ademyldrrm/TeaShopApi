﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DtoLayer.TestimonialDtos;
using TeaShopApi.EntiyLayer.Concrete;

namespace TeaShopApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TestimonialsController : ControllerBase
	{
		private readonly ITestimonialService _testimonialService;

		public TestimonialsController(ITestimonialService testimonialService)
		{
			_testimonialService = testimonialService;
		}
		[HttpGet]
		public IActionResult TestimonialList() 
		{
			var values=_testimonialService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto) 
		{
			Testimonial testimonial = new Testimonial()
			{
				TestimonialComment=createTestimonialDto.TestimonialComment,
				TestimonialImageUrl=createTestimonialDto.TestimonialImageUrl,
				TestimonialName=createTestimonialDto.TestimonialName
			};
			_testimonialService.TInsert(testimonial);
			return Ok("Eklemi İşlemi Gerçekleşti");
		}
		[HttpDelete]

		public IActionResult DeleteTestimonial(int id)
		{
			var values=_testimonialService.TGetById(id);
			_testimonialService.TDelete(values);
			return Ok("Silme İşlemi Gerçekleşti");

		}
		[HttpGet("{id}")]
		public IActionResult TestimonialGetById(int id)
		{
			var values=_testimonialService.TGetById(id);
			return Ok(values);
		}
		[HttpPut]
		public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
		{
			Testimonial testimonial = new Testimonial()
			{
				TestimonialComment = updateTestimonialDto.TestimonialComment,
				TestimonialImageUrl = updateTestimonialDto.TestimonialImageUrl,
				TestimonialName = updateTestimonialDto.TestimonialName,
				TestimonialID=updateTestimonialDto.TestimonialID
			};
			_testimonialService.TUpdate(testimonial);
			return Ok("Güncelleme İşlemi Gerçekleşti");
		}
	}
	}

