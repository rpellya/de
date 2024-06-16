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
    /// Форма для переназначения мастера на заявке
    /// </summary>
    public partial class ChangeMasterForm : Form
    {
        SqlClass database = new SqlClass();
        public ChangeMasterForm()
        {
            InitializeComponent();
            comboBoxMaster.DataSource = database.GetDataTable("select userID, fio from [User] where roleID = 3");
            comboBoxMaster.DisplayMember = "fio";
            comboBoxMaster.ValueMember = "userID";

            numericUpDownRequestID.Maximum = int.MaxValue;
            numericUpDownRequestID.Minimum = 1;
        }

        private void buttonChangeRequest_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = database.ExecuteReader($"select * from Request where requestID = {numericUpDownRequestID.Value}");
                if (!reader.HasRows)
                {
                    MessageBox.Show("Нет заявки с таким ID");
                    return;
                }

                var res = database.ExecuteNonQuery($"update Request set masterID = {comboBoxMaster.SelectedValue} where requestID = {numericUpDownRequestID.Value}");
                if (res != 0)
                {
                    MessageBox.Show("Данные обновлены");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Что то пошло не так {ex.Message}");            
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
