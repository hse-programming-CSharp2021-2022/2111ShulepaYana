using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MessageExchanger.Models;
using MessageExchanger.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MessageExchanger.Controllers
{
    /// <summary>
    /// Контроллер, отвечающий за действия с сообщениями
    /// </summary>
    [Route("Messages")]
    public class MessageController : Controller
    {
        internal static MessagesRepository messagesRepository { get; set; } = new MessagesRepository();

        /// <summary>
        /// Получение сообщений по id отправителя и получателя.
        /// </summary>
        /// <param name="senderId">Отправитель.</param>
        /// <param name="receiverId">Получатель.</param>
        /// <returns>Список сообщений.</returns>
        [HttpGet("get-message-by-two-ids")]
        public IActionResult GetMessageInfoByIds([Required] string senderId, [Required] string receiverId)
        {
            try
            {
                List<MessageInfo> messages = messagesRepository.GetMessages();
                List<MessageInfo> foundMessages = messages
                    .Where(x => x.SenderId == senderId && x.ReceiverId == receiverId)
                    .ToList();
                if (foundMessages.Count != 0)
                    return new OkObjectResult(foundMessages);
                return NotFound("Such messages has not been found");
            }
            catch
            {
                return BadRequest("File with messages is empty or is not available.");
            }
        }

        /// <summary>
        /// Обработчик, получающий сообщения по id получателя.
        /// </summary>
        /// <param name="receiverId">Получатель.</param>
        /// <returns>Список сообщений.</returns>
        [HttpGet("get-message-by-receiver-id")]
        public IActionResult GetMessageInfoByReceiverId([Required] string receiverId)
        {
            try
            {
                List<MessageInfo> messages = messagesRepository.GetMessages();
                List<MessageInfo> foundMessages = messages
                    .Where(x => x.ReceiverId == receiverId)
                    .ToList();
                if (foundMessages.Count != 0)
                    return new OkObjectResult(foundMessages);
                return NotFound("Such messages has not been found");
            }
            catch
            {
                return BadRequest("File with messages is empty or is not available.");
            }
        }

        /// <summary>
        /// Обработчик, получающий сообщения по id отправитель.
        /// </summary>
        /// <param name="senderId">Отправитель.</param>
        /// <returns>Список сообщений.</returns>
        [HttpGet("get-message-by-sender-id")]
        public IActionResult GetMessageInfoBySenderId([Required] string senderId)
        {
            try
            {
                List<MessageInfo> messages = messagesRepository.GetMessages();
                List<MessageInfo> foundMessages = messages
                    .Where(x => x.SenderId == senderId)
                    .ToList();
                if (foundMessages.Count != 0)
                    return new OkObjectResult(foundMessages);
                return NotFound("Such messages has not been found");
            }
            catch
            {
                return BadRequest("File with messages is empty or is not available.");
            }
        }
    }
}