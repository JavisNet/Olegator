using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
    
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {

            if (Class.Module.MOD(UnameTb.Text) == "" || Class.Module.MOD(PasswordTb.Text) == "")
            {
                MessageBox.Show("Введите имя пользователя и пароль!");
            }
            else if(Class.Module.MOD(UnameTb.Text) == "Admin" && Class.Module.MOD(PasswordTb.Text) == "Password")
            {
                MainMenu Obj = new MainMenu();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль!");
                UnameTb.Text = "";
                PasswordTb.Text = "";
            }
        }
    }
}
