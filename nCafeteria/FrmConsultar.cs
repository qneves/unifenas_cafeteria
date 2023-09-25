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

            PedidoModel PM = new PedidoModel();

            DataBase DB = new DataBase();
            var result = PM.GetAll(DB.getConnectionString());

            dgvConsulta.Rows.Clear();
            foreach (PedidoModel item in result)
            {
                if (item.data == dataProcurada)
                {
                    dgvConsulta.Rows.Add(item.nome, item.msgPedido, item.acucar, item.fPagamento, "R$ " + item.precoTotal); ;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var frm1 = new FrmInicio();
            this.Hide();
            frm1.ShowDialog();
            this.Close();
            Application.Exit();
        }
    }
}
