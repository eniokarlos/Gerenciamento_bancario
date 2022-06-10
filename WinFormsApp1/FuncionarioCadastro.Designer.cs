namespace WinFormsApp1
{
    partial class FuncionarioCadastro
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
            this.button1 = new System.Windows.Forms.Button();
            this.AgenciaBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SecretarioButton = new System.Windows.Forms.RadioButton();
            this.CaixaButton = new System.Windows.Forms.RadioButton();
            this.GerenteButton = new System.Windows.Forms.RadioButton();
            this.CpfBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(66, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgenciaBox
            // 
            this.AgenciaBox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgenciaBox.Location = new System.Drawing.Point(42, 141);
            this.AgenciaBox.Name = "AgenciaBox";
            this.AgenciaBox.PlaceholderText = "Agencia";
            this.AgenciaBox.Size = new System.Drawing.Size(219, 32);
            this.AgenciaBox.TabIndex = 8;
            this.AgenciaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.Location = new System.Drawing.Point(42, 95);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.PlaceholderText = "Senha";
            this.PasswordBox.Size = new System.Drawing.Size(219, 32);
            this.PasswordBox.TabIndex = 10;
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.Location = new System.Drawing.Point(42, 49);
            this.NameBox.Name = "NameBox";
            this.NameBox.PlaceholderText = "Nome";
            this.NameBox.Size = new System.Drawing.Size(219, 32);
            this.NameBox.TabIndex = 11;
            this.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SecretarioButton
            // 
            this.SecretarioButton.AutoSize = true;
            this.SecretarioButton.Location = new System.Drawing.Point(110, 318);
            this.SecretarioButton.Name = "SecretarioButton";
            this.SecretarioButton.Size = new System.Drawing.Size(95, 24);
            this.SecretarioButton.TabIndex = 13;
            this.SecretarioButton.TabStop = true;
            this.SecretarioButton.Text = "secretario";
            this.SecretarioButton.UseVisualStyleBackColor = true;
            this.SecretarioButton.CheckedChanged += new System.EventHandler(this.SecretarioButton_CheckedChanged);
            // 
            // CaixaButton
            // 
            this.CaixaButton.AutoSize = true;
            this.CaixaButton.Location = new System.Drawing.Point(110, 278);
            this.CaixaButton.Name = "CaixaButton";
            this.CaixaButton.Size = new System.Drawing.Size(64, 24);
            this.CaixaButton.TabIndex = 13;
            this.CaixaButton.TabStop = true;
            this.CaixaButton.Text = "caixa";
            this.CaixaButton.UseVisualStyleBackColor = true;
            this.CaixaButton.CheckedChanged += new System.EventHandler(this.CaixaButton_CheckedChanged);
            // 
            // GerenteButton
            // 
            this.GerenteButton.AutoSize = true;
            this.GerenteButton.Location = new System.Drawing.Point(110, 238);
            this.GerenteButton.Name = "GerenteButton";
            this.GerenteButton.Size = new System.Drawing.Size(81, 24);
            this.GerenteButton.TabIndex = 13;
            this.GerenteButton.TabStop = true;
            this.GerenteButton.Text = "gerente";
            this.GerenteButton.UseVisualStyleBackColor = true;
            this.GerenteButton.CheckedChanged += new System.EventHandler(this.GerenteButton_CheckedChanged);
            // 
            // CpfBox
            // 
            this.CpfBox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CpfBox.Location = new System.Drawing.Point(42, 186);
            this.CpfBox.Name = "CpfBox";
            this.CpfBox.PlaceholderText = "Cpf";
            this.CpfBox.Size = new System.Drawing.Size(219, 32);
            this.CpfBox.TabIndex = 8;
            this.CpfBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FuncionarioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 453);
            this.Controls.Add(this.SecretarioButton);
            this.Controls.Add(this.CaixaButton);
            this.Controls.Add(this.GerenteButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CpfBox);
            this.Controls.Add(this.AgenciaBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.NameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FuncionarioCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncionarioCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox AgenciaBox;
        private TextBox PasswordBox;
        private TextBox NameBox;
        private RadioButton SecretarioButton;
        private RadioButton CaixaButton;
        private RadioButton GerenteButton;
        private TextBox CpfBox;
    }
}