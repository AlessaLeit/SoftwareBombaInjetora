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
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
            string nomeOperador = SessaoOperador.Instancia.NomeOperador;
            string emailOperador = SessaoOperador.Instancia.EmailOperador;
            string primeiroNome = nomeOperador.Split(' ')[0];
            txtBemVindoOperador.Text = $"Bem-vindo, {primeiroNome}!";
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRealizarDiagnostico_Click(object sender, EventArgs e)
        {
            var diagnostico = new Form_RealizarDiagnostico();
            diagnostico.Show();

            this.Visible = false;
        }

        private void btnTrocarOperador_Click(object sender, EventArgs e)
        {
            var login = new Form_Login();
            login.Show();

            this.Visible = false;
        }
        private void btnConfigDiagnostico_Click(object sender, EventArgs e)
        {
            var configurar = new Form_ConfigDiagnostico();
            configurar.Show();

            this.Visible = false;
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            var historico = new Form_VisualizarHist();
            historico.Show();

            this.Visible = false;
        }

  
    }
}
