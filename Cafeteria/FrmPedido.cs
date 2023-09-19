﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class FrmPedido : Form
    {
        //Pedido P;

        private double valorTotal;

        private string pagamento = "";

        private double[] cafe = { 3, 5, 7 };
        private double[] salgado = { 3, 5, 7 };
        private double[] salada = { 3, 3, 3 };
        private double[] doce = { 5, 2.5, 3 };
        private double[] bebidas = { 6, 5, 2 };


        public FrmPedido()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = DateTime.Now.ToString("hh:mm");
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            // CAFE
            if (cbCafe1.Checked)
                valorTotal += cafe[0];
            if (cbCafe2.Checked)
                valorTotal += cafe[1];
            if (cbCafe3.Checked)
                valorTotal += cafe[1];

            // SALGADO
            if (cbSalgado1.Checked)
                valorTotal += salgado[0];
            if (cbSalgado2.Checked)
                valorTotal += salgado[1];
            if (cbSalgado3.Checked)
                valorTotal += salgado[2];

            // SALADA
            if (cbSalada1.Checked)
                valorTotal += salada[0];
            if (cbSalada2.Checked)
                valorTotal += salada[1];
            if (cbSalada3.Checked)
                valorTotal += salada[2];

            // DOCE
            if (cbDoce1.Checked)
                valorTotal += doce[0];
            if (cbDoce2.Checked)
                valorTotal += doce[1];
            if (cbDoce3.Checked)
                valorTotal += doce[2];

            // BEBIDAS
            if (cbBebida1.Checked)
                valorTotal += doce[0];
            if (cbBebida2.Checked)
                valorTotal += doce[1];
            if (cbBebida3.Checked)
                valorTotal += doce[2];

            // PAGAMENTO
            if (rbFPagamento1.Checked)
                pagamento = rbFPagamento1.Text;
            if (rbFPagamento2.Checked)
                pagamento = rbFPagamento2.Text;
            if (rbFPagamento3.Checked)
                pagamento = rbFPagamento3.Text;



            // BOTANDO NA LISTA
            Pedido P = new Pedido(txtNome.Text, dtpCalendario.Value);
            //P.Nome = txtNome.Text;
            //P.Data = dtpCalendario.Text;

            P.Expresso = cbCafe1.Checked;
            P.Cleite = cbCafe2.Checked;
            P.Cappuccino = cbCafe3.Checked;
            P.Misto = cbSalgado1.Checked;
            P.Croissant = cbSalgado2.Checked;
            P.Empada = cbSalgado3.Checked;
            P.Maca = cbSalada1.Checked;
            P.Laranja = cbSalada2.Checked;
            P.Morango = cbSalada3.Checked;
            P.Bolo = cbDoce1.Checked;
            P.Brigadeiro = cbDoce2.Checked;
            P.Cocada = cbDoce3.Checked;
            P.Suco = cbBebida1.Checked;
            P.Refri = cbBebida2.Checked;
            P.Agua = cbBebida3.Checked;




            P.PrecoTotal = valorTotal;
            P.FPagamento = pagamento;
            Program.ListaPedido.Add(P);


            

            // REDIRECIONANDO

            var frm2 = new FrmConcluido();
            frm2.AtualizarResumo(P.mostra());
            this.Hide();
            frm2.ShowDialog();
            this.Close();
            Application.Exit();
        }
    }
}
