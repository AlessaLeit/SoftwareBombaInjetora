using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombaInjetora
{
    public partial class Form_Cadastro : Form
    {
        public Form_Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string nome = txtNomeOperador.Text;
                string senha = txtSenha.Text;
                string confirmarSenha = txtConfirmarSenha.Text;

                // Verificação de email
                bool VerificarEmail(string email)
                {
                    string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                    return Regex.IsMatch(email, padrao);
                }

                if (!VerificarEmail(email))
                {
                    MessageBox.Show("Email inválido. Tente novamente.");
                    return;
                }

                if (senha != confirmarSenha)
                {
                    MessageBox.Show("As senhas não coincidem. Tente novamente.");
                    return;
                }

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmarSenha))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos!");
                    return;
                }

                string caminhoArquivo = @"C:\Users\Aless\OneDrive\Documentos\Programação\Faculdade\Adrian_POO\Projetos\BombaInjetoraOperadores.txt";
                if (File.Exists(caminhoArquivo))
                {
                    string[] linhas = File.ReadAllLines(caminhoArquivo);
                    foreach (string linha in linhas)
                    {
                        if (linha.Contains("Nome Operador: " + nome))
                        {
                            MessageBox.Show("Operador já cadastrado");
                            return;
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
                {
                    writer.WriteLine("Email: " + email);
                    writer.WriteLine("Nome Operador: " + nome);
                    writer.WriteLine("Senha: " + senha);
                    writer.WriteLine("-------------------------------------");
                }

                MessageBox.Show("Dados salvos com sucesso!");

                var login = new Form_Login();
                login.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados: " + ex.Message);
            }
        }

        private void chkboxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void chkboxConfirmarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxConfirmarSenha.Checked)
            {
                txtConfirmarSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtConfirmarSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnX_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
