using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BombaInjetora.Controller;
using BombaInjetora.Models;

namespace BombaInjetora
{
    public partial class Form_RealizarDiagnostico : Form
    {
        private Relatorio relatorio;
        private RelatorioController relatorioController;
        public Form_RealizarDiagnostico()
        {
            InitializeComponent();
            relatorio = new Relatorio();
            relatorioController = new RelatorioController();
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
                        relatorioController.RemoverTeste(teste, botao.Name, relatorio);
                    }
                    else
                    {
                        botao.BackColor = Color.Green;
                        relatorioController.AdicionarTeste(teste, botao.Name, relatorio);
                    }
                }
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
                        relatorioController.RemoverProveta(proveta, botao.Name, relatorio);
                    }
                    else
                    {
                        botao.BackColor = Color.Green;
                        relatorioController.AdicionarProveta(proveta, botao.Name, relatorio);
                    }
                }
            }
        }
        
        private void btnIniciarDiag_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(relatorio.modeloSelecionado) ||
             relatorio.testesSelecionados == null ||
             relatorio.testesSelecionados.Count == 0 ||
             relatorio.provetasSelecionadas == null ||
             relatorio.provetasSelecionadas.Count == 0)
            {
                MessageBox.Show("Dados inseridos são insuficientes, Tente novamente");
            }
            else
            {
                relatorioController.SalvarConfiguracaoEmArquivo(relatorio);
            }
        }

        private void menuModelos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuModelos_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem)
            {
                menuModelos.Text = menuItem.Text;
                relatorio.modeloSelecionado = menuModelos.Text;
            }
        }
    }
}
