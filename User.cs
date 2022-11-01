using System;
using BV_Burgers.Events;

namespace BV_Burgers.Models
{
    [Serializable]
    class User
    {
        public string Username{ get; set; }
        public string Login { get; }
        public string Password { get; set; }

        public int CountOfPurchases { get; }

        public event EventHandler<NameChangedEventArgs> NameChanged;

        public User(string name, string login,string password)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым.", nameof(name));
            }
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException("Логин пользователя не может быть пустым.", nameof(login));
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("Вы забыли ввести пароль.", nameof(name));
            }

            Username = name;
            Login = login;
            Password = password;
        }

    }

       
}
