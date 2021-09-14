using System.ComponentModel.DataAnnotations;

namespace signalr.DTO
{
    public class Message
    {
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}