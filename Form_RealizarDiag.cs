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
    public partial class Form_RealizarDiag : Form
    {
        public Form_RealizarDiag()
        {
            InitializeComponent();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTestes_Click(object sender, EventArgs e) // Precisa corrigir a cor quando você tira o selecionado
        {
            Button botao = sender as Button;

            if (botao != null)
            {
                if (botao.BackColor == Color.Green)
                {
                    botao.BackColor = SystemColors.ButtonFace;
                }
                else
                {
                    botao.BackColor = Color.Green;
                }
            }
        }
        private bool todosSelecionados = false; // Variável para rastrear o estado

        private void btnSelecionarTodos_Click(object sender, EventArgs e)
        {
            Color corParaAplicar = todosSelecionados ? SystemColors.ButtonFace : Color.Green;
            MudarCorDosBotoes(panelTestes, corParaAplicar); // Alterna entre verde e ButtonFace
            todosSelecionados = !todosSelecionados;
        }

        private void MudarCorDosBotoes(Control controle, Color cor)
        {
            foreach (Control subControle in controle.Controls)
            {
                if (subControle is Button button && button != btnTodos)
                {
                    button.BackColor = cor; // Muda a cor conforme a variável passada
                }
                else
                {
                    MudarCorDosBotoes(subControle, cor); // Recursivamente mudar a cor dos botões dentro de containers
                }
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnTrocarOperador_Click_1(object sender, EventArgs e)
        {
            var login = new Form_Login();
            login.Show();

            this.Visible = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            var inicio = new Form_Inicio();
            inicio.Show();

            this.Visible = false;
        }

        private void btnConfigDiagnostico_Click(object sender, EventArgs e)
        {

        }
    }

}


