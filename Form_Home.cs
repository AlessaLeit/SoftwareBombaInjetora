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
    public partial class Form_Home : Form
    {
        private string nomeOperador;
        public Form_Home(string nomeOperador)
        {
            InitializeComponent();
            string primeiroNome = nomeOperador.Split(' ')[0];
            txtBemVindoOperador.Text = $"Bem-vindo, {primeiroNome}!";
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRealizarDiagnostico_Click(object sender, EventArgs e)
        {
            var diagnostico = new Form_RealizarDiag();
            diagnostico.Show();

            this.Visible = false;
        }

        private void btnTrocarOperador_Click(object sender, EventArgs e)
        {
            var login = new Form_Login();
            login.Show();

            this.Visible = false;
        }

        private void txtBemVindoOperador_Click(object sender, EventArgs e)
        {

        }
    }
}
