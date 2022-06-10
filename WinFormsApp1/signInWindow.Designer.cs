namespace WinFormsApp1
{
    partial class signInWindow
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
            this.Accountbox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Corrente = new System.Windows.Forms.RadioButton();
            this.poupanca = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // Accountbox
            // 
            this.Accountbox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Accountbox.Location = new System.Drawing.Point(50, 144);
            this.Accountbox.Name = "Accountbox";
            this.Accountbox.PlaceholderText = "Account";
            this.Accountbox.Size = new System.Drawing.Size(202, 32);
            this.Accountbox.TabIndex = 1;
            this.Accountbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PassBox
            // 
            this.PassBox.Font = new System.Drawing.Font("Inter Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassBox.Location = new System.Drawing.Point(50, 189);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.PlaceholderText = "Password";
            this.PassBox.Size = new System.Drawing.Size(202, 32);
            this.PassBox.TabIndex = 1;
            this.PassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(196)))), ((int)(((byte)(98)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(66, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Corrente
            // 
            this.Corrente.AutoSize = true;
            this.Corrente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Corrente.ForeColor = System.Drawing.Color.White;
            this.Corrente.Location = new System.Drawing.Point(50, 227);
            this.Corrente.Name = "Corrente";
            this.Corrente.Size = new System.Drawing.Size(91, 24);
            this.Corrente.TabIndex = 6;
            this.Corrente.TabStop = true;
            this.Corrente.Text = "Corrente";
            this.Corrente.UseVisualStyleBackColor = true;
            this.Corrente.CheckedChanged += new System.EventHandler(this.Corrente_CheckedChanged);
            // 
            // poupanca
            // 
            this.poupanca.AutoSize = true;
            this.poupanca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.poupanca.ForeColor = System.Drawing.Color.White;
            this.poupanca.Location = new System.Drawing.Point(154, 227);
            this.poupanca.Name = "poupanca";
            this.poupanca.Size = new System.Drawing.Size(98, 24);
            this.poupanca.TabIndex = 6;
            this.poupanca.TabStop = true;
            this.poupanca.Text = "Poupança";
            this.poupanca.UseVisualStyleBackColor = true;
            this.poupanca.CheckedChanged += new System.EventHandler(this.poupanca_CheckedChanged);
            // 
            // signInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.poupanca);
            this.Controls.Add(this.Corrente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.Accountbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "signInWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "signIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox PassBox;
        private Button button1;
        public TextBox Accountbox;
        private RadioButton Corrente;
        private RadioButton poupanca;
    }
}