namespace BombaInjetora
{
    public partial class Form_Login : Form
    {
        private string nomeOperador;
        public Form_Login()
        {
            InitializeComponent();
            CarregarOperadoresRecentes();
        
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        private void CarregarOperadoresRecentes() //Preciso corrigir, apenas aparece 1/4 operadores
        {
            string caminhoArquivo = @"C:\Users\Aless\OneDrive\Documentos\Programação\Faculdade\Adrian_POO\Projetos\BombaInjetoraOperadores.txt";
            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                panelOperadoresRecentes.Controls.Clear();

                int count = 0;
                for (int i = 0; i < linhas.Length; i++)
                {
                    if (linhas[i].StartsWith("Nome Operador:"))
                    {
                        string linhaNome = linhas[i].Replace("Nome Operador: ", "").Trim();

                        Label txtOperador = new Label();
                        txtOperador.Text = linhaNome;
                        txtOperador.AutoSize = true;
                        txtOperador.Margin = new Padding(0, 10, 0, 10);
                        txtOperador.Cursor = Cursors.Hand;

                        // Use variável local para capturar o valor correto
                        string nomeCapturado = linhaNome;
                        txtOperador.Click += (s, e) =>
                        {
                            txtNomeOperador.Text = nomeCapturado;
                        };

                        panelOperadoresRecentes.Controls.Add(txtOperador);
                        count++;

                        if (count >= 6) break; // Limita a exibição a 4 operadores
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

                    for (int i = 0; i < linhas.Length; i += 3) // Pula de 3 em 3 linhas, pois no arquivo eu salvei o cadastro com 3 linhas sobre
                    {
                        string linhaNome = linhas[i].Replace("Nome Operador: ", "").Trim(); // Limpar pra deixar somente o nome/senha
                        string linhaSenha = linhas[i + 1].Replace("Senha: ", "").Trim();

                        if (linhaNome == nome && linhaSenha == senha)
                        {
                            loginValido = true;
                            nomeOperador = nome;
                            break;
                        }
                    }

                    if (loginValido)
                    {
                        var menu = new Form_Home(nomeOperador);
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

    }
}
