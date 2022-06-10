namespace WinFormsApp1
{
    partial class UserPoupanca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPoupanca));
            this.UserLabel = new System.Windows.Forms.Label();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.CpfLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaldoLabel = new System.Windows.Forms.Label();
            this.SacarButton = new System.Windows.Forms.Button();
            this.DepositarButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ExtratoButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserLabel
            // 
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(12, 114);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(260, 20);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Nome:  abcde";
            // 
            // AccountLabel
            // 
            this.AccountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccountLabel.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccountLabel.ForeColor = System.Drawing.Color.White;
            this.AccountLabel.Location = new System.Drawing.Point(11, 94);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(261, 20);
            this.AccountLabel.TabIndex = 1;
            this.AccountLabel.Text = "Conta:  abcde";
            // 
            // CpfLabel
            // 
            this.CpfLabel.BackColor = System.Drawing.Color.Transparent;
            this.CpfLabel.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CpfLabel.ForeColor = System.Drawing.Color.White;
            this.CpfLabel.Location = new System.Drawing.Point(12, 134);
            this.CpfLabel.Name = "CpfLabel";
            this.CpfLabel.Size = new System.Drawing.Size(175, 20);
            this.CpfLabel.TabIndex = 1;
            this.CpfLabel.Text = "CPF:  abcde";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AccountLabel);
            this.panel1.Controls.Add(this.UserLabel);
            this.panel1.Controls.Add(this.CpfLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 166);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(152, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Conta Poupanca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(13, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saldo";
            // 
            // SaldoLabel
            // 
            this.SaldoLabel.AutoEllipsis = true;
            this.SaldoLabel.AutoSize = true;
            this.SaldoLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaldoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SaldoLabel.Location = new System.Drawing.Point(30, 228);
            this.SaldoLabel.Name = "SaldoLabel";
            this.SaldoLabel.Size = new System.Drawing.Size(71, 46);
            this.SaldoLabel.TabIndex = 3;
            this.SaldoLabel.Text = "R$ ";
            // 
            // SacarButton
            // 
            this.SacarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(196)))), ((int)(((byte)(98)))));
            this.SacarButton.FlatAppearance.BorderSize = 0;
            this.SacarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SacarButton.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SacarButton.ForeColor = System.Drawing.Color.White;
            this.SacarButton.Location = new System.Drawing.Point(12, 296);
            this.SacarButton.Margin = new System.Windows.Forms.Padding(0);
            this.SacarButton.Name = "SacarButton";
            this.SacarButton.Size = new System.Drawing.Size(88, 27);
            this.SacarButton.TabIndex = 6;
            this.SacarButton.Text = "Sacar";
            this.SacarButton.UseVisualStyleBackColor = false;
            this.SacarButton.Click += new System.EventHandler(this.SacarButton_Click);
            // 
            // DepositarButton
            // 
            this.DepositarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(196)))), ((int)(((byte)(98)))));
            this.DepositarButton.FlatAppearance.BorderSize = 0;
            this.DepositarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositarButton.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DepositarButton.ForeColor = System.Drawing.Color.White;
            this.DepositarButton.Location = new System.Drawing.Point(12, 339);
            this.DepositarButton.Margin = new System.Windows.Forms.Padding(0);
            this.DepositarButton.Name = "DepositarButton";
            this.DepositarButton.Size = new System.Drawing.Size(112, 27);
            this.DepositarButton.TabIndex = 6;
            this.DepositarButton.Text = "Depositar";
            this.DepositarButton.UseVisualStyleBackColor = false;
            this.DepositarButton.Click += new System.EventHandler(this.DepositarButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 339);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Digite um valor";
            this.textBox1.Size = new System.Drawing.Size(139, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Digite um valor";
            this.textBox2.Size = new System.Drawing.Size(139, 27);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExtratoButton
            // 
            this.ExtratoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(196)))), ((int)(((byte)(98)))));
            this.ExtratoButton.FlatAppearance.BorderSize = 0;
            this.ExtratoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExtratoButton.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExtratoButton.ForeColor = System.Drawing.Color.White;
            this.ExtratoButton.Location = new System.Drawing.Point(62, 383);
            this.ExtratoButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExtratoButton.Name = "ExtratoButton";
            this.ExtratoButton.Size = new System.Drawing.Size(179, 27);
            this.ExtratoButton.TabIndex = 8;
            this.ExtratoButton.Text = "Extrato";
            this.ExtratoButton.UseVisualStyleBackColor = false;
            this.ExtratoButton.Click += new System.EventHandler(this.ExtratoButton_Click);
            // 
            // UserPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.ExtratoButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DepositarButton);
            this.Controls.Add(this.SacarButton);
            this.Controls.Add(this.SaldoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserPoupanca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poupanca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPoupanca_FormClosing);
            this.Load += new System.EventHandler(this.UserPoupanca_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label UserLabel;
        private Label AccountLabel;
        private Label CpfLabel;
        private Panel panel1;
        private Label label1;
        private Label SaldoLabel;
        private Button SacarButton;
        private Button DepositarButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button ExtratoButton;
        private Label label2;
        private Label label3;
    }
}