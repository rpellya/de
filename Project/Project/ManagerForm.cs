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
    /// Меню менеджера
    /// </summary>
    public partial class ManagerForm : Form
    {
        private int _userID;
        public ManagerForm(int userID)
        {
            _userID = userID;
            InitializeComponent();
            
        }

        private void buttonСlose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonChangeEndDate_Click(object sender, EventArgs e)
        {
            Visible = false;
            ChangeEndTimeForm changeEndTimeForm = new ChangeEndTimeForm();
            changeEndTimeForm.ShowDialog();
            Visible = true;
        }

        private void buttonChangeMaster_Click(object sender, EventArgs e)
        {
            Visible = false;
            ChangeMasterForm changeMasterForm = new ChangeMasterForm();
            changeMasterForm.ShowDialog();
            Visible = true;
        }
    }
}
