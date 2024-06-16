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
    /// Форма матсера
    /// </summary>
    public partial class MasterForm : Form
    {
        private int _userID;
        public MasterForm(int userID)
        {
            _userID = userID;
            InitializeComponent();
        }
    }
}
