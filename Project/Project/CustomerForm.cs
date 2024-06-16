using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Project
{
    /// <summary>
    /// Форма пользователя
    /// </summary>
    public partial class CustomerForm : Form
    {
        private int _userID;
        SqlClass database = new SqlClass();
        public CustomerForm(int userID)
        {
            _userID = userID;
            InitializeComponent();

            pictureBoxQRCode.Image = GetQR();
        }

        /// <summary>
        /// Функция создания QR кода
        /// </summary>
        /// <returns></returns>
        private Image GetQR()
        {
            using (var qrGenerator = new QRCodeGenerator())
            {
                var qrData = qrGenerator.CreateQrCode("https://docs.google.com/forms/d/e/1FAIpQLSdhZcExx6LSIXxk0ub55mSu-WIh23WYdGG9HY5EZhLDo7P8eA/viewform?usp=sf_link", QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrData))
                {
                    return qrCode.GetGraphic(20);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
