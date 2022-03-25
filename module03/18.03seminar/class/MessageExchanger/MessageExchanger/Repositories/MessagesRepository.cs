using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MessageExchanger.Models;
using MessageExchanger.Services;


namespace MessageExchanger.Repositories
{
    /// <summary>
    /// Репозиторий сообщений.
    /// </summary>
    public class MessagesRepository : IMessagesRepository
    {
        /// <summary>
        /// Метод для записи сообщений, полученных из сервиса, в файл.
        /// </summary>
        public void CreateMessages()
        {
            List<MessageInfo> messages = RandomizingService.RandomizeMessages();
            string json = JsonSerializer.Serialize(messages);
            using StreamWriter sw = new("messages.json");
            sw.Write(json);
            sw.Close();
        }
        /// <summary>
        /// Метод для получения списка сообщений из файла.
        /// </summary>
        /// <returns>Список сообщений.</returns>
        public List<MessageInfo> GetMessages()
        {
            using StreamReader sr = new("messages.json");
            string json = sr.ReadToEnd();
            sr.Close();
            List<MessageInfo> messages = JsonSerializer.Deserialize<List<MessageInfo>>(json);
            return messages;
        }
    }
}