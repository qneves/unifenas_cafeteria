namespace Cafeteria
{
    public partial class FrmInicio : Form
    {
        private bool password = false;

        public FrmInicio()
        {
            InitializeComponent();
        }



        private void btnPedido_Click(object sender, EventArgs e)
        {
            var frm1 = new FrmPedido();
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