namespace Cafeteria
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtPassword = new TextBox();
            menuStrip1 = new MenuStrip();
            btnInicio = new ToolStripMenuItem();
            toolStripTextBox3 = new ToolStripTextBox();
            btnPedido = new ToolStripMenuItem();
            toolStripTextBox4 = new ToolStripTextBox();
            btnAdm = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(253, 77);
            label1.Name = "label1";
            label1.Size = new Size(295, 54);
            label1.TabIndex = 2;
            label1.Text = "Cafeteria dos Zé";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.logo;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.InitialImage = Properties.Resources.logo;
            pictureBox1.Location = new Point(245, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(678, 43);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(120, 23);
            txtPassword.TabIndex = 3;
            txtPassword.TextAlign = HorizontalAlignment.Center;
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
            menuStrip1.TabIndex = 1;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(169, 377);
            label2.Name = "label2";
            label2.Size = new Size(452, 40);
            label2.TabIndex = 5;
            label2.Text = "Seja bem-vindo a nossa Cafeteria!!";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInicio";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnInicio;
        private ToolStripMenuItem btnPedido;
        private ToolStripMenuItem btnAdm;
        private ToolStripTextBox toolStripTextBox3;
        private ToolStripTextBox toolStripTextBox4;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label label2;
    }
}