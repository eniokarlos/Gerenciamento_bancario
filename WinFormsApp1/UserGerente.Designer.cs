namespace WinFormsApp1
{
    partial class UserGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGerente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PoupancaButton = new System.Windows.Forms.RadioButton();
            this.CorrenteButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.AgenciaLabel = new System.Windows.Forms.Label();
            this.NomeLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Visualizarbutton = new System.Windows.Forms.Button();
            this.cadastrarButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.PoupancaButton);
            this.panel1.Controls.Add(this.CorrenteButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AgenciaLabel);
            this.panel1.Controls.Add(this.NomeLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Visualizarbutton);
            this.panel1.Controls.Add(this.cadastrarButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 500);
            this.panel1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 385);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Valor";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Conta";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 21;
            // 
            // PoupancaButton
            // 
            this.PoupancaButton.AutoSize = true;
            this.PoupancaButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PoupancaButton.ForeColor = System.Drawing.Color.White;
            this.PoupancaButton.Location = new System.Drawing.Point(182, 418);
            this.PoupancaButton.Name = "PoupancaButton";
            this.PoupancaButton.Size = new System.Drawing.Size(107, 27);
            this.PoupancaButton.TabIndex = 20;
            this.PoupancaButton.TabStop = true;
            this.PoupancaButton.Text = "Poupança";
            this.PoupancaButton.UseVisualStyleBackColor = true;
            this.PoupancaButton.CheckedChanged += new System.EventHandler(this.PoupancaButton_CheckedChanged);
            // 
            // CorrenteButton
            // 
            this.CorrenteButton.AutoSize = true;
            this.CorrenteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CorrenteButton.ForeColor = System.Drawing.Color.White;
            this.CorrenteButton.Location = new System.Drawing.Point(17, 415);
            this.CorrenteButton.Name = "CorrenteButton";
            this.CorrenteButton.Size = new System.Drawing.Size(101, 27);
            this.CorrenteButton.TabIndex = 20;
            this.CorrenteButton.TabStop = true;
            this.CorrenteButton.Text = "Corrente";
            this.CorrenteButton.UseVisualStyleBackColor = true;
            this.CorrenteButton.CheckedChanged += new System.EventHandler(this.CorrenteButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 35);
            this.label2.TabIndex = 19;
            this.label2.Text = "Gerente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgenciaLabel
            // 
            this.AgenciaLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgenciaLabel.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AgenciaLabel.ForeColor = System.Drawing.Color.White;
            this.AgenciaLabel.Location = new System.Drawing.Point(8, 211);
            this.AgenciaLabel.Name = "AgenciaLabel";
            this.AgenciaLabel.Size = new System.Drawing.Size(287, 20);
            this.AgenciaLabel.TabIndex = 19;
            this.AgenciaLabel.Text = "Agencia: ";
            this.AgenciaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NomeLabel
            // 
            this.NomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NomeLabel.Font = new System.Drawing.Font("Inter SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NomeLabel.ForeColor = System.Drawing.Color.White;
            this.NomeLabel.Location = new System.Drawing.Point(8, 190);
            this.NomeLabel.Name = "NomeLabel";
            this.NomeLabel.Size = new System.Drawing.Size(287, 20);
            this.NomeLabel.TabIndex = 19;
            this.NomeLabel.Text = "Nome:";
            this.NomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(15, 355);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 57);
            this.button2.TabIndex = 18;
            this.button2.Text = "Conceder Emprestimo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Visualizarbutton
            // 
            this.Visualizarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.Visualizarbutton.FlatAppearance.BorderSize = 0;
            this.Visualizarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Visualizarbutton.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Visualizarbutton.ForeColor = System.Drawing.Color.White;
            this.Visualizarbutton.Location = new System.Drawing.Point(14, 301);
            this.Visualizarbutton.Margin = new System.Windows.Forms.Padding(0);
            this.Visualizarbutton.Name = "Visualizarbutton";
            this.Visualizarbutton.Size = new System.Drawing.Size(275, 44);
            this.Visualizarbutton.TabIndex = 18;
            this.Visualizarbutton.Text = "Visualizar Clientes";
            this.Visualizarbutton.UseVisualStyleBackColor = false;
            this.Visualizarbutton.Click += new System.EventHandler(this.Visualizarbutton_Click);
            // 
            // cadastrarButton
            // 
            this.cadastrarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.cadastrarButton.FlatAppearance.BorderSize = 0;
            this.cadastrarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarButton.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cadastrarButton.ForeColor = System.Drawing.Color.White;
            this.cadastrarButton.Location = new System.Drawing.Point(14, 244);
            this.cadastrarButton.Margin = new System.Windows.Forms.Padding(0);
            this.cadastrarButton.Name = "cadastrarButton";
            this.cadastrarButton.Size = new System.Drawing.Size(275, 44);
            this.cadastrarButton.TabIndex = 18;
            this.cadastrarButton.Text = "Cadastrar Cliente";
            this.cadastrarButton.UseVisualStyleBackColor = false;
            this.cadastrarButton.Click += new System.EventHandler(this.cadastrarButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(76, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 150);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Inter SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 44);
            this.button1.TabIndex = 18;
            this.button1.Text = "MInha Conta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UserGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserGerente";
            this.Load += new System.EventHandler(this.UserGerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label AgenciaLabel;
        private Label NomeLabel;
        private Button button2;
        private Button Visualizarbutton;
        private Button cadastrarButton;
        private Panel panel2;
        private RadioButton PoupancaButton;
        private RadioButton CorrenteButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}