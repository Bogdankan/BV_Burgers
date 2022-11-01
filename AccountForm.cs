using BV_Burgers.Controllers;
using BV_Burgers.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BV_Burgers
{
    public partial class AccountForm : Form
    {
        List<Button> buttons = new List<Button>();
        Button currentButton;
        public Label label;
        readonly GoodsController gc = new GoodsController();
        readonly Usercontroller uc = new Usercontroller();
        readonly loginForm lf = new loginForm();
        readonly registForm rf = new registForm();
        MainForm mf = new MainForm();
        string good;
        string name;
        string type;
        double price;

        public AccountForm()
        {
            InitializeComponent();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowProducts();
            if (checkBox1.Checked == true)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            DeleteButton.Enabled = false;
            AddButton.Enabled = false;
            buttons.Add(ChangeButton);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            domainUpDown1.Visible = true;
            label3.Visible = true;
            panel2.Visible = true;
            DeleteButton.Enabled = false;
            ChangeButton.Enabled = false;
            buttons.Add(AddButton);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            gc.Delete(listView.SelectedItems[0].Text);
            listView.Items.Remove(listView.SelectedItems[0]);
        }
        private void ShowProducts()
        {
            listView.Items.Clear();
            gc.Goods = gc.GetData();
            foreach (var good in gc.Goods)
            {
                ListViewItem lvi = new ListViewItem(good.GoodName);
                lvi.SubItems.Add(good.Price.ToString());
                listView.Items.Add(lvi);
                textBox1.Clear();
                numericUpDown1.Value = 0;
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;

            if (string.IsNullOrEmpty(name))
                return;
            

            price = (double)numericUpDown1.Value;

            
            currentButton = buttons.SingleOrDefault();
            switch (currentButton.Text)
            {
                case "Додати":
                    {
                        type = domainUpDown1.Text;

                        if (string.IsNullOrEmpty(type))
                            return;

                        gc.GoodAdd(new Goods(name, price, type));
                    }
                    break;               
                case "Змінити":
                    {
                        gc.Change(good, name, price);
                    }
                    break;
            }
            ShowProducts();
            panel2.Visible = false;
            domainUpDown1.Visible = false;
            label3.Visible = false;
            DeleteButton.Enabled = true;
            ChangeButton.Enabled = true;
            AddButton.Enabled = true;
            buttons.Clear();
        }

        private void listView_Click(object sender, EventArgs e)
        {
            good = listView.SelectedItems[0].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //loginform
           lf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //uc.Delete(uc.CurrentUser.Username);

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Text = "Введіть нове ім'я";
            label7.Visible = true;
            textBox7.Visible = true;
            button7.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label7.Text = "Введіть новий пароль";          
            label7.Visible = true;
            textBox7.Visible = true;
            label8.Visible = true;
            textBox8.Visible = true;
            button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == textBox8.Text)
            {
                if (string.IsNullOrEmpty(textBox7.Text))
                    return;
                uc.GetData();
                uc.ChangePass(uc.CurrentUser.Login, textBox7.Text);
            }
            label7.Visible = false;
            textBox7.Visible = false;
            button7.Visible = false;
            label8.Visible = false;
            textBox8.Visible = false;
            button8.Visible = false;
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox7.Text))
                return;
            uc.GetData();
            uc.ChangeName(uc.CurrentUser.Login, textBox7.Text);
            label.Text = $"Привіт, {textBox7.Text}!";
            label7.Visible = false;
            textBox7.Visible = false;
            button7.Visible = false;
            textBox7.Clear();
        }
    }
}
