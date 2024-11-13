using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BombaInjetora.SessaoOperadorcs;

namespace BombaInjetora
{
    public partial class Form_VisualizarHist : Form
    {
        private Panel[] panels;
        public Form_VisualizarHist()
        {
            InitializeComponent();
            string nomeOperador = SessaoOperador.Instancia.NomeOperador;
            // Inicializa o array de painéis com os painéis do histórico
            panels = new Panel[] { panelHistoricoUm, panelHistoricoDois, panelHistoricoTres, panelHistoricoQuatro };
            CarregarHistorico();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            var menu = new Form_Home();
            menu.Show();

            this.Visible = false;
        }

        private void btnRealizarDiagnostico_Click(object sender, EventArgs e)
        {
            var diagnostico = new Form_RealizarDiagnostico();
            diagnostico.Show();

            this.Visible = false;
        }

        private void btnConfigDiagnostico_Click(object sender, EventArgs e)
        {
            var configuracao = new Form_ConfigDiagnostico();
            configuracao.Show();

            this.Visible = false;
        }

        private void btnTrocarOperador_Click(object sender, EventArgs e)
        {
            var login = new Form_Login();
            login.Show();

            this.Visible = false;
        }

        private void CarregarHistorico()
        {
            string caminhoArquivo = @"C:\Users\Aless\OneDrive\Documentos\Programação\Faculdade\Adrian_POO\Projetos\BombaInjetoraTestes.txt";

            if (File.Exists(caminhoArquivo))
            {
                // Lê o conteúdo do arquivo e separa os diagnósticos
                string[] diagnosticos = File.ReadAllText(caminhoArquivo).Split(new[] { "-----------------------------------------------------------" }, StringSplitOptions.RemoveEmptyEntries);
                List<(int id, string diagnostico)> listaDiagnosticos = new List<(int, string)>();
                foreach (var diagnostico in diagnosticos)
                {
                    var linhas = diagnostico.Split('\n');
                    int id = 0;

                    foreach (var linha in linhas)
                    {
                        if (linha.StartsWith("ID do Relatório:"))
                        {
                            id = int.Parse(linha.Split(':')[1].Trim());  
                            break;
                        }
                    }

                    listaDiagnosticos.Add((id, diagnostico));
                }
                // Ordena a lista de diagnósticos pelo ID em ordem decrescente
                listaDiagnosticos.Sort((a, b) => b.id.CompareTo(a.id));

                int count = 0;
                foreach (var diagnostico in listaDiagnosticos)
                {
                    if (count >= 4)  
                        break;

                    if (count < panels.Length)  
                    {
                        var diagnosticoText = diagnostico.diagnostico;
                        // Cria um novo label para exibir o texto do diagnóstico
                        Label label = new Label
                        {
                            Text = diagnosticoText.Trim(),
                            Size = panels[count].Size,
                            AutoSize = false,
                            TextAlign = ContentAlignment.TopLeft,
                            Dock = DockStyle.Fill,
                            Padding = new Padding(5),
                            AutoEllipsis = true
                        };

                        panels[count].Controls.Clear();
                        panels[count].Controls.Add(label);

                        count++;
                    }
                }

                if (count == 0)
                {
                    MessageBox.Show("Nenhum diagnóstico encontrado.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum histórico encontrado.");
            }

        }
    }
}
