using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BV_Burgers.Controllers;
using BV_Burgers.Events;
using BV_Burgers.Models;

namespace BV_Burgers
{
    public partial class MainForm : Form
    {

        private Form activeForm = null;
        private bool categoryChoose = false;
        readonly loginForm lf = new loginForm();      
        Usercontroller uc;
        GoodsController gc;

        public Label Choose 
        {
            get
            {
                return choose;
            } 
        }
        public MainForm()
        {
            InitializeComponent();
            this.Text = "BV Burgers";
        }


        #region Private methods
        private void MenuShow(Panel menu)
        {
            if (menu.Visible == false)
            {
                picMenu.BackColor = Color.FromArgb(224, 224, 224);
                menu.Visible = true;
            }
            else
            {
                picMenu.BackColor = Color.Silver;
                menu.Visible = false;
            }
        }

        private void ChoosePic(PictureBox pb)
        {
            List<PictureBox> collection = new List<PictureBox>();
            collection.Add(pbBurger);
            collection.Add(pbChicken);
            collection.Add(pbDesserts);
            collection.Add(pbDrinks);
            collection.Add(pbPotato);
            collection.Add(pbSalads);
            collection.Add(pbSets);
            collection.Add(pbSnacks);
            collection.Add(pbVouchers);
            if (!categoryChoose)
            {
                pb.BorderStyle = BorderStyle.FixedSingle;
                categoryChoose = true;
            }
            else
            {
                foreach (var item in collection)
                {
                    if (pb != item)
                    {
                        item.BorderStyle = BorderStyle.None;
                    }
                    else item.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFormLoader.Controls.Add(childForm);
            pnlFormLoader.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            gc = new GoodsController();

            double sum;
            sum = gc.CalculatePrice(gc.GetData());
            label1.Text = sum.ToString();
            var bf = new BurgersCategoryForm();
            gc.AddGood(new GoodIcon(), bf.burgerPanel);
        }

        #endregion


        #region 

        private void picMenu_Click(object sender, EventArgs e)
        {
            MenuShow(menuPanel);
        }

        private void pbBurger_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb = (PictureBox)sender;
            pb.BackColor = Color.Silver;
        }

        private void pbBurger_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb = (PictureBox)sender;
            pb.BackColor = Color.FromArgb(224, 224, 224);
        }

        #endregion


        #region Categories
        private void Category_Click(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb = (PictureBox)sender;
            ChoosePic(pb);
            switch (pb.Name)
            {
                case "pbBurger":
                    OpenChildForm(new BurgersCategoryForm());
                    choose.Text = "Бургери";
                    break;
                case "pbChicken":
                    OpenChildForm(new ChickenCategoryForm());
                    choose.Text = "Курка";
                    break;
                case "pbSnacks":
                    OpenChildForm(new SnacksCategoryForm());
                    choose.Text = "Снеки";
                    break;
                case "pbPotato":
                    OpenChildForm(new PotatoCategoryForm());
                    choose.Text = "Смажена картопля";
                    break;
                case "pbSalads":
                    OpenChildForm(new SaladsCategoryForm());
                    choose.Text = "Салати";
                    break;
                case "pbDesserts":
                    OpenChildForm(new DessertsCategoryForm());
                    choose.Text = "Десерти";
                    break;
                case "pbDrinks":
                    OpenChildForm(new DrinksCategoryForm());
                    choose.Text = "Напої";
                    break;
                case "pbSets":
                    OpenChildForm(new SetsCategoryForm());
                    choose.Text = "Особливі набори";
                    break;
                case "pbVouchers":
                    OpenChildForm(new VouchersCategoryForm());
                    choose.Text = "Ваучери";
                    break;
                default:
                    break;
            }
            MenuShow(menuPanel);
            pb.BackColor = Color.FromArgb(224, 224, 224);
        }
        #endregion


        #region Settings
        private void Button1_Click(object sender, EventArgs e)
        {
            uc = new Usercontroller();
            uc.GetData();

            if (uc.CurrentUser == null)
            {
                this.Hide();
                lf.ShowDialog();
                this.Show();
            }
            else
            {
                AccountForm af = new AccountForm();
                af.label = choose;
                OpenChildForm(af);
                choose.Text =  $"Привіт, {uc.CurrentUser.Username}!";
                MenuShow(menuPanel);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Cart());
            choose.Text ="Корзина";
            MenuShow(menuPanel);
        }

        #endregion

        internal static void HandlerSample(object sender, NameChangedEventArgs e)
        {

        }

    }


}
