using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    /// <summary>
    /// Форма изменения конечного времени заявки
    /// </summary>
    public partial class ChangeEndTimeForm : Form
    {
        SqlClass database = new SqlClass();
        public ChangeEndTimeForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Изменеие заявки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

                var res = database.ExecuteNonQuery($"update Request set completionDate = '{dateTimePickerEndDate.Value}' where requestID = {numericUpDownRequestID.Value}");

                if (res != 0)
                {
                    MessageBox.Show("Данные обновлены");
                }
            }
            catch(Exception ex)
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
