using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using System.Timers;
using System.IO;

namespace ATMProject
{
    public partial class Form1 : Form
    {
        //public Form1 parent = this;
        String connectionString = "DataSource=database.db; Version=3;";
        public SQLiteConnection con;
        public bool loggedIn = false;
        public string oldPIN;
        
        public Form1()
        {
            InitializeComponent();

            //con = new SQLiteConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            con = DatabaseCheck(connectionString);
            con.Open();
        }

       

        public SQLiteConnection DatabaseCheck(String connectionString)
        {
            SQLiteConnection con;
            if (File.Exists("database.db"))
            {
                con = new SQLiteConnection(connectionString);
            
            }

            else
            {
                SQLiteConnection.CreateFile("database.db");
                con = new SQLiteConnection("datasource=database.db; version=3;");
                con.Open();
                string sql = "create table accounts (cardnumber text, name text, pin text, money text)";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
            return con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void NewLineText(string s)
        {
            terminalTextbox.AppendText(s);
            terminalTextbox.AppendText(Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            var cardNumber = textBox_CardNr.Text;
            var pin = textBox_PIN.Text;

            oldPIN = pin;

            var cmd = new SQLiteCommand(con);
            cmd.Parameters.AddWithValue("cardNumber", cardNumber);
            cmd.Parameters.AddWithValue("pin", pin);
            cmd.CommandText = "SELECT MONEY, NAME FROM ACCOUNTS WHERE CARDNUMBER= @cardNumber AND PIN=@pin";
            
            SQLiteDataReader rdr = cmd.ExecuteReader();

           if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    statusLabel.Text = "Status: Connected";
                    string name = rdr.GetString(1);
                    NewLineText("Welcome, " + name + "!");
                    NewLineText("Click on the buttons below for the named function.");
                    loggedIn = true;
                }

            }

           else
            {
                MessageBox.Show("The Card Number or the name are wrong! Please try again!");
            }

           if (loggedIn)
            {
                errorProvider1.Clear();
                terminalTextbox.Enabled = true;
                b_Money.Enabled = true;
                b_Withdraw.Enabled = true;
                b_ChangePIN.Enabled = true;
                b_logOut.Enabled = true;
                textBox_CardNr.Enabled = false;
                textBox_PIN.Enabled = false;
                button3.Enabled = false;
                b_fastWithdraw.Enabled = true;
                b_deposit.Enabled = true;
                button4.Enabled = true;
            }

           

            

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            var pin = textBox_PIN.Text;
            int result;
            bool isNumeric = int.TryParse(pin, out result);
            if (pin == "" || !isNumeric || pin.Length !=4)
            {
                errorProvider1.SetError(textBox_PIN, "Pin can't be empty, not numberic or more than 4 digits!");
                button3.Enabled = false;
            }

            else if (loggedIn)
            {
                errorProvider1.Clear();
                button3.Enabled = true;
            }

            else
            {
                errorProvider1.Clear();
                button3.Enabled = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button3_Click(sender, e);
            }
        }

        private string Command(string s, int column)
        {
            var cardNumber = textBox_CardNr.Text;
            var pin = textBox_PIN.Text;
            var cmd = new SQLiteCommand(con);
            cmd.Parameters.AddWithValue("cardNumber", cardNumber);
            cmd.Parameters.AddWithValue("pin", pin);
            cmd.CommandText = s;
            SQLiteDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    string money = rdr.GetString(column);

                    return money;
                }

                return "Nothing";

            }

            else
            {
                return "Nothing";
            }

        }

        private void b_Money_Click(object sender, EventArgs e)
        {
            var com = Command("SELECT MONEY, NAME FROM ACCOUNTS WHERE CARDNUMBER= @cardNumber AND PIN=@pin", 0);

            if ( com == "Nothing")
            {
                NewLineText("Something went wrong, please try again!");
            }

            else
            {
                NewLineText("Account balance: " + com + "$");
            }
            


        }

        private void b_Withdraw_Click(object sender, EventArgs e)
        {
            FormMoneyAmount formMoneyAmount = new FormMoneyAmount();
            formMoneyAmount.parent = this;
            formMoneyAmount.ShowDialog();
            if (formMoneyAmount.DialogResult != DialogResult.OK)
            {
            }

            else
            {

                var mn = formMoneyAmount.money;
                var cardNumber = textBox_CardNr.Text;
                var cmd = new SQLiteCommand(con);
                var com = Command("SELECT MONEY, NAME FROM ACCOUNTS WHERE CARDNUMBER= @cardNumber AND PIN=@pin", 0);
                if (mn == "")
                {
                    MessageBox.Show("The amount can't be empty!", "Error");
                }
                else
                {


                    if (int.Parse(com) < int.Parse(mn))
                    {
                        NewLineText("You don't have that amount of money, your balance is: " + com + "$");
                    }
                    else
                    {
                        var s = int.Parse(com) - int.Parse(mn);
                        cmd.Parameters.AddWithValue("cardNumber", cardNumber);
                        cmd.Parameters.AddWithValue("money", s);
                        cmd.CommandText = "UPDATE ACCOUNTS SET MONEY=@money WHERE CARDNUMBER = @cardNumber";
                        cmd.ExecuteNonQuery();

                        NewLineText("New balance: " + s + "$");
                    }
                }
            }
        }

