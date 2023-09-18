namespace Cafeteria
{
    partial class FrmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            gbSalgado = new GroupBox();
            cbSalgado3 = new CheckBox();
            cbSalgado2 = new CheckBox();
            cbSalgado1 = new CheckBox();
            gbCafe = new GroupBox();
            cbCafe3 = new CheckBox();
            cbCafe2 = new CheckBox();
            cbCafe1 = new CheckBox();
            btnCancelar = new Button();
            btnFinalizar = new Button();
            txtNome = new TextBox();
            lbNome = new Label();
            dtpCalendario = new DateTimePicker();
            pbLogo = new PictureBox();
            gbSalada = new GroupBox();
            cbSalada3 = new CheckBox();
            cbSalada2 = new CheckBox();
            cbSalada1 = new CheckBox();
            gbBebida = new GroupBox();
            cbBebida3 = new CheckBox();
            cbBebida2 = new CheckBox();
            cbBebida1 = new CheckBox();
            gbFPagamento = new GroupBox();
            rbFPagamento3 = new RadioButton();
            rbFPagamento2 = new RadioButton();
            rbFPagamento1 = new RadioButton();
            gbDoce = new GroupBox();
            cbDoce3 = new CheckBox();
            cbDoce2 = new CheckBox();
            cbDoce1 = new CheckBox();
            cbAcucar = new ComboBox();
            timer = new System.Windows.Forms.Timer(components);
            lbTimer = new Label();
            gbSalgado.SuspendLayout();
            gbCafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbSalada.SuspendLayout();
            gbBebida.SuspendLayout();
            gbFPagamento.SuspendLayout();
            gbDoce.SuspendLayout();
            SuspendLayout();
            // 
            // gbSalgado
            // 
            gbSalgado.Controls.Add(cbSalgado3);
            gbSalgado.Controls.Add(cbSalgado2);
            gbSalgado.Controls.Add(cbSalgado1);
            gbSalgado.ForeColor = Color.SaddleBrown;
            gbSalgado.Location = new Point(283, 68);
            gbSalgado.Name = "gbSalgado";
            gbSalgado.Size = new Size(200, 138);
            gbSalgado.TabIndex = 8;
            gbSalgado.TabStop = false;
            gbSalgado.Text = "Salgado";
            // 
            // cbSalgado3
            // 
            cbSalgado3.AutoSize = true;
            cbSalgado3.Location = new Point(15, 104);
            cbSalgado3.Name = "cbSalgado3";
            cbSalgado3.Size = new Size(69, 19);
            cbSalgado3.TabIndex = 2;
            cbSalgado3.Text = "Empada";
            cbSalgado3.UseVisualStyleBackColor = true;
            // 
            // cbSalgado2
            // 
            cbSalgado2.AutoSize = true;
            cbSalgado2.Location = new Point(15, 68);
            cbSalgado2.Name = "cbSalgado2";
            cbSalgado2.Size = new Size(75, 19);
            cbSalgado2.TabIndex = 1;
            cbSalgado2.Text = "Croissant";
            cbSalgado2.UseVisualStyleBackColor = true;
            // 
            // cbSalgado1
            // 
            cbSalgado1.AutoSize = true;
            cbSalgado1.Location = new Point(15, 32);
            cbSalgado1.Name = "cbSalgado1";
            cbSalgado1.Size = new Size(98, 19);
            cbSalgado1.TabIndex = 0;
            cbSalgado1.Text = "Misto Quente";
            cbSalgado1.UseVisualStyleBackColor = true;
            // 
            // gbCafe
            // 
            gbCafe.Controls.Add(cbCafe3);
            gbCafe.Controls.Add(cbCafe2);
            gbCafe.Controls.Add(cbCafe1);
            gbCafe.ForeColor = Color.SaddleBrown;
            gbCafe.Location = new Point(12, 68);
            gbCafe.Name = "gbCafe";
            gbCafe.Size = new Size(200, 138);
            gbCafe.TabIndex = 7;
            gbCafe.TabStop = false;
            gbCafe.Text = "Café";
            // 
            // cbCafe3
            // 
            cbCafe3.AutoSize = true;
            cbCafe3.Location = new Point(19, 104);
            cbCafe3.Name = "cbCafe3";
            cbCafe3.Size = new Size(90, 19);
            cbCafe3.TabIndex = 2;
            cbCafe3.Text = "Cappuccino";
            cbCafe3.UseVisualStyleBackColor = true;
            // 
            // cbCafe2
            // 
            cbCafe2.AutoSize = true;
            cbCafe2.Location = new Point(19, 68);
            cbCafe2.Name = "cbCafe2";
            cbCafe2.Size = new Size(105, 19);
            cbCafe2.TabIndex = 1;
            cbCafe2.Text = "Café com Leite";
            cbCafe2.UseVisualStyleBackColor = true;
            // 
            // cbCafe1
            // 
            cbCafe1.AutoSize = true;
            cbCafe1.Location = new Point(19, 32);
            cbCafe1.Name = "cbCafe1";
            cbCafe1.Size = new Size(99, 19);
            cbCafe1.TabIndex = 0;
            cbCafe1.Text = "Café Expresso";
            cbCafe1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.FromArgb(255, 128, 128);
            btnCancelar.Location = new Point(547, 400);
            btnCancelar.Margin = new Padding(5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 33);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar Pedido";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.ForeColor = Color.Green;
            btnFinalizar.Location = new Point(665, 400);
            btnFinalizar.Margin = new Padding(5);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(112, 33);
            btnFinalizar.TabIndex = 5;
            btnFinalizar.Text = "Finalizar Pedido";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 4;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.ForeColor = Color.SaddleBrown;
            lbNome.Location = new Point(12, 9);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(95, 15);
            lbNome.TabIndex = 3;
            lbNome.Text = "Digite seu Nome";
            // 
            // dtpCalendario
            // 
            dtpCalendario.CalendarForeColor = Color.SaddleBrown;
            dtpCalendario.CalendarMonthBackground = Color.SaddleBrown;
            dtpCalendario.CalendarTitleBackColor = Color.SaddleBrown;
            dtpCalendario.CalendarTitleForeColor = Color.SaddleBrown;
            dtpCalendario.CalendarTrailingForeColor = Color.SaddleBrown;
            dtpCalendario.Enabled = false;
            dtpCalendario.Format = DateTimePickerFormat.Short;
            dtpCalendario.Location = new Point(562, 27);
            dtpCalendario.Name = "dtpCalendario";
            dtpCalendario.Size = new Size(200, 23);
            dtpCalendario.TabIndex = 11;
            // 
            // pbLogo
            // 
            pbLogo.ErrorImage = Properties.Resources.logo;
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.InitialImage = Properties.Resources.logo;
            pbLogo.Location = new Point(12, 368);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(70, 70);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 12;
            pbLogo.TabStop = false;
            // 
            // gbSalada
            // 
            gbSalada.Controls.Add(cbSalada3);
            gbSalada.Controls.Add(cbSalada2);
            gbSalada.Controls.Add(cbSalada1);
            gbSalada.ForeColor = Color.SaddleBrown;
            gbSalada.Location = new Point(562, 68);
            gbSalada.Name = "gbSalada";
            gbSalada.Size = new Size(200, 138);
            gbSalada.TabIndex = 9;
            gbSalada.TabStop = false;
            gbSalada.Text = "Salada de Frutas";
            // 
            // cbSalada3
            // 
            cbSalada3.AutoSize = true;
            cbSalada3.Location = new Point(15, 104);
            cbSalada3.Name = "cbSalada3";
            cbSalada3.Size = new Size(75, 19);
            cbSalada3.TabIndex = 2;
            cbSalada3.Text = "Morango";
            cbSalada3.UseVisualStyleBackColor = true;
            // 
            // cbSalada2
            // 
            cbSalada2.AutoSize = true;
            cbSalada2.Location = new Point(15, 68);
            cbSalada2.Name = "cbSalada2";
            cbSalada2.Size = new Size(64, 19);
            cbSalada2.TabIndex = 1;
            cbSalada2.Text = "Laranja";
            cbSalada2.UseVisualStyleBackColor = true;
            // 
            // cbSalada1
            // 
            cbSalada1.AutoSize = true;
            cbSalada1.Location = new Point(15, 32);
            cbSalada1.Name = "cbSalada1";
            cbSalada1.Size = new Size(55, 19);
            cbSalada1.TabIndex = 0;
            cbSalada1.Text = "Maçã";
            cbSalada1.UseVisualStyleBackColor = true;
            // 
            // gbBebida
            // 
            gbBebida.Controls.Add(cbBebida3);
            gbBebida.Controls.Add(cbBebida2);
            gbBebida.Controls.Add(cbBebida1);
            gbBebida.ForeColor = Color.SaddleBrown;
            gbBebida.Location = new Point(283, 212);
            gbBebida.Name = "gbBebida";
            gbBebida.Size = new Size(200, 138);
            gbBebida.TabIndex = 9;
            gbBebida.TabStop = false;
            gbBebida.Text = "Outras Bebidas";
            // 
            // cbBebida3
            // 
            cbBebida3.AutoSize = true;
            cbBebida3.Location = new Point(15, 104);
            cbBebida3.Name = "cbBebida3";
            cbBebida3.Size = new Size(54, 19);
            cbBebida3.TabIndex = 2;
            cbBebida3.Text = "Água";
            cbBebida3.UseVisualStyleBackColor = true;
            // 
            // cbBebida2
            // 
            cbBebida2.AutoSize = true;
            cbBebida2.Location = new Point(15, 68);
            cbBebida2.Name = "cbBebida2";
            cbBebida2.Size = new Size(75, 19);
            cbBebida2.TabIndex = 1;
            cbBebida2.Text = "Refri Lata";
            cbBebida2.UseVisualStyleBackColor = true;
            // 
            // cbBebida1
            // 
            cbBebida1.AutoSize = true;
            cbBebida1.Location = new Point(15, 32);
            cbBebida1.Name = "cbBebida1";
            cbBebida1.Size = new Size(52, 19);
            cbBebida1.TabIndex = 0;
            cbBebida1.Text = "Suco";
            cbBebida1.UseVisualStyleBackColor = true;
            // 
            // gbFPagamento
            // 
            gbFPagamento.BackColor = Color.Honeydew;
            gbFPagamento.Controls.Add(rbFPagamento3);
            gbFPagamento.Controls.Add(rbFPagamento2);
            gbFPagamento.Controls.Add(rbFPagamento1);
            gbFPagamento.ForeColor = Color.SaddleBrown;
            gbFPagamento.Location = new Point(562, 212);
            gbFPagamento.Name = "gbFPagamento";
            gbFPagamento.Size = new Size(200, 138);
            gbFPagamento.TabIndex = 11;
            gbFPagamento.TabStop = false;
            gbFPagamento.Text = "Forma de Pagamento";
            // 
            // rbFPagamento3
            // 
            rbFPagamento3.AutoSize = true;
            rbFPagamento3.Location = new Point(19, 104);
            rbFPagamento3.Name = "rbFPagamento3";
            rbFPagamento3.Size = new Size(80, 19);
            rbFPagamento3.TabIndex = 2;
            rbFPagamento3.TabStop = true;
            rbFPagamento3.Text = "C/ Crédito";
            rbFPagamento3.UseVisualStyleBackColor = true;
            // 
            // rbFPagamento2
            // 
            rbFPagamento2.AutoSize = true;
            rbFPagamento2.Location = new Point(19, 68);
            rbFPagamento2.Name = "rbFPagamento2";
            rbFPagamento2.Size = new Size(76, 19);
            rbFPagamento2.TabIndex = 1;
            rbFPagamento2.TabStop = true;
            rbFPagamento2.Text = "C/ Débito";
            rbFPagamento2.UseVisualStyleBackColor = true;
            // 
            // rbFPagamento1
            // 
            rbFPagamento1.AutoSize = true;
            rbFPagamento1.Location = new Point(19, 32);
            rbFPagamento1.Name = "rbFPagamento1";
            rbFPagamento1.Size = new Size(70, 19);
            rbFPagamento1.TabIndex = 0;
            rbFPagamento1.TabStop = true;
            rbFPagamento1.Text = "Dinheiro";
            rbFPagamento1.UseVisualStyleBackColor = true;
            // 
            // gbDoce
            // 
            gbDoce.Controls.Add(cbDoce3);
            gbDoce.Controls.Add(cbDoce2);
            gbDoce.Controls.Add(cbDoce1);
            gbDoce.ForeColor = Color.SaddleBrown;
            gbDoce.Location = new Point(12, 212);
            gbDoce.Name = "gbDoce";
            gbDoce.Size = new Size(200, 138);
            gbDoce.TabIndex = 10;
            gbDoce.TabStop = false;
            gbDoce.Text = "Doce";
            // 
            // cbDoce3
            // 
            cbDoce3.AutoSize = true;
            cbDoce3.Location = new Point(15, 104);
            cbDoce3.Name = "cbDoce3";
            cbDoce3.Size = new Size(66, 19);
            cbDoce3.TabIndex = 2;
            cbDoce3.Text = "Cocada";
            cbDoce3.UseVisualStyleBackColor = true;
            // 
            // cbDoce2
            // 
            cbDoce2.AutoSize = true;
            cbDoce2.Location = new Point(15, 68);
            cbDoce2.Name = "cbDoce2";
            cbDoce2.Size = new Size(80, 19);
            cbDoce2.TabIndex = 1;
            cbDoce2.Text = "Brigadeiro";
            cbDoce2.UseVisualStyleBackColor = true;
            // 
            // cbDoce1
            // 
            cbDoce1.AutoSize = true;
            cbDoce1.Location = new Point(15, 32);
            cbDoce1.Name = "cbDoce1";
            cbDoce1.Size = new Size(50, 19);
            cbDoce1.TabIndex = 0;
            cbDoce1.Text = "Bolo";
            cbDoce1.UseVisualStyleBackColor = true;
            // 
            // cbAcucar
            // 
            cbAcucar.ForeColor = Color.SaddleBrown;
            cbAcucar.FormattingEnabled = true;
            cbAcucar.Items.AddRange(new object[] { "Sim", "Não" });
            cbAcucar.Location = new Point(283, 363);
            cbAcucar.Name = "cbAcucar";
            cbAcucar.Size = new Size(200, 23);
            cbAcucar.TabIndex = 13;
            cbAcucar.Text = "Gostaria de Açúcar?";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1;
            timer.Tick += timer_Tick;
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.ForeColor = Color.SaddleBrown;
            lbTimer.Location = new Point(93, 394);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(0, 15);
            lbTimer.TabIndex = 14;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lbTimer);
            Controls.Add(cbAcucar);
            Controls.Add(gbDoce);
            Controls.Add(gbFPagamento);
            Controls.Add(gbBebida);
            Controls.Add(gbSalada);
            Controls.Add(pbLogo);
            Controls.Add(dtpCalendario);
            Controls.Add(gbCafe);
            Controls.Add(gbSalgado);
            Controls.Add(lbNome);
            Controls.Add(txtNome);
            Controls.Add(btnCancelar);
            Controls.Add(btnFinalizar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPedido";
            StartPosition = FormStartPosition.CenterScreen;
            gbSalgado.ResumeLayout(false);
            gbSalgado.PerformLayout();
            gbCafe.ResumeLayout(false);
            gbCafe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbSalada.ResumeLayout(false);
            gbSalada.PerformLayout();
            gbBebida.ResumeLayout(false);
            gbBebida.PerformLayout();
            gbFPagamento.ResumeLayout(false);
            gbFPagamento.PerformLayout();
            gbDoce.ResumeLayout(false);
            gbDoce.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox gbSalgado;
        private GroupBox gbCafe;
        private Button btnCancelar;
        private Button btnFinalizar;
        private TextBox txtNome;
        private Label lbNome;
        private CheckBox cbSalgado3;
        private CheckBox cbSalgado2;
        private CheckBox cbSalgado1;
        private CheckBox cbCafe3;
        private CheckBox cbCafe2;
        private CheckBox cbCafe1;
        private DateTimePicker dtpCalendario;
        private PictureBox pbLogo;
        private GroupBox gbSalada;
        private CheckBox cbSalada3;
        private CheckBox cbSalada2;
        private CheckBox cbSalada1;
        private GroupBox gbBebida;
        private CheckBox cbBebida3;
        private CheckBox cbBebida2;
        private CheckBox cbBebida1;
        private GroupBox gbFPagamento;
        private RadioButton rbFPagamento3;
        private RadioButton rbFPagamento2;
        private RadioButton rbFPagamento1;
        private GroupBox gbDoce;
        private CheckBox cbDoce3;
        private CheckBox cbDoce2;
        private CheckBox cbDoce1;
        private ComboBox cbAcucar;
        private System.Windows.Forms.Timer timer;
        private Label lbTimer;
    }
}