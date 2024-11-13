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
    public partial class Form_State : Form
    {
        public Form_State()
        {
            InitializeComponent();
        }
        public void UpdateState()
        {
            lblRail.Text = "YY";
            lblNivel.Text = "YY";
            lbTemp.Text = "YY°C";
        }
    }
}

