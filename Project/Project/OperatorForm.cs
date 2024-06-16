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
    /// Меню оператора
    /// </summary>
    public partial class OperatorForm : Form
    {
        private int _userID;
        public OperatorForm(int userID)
        {
            _userID = userID;
            InitializeComponent();
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            Visible = false;
            AddRequestForm addRequestForm = new AddRequestForm();   
            addRequestForm.ShowDialog();
            Visible = true;
        }

        private void buttonEditRequest_Click(object sender, EventArgs e)
        {
            Visible = false;
            EditRequestForm editRequestForm = new EditRequestForm();
            editRequestForm.ShowDialog();
            Visible = true;
        }
    }
}
