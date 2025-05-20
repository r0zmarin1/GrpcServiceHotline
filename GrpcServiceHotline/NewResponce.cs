namespace GrpcServiceHotline
{
    public class NewResponce
    {
        public List<Choices> choices { get; set; } = new List<Choices>();
    }

    public class Choices
    {
        public Message message { get; set; }
    }

    public class Message
    {
        public string content { get; set; }
    }
}
