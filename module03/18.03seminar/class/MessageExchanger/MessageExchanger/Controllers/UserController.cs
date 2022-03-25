using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using MessageExchanger.Models;
using MessageExchanger.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MessageExchanger.Controllers
{
    /// <summary>
    /// Основной класс пользователей.
    /// </summary>
    [Route("Users")]
    public class UserController : Controller
    {
        private static UsersRepository usersRepository = new UsersRepository();
        
        /// <summary>
        /// Создание случайных пользователей и сообщений.
        /// </summary>
        /// <returns>Результат выполнения.</returns>
        [HttpPost("create-random-user")]
        public ActionResult CreateRandomUsers()
        {
            try
            {
                usersRepository.CreateUsers();
                MessageController.messagesRepository.CreateMessages();
                return Ok("Successfully made files with random users and messages.");
            }
            catch
            {
                return BadRequest("Failed to write a list of random users or messages into a file.");
            }
        }
        
        
        /// <summary>
        /// Получение пользователя по email.
        /// </summary>
        /// <param name="email">Email пользователя</param>
        /// <returns>Пользователь с введенным email.</returns>
        [HttpGet("get-user-by-id")]
        public IActionResult GetUserById([Required] string email)
        {
            try
            {
                List<UserInfo> users = usersRepository.GetUsers();
                List<UserInfo> foundUser = users.Where(x => x.Email == email).ToList();
                if (foundUser.Count == 0)
                    return NotFound("User with this email does not exist");
                else
                    return new OkObjectResult(foundUser.First());
            }
            catch
            {
                return BadRequest("File with users is empty or is not available.");
            }
        }
        /// <summary>
        /// Получить всех пользователей.
        /// </summary>
        /// <returns>Все пользователи.</returns>
        [HttpGet("get-all-users")]
        public IActionResult GetAllUsers()
        {
            try
            {
                List<UserInfo> users = usersRepository.GetUsers();
                return new OkObjectResult(users);
            }
            catch
            {
                return BadRequest("File with users is empty or is not available.");
            }
        }
    }
}