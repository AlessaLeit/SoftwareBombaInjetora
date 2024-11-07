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
            string emailOperador = SessaoOperador.Instancia.EmailOperador;
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
                string[] diagnostico = File.ReadAllText(caminhoArquivo).Split(new[] { "-----------------------------------------------------------" }, StringSplitOptions.RemoveEmptyEntries);
                // CRIAR ID DE DIAGNOSTICO PRA CONSEGUIR LOCALIZAR OS ULTIMOS DIAGNOSTICOS
                for (int i = 0; i < panels.Length && i < diagnostico.Length; i++)
                {
                    Label label = new Label
                    {
                        Text = diagnostico[i].Trim(),
                        Size = panels[i].Size,
                        AutoSize = false,
                        TextAlign = ContentAlignment.TopLeft,
                        Dock = DockStyle.Fill,
                        Padding = new Padding(5),
                        AutoEllipsis = true
                    };

                    panels[i].Controls.Clear();
                    panels[i].Controls.Add(label);
                }
            }
            else
            {
                MessageBox.Show("Nenhum histórico encontrado.");
            }
        }
    }
}
