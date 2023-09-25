namespace nCafeteria
{
    partial class c
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(c));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.gbCafe = new System.Windows.Forms.GroupBox();
            this.cbCafe3 = new System.Windows.Forms.CheckBox();
            this.cbCafe2 = new System.Windows.Forms.CheckBox();
            this.cbCafe1 = new System.Windows.Forms.CheckBox();
            this.gbDoce = new System.Windows.Forms.GroupBox();
            this.cbDoce3 = new System.Windows.Forms.CheckBox();
            this.cbDoce2 = new System.Windows.Forms.CheckBox();
            this.cbDoce1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSalgado = new System.Windows.Forms.GroupBox();
            this.cbSalgado3 = new System.Windows.Forms.CheckBox();
            this.cbSalgado2 = new System.Windows.Forms.CheckBox();
            this.cbSalgado1 = new System.Windows.Forms.CheckBox();
            this.gbBebida = new System.Windows.Forms.GroupBox();
            this.cbBebida3 = new System.Windows.Forms.CheckBox();
            this.cbBebida2 = new System.Windows.Forms.CheckBox();
            this.cbBebida1 = new System.Windows.Forms.CheckBox();
            this.cbAcucar = new System.Windows.Forms.ComboBox();
            this.gbSalada = new System.Windows.Forms.GroupBox();
            this.cbSalada3 = new System.Windows.Forms.CheckBox();
            this.cbSalada2 = new System.Windows.Forms.CheckBox();
            this.cbSalada1 = new System.Windows.Forms.CheckBox();
            this.gbFPagamento = new System.Windows.Forms.GroupBox();
            this.rbFPagamento2 = new System.Windows.Forms.RadioButton();
            this.rbFPagamento3 = new System.Windows.Forms.RadioButton();
            this.rbFPagamento1 = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.dtpCalendario = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTimer1 = new System.Windows.Forms.Label();
            this.gbCafe.SuspendLayout();
            this.gbDoce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSalgado.SuspendLayout();
            this.gbBebida.SuspendLayout();
            this.gbSalada.SuspendLayout();
            this.gbFPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(199, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbNome.Location = new System.Drawing.Point(20, 7);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(99, 15);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Digite seu Nome";
            // 
            // gbCafe
            // 
            this.gbCafe.Controls.Add(this.cbCafe3);
            this.gbCafe.Controls.Add(this.cbCafe2);
            this.gbCafe.Controls.Add(this.cbCafe1);
            this.gbCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCafe.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbCafe.Location = new System.Drawing.Point(17, 65);
            this.gbCafe.Name = "gbCafe";
            this.gbCafe.Size = new System.Drawing.Size(200, 138);
            this.gbCafe.TabIndex = 2;
            this.gbCafe.TabStop = false;
            this.gbCafe.Text = "Café";
            // 
            // cbCafe3
            // 
            this.cbCafe3.AutoSize = true;
            this.cbCafe3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbCafe3.Location = new System.Drawing.Point(11, 100);
            this.cbCafe3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbCafe3.Name = "cbCafe3";
            this.cbCafe3.Size = new System.Drawing.Size(137, 19);
            this.cbCafe3.TabIndex = 2;
            this.cbCafe3.Text = "R$ 7,00 | Cappucino";
            this.cbCafe3.UseVisualStyleBackColor = true;
            // 
            // cbCafe2
            // 
            this.cbCafe2.AutoSize = true;
            this.cbCafe2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbCafe2.Location = new System.Drawing.Point(13, 64);
            this.cbCafe2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbCafe2.Name = "cbCafe2";
            this.cbCafe2.Size = new System.Drawing.Size(163, 19);
            this.cbCafe2.TabIndex = 1;
            this.cbCafe2.Text = "R$ 5,00 |  Café com Leite";
            this.cbCafe2.UseVisualStyleBackColor = true;
            // 
            // cbCafe1
            // 
            this.cbCafe1.AutoSize = true;
            this.cbCafe1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbCafe1.Location = new System.Drawing.Point(13, 29);
            this.cbCafe1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbCafe1.Name = "cbCafe1";
            this.cbCafe1.Size = new System.Drawing.Size(157, 19);
            this.cbCafe1.TabIndex = 0;
            this.cbCafe1.Text = "R$ 3,00 | Café Expresso";
            this.cbCafe1.UseVisualStyleBackColor = true;
            // 
            // gbDoce
            // 
            this.gbDoce.Controls.Add(this.cbDoce3);
            this.gbDoce.Controls.Add(this.cbDoce2);
            this.gbDoce.Controls.Add(this.cbDoce1);
            this.gbDoce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDoce.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbDoce.Location = new System.Drawing.Point(17, 216);
            this.gbDoce.Name = "gbDoce";
            this.gbDoce.Size = new System.Drawing.Size(200, 138);
            this.gbDoce.TabIndex = 3;
            this.gbDoce.TabStop = false;
            this.gbDoce.Text = "Doce";
            // 
            // cbDoce3
            // 
            this.cbDoce3.AutoSize = true;
            this.cbDoce3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbDoce3.Location = new System.Drawing.Point(11, 100);
            this.cbDoce3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbDoce3.Name = "cbDoce3";
            this.cbDoce3.Size = new System.Drawing.Size(120, 19);
            this.cbDoce3.TabIndex = 2;
            this.cbDoce3.Text = "R$ 3,00 | Cocada";
            this.cbDoce3.UseVisualStyleBackColor = true;
            // 
            // cbDoce2
            // 
            this.cbDoce2.AutoSize = true;
            this.cbDoce2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbDoce2.Location = new System.Drawing.Point(13, 64);
            this.cbDoce2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbDoce2.Name = "cbDoce2";
            this.cbDoce2.Size = new System.Drawing.Size(135, 19);
            this.cbDoce2.TabIndex = 1;
            this.cbDoce2.Text = "R$ 2,50 | Brigadeiro";
            this.cbDoce2.UseVisualStyleBackColor = true;
            // 
            // cbDoce1
            // 
            this.cbDoce1.AutoSize = true;
            this.cbDoce1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbDoce1.Location = new System.Drawing.Point(13, 29);
            this.cbDoce1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbDoce1.Name = "cbDoce1";
            this.cbDoce1.Size = new System.Drawing.Size(103, 19);
            this.cbDoce1.TabIndex = 0;
            this.cbDoce1.Text = "R$ 5,00 | Bolo";
            this.cbDoce1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::nCafeteria.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // gbSalgado
            // 
            this.gbSalgado.Controls.Add(this.cbSalgado3);
            this.gbSalgado.Controls.Add(this.cbSalgado2);
            this.gbSalgado.Controls.Add(this.cbSalgado1);
            this.gbSalgado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalgado.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbSalgado.Location = new System.Drawing.Point(284, 65);
            this.gbSalgado.Name = "gbSalgado";
            this.gbSalgado.Size = new System.Drawing.Size(200, 138);
            this.gbSalgado.TabIndex = 4;
            this.gbSalgado.TabStop = false;
            this.gbSalgado.Text = "Salgado";
            // 
            // cbSalgado3
            // 
            this.cbSalgado3.AutoSize = true;
            this.cbSalgado3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbSalgado3.Location = new System.Drawing.Point(11, 100);
            this.cbSalgado3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbSalgado3.Name = "cbSalgado3";
            this.cbSalgado3.Size = new System.Drawing.Size(125, 19);
            this.cbSalgado3.TabIndex = 2;
            this.cbSalgado3.Text = "R$ 7,00 | Empada";
            this.cbSalgado3.UseVisualStyleBackColor = true;
            // 
            // cbSalgado2
            // 
            this.cbSalgado2.AutoSize = true;
            this.cbSalgado2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbSalgado2.Location = new System.Drawing.Point(13, 64);
            this.cbSalgado2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbSalgado2.Name = "cbSalgado2";
            this.cbSalgado2.Size = new System.Drawing.Size(129, 19);
            this.cbSalgado2.TabIndex = 1;
            this.cbSalgado2.Text = "R$ 5,00 | Croissant";
            this.cbSalgado2.UseVisualStyleBackColor = true;
            // 
            // cbSalgado1
            // 
            this.cbSalgado1.AutoSize = true;
            this.cbSalgado1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbSalgado1.Location = new System.Drawing.Point(13, 29);
            this.cbSalgado1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbSalgado1.Name = "cbSalgado1";
            this.cbSalgado1.Size = new System.Drawing.Size(151, 19);
            this.cbSalgado1.TabIndex = 0;
            this.cbSalgado1.Text = "R$ 3,00 | Misto Quente";
            this.cbSalgado1.UseVisualStyleBackColor = true;
            // 
            // gbBebida
            // 
            this.gbBebida.Controls.Add(this.cbBebida3);
            this.gbBebida.Controls.Add(this.cbBebida2);
            this.gbBebida.Controls.Add(this.cbBebida1);
            this.gbBebida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBebida.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbBebida.Location = new System.Drawing.Point(284, 216);
            this.gbBebida.Name = "gbBebida";
            this.gbBebida.Size = new System.Drawing.Size(200, 138);
            this.gbBebida.TabIndex = 5;
            this.gbBebida.TabStop = false;
            this.gbBebida.Text = "Outras Bebidas";
            // 
            // cbBebida3
            // 
            this.cbBebida3.AutoSize = true;
            this.cbBebida3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbBebida3.Location = new System.Drawing.Point(11, 100);
            this.cbBebida3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbBebida3.Name = "cbBebida3";
            this.cbBebida3.Size = new System.Drawing.Size(106, 19);
            this.cbBebida3.TabIndex = 2;
            this.cbBebida3.Text = "R$ 2,00 | Água";
            this.cbBebida3.UseVisualStyleBackColor = true;
            // 
            // cbBebida2
            // 
            this.cbBebida2.AutoSize = true;
            this.cbBebida2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbBebida2.Location = new System.Drawing.Point(13, 64);
            this.cbBebida2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbBebida2.Name = "cbBebida2";
            this.cbBebida2.Size = new System.Drawing.Size(131, 19);
            this.cbBebida2.TabIndex = 1;
            this.cbBebida2.Text = "R$ 5,00 | Refri Lata";
            this.cbBebida2.UseVisualStyleBackColor = true;
            // 
            // cbBebida1
            // 
            this.cbBebida1.AutoSize = true;
            this.cbBebida1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbBebida1.Location = new System.Drawing.Point(13, 29);
            this.cbBebida1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbBebida1.Name = "cbBebida1";
            this.cbBebida1.Size = new System.Drawing.Size(106, 19);
            this.cbBebida1.TabIndex = 0;
            this.cbBebida1.Text = "R$ 6,00 | Suco";
            this.cbBebida1.UseVisualStyleBackColor = true;
            // 
            // cbAcucar
            // 
            this.cbAcucar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcucar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAcucar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbAcucar.FormattingEnabled = true;
            this.cbAcucar.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbAcucar.Location = new System.Drawing.Point(284, 392);
            this.cbAcucar.Name = "cbAcucar";
            this.cbAcucar.Size = new System.Drawing.Size(200, 23);
            this.cbAcucar.TabIndex = 6;
            // 
            // gbSalada
            // 
            this.gbSalada.Controls.Add(this.cbSalada3);
            this.gbSalada.Controls.Add(this.cbSalada2);
            this.gbSalada.Controls.Add(this.cbSalada1);
            this.gbSalada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSalada.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbSalada.Location = new System.Drawing.Point(557, 65);
            this.gbSalada.Name = "gbSalada";
            this.gbSalada.Size = new System.Drawing.Size(200, 138);
            this.gbSalada.TabIndex = 6;
            this.gbSalada.TabStop = false;
            this.gbSalada.Text = "Salada de Frutas";
            // 
            // cbSalada3
            // 
            this.cbSalada3.AutoSize = true;
            this.cbSalada3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbSalada3.Location = new System.Drawing.Point(11, 100);
            this.cbSalada3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbSalada3.Name = "cbSalada3";
            this.cbSalada3.Size = new System.Drawing.Size(128, 19);
            this.cbSalada3.TabIndex = 2;
            this.cbSalada3.Text = "R$ 3,00 | Morango";
            this.cbSalada3.UseVisualStyleBackColor = true;
            // 
            // cbSalada2
            // 
            this.cbSalada2.AutoSize = true;
            this.cbSalada2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbSalada2.Location = new System.Drawing.Point(13, 64);
            this.cbSalada2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbSalada2.Name = "cbSalada2";
            this.cbSalada2.Size = new System.Drawing.Size(120, 19);
            this.cbSalada2.TabIndex = 1;
            this.cbSalada2.Text = "R$ 3,00 | Laranja";
            this.cbSalada2.UseVisualStyleBackColor = true;
            // 
            // cbSalada1
            // 
            this.cbSalada1.AutoSize = true;
            this.cbSalada1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbSalada1.Location = new System.Drawing.Point(13, 29);
            this.cbSalada1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.cbSalada1.Name = "cbSalada1";
            this.cbSalada1.Size = new System.Drawing.Size(109, 19);
            this.cbSalada1.TabIndex = 0;
            this.cbSalada1.Text = "R$ 3,00 | Maçã";
            this.cbSalada1.UseVisualStyleBackColor = true;
            // 
            // gbFPagamento
            // 
            this.gbFPagamento.BackColor = System.Drawing.Color.Honeydew;
            this.gbFPagamento.Controls.Add(this.rbFPagamento2);
            this.gbFPagamento.Controls.Add(this.rbFPagamento3);
            this.gbFPagamento.Controls.Add(this.rbFPagamento1);
            this.gbFPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFPagamento.ForeColor = System.Drawing.Color.SaddleBrown;
            this.gbFPagamento.Location = new System.Drawing.Point(557, 216);
            this.gbFPagamento.Name = "gbFPagamento";
            this.gbFPagamento.Size = new System.Drawing.Size(200, 138);
            this.gbFPagamento.TabIndex = 12;
            this.gbFPagamento.TabStop = false;
            this.gbFPagamento.Text = "Forma de Pagamento";
            // 
            // rbFPagamento2
            // 
            this.rbFPagamento2.AutoSize = true;
            this.rbFPagamento2.Location = new System.Drawing.Point(13, 64);
            this.rbFPagamento2.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.rbFPagamento2.Name = "rbFPagamento2";
            this.rbFPagamento2.Size = new System.Drawing.Size(73, 19);
            this.rbFPagamento2.TabIndex = 5;
            this.rbFPagamento2.TabStop = true;
            this.rbFPagamento2.Text = "c/ Débito";
            this.rbFPagamento2.UseVisualStyleBackColor = true;
            // 
            // rbFPagamento3
            // 
            this.rbFPagamento3.AutoSize = true;
            this.rbFPagamento3.Location = new System.Drawing.Point(13, 94);
            this.rbFPagamento3.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.rbFPagamento3.Name = "rbFPagamento3";
            this.rbFPagamento3.Size = new System.Drawing.Size(76, 19);
            this.rbFPagamento3.TabIndex = 4;
            this.rbFPagamento3.TabStop = true;
            this.rbFPagamento3.Text = "c/ Crédito";
            this.rbFPagamento3.UseVisualStyleBackColor = true;
            // 
            // rbFPagamento1
            // 
            this.rbFPagamento1.AutoSize = true;
            this.rbFPagamento1.Location = new System.Drawing.Point(13, 34);
            this.rbFPagamento1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.rbFPagamento1.Name = "rbFPagamento1";
            this.rbFPagamento1.Size = new System.Drawing.Size(72, 19);
            this.rbFPagamento1.TabIndex = 3;
            this.rbFPagamento1.TabStop = true;
            this.rbFPagamento1.Text = "Dinheiro";
            this.rbFPagamento1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(557, 387);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 40);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar Pedido";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Green;
            this.btnFinalizar.Location = new System.Drawing.Point(662, 387);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(95, 40);
            this.btnFinalizar.TabIndex = 14;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbTimer.Location = new System.Drawing.Point(94, 401);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(0, 15);
            this.lbTimer.TabIndex = 15;
            // 
            // dtpCalendario
            // 
            this.dtpCalendario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCalendario.Location = new System.Drawing.Point(557, 24);
            this.dtpCalendario.Name = "dtpCalendario";
            this.dtpCalendario.Size = new System.Drawing.Size(200, 20);
            this.dtpCalendario.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(282, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Gostaria de Açúcar?";
            // 
            // lbTimer1
            // 
            this.lbTimer1.AutoSize = true;
            this.lbTimer1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbTimer1.Location = new System.Drawing.Point(100, 393);
            this.lbTimer1.Name = "lbTimer1";
            this.lbTimer1.Size = new System.Drawing.Size(0, 21);
            this.lbTimer1.TabIndex = 18;
            // 
            // c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTimer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCalendario);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbFPagamento);
            this.Controls.Add(this.gbSalada);
            this.Controls.Add(this.cbAcucar);
            this.Controls.Add(this.gbBebida);
            this.Controls.Add(this.gbSalgado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbDoce);
            this.Controls.Add(this.gbCafe);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "c";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.gbCafe.ResumeLayout(false);
            this.gbCafe.PerformLayout();
            this.gbDoce.ResumeLayout(false);
            this.gbDoce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSalgado.ResumeLayout(false);
            this.gbSalgado.PerformLayout();
            this.gbBebida.ResumeLayout(false);
            this.gbBebida.PerformLayout();
            this.gbSalada.ResumeLayout(false);
            this.gbSalada.PerformLayout();
            this.gbFPagamento.ResumeLayout(false);
            this.gbFPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.GroupBox gbCafe;
        private System.Windows.Forms.CheckBox cbCafe1;
        private System.Windows.Forms.CheckBox cbCafe3;
        private System.Windows.Forms.CheckBox cbCafe2;
        private System.Windows.Forms.GroupBox gbDoce;
        private System.Windows.Forms.CheckBox cbDoce3;
        private System.Windows.Forms.CheckBox cbDoce2;
        private System.Windows.Forms.CheckBox cbDoce1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbSalgado;
        private System.Windows.Forms.CheckBox cbSalgado3;
        private System.Windows.Forms.CheckBox cbSalgado2;
        private System.Windows.Forms.CheckBox cbSalgado1;
        private System.Windows.Forms.GroupBox gbBebida;
        private System.Windows.Forms.CheckBox cbBebida3;
        private System.Windows.Forms.CheckBox cbBebida2;
        private System.Windows.Forms.CheckBox cbBebida1;
        private System.Windows.Forms.ComboBox cbAcucar;
        private System.Windows.Forms.GroupBox gbSalada;
        private System.Windows.Forms.CheckBox cbSalada3;
        private System.Windows.Forms.CheckBox cbSalada2;
        private System.Windows.Forms.CheckBox cbSalada1;
        private System.Windows.Forms.GroupBox gbFPagamento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.DateTimePicker dtpCalendario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFPagamento2;
        private System.Windows.Forms.RadioButton rbFPagamento3;
        private System.Windows.Forms.RadioButton rbFPagamento1;
        private System.Windows.Forms.Label lbTimer1;
    }
}