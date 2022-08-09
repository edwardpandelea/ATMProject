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
    public partial class FormMoneyAmount : Form
    {
        public string money;
        public bool isClosed = false;
        public Form1 parent;
        public FormMoneyAmount()
        {
            InitializeComponent();
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            
           
            money = textBox_MoneyAmount.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void textBox_MoneyAmount_TextChanged(object sender, EventArgs e)
        {
            int result;
            var mn = textBox_MoneyAmount.Text;
            bool isNumeric = int.TryParse(mn, out result);
            if (!isNumeric)
            {
                errorProvider1.SetError(textBox_MoneyAmount, "The amount must be numeric!");
                b_ok.Enabled = false;
            }

            else 
            {
                errorProvider1.Clear();
                b_ok.Enabled = true;
            }

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormMoneyAmount_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
