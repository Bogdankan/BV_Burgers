using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BV_Burgers.Controllers;

namespace BV_Burgers
{
    public partial class loginForm : Form
    {
        Usercontroller uc;
        readonly registForm rf = new registForm();
        string login;
        string pass;

        public loginForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DefaultSettings();
            this.Close();
        }

        private void regist_Click(object sender, EventArgs e)
        {
            this.Hide();
            rf.ShowDialog();
            DefaultSettings();
            this.Show();
        }
        private void continueButton_Click(object sender, EventArgs e)
        {
            try
            {
                uc = new Usercontroller();
                uc.Users =  uc.GetData();
                if (uc.Users.Count == 0)
                    return;

                login = loginField.Text;

                pass = passField.Text;

                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
                    return;

                //uc.GetCurrentUser();

                if (uc.CurrentUser.Password == pass)
                {
                    DefaultSettings();
                    uc.Save();
                    this.Close();
                }
                else
                {
                    needPassword.Text = "*неверный пароль";
                    needPassword.Visible = true;
                }
            }
            catch (ArgumentNullException)
            {
                needLogin.Visible = true;
                needPassword.Visible = true;
            }
        }

        public void DefaultSettings()
        {
            needLogin.Visible = false;
            needLogin.Text = "*обязательное поле";
            needPassword.Visible = false;
            loginField.Clear();
            passField.Clear();
        }

    }
}
