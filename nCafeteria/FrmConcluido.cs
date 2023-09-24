using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nCafeteria
{
    public partial class FrmConcluido : Form
    {

        private bool password = false;

        public FrmConcluido()
        {
            InitializeComponent();
        }

        public void AtualizarResumo(string novoTexto)
        {
            lbResumo.Text = novoTexto;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            var frm3 = new FrmInicio();
            this.Hide();
            frm3.ShowDialog();
            this.Close();
            Application.Exit();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            var frm1 = new c();
            this.Hide();
            frm1.ShowDialog();
            this.Close();
            Application.Exit();
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            btnAdm.Text = "Confirmar";

            if (password)
            {
                if (String.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text != "123")
                {
                    MessageBox.Show("Senha Inválida", "Atenção!");
                    return;
                }
                else
                {
                    password = false;
                    txtPassword.Visible = false;

                    var frm = new FrmConsultar();
                    frm.senhaLogin = txtPassword.Text;
                    frm.ShowDialog();
                    frm.Dispose();
                }
            }
            else
            {
                txtPassword.Visible = true;
                password = true;
            }
        }
    }
}
