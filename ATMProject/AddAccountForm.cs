using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMProject
{
    public partial class AddAccountForm : Form
    {
        public Form1 parent;
        public string CardNumber;
        public string Name;
        public string Money;
        public string PIN;
        public AddAccountForm()
        {
            InitializeComponent();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            bool error = false;
            var cardNumber = textBox_CardNumber.Text;
            long result;
            bool isNumeric = long.TryParse(cardNumber, out result);
            if (!isNumeric || cardNumber == "" || cardNumber.Length != 16)
            {
                errorProvider1.SetError(textBox_CardNumber, "The Card Number must be 16 digits long and numberic!");
                error = true;
            }

            var firstName = textBox_FirstName.Text;
            if (firstName.Length < 3)
            {
                errorProvider2.SetError(textBox_FirstName, "The Fist Name should be at least 3 charaters long!");

            }

            
            var lastName = textBox_LastName.Text;
            if (lastName.Length < 3)
            {
                errorProvider3.SetError(textBox_LastName, "The Fist Name should be at least 3 charaters long!");

            }


            var money = textBox_MoneyAmount.Text;
            int result2;
            bool isNumeric2 = int.TryParse(money, out result2);
            if (!isNumeric2 || money == "" || money.Length == 0)
            {
                errorProvider4.SetError(textBox_MoneyAmount, "The money amount should be at least 1!");

            }

         
            var pin = textBox_PIN.Text;
            int result3;
            bool isNumeric3 = int.TryParse(pin, out result3);
            if (!isNumeric || pin == "" || pin.Length != 4)
            {
                errorProvider5.SetError(textBox_PIN, "The PIN must be 4 digits long and numeric!");
            }

            if (!error)
            {
                Name = textBox_FirstName.Text + " " + textBox_LastName.Text;
                CardNumber = textBox_CardNumber.Text;
                PIN = textBox_PIN.Text;
                Money = textBox_MoneyAmount.Text;

                DialogResult = DialogResult.OK;
            }

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AddAccountForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

      
       

      
    }
}
