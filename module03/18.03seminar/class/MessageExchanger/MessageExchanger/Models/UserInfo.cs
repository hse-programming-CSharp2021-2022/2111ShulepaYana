using System.ComponentModel.DataAnnotations;

namespace MessageExchanger.Models
{
    /// <summary>
    /// Класс пользователя.
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// Почта пользователя.
        /// </summary>
        [Required]
        public string Email {get; set;}

        /// <summary>
        /// Конструктор пользователя.
        /// </summary>
        /// <param name="userName">Имя пользователя.</param>
        /// <param name="email">Почта пользователя.</param>
        public UserInfo(string userName, string email)
        {
            UserName = userName;
            Email = email;
        }
    }
}