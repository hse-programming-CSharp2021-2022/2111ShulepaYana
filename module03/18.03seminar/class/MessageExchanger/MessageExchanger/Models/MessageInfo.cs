using System.ComponentModel.DataAnnotations;

namespace MessageExchanger.Models
{
    /// <summary>
    /// Класс сообщения.
    /// </summary>
    public class MessageInfo
    {
        /// <summary>
        /// Тема сообщения.
        /// </summary>
        [Required]
        public string Subject { get; set; }
        /// <summary>
        /// Текст сообщения.
        /// </summary>
        [Required]
        public string Message { get; set; }
        /// <summary>
        /// Отправитель сообщения.
        /// </summary>
        [Required]
        public string SenderId { get; set; } 
        /// <summary>
        /// Получатель сообщения.
        /// </summary>
        [Required]
        public string ReceiverId { get; set; }
        
        /// <summary>
        /// Конструктор сообщения.
        /// </summary>
        /// <param name="subject">Тема сообщения.</param>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="senderId">Отправитель сообщения.</param>
        /// <param name="receiverId">Получатель сообщения.</param>

        public MessageInfo(string subject, string message, string senderId, string receiverId)
        {
            Message = message;
            Subject = subject;
            SenderId = senderId;
            ReceiverId = receiverId;
        }
    }
}