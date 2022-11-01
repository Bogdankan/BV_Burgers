using BV_Burgers.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace BV_Burgers.Controllers
{
    class Usercontroller : Controller
    {
        public List<User> Users { get; set; }

        public User CurrentUser { get; private set; }

        public bool IsCurrentUser { get; private set; } = false;


        public Usercontroller()
        {
            Users = new List<User>();
        }
        public Usercontroller(string login, string pass)
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                throw new ArgumentNullException("Логин пользователя не может быть пустым.",nameof(login));
            }
            if (string.IsNullOrWhiteSpace(pass))
            {
                throw new ArgumentNullException("Поле не может быть пустым.", nameof(pass));
            }
            Users = GetData();
            CurrentUser = Users.SingleOrDefault(u => u.Login == login && u.Password == pass);
            if (CurrentUser != null)
            {
                IsCurrentUser = true;
            }
        }

        public void Save()
        {
            Save("users.dat", Users);
            Save("currentUser.dat", CurrentUser);
        }

        public List<User> GetData()
        {
            CurrentUser = GetCurrentUser();
            Users = Load<List<User>>("users.dat") ?? new List<User>();
            return Users;
        }

        public User GetCurrentUser()
        {
            return Load<User>("currentUser.dat") ?? null;
        }
        public void UserAdd(User user)
        {
            Users.Add(user);
            CurrentUser = Users.SingleOrDefault(u => u.Login == user.Login);
            Save();
        }

        public void Delete(string username)
        {
            CurrentUser = Users.SingleOrDefault(u => u.Username == username);
            Users.Remove(CurrentUser);
            Save();
        }

        public void ChangeName(string user, string name)
        {
            CurrentUser = Users.SingleOrDefault(u => u.Login == user);
            Users.Remove(CurrentUser);
            CurrentUser.Username = name;
            Users.Add(CurrentUser);
            Save();
        }
        public void ChangePass(string user, string pass)
        {
            CurrentUser = Users.SingleOrDefault(u => u.Login == user);
            Users.Remove(CurrentUser);
            CurrentUser.Password = pass;
            Users.Add(CurrentUser);
            Save();
        }
       
    }
}
