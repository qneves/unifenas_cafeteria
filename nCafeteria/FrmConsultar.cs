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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime dataProcurada = dtpConsulta.Value.Date;

            foreach (Pedido item in Program.ListaPedido)
            {

                if (item.Data == dataProcurada)
                {
                    dgvConsulta.Rows.Add(item.Nome, item.pedido(), item.Acucar, item.FPagamento, "R$ " + item.PrecoTotal); ;
                }
            }
        }
    }
}
