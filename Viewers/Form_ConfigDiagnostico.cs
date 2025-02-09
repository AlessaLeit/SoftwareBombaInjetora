﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BombaInjetora;
using BombaInjetora.Controller;
using BombaInjetora.Models;
using static BombaInjetora.SessaoOperadorcs;

namespace BombaInjetora
{
    public partial class Form_ConfigDiagnostico : Form
    {
        public Form_State formState;
        private State currentState;
        public Form_ConfigDiagnostico()
        {
            InitializeComponent();
            // Compartilha pra futuramente incrementar no relatório por quem foi feito
            string nomeOperador = SessaoOperador.Instancia.NomeOperador; 
            SetState(new DesligarTesteState());
        }
        // Alteração do Design Patters State
        public void SetState(State newState)
        {
            currentState = newState;
            currentState.Handle(this);
            btnIniciarDiag.Text = currentState.ProximoEstadoTexto;
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            var menu = new Form_Home();
            menu.Show();

            this.Visible = false;
        }
        // Todos os botões do diagnóstico seguem a mesma lógica
        private void btnTempoPulso_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxTempoPulso.Text, out int tp))
            {
                Button clickedButton = sender as Button;
                switch (clickedButton?.Name)
                {
                    case "btnTempoMenosDez":
                        if (tp != 0 && tp >= 10)
                        {
                            tp -= 10;
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido no campo.");
                        }
                        break;
                    case "btnTempoMaisDez":
                        tp += 10;
                        break;
                    case "btnTempoMenosCem":
                        if (tp != 0 && tp >= 100)
                        {
                            tp -= 100;
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido no campo.");
                        }
                        break;
                    case "btnTempoMaisCem":
                        tp += 100;
                        break;
                }
                txtBoxTempoPulso.Text = tp.ToString();
            }
            else
            {
                MessageBox.Show("Valor inválido no campo. Insira um número.");
            }
        }

        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxFrequencia.Text, out int f))
            {
                Button clickedButton = sender as Button;
                switch (clickedButton?.Name)
                {
                    case "btnFreqMenosDez":
                        if (f != 0 && f >= 10)
                        {
                            f -= 10;
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido no campo.");
                        }
                        break;
                    case "btnFreqMaisDez":
                        f += 10;
                        break;
                    case "btnFreqMenosCem":
                        if (f != 0 && f >= 100)
                        {
                            f -= 100;
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido no campo.");
                        }
                        break;
                    case "btnFreqMaisCem":
                        f += 100;
                        break;
                }
                txtBoxFrequencia.Text = f.ToString();
            }
            else
            {
                MessageBox.Show("Valor inválido no campo. Insira um número.");
            }
        }

        private void btnRPM_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxRpm.Text, out int rpm))
            {
                Button clickedButton = sender as Button;
                switch (clickedButton?.Name)
                {
                    case "btnRpmMenosDez":
                        if (rpm != 0 && rpm >= 10)
                        {
                            rpm -= 10;
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido no campo.");
                        }
                        break;
                    case "btnRpmMaisDez":
                        rpm += 10;
                        break;
                }
                txtBoxRpm.Text = rpm.ToString();
            }
            else
            {
                MessageBox.Show("Valor inválido no campo. Insira um número.");
            }
        }

        private void btnControlePressao_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtBoxCp.Text, out float cp))
            {
                Button clickedButton = sender as Button;
                switch (clickedButton?.Name)
                {
                    case "btnControlMenosUm":
                        if (cp != 0 && cp >= 1)
                        {
                            cp -= 1;
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido no campo.");
                        }
                        break;
                    case "btnControlMenosZeroUm":
                        if (cp != 0 && cp >= 0.1)
                        {
                            cp -= (float)0.1;
                        }
                        else
                        {
                            MessageBox.Show("Valor inválido no campo.");
                        }
                        break;
                    case "btnControlMaisZeroUm":
                        cp += (float)0.1;
                        break;
                    case "btnControlMaisUm":
                        cp += 1;
                        break;
                    case "btnControlZero":
                        cp = 0;
                        break;
                }
                txtBoxCp.Text = cp.ToString("F2");
            }
            else
            {
                MessageBox.Show("Valor inválido no campo. Insira um número.");
            }
        }
        
        // Provetas seguem a mesma lógica do outro tipo de diagnósitco
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
                    }
                    else
                    {
                        botao.BackColor = Color.Green;
                    }
                }
            }
        }

        // Ao iniciar vai ser colocado em prática o design patter state
        private void btnInciarDiag_Click(object sender, EventArgs e)
        {
            if (currentState is IniciarTesteState)
            {
                SetState(new ExecutandoTesteState());
            }
            else if (currentState is ExecutandoTesteState)
            {
                SetState(new DesligarTesteState());
            }
            else if (currentState is DesligarTesteState)
            {
                SetState(new IniciarTesteState());
            }
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

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            var historico = new Form_VisualizarHist();
            historico.Show();

            this.Visible = false;
        }
        // Salvar o modelo escolhido
        private void menuModelo_Click(object sender, EventArgs e)
        {

            if (sender is ToolStripMenuItem menuItem)
            {
                menuModelos.Text = menuItem.Text;
            }
        }

    }
}
