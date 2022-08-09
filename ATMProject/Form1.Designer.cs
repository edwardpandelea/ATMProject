
namespace ATMProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.b_fastWithdraw = new System.Windows.Forms.Button();
            this.b_deposit = new System.Windows.Forms.Button();
            this.b_logOut = new System.Windows.Forms.Button();
            this.b_ChangePIN = new System.Windows.Forms.Button();
            this.b_Withdraw = new System.Windows.Forms.Button();
            this.b_Money = new System.Windows.Forms.Button();
            this.terminalTextbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_PIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_CardNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b_addAccount = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.b_addAccount);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.b_fastWithdraw);
            this.panel1.Controls.Add(this.b_deposit);
            this.panel1.Controls.Add(this.b_logOut);
            this.panel1.Controls.Add(this.b_ChangePIN);
            this.panel1.Controls.Add(this.b_Withdraw);
            this.panel1.Controls.Add(this.b_Money);
            this.panel1.Controls.Add(this.terminalTextbox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_PIN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_CardNr);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 398);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(671, 372);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Log Out and Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // b_fastWithdraw
            // 
            this.b_fastWithdraw.Enabled = false;
            this.b_fastWithdraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.b_fastWithdraw.FlatAppearance.BorderSize = 0;
            this.b_fastWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.b_fastWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_fastWithdraw.Location = new System.Drawing.Point(531, 260);
            this.b_fastWithdraw.Margin = new System.Windows.Forms.Padding(0);
            this.b_fastWithdraw.Name = "b_fastWithdraw";
            this.b_fastWithdraw.Size = new System.Drawing.Size(86, 23);
            this.b_fastWithdraw.TabIndex = 12;
            this.b_fastWithdraw.Text = "Fast Withdraw";
            this.b_fastWithdraw.UseVisualStyleBackColor = true;
            this.b_fastWithdraw.Click += new System.EventHandler(this.b_fastWithdraw_Click);
            // 
            // b_deposit
            // 
            this.b_deposit.Enabled = false;
            this.b_deposit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.b_deposit.FlatAppearance.BorderSize = 0;
            this.b_deposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.b_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_deposit.Location = new System.Drawing.Point(537, 286);
            this.b_deposit.Margin = new System.Windows.Forms.Padding(0);
            this.b_deposit.Name = "b_deposit";
            this.b_deposit.Size = new System.Drawing.Size(75, 23);
            this.b_deposit.TabIndex = 11;
            this.b_deposit.Text = "Deposit";
            this.b_deposit.UseVisualStyleBackColor = true;
            this.b_deposit.Click += new System.EventHandler(this.b_deposit_Click);
            // 
            // b_logOut
            // 
            this.b_logOut.Enabled = false;
            this.b_logOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.b_logOut.FlatAppearance.BorderSize = 0;
            this.b_logOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.b_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_logOut.Location = new System.Drawing.Point(537, 338);
            this.b_logOut.Margin = new System.Windows.Forms.Padding(0);
            this.b_logOut.Name = "b_logOut";
            this.b_logOut.Size = new System.Drawing.Size(75, 23);
            this.b_logOut.TabIndex = 10;
            this.b_logOut.Text = "Log Out";
            this.b_logOut.UseVisualStyleBackColor = true;
            this.b_logOut.Click += new System.EventHandler(this.b_logOut_Click);
            // 
            // b_ChangePIN
            // 
            this.b_ChangePIN.Enabled = false;
            this.b_ChangePIN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.b_ChangePIN.FlatAppearance.BorderSize = 0;
            this.b_ChangePIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.b_ChangePIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_ChangePIN.Location = new System.Drawing.Point(537, 312);
            this.b_ChangePIN.Margin = new System.Windows.Forms.Padding(0);
            this.b_ChangePIN.Name = "b_ChangePIN";
            this.b_ChangePIN.Size = new System.Drawing.Size(75, 23);
            this.b_ChangePIN.TabIndex = 9;
            this.b_ChangePIN.Text = "Change PIN";
            this.b_ChangePIN.UseVisualStyleBackColor = true;
            this.b_ChangePIN.Click += new System.EventHandler(this.b_ChangePIN_Click);
            // 
            // b_Withdraw
            // 
            this.b_Withdraw.Enabled = false;
            this.b_Withdraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.b_Withdraw.FlatAppearance.BorderSize = 0;
            this.b_Withdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.b_Withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Withdraw.Location = new System.Drawing.Point(537, 234);
            this.b_Withdraw.Margin = new System.Windows.Forms.Padding(0);
            this.b_Withdraw.Name = "b_Withdraw";
            this.b_Withdraw.Size = new System.Drawing.Size(75, 23);
            this.b_Withdraw.TabIndex = 8;
            this.b_Withdraw.Text = "Withdraw";
            this.b_Withdraw.UseVisualStyleBackColor = true;
            this.b_Withdraw.Click += new System.EventHandler(this.b_Withdraw_Click);
            // 
            // b_Money
            // 
            this.b_Money.Enabled = false;
            this.b_Money.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.b_Money.FlatAppearance.BorderSize = 0;
            this.b_Money.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.b_Money.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Money.Location = new System.Drawing.Point(506, 208);
            this.b_Money.Margin = new System.Windows.Forms.Padding(0);
            this.b_Money.Name = "b_Money";
            this.b_Money.Size = new System.Drawing.Size(136, 23);
            this.b_Money.TabIndex = 7;
            this.b_Money.TabStop = false;
            this.b_Money.Text = "Account Balance";
            this.b_Money.UseVisualStyleBackColor = true;
            this.b_Money.Click += new System.EventHandler(this.b_Money_Click);
            // 
            // terminalTextbox
            // 
            this.terminalTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.terminalTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.terminalTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.terminalTextbox.Enabled = false;
            this.terminalTextbox.ForeColor = System.Drawing.Color.White;
            this.terminalTextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.terminalTextbox.Location = new System.Drawing.Point(392, 14);
            this.terminalTextbox.Multiline = true;
            this.terminalTextbox.Name = "terminalTextbox";
            this.terminalTextbox.ReadOnly = true;
            this.terminalTextbox.Size = new System.Drawing.Size(365, 191);
            this.terminalTextbox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.terminalTextbox, "Double click to clear the terminal");
            this.terminalTextbox.DoubleClick += new System.EventHandler(this.terminalTextbox_DoubleClick);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(66, 271);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PIN";
            // 
            // textBox_PIN
            // 
            this.textBox_PIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_PIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PIN.ForeColor = System.Drawing.Color.White;
            this.textBox_PIN.Location = new System.Drawing.Point(21, 185);
            this.textBox_PIN.Name = "textBox_PIN";
            this.textBox_PIN.PasswordChar = '*';
            this.textBox_PIN.Size = new System.Drawing.Size(164, 20);
            this.textBox_PIN.TabIndex = 3;
            this.textBox_PIN.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Card Number";
            // 
            // textBox_CardNr
            // 
            this.textBox_CardNr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox_CardNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_CardNr.ForeColor = System.Drawing.Color.White;
            this.textBox_CardNr.Location = new System.Drawing.Point(21, 109);
            this.textBox_CardNr.Name = "textBox_CardNr";
            this.textBox_CardNr.Size = new System.Drawing.Size(164, 20);
            this.textBox_CardNr.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Insert your credentials to login in your account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(9, 432);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(128, 13);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Status: Waiting for login...";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ATMProject.Properties.Resources._;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(746, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ATMProject.Properties.Resources.MergeX;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(775, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATMProject.Properties.Resources.ATMiconWhite;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // b_addAccount
            // 
            this.b_addAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.b_addAccount.FlatAppearance.BorderSize = 0;
            this.b_addAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.b_addAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_addAccount.Location = new System.Drawing.Point(1, 372);
            this.b_addAccount.Margin = new System.Windows.Forms.Padding(0);
            this.b_addAccount.Name = "b_addAccount";
            this.b_addAccount.Size = new System.Drawing.Size(93, 23);
            this.b_addAccount.TabIndex = 14;
            this.b_addAccount.Text = "Add Account";
            this.b_addAccount.UseVisualStyleBackColor = true;
            this.b_addAccount.Click += new System.EventHandler(this.b_addAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_PIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_CardNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox terminalTextbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button b_Money;
        private System.Windows.Forms.Button b_Withdraw;
        private System.Windows.Forms.Button b_ChangePIN;
        private System.Windows.Forms.Button b_logOut;
        private System.Windows.Forms.Button b_fastWithdraw;
        private System.Windows.Forms.Button b_deposit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button b_addAccount;
    }
}

