using System.Drawing.Text;
using static BombaInjetora.SessaoOperadorcs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BombaInjetora
{
    public partial class Form_Login : Form
    {

        public Form_Login()
        {
            InitializeComponent();
            CarregarOperadoresRecentes();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        // Método para carregar e exibir os operadores mais recentes no painel
        private void CarregarOperadoresRecentes()
        {
            string caminhoArquivo = @"C:\Users\Aless\OneDrive\Documentos\Programação\Faculdade\Adrian_POO\Projetos\BombaInjetoraOperadores.txt";
            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                panelOperadoresRecentes.Controls.Clear();

                int count = 0; // Contador para limitar a exibição a até 6 operadores recentes
                for (int i = 0; i < linhas.Length; i++)
                {   
                    // Criação dos nomes já cadastrados no panel
                    if (linhas[i].StartsWith("Nome Operador:"))
                    {
                        string linhaNome = linhas[i].Replace("Nome Operador: ", "").Trim();

                        Label txtOperador = new Label();
                        txtOperador.Text = linhaNome;
                        txtOperador.AutoSize = true;
                        txtOperador.Margin = new Padding(0, 10, 0, 10);
                        txtOperador.Cursor = Cursors.Hand;

                        string nomeCapturado = linhaNome;
                        txtOperador.Click += (s, e) =>
                        {
                            txtNomeOperador.Text = nomeCapturado;
                        };

                        panelOperadoresRecentes.Controls.Add(txtOperador);
                        count++;

                        if (count >= 6) break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum cadastro encontrado.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNomeOperador.Text;
                string senha = txtSenha.Text;

                string caminhoArquivo = @"C:\Users\Aless\OneDrive\Documentos\Programação\Faculdade\Adrian_POO\Projetos\BombaInjetoraOperadores.txt";

                if (File.Exists(caminhoArquivo))
                {
                    string[] linhas = File.ReadAllLines(caminhoArquivo);
                    bool loginValido = false;

                    for (int i = 0; i < linhas.Length; i += 3)
                    {
                        string linhaNome = linhas[i].Replace("Nome Operador: ", "").Trim();
                        string linhaSenha = linhas[i + 1].Replace("Senha: ", "").Trim();

                        if (linhaNome == nome && linhaSenha == senha)
                        {
                            loginValido = true;
                            break;
                        }
                    }

                    if (loginValido)
                    {
                        SessaoOperador.Instancia.NomeOperador = nome; // Armazena o nome do operador na sessão
                        var menu = new Form_Home();
                        menu.Show();

                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Nome ou senha incorretos, Tente novamente");
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum cadastro encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var cadastro = new Form_Cadastro();
            cadastro.Show();

            this.Visible = false;
        }

        private void chkSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }

        }

        private void btnX_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var editar = new Form_Editar();
            editar.Show();

            this.Visible = false;
        }
    }
}
