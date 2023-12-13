namespace TeaShopApi.WebUI.Dtos.MessageDto
{
    public class CreateMessageDto
    {
       
        public string MessageSenderName { get; set; }
        public string MessageSubject { get; set; }
        public string MessageEmail { get; set; }
        public string MessageDetail { get; set; }
       
    }
}
