using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MessageExchanger.Models;
using MessageExchanger.Services;

namespace MessageExchanger.Repositories
{
    /// <summary>
    /// Репозиторий пользователей.
    /// </summary>
    public class UsersRepository : IUsersRepository
    {

        /// <summary>
        /// Метод для записи пользователей, полученных из сервиса, в файл.
        /// </summary>
        public void CreateUsers()
        {
            List<UserInfo> users = RandomizingService.RandomizeUsers().OrderBy(x=>x.Email).ToList();
            string json = JsonSerializer.Serialize(users);
            using StreamWriter sw = new("users.json");
            sw.Write(json);
            sw.Close();
        }

        /// <summary>
        /// Метод для получения списка пользователей из файла.
        /// </summary>
        /// <returns>Список пользователей.</returns>
        public List<UserInfo> GetUsers()
        {
            using StreamReader sr = new("users.json");
            string json = sr.ReadToEnd();
            sr.Close();
            List<UserInfo> users = JsonSerializer.Deserialize<List<UserInfo>>(json);
            return users;
        }
        
        /// <summary>
        /// Метод, добавляющий в файл созданного пользователя.
        /// </summary>
        /// <param name="user">Пользователь.</param>
        /// <returns>Проверка существования такого пользователя.</returns>
        public bool AppendUserToFile(UserInfo user)
        {
            bool isEmailFree = true;
            using StreamReader sr = new("users.json");
            string json = sr.ReadToEnd();
            sr.Close();
            List<UserInfo> users = JsonSerializer.Deserialize<List<UserInfo>>(json);
            if (users is null)
                users = new List<UserInfo>();
            if (!users.Select(x => x.Email).ToList().Contains(user.Email))
            {
                users.Add(user);
                List<UserInfo> sortedUsers = users.OrderBy(x => x.Email).ToList();
                json = JsonSerializer.Serialize(sortedUsers);
                using StreamWriter sw = new("users.json");
                sw.Write(json);
                sw.Close();
            }
            else
                isEmailFree = false;
            return isEmailFree;
        }
    }
}