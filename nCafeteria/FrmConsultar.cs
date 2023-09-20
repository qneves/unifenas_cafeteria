using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nCafeteria
{
    public partial class FrmConsultar : Form
    {
        internal string senhaLogin = "";

        public FrmConsultar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Pedido item in Program.ListaPedido)
            {
                DateTime dtpData = item.Data;
                DateTime dtpCnst = dtpConsulta.Value;

                if (dtpCnst == dtpData)
                {
                    label2.Text = item.mostra();
                }
            }
        }
    }
}
