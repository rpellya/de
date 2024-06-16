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
    /// Форма для создания заявки
    /// </summary>
    public partial class AddRequestForm : Form
    {
        SqlClass database = new SqlClass();
        public AddRequestForm()
        {

            InitializeComponent();

            // Подгрузка данных
            comboBoxClient.DataSource = database.GetDataTable("select userID, fio from [User] where roleID = 1");
            comboBoxClient.DisplayMember = "fio";
            comboBoxClient.ValueMember = "userID";

            comboBoxTechType.DataSource = database.GetDataTable("select orgTechTypeID, name from [OrgTechType]");
            comboBoxTechType.DisplayMember = "name";
            comboBoxTechType.ValueMember = "orgTechTypeID";
        }
        /// <summary>
        /// Функция создания заявки
        /// </summary>
        /// <param name="techTypeID"></param>
        /// <param name="model"></param>
        /// <param name="clientID"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public int CreateRequest(int techTypeID, string model, int clientID, string description)
        {
            int countChangeRow = 0;
            try
            {
                countChangeRow = database.ExecuteNonQuery($"insert into Request values ('{DateTime.Now}', {techTypeID}, '{model}', '{description}', 3, null, '', null, {clientID})");
                return countChangeRow;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Что то пошло не так {ex.Message}");
                return -1;
            }
            
        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            int techTypeID = (int)comboBoxTechType.SelectedValue;
            string model = textBoxModel.Text;
            int clientID = (int)comboBoxClient.SelectedValue;
            string description = richTextBoxDescription.Text;

            if (model == "" || description == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            if(CreateRequest(techTypeID, model, clientID, description) == 1)
            {
                MessageBox.Show("Заявка успешно создана");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
