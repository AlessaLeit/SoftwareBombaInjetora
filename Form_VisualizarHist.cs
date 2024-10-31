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
    public partial class Form_VisualizarHist : Form
    {
        public Form_VisualizarHist()
        {
            InitializeComponent();
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

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
