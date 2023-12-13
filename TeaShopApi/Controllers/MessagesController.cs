using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DtoLayer.MessageDtos;
using TeaShopApi.EntiyLayer.Concrete;

namespace TeaShopApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MessagesController : ControllerBase
	{
		private readonly IMessageService _messageService;

		public MessagesController(IMessageService messageService)
		{
			_messageService = messageService;
		}
		[HttpGet]
		public IActionResult MessageList()
		{
			var values=_messageService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateMessage(CreateMessageDto createMessageDto)
		{
			Message message = new Message()
			{
				MessageDetail=createMessageDto.MessageDetail,
				MessageEmail=createMessageDto.MessageEmail,	
				MessageSenderName=createMessageDto.MessageSenderName,
				MessageSubject = createMessageDto.MessageSubject
			};
			_messageService.TInsert(message);
			return Ok("Mesajınız Eklendi");
		}
		[HttpDelete]
		public IActionResult DeleteMessage(int id) 
		{
			var values=_messageService.TGetById(id);
			_messageService.TDelete(values);
			return Ok("Mesajınız Silindi");
			
		}
		[HttpPut]
		public IActionResult UpDAteMessage(UpdateMessageUpdateDto updateMessageUpdateDto)
		{
			Message message = new Message()
			{
				MessageDetail = updateMessageUpdateDto.MessageDetail,
				MessageEmail = updateMessageUpdateDto.MessageEmail,
				MessageSenderName = updateMessageUpdateDto.MessageSenderName,
				MessageSubject = updateMessageUpdateDto.MessageSubject,
				MessageID = updateMessageUpdateDto.MessageID

			};
			_messageService.TUpdate(message);
			return Ok("Mesajınız Güncellendi");
		}
		[HttpGet("{id}")]
		public IActionResult GetByIdMessage(int id)
		{
			var values = _messageService.TGetById(id);
			return Ok(values);
		}


	}
}
