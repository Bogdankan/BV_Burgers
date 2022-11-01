using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using BV_Burgers.Controllers;
using BV_Burgers.Models;

namespace BV_Burgers
{
    public partial class registForm : Form
    {
        Usercontroller uc = new Usercontroller();
        string username;
        string login;
        string password;
        public registForm()
        {
            InitializeComponent();
        }

        public void CloseButton_Click(object sender, EventArgs e)
        {
            DefaultSettings();           
            this.Close();
        }

        public void SignInButton_Click(object sender, EventArgs e)
        {

            if (passwordField.Text == confirmPassField.Text)
            {
                username = usernameField.Text;
                login = loginField.Text;
                password = passwordField.Text;
            }
            if (string.IsNullOrEmpty(username) 
                || string.IsNullOrEmpty(login)
                || string.IsNullOrEmpty(password))
            {
                needName.Visible = true;
                needLogin.Visible = true;
                needPassword.Visible = true;
                needConfirm.Visible = true;
                return;
            }
            User user = new User(username, login, password);
            uc.UserAdd(user);
            uc.Save();
            DefaultSettings();
            this.Close();             
        }

        public void DefaultSettings()
        {
            needName.Visible = false;
            needLogin.Visible = false;
            needPassword.Visible = false;
            needConfirm.Visible = false;
            usernameField.Text = null;
            loginField.Text = null;
            passwordField.Text = null;
            confirmPassField.Text = null;
        }

    }
}
