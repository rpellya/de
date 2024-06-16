using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учет_заявок_на_ремонт_оргтехники
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        CleintForm clientForm = new CleintForm();
        MainMenu mainMenu = new MainMenu();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Properties.Settings.Default.login1log && textBox2.Text == Properties.Settings.Default.login1pass)
            {
                Visible = false;

                clientForm.ShowDialog();

                Visible = true;

            }
            else if (textBox1.Text == Properties.Settings.Default.login2log && textBox2.Text == Properties.Settings.Default.login2pass)
            {
                Visible = false;

                mainMenu.ShowDialog();

                Visible = true;
            }
            else if (textBox1.Text == Properties.Settings.Default.admin && textBox2.Text == Properties.Settings.Default.pass)
            {
                Visible = false;

                mainMenu.ShowDialog();

                Visible = true;
            }
            else
            {
                MessageBox.Show("Неверно введен пароль");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Visible = false;

            clientForm.ShowDialog();

            Visible = true;

        }
    }
}
