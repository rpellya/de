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
    /// Форма редактирования заявки
    /// </summary>
    public partial class EditRequestForm : Form
    {
        SqlClass database = new SqlClass();
        public EditRequestForm()
        {
            InitializeComponent();
            numericUpDownRequestID.Maximum = int.MaxValue;

            //Подгрузка данных
            comboBoxTechType.DataSource = database.GetDataTable("select orgTechTypeID, name from [OrgTechType]");
            comboBoxTechType.DisplayMember = "name";
            comboBoxTechType.ValueMember = "orgTechTypeID";

            comboBoxStatus.DataSource = database.GetDataTable("select requestStatusID, name from [RequestStatus]");
            comboBoxStatus.DisplayMember = "name";
            comboBoxStatus.ValueMember = "requestStatusID";

            comboBoxMaster.DataSource = database.GetDataTable("select userID, fio from [User] where roleID = 1");
            comboBoxMaster.DisplayMember = "fio";
            comboBoxMaster.ValueMember = "userID";

        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            int requestID = (int)numericUpDownRequestID.Value;
            var request = database.ExecuteReader($"select * from [Request] where requestID = {requestID}");

            if (!request.HasRows)
            {
                MessageBox.Show("Нет заявки с таким ID");
                return;
            }


 
            // Подгрузка данных в поля
            while (request.Read()) 
            {
                dateTimePickerStrart.Value = request.GetDateTime(request.GetOrdinal("startDate"));
                dateTimePickerEnd.Value = request.IsDBNull(request.GetOrdinal("completionDate")) ? DateTime.Now : request.GetDateTime(request.GetOrdinal("completionDate"));
                comboBoxTechType.SelectedValue = request.GetInt32(request.GetOrdinal("orgTechTypeID"));
                textBoxModel.Text = request.GetString(request.GetOrdinal("orgTechModel"));
                richTextBoxDescription.Text = request.GetString(request.GetOrdinal("problemDescryption"));
                comboBoxStatus.SelectedValue = request.GetInt32(request.GetOrdinal("requestStatusID"));
                if (!request.IsDBNull(request.GetOrdinal("completionDate")))
                 {
                    comboBoxMaster.SelectedValue = request.GetInt32(request.GetOrdinal("masterID"));
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Редактирование заявки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditRequest_Click(object sender, EventArgs e)
        {

            int requestID = (int)numericUpDownRequestID.Value;
            var startDate = dateTimePickerStrart.Value;
            int orgTechType = (int)comboBoxTechType.SelectedValue;
            string description = richTextBoxDescription.Text;
            int statusID = (int)comboBoxStatus.SelectedValue;
            var endDate = dateTimePickerEnd.Value;
            int masterID = (int)comboBoxMaster.SelectedValue;
            string model = textBoxModel.Text;
            if (model == "" || description == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }

            try
            {
                int row = database.ExecuteNonQuery($"Update Request set startDate = '{startDate}', completionDate = '{endDate}', orgTechTypeID = {orgTechType}, orgTechModel = '{model}', problemDescryption = '{description}' , requestStatusID = {statusID}, masterID = {masterID} where requestID = {requestID}");
                if (row == 1) MessageBox.Show("Успешно обнавлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что то пошло не так {ex.Message}");

            }
        }
    }
}
