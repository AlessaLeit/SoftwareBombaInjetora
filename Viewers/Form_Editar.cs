using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BombaInjetora.Models;

namespace BombaInjetora
{
    public partial class Form_Editar : Form
    {
        public Form_Editar()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeOperador.Text;
            string senhaAntiga = txtSenhaAntiga.Text;
            string novaSenha = txtNovaSenha.Text;
            string caminhoArquivo = @"C:\Users\Aless\OneDrive\Documentos\Programação\Faculdade\Adrian_POO\Projetos\BombaInjetoraOperadores.txt";

            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                bool operadorEncontrado = false;

                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    for (int i = 0; i < linhas.Length; i += 3)
                    {
                        string linhaNome = linhas[i].Replace("Nome Operador: ", "").Trim();
                        string linhaSenha = linhas[i + 1].Replace("Senha: ", "").Trim();

                        if (linhaNome == nome && linhaSenha == senhaAntiga)
                        {
                            operadorEncontrado = true;
                            // Escreve o operador atualizado com a nova senha
                            writer.WriteLine("Nome Operador: " + nome);
                            writer.WriteLine("Senha: " + novaSenha);
                            writer.WriteLine("-------------------------------------");
                            i += 2; // Pula para o próximo operador
                        }
                        else
                        {
                            // Copia as linhas existentes pra não perder 
                            writer.WriteLine(linhas[i]);
                            writer.WriteLine(linhas[i + 1]);
                            writer.WriteLine(linhas[i + 2]);
                        }
                    }
                }

                if (operadorEncontrado)
                {
                    MessageBox.Show("Senha alterada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Operador não encontrado ou senha antiga incorreta.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum cadastro encontrado.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nome = txtNomeOperador.Text;
            string caminhoArquivo = @"C:\Users\Aless\OneDrive\Documentos\Programação\Faculdade\Adrian_POO\Projetos\BombaInjetoraOperadores.txt";

            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                bool operadorEncontrado = false;

                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    for (int i = 0; i < linhas.Length; i += 3)
                    {
                        string linhaNome = linhas[i].Replace("Nome Operador: ", "").Trim();

                        if (linhaNome == nome)
                        {
                            operadorEncontrado = true;
                            i += 2; // Pula o bloco do operador a ser excluído
                        }
                        else
                        {
                            // Copia as linhas existentes
                            writer.WriteLine(linhas[i]);
                            writer.WriteLine(linhas[i + 1]);
                            writer.WriteLine(linhas[i + 2]);
                        }
                    }
                }

                if (operadorEncontrado)
                {
                    MessageBox.Show("Operador excluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Operador não encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum cadastro encontrado.");
            }
        }

        private void chkboxSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSenha.Checked)
            {
                txtSenhaAntiga.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaAntiga.UseSystemPasswordChar = true;
            }
        }

        private void chkboxSenhaNova_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSenhaNova.Checked)
            {
                txtNovaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtNovaSenha.UseSystemPasswordChar = true;
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var login = new Form_Login();
            login.Show();
            this.Visible = false;
        }
    }
}

