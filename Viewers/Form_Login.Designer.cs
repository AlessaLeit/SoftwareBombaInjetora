namespace BombaInjetora
{
    partial class Form_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNomeOperador = new TextBox();
            txtSenha = new TextBox();
            lbnSenha = new Label();
            chkSenha = new CheckBox();
            btnLogin = new Button();
            btnCadastrar = new Button();
            lbnNomesSalvos = new Label();
            panel1 = new Panel();
            btnX = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            panelOperadoresRecentes = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtNomeOperador
            // 
            txtNomeOperador.CausesValidation = false;
            txtNomeOperador.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeOperador.Location = new Point(71, 242);
            txtNomeOperador.Name = "txtNomeOperador";
            txtNomeOperador.Size = new Size(401, 43);
            txtNomeOperador.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(71, 328);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(401, 43);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lbnSenha
            // 
            lbnSenha.AutoSize = true;
            lbnSenha.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbnSenha.ForeColor = SystemColors.ActiveCaptionText;
            lbnSenha.Location = new Point(71, 295);
            lbnSenha.Name = "lbnSenha";
            lbnSenha.Size = new Size(71, 23);
            lbnSenha.TabIndex = 5;
            lbnSenha.Text = "Senha";
            // 
            // chkSenha
            // 
            chkSenha.AutoSize = true;
            chkSenha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkSenha.ForeColor = SystemColors.WindowText;
            chkSenha.Location = new Point(336, 377);
            chkSenha.Name = "chkSenha";
            chkSenha.Size = new Size(136, 24);
            chkSenha.TabIndex = 7;
            chkSenha.Text = "Mostrar Senha";
            chkSenha.UseVisualStyleBackColor = true;
            chkSenha.CheckedChanged += chkSenha_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Yellow;
            btnLogin.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.WindowText;
            btnLogin.Location = new Point(295, 429);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(177, 49);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Yellow;
            btnCadastrar.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.WindowText;
            btnCadastrar.Location = new Point(71, 429);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(177, 49);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lbnNomesSalvos
            // 
            lbnNomesSalvos.AutoSize = true;
            lbnNomesSalvos.Font = new Font("Century Gothic", 18.8000011F);
            lbnNomesSalvos.ForeColor = SystemColors.ActiveCaptionText;
            lbnNomesSalvos.Location = new Point(20, 46);
            lbnNomesSalvos.Name = "lbnNomesSalvos";
            lbnNomesSalvos.Size = new Size(416, 39);
            lbnNomesSalvos.TabIndex = 12;
            lbnNomesSalvos.Text = "Operadores Cadastrados";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnX);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 38);
            panel1.TabIndex = 15;
            // 
            // btnX
            // 
            btnX.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnX.ForeColor = Color.Black;
            btnX.Location = new Point(1067, 3);
            btnX.Name = "btnX";
            btnX.Size = new Size(44, 31);
            btnX.TabIndex = 0;
            btnX.Text = "X";
            btnX.UseVisualStyleBackColor = true;
            btnX.Click += btnX_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(205, 117);
            label1.Name = "label1";
            label1.Size = new Size(126, 49);
            label1.TabIndex = 16;
            label1.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnCadastrar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(chkSenha);
            panel2.Controls.Add(lbnSenha);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtNomeOperador);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(575, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(539, 596);
            panel2.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(71, 207);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 17;
            label4.Text = "Nome Operador";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonFace;
            panel3.Controls.Add(panelOperadoresRecentes);
            panel3.Controls.Add(lbnNomesSalvos);
            panel3.Location = new Point(54, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 445);
            panel3.TabIndex = 18;
            // 
            // panelOperadoresRecentes
            // 
            panelOperadoresRecentes.FlowDirection = FlowDirection.TopDown;
            panelOperadoresRecentes.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panelOperadoresRecentes.ForeColor = Color.Black;
            panelOperadoresRecentes.Location = new Point(30, 111);
            panelOperadoresRecentes.Name = "panelOperadoresRecentes";
            panelOperadoresRecentes.Size = new Size(392, 303);
            panelOperadoresRecentes.TabIndex = 17;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1114, 596);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = Color.Yellow;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Login";
            Text = "Form1";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtNomeOperador;
        private TextBox txtSenha;
        private Label lbnSenha;
        private CheckBox chkSenha;
        private Button btnLogin;
        private Button btnCadastrar;
        private Label lbnNomesSalvos;
        private Panel panel1;
        private Button btnX;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private FlowLayoutPanel panelOperadoresRecentes;
    }
}
