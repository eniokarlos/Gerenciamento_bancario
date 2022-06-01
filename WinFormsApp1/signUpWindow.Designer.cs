namespace WinFormsApp1
{
    partial class signUpWindow
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Accountbox = new System.Windows.Forms.TextBox();
            this.CpfBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Corrente = new System.Windows.Forms.RadioButton();
            this.Poupanca = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.Location = new System.Drawing.Point(42, 164);
            this.NameBox.Name = "NameBox";
            this.NameBox.PlaceholderText = "Enter Your Name";
            this.NameBox.Size = new System.Drawing.Size(219, 32);
            this.NameBox.TabIndex = 0;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.Location = new System.Drawing.Point(42, 105);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PlaceholderText = "Password";
            this.PasswordBox.Size = new System.Drawing.Size(219, 32);
            this.PasswordBox.TabIndex = 0;
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Accountbox
            // 
            this.Accountbox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Accountbox.Location = new System.Drawing.Point(42, 46);
            this.Accountbox.Name = "Accountbox";
            this.Accountbox.PlaceholderText = "Account";
            this.Accountbox.Size = new System.Drawing.Size(219, 32);
            this.Accountbox.TabIndex = 0;
            this.Accountbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CpfBox
            // 
            this.CpfBox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CpfBox.Location = new System.Drawing.Point(42, 223);
            this.CpfBox.Name = "CpfBox";
            this.CpfBox.PlaceholderText = "Cpf";
            this.CpfBox.Size = new System.Drawing.Size(219, 32);
            this.CpfBox.TabIndex = 0;
            this.CpfBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(66, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Corrente
            // 
            this.Corrente.AutoSize = true;
            this.Corrente.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Corrente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Corrente.Location = new System.Drawing.Point(32, 284);
            this.Corrente.Name = "Corrente";
            this.Corrente.Size = new System.Drawing.Size(103, 24);
            this.Corrente.TabIndex = 6;
            this.Corrente.TabStop = true;
            this.Corrente.Text = "Corrente";
            this.Corrente.UseVisualStyleBackColor = true;
            this.Corrente.CheckedChanged += new System.EventHandler(this.Corrente_CheckedChanged);
            // 
            // Poupanca
            // 
            this.Poupanca.AutoSize = true;
            this.Poupanca.Font = new System.Drawing.Font("Inter SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Poupanca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Poupanca.Location = new System.Drawing.Point(164, 284);
            this.Poupanca.Name = "Poupanca";
            this.Poupanca.Size = new System.Drawing.Size(112, 24);
            this.Poupanca.TabIndex = 6;
            this.Poupanca.TabStop = true;
            this.Poupanca.Text = "Poupança";
            this.Poupanca.UseVisualStyleBackColor = true;
            this.Poupanca.CheckedChanged += new System.EventHandler(this.Poupanca_CheckedChanged);
            // 
            // signUpWindow
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(196)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.Poupanca);
            this.Controls.Add(this.Corrente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CpfBox);
            this.Controls.Add(this.Accountbox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.NameBox);
            this.Name = "signUpWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameBox;
        private TextBox PasswordBox;
        private TextBox Accountbox;
        private TextBox CpfBox;
        private Button button1;
        private RadioButton Corrente;
        private RadioButton Poupanca;
    }
}