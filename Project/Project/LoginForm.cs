using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    /// <summary>
    /// Форма авторизации
    /// </summary>
    public partial class LoginForm : Form
    {
        SqlClass database = new SqlClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        enum Role
        {
            Manager = 4,
            Master = 3,
            Operator = 2,
            Customer = 1,
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            int roleID = 0;
            try
            {
                roleID = CheckAuth(textBoxLogin.Text, textBoxPassword.Text);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            var userID = database.ExecuteScalar<int>($"select userID from [User] where login = '{textBoxLogin.Text}'");
            switch (roleID)
            {
                case (int)Role.Manager:
                    Visible = false;
                    ManagerForm managerForm = new ManagerForm(userID);
                    managerForm.ShowDialog();
                    Visible = true;
                    break;
                case (int)Role.Master:
                    Visible = false;
                    MasterForm masterForm= new MasterForm(userID);
                    masterForm.ShowDialog();
                    Visible = true;
                    break;
                case (int)Role.Operator:
                    Visible = false;
                    OperatorForm operatorForm = new OperatorForm(userID);
                    operatorForm.ShowDialog();
                    Visible = true;
                    break;
                case (int)Role.Customer:
                    Visible = false;
                    CustomerForm customerForm= new CustomerForm(userID);
                    customerForm.ShowDialog();
                    Visible = true;
                    break;
            }
        }

        public int CheckAuth(string login, string password)
        {
            if (login == "" || password == "") throw new Exception("Не все поля заполнены");

            var reader = database.ExecuteReader($"select login, password, roleID from [User] where login = '{login}'");

            if (!reader.HasRows) throw new Exception("Пользователя с таким логином не существует");

            string passwordInDB = "";
            int roleID = 0;
            while (reader.Read())
            {
                passwordInDB = reader.GetString(1);
                roleID = reader.GetInt32(2);
            }

            if (password != passwordInDB) throw new Exception("Пароль неверный");
            return roleID;
        }
    }
}
