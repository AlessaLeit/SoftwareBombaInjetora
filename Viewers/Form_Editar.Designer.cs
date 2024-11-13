namespace BombaInjetora
{
    partial class Form_Editar
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
            panel2 = new Panel();
            btnVoltar = new Button();
            btnExcluir = new Button();
            chkboxSenhaNova = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            txtNovaSenha = new TextBox();
            btnAlterar = new Button();
            chkboxSenha = new CheckBox();
            lbnNomeOperador = new Label();
            lbnSenha = new Label();
            txtSenhaAntiga = new TextBox();
            txtNomeOperador = new TextBox();
            panel1 = new Panel();
            btnX = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(btnVoltar);
            panel2.Controls.Add(btnExcluir);
            panel2.Controls.Add(chkboxSenhaNova);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtNovaSenha);
            panel2.Controls.Add(btnAlterar);
            panel2.Controls.Add(chkboxSenha);
            panel2.Controls.Add(lbnNomeOperador);
            panel2.Controls.Add(lbnSenha);
            panel2.Controls.Add(txtSenhaAntiga);
            panel2.Controls.Add(txtNomeOperador);
            panel2.Location = new Point(274, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 465);
            panel2.TabIndex = 29;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Yellow;
            btnVoltar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(21, 16);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(44, 31);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "<";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Yellow;
            btnExcluir.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = SystemColors.WindowText;
            btnExcluir.Location = new Point(131, 383);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(180, 49);
            btnExcluir.TabIndex = 29;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // chkboxSenhaNova
            // 
            chkboxSenhaNova.AutoSize = true;
            chkboxSenhaNova.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkboxSenhaNova.ForeColor = SystemColors.WindowText;
            chkboxSenhaNova.Location = new Point(366, 329);
            chkboxSenhaNova.Name = "chkboxSenhaNova";
            chkboxSenhaNova.Size = new Size(136, 24);
            chkboxSenhaNova.TabIndex = 28;
            chkboxSenhaNova.Text = "Mostrar Senha";
            chkboxSenhaNova.UseVisualStyleBackColor = true;
            chkboxSenhaNova.CheckedChanged += chkboxSenhaNova_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(146, 34);
            label2.Name = "label2";
            label2.Size = new Size(335, 49);
            label2.TabIndex = 26;
            label2.Text = "Editar Operador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(131, 263);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 24;
            label1.Text = "Senha Nova";
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Font = new Font("Segoe UI", 12F);
            txtNovaSenha.Location = new Point(131, 289);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(371, 34);
            txtNovaSenha.TabIndex = 23;
            txtNovaSenha.UseSystemPasswordChar = true;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Yellow;
            btnAlterar.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = SystemColors.WindowText;
            btnAlterar.Location = new Point(322, 383);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(180, 49);
            btnAlterar.TabIndex = 22;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // chkboxSenha
            // 
            chkboxSenha.AutoSize = true;
            chkboxSenha.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkboxSenha.ForeColor = SystemColors.WindowText;
            chkboxSenha.Location = new Point(366, 256);
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
            lbnNomeOperador.Location = new Point(131, 118);
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
            lbnSenha.Location = new Point(131, 190);
            lbnSenha.Name = "lbnSenha";
            lbnSenha.Size = new Size(130, 23);
            lbnSenha.TabIndex = 16;
            lbnSenha.Text = "Senha Atual";
            // 
            // txtSenhaAntiga
            // 
            txtSenhaAntiga.Font = new Font("Segoe UI", 12F);
            txtSenhaAntiga.Location = new Point(131, 216);
            txtSenhaAntiga.Name = "txtSenhaAntiga";
            txtSenhaAntiga.Size = new Size(371, 34);
            txtSenhaAntiga.TabIndex = 15;
            txtSenhaAntiga.UseSystemPasswordChar = true;
            // 
            // txtNomeOperador
            // 
            txtNomeOperador.CausesValidation = false;
            txtNomeOperador.Font = new Font("Segoe UI", 12F);
            txtNomeOperador.Location = new Point(131, 144);
            txtNomeOperador.Name = "txtNomeOperador";
            txtNomeOperador.Size = new Size(371, 34);
            txtNomeOperador.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnX);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 38);
            panel1.TabIndex = 28;
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
            btnX.Click += btnX_Click;
            // 
            // Form_Editar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Yellow;
            ClientSize = new Size(1114, 596);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Editar";
            Text = "Form_Editar";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private CheckBox chkboxSenhaNova;
        private Label label2;
        private Label label1;
        private TextBox txtNovaSenha;
        private Button btnAlterar;
        private CheckBox chkboxSenha;
        private Label lbnNomeOperador;
        private Label lbnSenha;
        private TextBox txtSenhaAntiga;
        private TextBox txtNomeOperador;
        private Panel panel1;
        private Button btnX;
        private Button btnExcluir;
        private Button btnVoltar;
    }
}