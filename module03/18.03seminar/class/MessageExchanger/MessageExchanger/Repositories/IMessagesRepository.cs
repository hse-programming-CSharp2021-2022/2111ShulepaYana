using System.Collections.Generic;
using MessageExchanger.Models;

namespace MessageExchanger.Repositories
{
    /// <summary>
    /// Интерфейс сообщений для работы репозитория.
    /// </summary>
    public interface IMessagesRepository
    {
        /// <summary>
        /// Метод для записи сообщений, полученных из сервиса, в файл.
        /// </summary>
        public void CreateMessages();

        /// <summary>
        /// Метод для получения списка сообщений из файла.
        /// </summary>
        /// <returns>Список сообщений.</returns>
        public List<MessageInfo> GetMessages();
    }
}