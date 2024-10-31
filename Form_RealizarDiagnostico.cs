using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombaInjetora
{
    public partial class Form_RealizarDiagnostico : Form
    {
        private List<int> provetasSelecionadas = new List<int>();
        //private string modeloSelecionado;
        private List<string> testesSelecionados = new List<string>();

        public Form_RealizarDiagnostico()
        {
            InitializeComponent();
        }

        private void btnTestes_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;

            if (botao != null)
            {
                string teste = botao.Text;
                {
                    if (botao.BackColor == Color.Green)
                    {
                        botao.BackColor = SystemColors.ButtonFace;
                        RemoverTeste(teste, botao.Name);
                    }
                    else
                    {
                        botao.BackColor = Color.Green;
                        AdicionarTeste(teste, botao.Name);
                    }
                }
            }
        }
        private void AdicionarTeste(string teste, string buttonName)
        {
            switch (buttonName)
            {
                case "btnEstanqueidade":
                case "btnPreInjecao":
                case "btnMarchaLenta":
                case "btnEmissoes":
                case "btnPlenaCarga":
                    testesSelecionados.Add(teste);
                    break;
            }
        }

        private void RemoverTeste(string teste, string buttonName)
        {
            switch (buttonName)
            {
                case "btnEstanqueidade":
                case "btnPreInjecao":
                case "btnMarchaLenta":
                case "btnEmissoes":
                case "btnPlenaCarga":
                    testesSelecionados.Remove(teste);
                    break;
            }
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrocarOperador_Click(object sender, EventArgs e)
        {
            var login = new Form_Login();
            login.Show();

            this.Visible = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            var menu = new Form_Home();
            menu.Show();

            this.Visible = false;
        }

        private void btnConfigDiagnostico_Click(object sender, EventArgs e)
        {
            var diagnostico = new Form_ConfigDiagnostico();
            diagnostico.Show();

            this.Visible = false;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            var historico = new Form_VisualizarHist();
            historico.Show();

            this.Visible = false;
        }

        private void btnProvetas_Click(object sender, EventArgs e)
        {
            Button botao = sender as Button;

            if (botao != null)
            {
                int proveta;
                if (int.TryParse(botao.Text, out proveta))
                {
                    if (botao.BackColor == Color.Green)
                    {
                        botao.BackColor = SystemColors.Control;
                        RemoverProveta(proveta, botao.Name);
                    }
                    else
                    {
                        botao.BackColor = Color.Green;
                        AdicionarProveta(proveta, botao.Name);
                    }
                }
            }
        }
        private void AdicionarProveta(int proveta, string buttonName)
        {
            switch (buttonName)
            {
                case "btnUm":
                case "btnDois":
                case "btnTres":
                case "btnQuatro":
                    provetasSelecionadas.Add(proveta);
                    break;
            }
        }

        private void RemoverProveta(int proveta, string buttonName)
        {
            switch (buttonName)
            {
                case "btnUm":
                case "btnDois":
                case "btnTres":
                case "btnQuatro":
                    provetasSelecionadas.Remove(proveta);
                    break;
            }
        }

        private void SalvarConfiguracaoEmArquivo()
        {
            string caminhoArquivo = @"C:\Users\Aless\OneDrive\Documentos\Programação\Faculdade\Adrian_POO\Projetos\BombaInjetoraTestes.txt";
            using (StreamWriter writer = new StreamWriter(caminhoArquivo, false)) // "false" para sobrescrever o arquivo
            {
                writer.WriteLine("Testes Selecionados: " + string.Join(", ", testesSelecionados));
                writer.WriteLine("Provetas Selecionadas: " + string.Join(", ", provetasSelecionadas));

            }

            MessageBox.Show("Começando testes!");

            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                for (int i = 0; i < linhas.Length; i += 3)
                {
                    string linhaTeste = linhas[i];
                    string linhaProveta = linhas[i + 1];
                    //string linhaModelo = linhas[i + 2];

                    MessageBox.Show($"Resultado Diagnóstico:\n{linhaTeste}\n{linhaProveta}");
                    //\n{linhaModelo}
                }
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado.");
            }
        }
        private void btnIniciarDiag_Click(object sender, EventArgs e)
        {
            SalvarConfiguracaoEmArquivo();
        }

        private void menuModelos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