        private void b_ChangePIN_Click(object sender, EventArgs e)
        {
            ChangePINForm form = new ChangePINForm();
            form.parent = this;
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                var newPN = form.newPIN;
                var cmd = new SQLiteCommand(con);
                var cardNumber = textBox_CardNr.Text;
                cmd.Parameters.AddWithValue("cardNumber", cardNumber);
                cmd.Parameters.AddWithValue("newPN", newPN);
                cmd.CommandText="UPDATE ACCOUNTS SET PIN = @newPN WHERE CARDNUMBER= @cardNumber";
                cmd.ExecuteNonQuery();
                NewLineText("The PIN has been changed successfully!");
            }

        }

        private void b_logOut_Click(object sender, EventArgs e)
        {
            loggedIn = false;
            statusLabel.Text = "Status: Waiting for login...";
            terminalTextbox.Enabled = false;
            b_Money.Enabled = false;
            b_Withdraw.Enabled = false;
            b_ChangePIN.Enabled = false;
            textBox_CardNr.Clear();
            textBox_PIN.Clear();
            textBox_CardNr.Enabled = true;
            textBox_PIN.Enabled = true;
            button3.Enabled = true;
            b_logOut.Enabled = false;
            b_fastWithdraw.Enabled = false;
            b_deposit.Enabled = false;
            errorProvider1.Clear();
            terminalTextbox.Clear();
        }

        private void b_fastWithdraw_Click(object sender, EventArgs e)
        {
            var mn = "50";
            var cardNumber = textBox_CardNr.Text;
            var cmd = new SQLiteCommand(con);
            var com = Command("SELECT MONEY, NAME FROM ACCOUNTS WHERE CARDNUMBER= @cardNumber AND PIN=@pin", 0);
            if (mn == "")
            {
                MessageBox.Show("The amount can't be empty!", "Error");
            }
            else
            {


                if (int.Parse(com) < int.Parse(mn))
                {
                    NewLineText("You don't have that amount of money, your balance is: " + com + "$");
                }
                else
                {
                    var s = int.Parse(com) - int.Parse(mn);
                    cmd.Parameters.AddWithValue("cardNumber", cardNumber);
                    cmd.Parameters.AddWithValue("money", s);
                    cmd.CommandText = "UPDATE ACCOUNTS SET MONEY=@money WHERE CARDNUMBER = @cardNumber";
                    cmd.ExecuteNonQuery();

                    NewLineText("New balance after fast withdraw: " + s + "$");
                }
            }
        }

        private void terminalTextbox_DoubleClick(object sender, EventArgs e)
        {
            terminalTextbox.Clear();
        }

        private void b_deposit_Click(object sender, EventArgs e)
        {
            FormMoneyAmount formMoneyAmount = new FormMoneyAmount();
            formMoneyAmount.parent = this;
            formMoneyAmount.ShowDialog();
            if (formMoneyAmount.DialogResult != DialogResult.OK)
            {

            }

            else
            {

                var mn = formMoneyAmount.money;
                var cardNumber = textBox_CardNr.Text;
                var cmd = new SQLiteCommand(con);
                var com = Command("SELECT MONEY, NAME FROM ACCOUNTS WHERE CARDNUMBER= @cardNumber AND PIN=@pin", 0);
                if (mn == "")
                {
                    MessageBox.Show("The amount can't be empty!", "Error");
                }
                else
                {

                    var s = int.Parse(com) + int.Parse(mn);
                    cmd.Parameters.AddWithValue("cardNumber", cardNumber);
                    cmd.Parameters.AddWithValue("money", s);
                    cmd.CommandText = "UPDATE ACCOUNTS SET MONEY=@money WHERE CARDNUMBER = @cardNumber";
                    cmd.ExecuteNonQuery();

                    NewLineText("New balance after deposit: " + s + "$");
                }
            }
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            
            terminalTextbox.Enabled = false;
            b_Money.Enabled = false;
            b_Withdraw.Enabled = false;
            b_ChangePIN.Enabled = false;
            textBox_CardNr.Clear();
            textBox_PIN.Clear();
            textBox_CardNr.Enabled = false;
            textBox_PIN.Enabled = false;
            b_logOut.Enabled = false;
            b_fastWithdraw.Enabled = false;
            b_deposit.Enabled = false;
            errorProvider1.Clear();
            terminalTextbox.Clear();

            timer1.Enabled = true;

            statusLabel.Text = "Status: Closing the app...";

            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_addAccount_Click(object sender, EventArgs e)
        {
            AddAccountForm form = new AddAccountForm();
            form.parent = this;
            form.ShowDialog();
            if (form.DialogResult != DialogResult.OK)
            {

            }

            else
            {
                var cmd = new SQLiteCommand(con);
                
                   cmd.Parameters.AddWithValue("cardNumber", form.CardNumber);
                    cmd.Parameters.AddWithValue("name", form.Name);
                    cmd.Parameters.AddWithValue("pin", form.PIN);
                    cmd.Parameters.AddWithValue("money", form.Money);
                    cmd.CommandText = "INSERT INTO accounts (cardnumber, name, pin, money) values (@cardNumber, @name, @pin, @money)";
                    cmd.ExecuteNonQuery();
                
            }
        }
    }
}
