using System.Collections.Generic;
using MessageExchanger.Models;

namespace MessageExchanger.Repositories
{
    /// <summary>
    /// Интерфейс пользователя для работы репозитория.
    /// </summary>
    public interface IUsersRepository
    {
        /// <summary>
        /// Метод для записи пользователей, полученных из сервиса, в файл.
        /// </summary>
        public void CreateUsers();
        
        /// <summary>
        /// Метод для получения списка пользователей из файла.
        /// </summary>
        /// <returns>Список пользователей.</returns>
        public List<UserInfo> GetUsers();
    }
}