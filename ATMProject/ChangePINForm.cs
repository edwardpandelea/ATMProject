using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ATMProject
{
    public partial class ChangePINForm : Form
    {

        public string newPIN;
        public Form1 parent;
        public ChangePINForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ChangePINForm_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var pin = textBox1_NewPIN.Text;
            int result;
            bool isNumeric = int.TryParse(pin, out result);
            if (!isNumeric || pin == "" || pin.Length != 4)
            {
                errorProvider1.SetError(textBox1_NewPIN, "The PIN must be 4 digits long and numeric!");
            }

            else
            {
                newPIN = textBox1_NewPIN.Text;

                errorProvider1.Clear();
                
            }
        }

        private void textBox_OldPIN_TextChanged(object sender, EventArgs e)
        {
            var oldPN = textBox_OldPIN.Text;
            if (oldPN != parent.oldPIN)
            {
                errorProvider1.SetError(textBox_OldPIN, "The old PIN is incorrect!");
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void textBox3_RePIN_TextChanged(object sender, EventArgs e)
        {
            string newReenterPIN = textBox3_RePIN.Text;
            newPIN = textBox1_NewPIN.Text;

            if (newPIN != newReenterPIN)
            {
                errorProvider1.SetError(textBox1_NewPIN, "The PIN doesn't match!");
                button3.Enabled = false;
            }

            else
            {
                button3.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void ChangePINForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
