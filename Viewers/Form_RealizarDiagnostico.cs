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
        private string modeloSelecionado;
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
            using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
            {
                writer.WriteLine("Modelo Selecionado: " + modeloSelecionado);
                writer.WriteLine("Testes Selecionados: " + string.Join(", ", testesSelecionados));
                writer.WriteLine("Provetas Selecionadas: " + string.Join(", ", provetasSelecionadas));
                writer.WriteLine("-----------------------------------------------------------");
            }

            MessageBox.Show("Começando testes!");

            MessageBox.Show($"Iniciando Diagnóstico! \n" +
                $"Modelo Selecionado: {modeloSelecionado}\n" +
                $"Testes Selecionados: {string.Join(", ", testesSelecionados)}\n" +
                $"Provetas Selecionadas: {string.Join(", ", provetasSelecionadas)}\n");
        }

        private void btnIniciarDiag_Click(object sender, EventArgs e)
        {
            SalvarConfiguracaoEmArquivo();
        }

        private void menuModelos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuModelos_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                menuModelos.Text = menuItem.Text;
                modeloSelecionado = menuModelos.Text;
            }
        }
    }
}
