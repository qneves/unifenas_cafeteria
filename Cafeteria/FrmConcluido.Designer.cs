namespace Cafeteria
{
    partial class FrmConcluido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConcluido));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            lbObgd = new Label();
            pbLogo = new PictureBox();
            txtPassword = new TextBox();
            menuStrip1 = new MenuStrip();
            btnInicio = new ToolStripMenuItem();
            toolStripTextBox3 = new ToolStripTextBox();
            btnPedido = new ToolStripMenuItem();
            toolStripTextBox4 = new ToolStripTextBox();
            btnAdm = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.check;
            pictureBox1.Location = new Point(334, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(253, 342);
            label2.Name = "label2";
            label2.Size = new Size(312, 64);
            label2.TabIndex = 21;
            label2.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed at varius eros, vitae sagittis diam";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(378, 299);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 20;
            label1.Text = "resumo:";
            // 
            // lbObgd
            // 
            lbObgd.AutoSize = true;
            lbObgd.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lbObgd.ForeColor = Color.SaddleBrown;
            lbObgd.Location = new Point(280, 249);
            lbObgd.Name = "lbObgd";
            lbObgd.Size = new Size(258, 40);
            lbObgd.TabIndex = 19;
            lbObgd.Text = "Pedido Concluído !";
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
            pbLogo.TabIndex = 18;
            pbLogo.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(679, 43);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 24;
            txtPassword.Visible = false;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.White;
            menuStrip1.BackgroundImage = Properties.Resources.menu;
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnInicio, toolStripTextBox3, btnPedido, toolStripTextBox4, btnAdm, toolStripMenuItem1, toolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 40);
            menuStrip1.TabIndex = 25;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnInicio
            // 
            btnInicio.AutoSize = false;
            btnInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(120, 36);
            btnInicio.Text = "Início";
            btnInicio.Click += btnInicio_Click;
            // 
            // toolStripTextBox3
            // 
            toolStripTextBox3.AutoSize = false;
            toolStripTextBox3.BackColor = Color.White;
            toolStripTextBox3.BorderStyle = BorderStyle.None;
            toolStripTextBox3.Enabled = false;
            toolStripTextBox3.Margin = new Padding(215, 0, 1, 0);
            toolStripTextBox3.Name = "toolStripTextBox3";
            toolStripTextBox3.Size = new Size(0, 30);
            // 
            // btnPedido
            // 
            btnPedido.AutoSize = false;
            btnPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnPedido.ForeColor = Color.White;
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(120, 36);
            btnPedido.Text = "Realizar Pedido";
            btnPedido.Click += btnPedido_Click;
            // 
            // toolStripTextBox4
            // 
            toolStripTextBox4.AutoSize = false;
            toolStripTextBox4.BackColor = Color.White;
            toolStripTextBox4.BorderStyle = BorderStyle.None;
            toolStripTextBox4.Enabled = false;
            toolStripTextBox4.Margin = new Padding(215, 0, 1, 0);
            toolStripTextBox4.Name = "toolStripTextBox4";
            toolStripTextBox4.Size = new Size(0, 30);
            // 
            // btnAdm
            // 
            btnAdm.AutoSize = false;
            btnAdm.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdm.ForeColor = Color.White;
            btnAdm.Name = "btnAdm";
            btnAdm.Size = new Size(120, 36);
            btnAdm.Text = "Painel";
            btnAdm.Click += btnAdm_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 36);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(12, 36);
            // 
            // FrmConcluido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbObgd);
            Controls.Add(pbLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConcluido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConcluido";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label lbObgd;
        private PictureBox pbLogo;
        private TextBox txtPassword;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnInicio;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripMenuItem btnPedido;
        private ToolStripTextBox toolStripTextBox4;
        private ToolStripMenuItem btnAdm;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}