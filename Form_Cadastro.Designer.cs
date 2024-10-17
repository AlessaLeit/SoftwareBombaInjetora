namespace BombaInjetora
{
    partial class Form_Cadastro
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
            btnCadastrar = new Button();
            chkboxSenha = new CheckBox();
            lbnNomeOperador = new Label();
            lbnSenha = new Label();
            txtSenha = new TextBox();
            txtNomeOperador = new TextBox();
            label1 = new Label();
            txtConfirmarSenha = new TextBox();
            panel1 = new Panel();
            btnX = new Button();
            panel2 = new Panel();
            chkboxConfirmarSenha = new CheckBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Yellow;
            btnCadastrar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = SystemColors.WindowText;
            btnCadastrar.Location = new Point(217, 390);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(180, 49);
            btnCadastrar.TabIndex = 22;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // chkboxSenha
            // 
            chkboxSenha.AutoSize = true;
            chkboxSenha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkboxSenha.ForeColor = SystemColors.WindowText;
            chkboxSenha.Location = new Point(349, 259);
            chkboxSenha.Name = "chkboxSenha";
            chkboxSenha.Size = new Size(136, 24);
            chkboxSenha.TabIndex = 18;
            chkboxSenha.Text = "Mostrar Senha";
            chkboxSenha.UseVisualStyleBackColor = true;
            chkboxSenha.CheckedChanged += chkboxSenha_CheckedChanged;
            // 
            // lbnNomeOperador
            // 
            lbnNomeOperador.AutoSize = true;
            lbnNomeOperador.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbnNomeOperador.ForeColor = SystemColors.ActiveCaptionText;
            lbnNomeOperador.Location = new Point(114, 121);
            lbnNomeOperador.Name = "lbnNomeOperador";
            lbnNomeOperador.Size = new Size(173, 23);
            lbnNomeOperador.TabIndex = 17;
            lbnNomeOperador.Text = "Nome Operador";
            // 
            // lbnSenha
            // 
            lbnSenha.AutoSize = true;
            lbnSenha.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbnSenha.ForeColor = SystemColors.ActiveCaptionText;
            lbnSenha.Location = new Point(114, 193);
            lbnSenha.Name = "lbnSenha";
            lbnSenha.Size = new Size(71, 23);
            lbnSenha.TabIndex = 16;
            lbnSenha.Text = "Senha";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(114, 219);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(371, 34);
            txtSenha.TabIndex = 15;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtNomeOperador
            // 
            txtNomeOperador.CausesValidation = false;
            txtNomeOperador.Font = new Font("Segoe UI", 12F);
            txtNomeOperador.Location = new Point(114, 147);
            txtNomeOperador.Name = "txtNomeOperador";
            txtNomeOperador.Size = new Size(371, 34);
            txtNomeOperador.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(114, 266);
            label1.Name = "label1";
            label1.Size = new Size(172, 23);
            label1.TabIndex = 24;
            label1.Text = "Confirmar Senha";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Segoe UI", 12F);
            txtConfirmarSenha.Location = new Point(114, 292);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(371, 34);
            txtConfirmarSenha.TabIndex = 23;
            txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnX);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 38);
            panel1.TabIndex = 26;
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
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(chkboxConfirmarSenha);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtConfirmarSenha);
            panel2.Controls.Add(btnCadastrar);
            panel2.Controls.Add(chkboxSenha);
            panel2.Controls.Add(lbnNomeOperador);
            panel2.Controls.Add(lbnSenha);
            panel2.Controls.Add(txtSenha);
            panel2.Controls.Add(txtNomeOperador);
            panel2.Location = new Point(264, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 472);
            panel2.TabIndex = 27;
            // 
            // chkboxConfirmarSenha
            // 
            chkboxConfirmarSenha.AutoSize = true;
            chkboxConfirmarSenha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkboxConfirmarSenha.ForeColor = SystemColors.WindowText;
            chkboxConfirmarSenha.Location = new Point(349, 332);
            chkboxConfirmarSenha.Name = "chkboxConfirmarSenha";
            chkboxConfirmarSenha.Size = new Size(136, 24);
            chkboxConfirmarSenha.TabIndex = 28;
            chkboxConfirmarSenha.Text = "Mostrar Senha";
            chkboxConfirmarSenha.UseVisualStyleBackColor = true;
            chkboxConfirmarSenha.CheckedChanged += chkboxConfirmarSenha_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(193, 41);
            label2.Name = "label2";
            label2.Size = new Size(204, 49);
            label2.TabIndex = 26;
            label2.Text = "Cadastro";
            // 
            // Form_Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1114, 596);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Cadastro";
            Text = "Form_Cadastro";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrar;
        private CheckBox chkboxSenha;
        private Label lbnNomeOperador;
        private Label lbnSenha;
        private TextBox txtSenha;
        private TextBox txtNomeOperador;
        private Label label1;
        private TextBox txtConfirmarSenha;
        private Panel panel1;
        private Button btnX;
        private Panel panel2;
        private Label label2;
        private CheckBox chkboxConfirmarSenha;
    }
}