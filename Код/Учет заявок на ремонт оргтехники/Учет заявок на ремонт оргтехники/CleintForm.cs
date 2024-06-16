using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Учет_заявок_на_ремонт_оргтехники
{
    public partial class CleintForm : Form
    {
        MainMenu mainMenu = new MainMenu();

        public CleintForm()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Now;
            string startDateString = startDate.ToString();
            string problemDescription = textBox2.Text;
            int repairParts = int.Parse(textBox1.Text);

            mainMenu.AddRequest(startDateString, problemDescription, repairParts);
            MessageBox.Show("Request added successfully!");
            this.Close();
        }

        private void CleintForm_Leave(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visible = false;

            mainMenu.ShowDialog();

            Visible = true;
        }

        private void CleintForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "de_example_1DataSet.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.de_example_1DataSet.Requests);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();
            var QRdata = QRgen.CreateQrCode(textBox3.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var QRcode = new QRCoder.QRCode(QRdata);

            pictureBox1.Image = QRcode.GetGraphic(100);
        }
    }
}
