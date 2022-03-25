using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MessageExchanger.Models;

namespace MessageExchanger.Services
{
    internal enum Names
    {
        Vi, Jinx, Ekko, Singed, Caitlyn, Jayce, Heimerdinger, Viktor, Kindred, Teemo,
        Ganyu, HuTao, Raiden, Venti, Itto, Bennett, Xingqiu, Zhongli, Albedo, Ayaka, 
        Jean, Eula, Kazuha, YaeMiko, Shenhe, YunJin, Gorou, Klee, Diluc, Kokomi, 
        Yoimiya, Aloy, Yanfei, Mona, Tartaglia, Xiao, Diona, Sucrose, Keqing, Ningguang, 
        Razor, Fischl, Noelle, Xiangling, Thoma, Barbara, Sara, Sayu, Beidou, Chongyun, 
        Kaeya, Rosaria, Qiqi, Xinyan, Lisa, Amber
    }
    internal enum Verbals
    {
        ask, be, become, begin, call, can, come, could, feel, find,
        get, give, go, have, hear, help, keep, know, leave, let,
        like, live, look, make, may, mean, might, move, need, pause,
        play, put, run, say, see, seem, should, show, start, take,
        talk, tell, think, turn, use, want, will, work, would, walk
    }
    
    /// <summary>
    /// Сервис для создания случайных пользователей и сообщений.
    /// </summary>
    public class RandomizingService
    {
        private static readonly List<UserInfo> _users = new List<UserInfo>();
        private static readonly List<MessageInfo> _messages = new List<MessageInfo>();
        private static readonly Random _random = new Random();

        /// <summary>
        /// Метод создания случайных пользователей.
        /// </summary>
        /// <returns>Список пользователей.</returns>
        public static List<UserInfo> RandomizeUsers()
        {
            _users.Clear();
            int usersCount = _random.Next(5, 21);
            for (int i = 0; i < usersCount; i++)
            {
                string name = ((Names) _random.Next(0, 55)).ToString();
                string email = name + "_" + _random.Next(1920, 2022) + "@therealmail.com";
                if (!_users.Select(x => x.Email).ToList().Contains(email))
                {
                    _users.Add(new UserInfo(name, email));
                }
                else
                    i--;
            }
            return _users;
        }
        
        /// <summary>
        /// Метод создания случайных сообщений.
        /// </summary>
        /// <returns>Список сообщений.</returns>
        public static List<MessageInfo> RandomizeMessages()
        {
            _messages.Clear();
            int messagesCount = _random.Next(10, 101);
            for (int i = 0; i < messagesCount; i++)
            {
                string sendedId = _users[_random.Next(0, _users.Count)].Email;
                string receiverId = _users[_random.Next(0, _users.Count)].Email;
                int subjectWordsCount = _random.Next(1, 5);
                string subject = "";
                for (int j = 0; j < subjectWordsCount; j++)
                    subject += ((Verbals) _random.Next(0, 50)).ToString() + " ";
                int messageWordsCount = _random.Next(2, 10);
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < messageWordsCount; j++)
                {
                    if (j == 0 || j == messageWordsCount - 1)
                        sb.Append(((Names) _random.Next(0, 55)).ToString() + " ");
                    else
                        sb.Append(((Verbals) _random.Next(0, 50)).ToString() + " ");
                }
                string message = sb.ToString();
                _messages.Add(new MessageInfo(subject, message, sendedId, receiverId));
            }
            return _messages;
        }
    }
}