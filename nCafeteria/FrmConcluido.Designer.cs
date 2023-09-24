namespace nCafeteria
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbObgd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResumo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.btnAdm = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(688, 36);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::nCafeteria.Properties.Resources.check;
            this.pictureBox1.Location = new System.Drawing.Point(322, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbObgd
            // 
            this.lbObgd.AutoSize = true;
            this.lbObgd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObgd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbObgd.Location = new System.Drawing.Point(282, 255);
            this.lbObgd.Name = "lbObgd";
            this.lbObgd.Size = new System.Drawing.Size(236, 29);
            this.lbObgd.TabIndex = 3;
            this.lbObgd.Text = "Pedido Concluído !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(362, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Resumo:";
            // 
            // lbResumo
            // 
            this.lbResumo.AutoSize = true;
            this.lbResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResumo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbResumo.Location = new System.Drawing.Point(126, 337);
            this.lbResumo.Name = "lbResumo";
            this.lbResumo.Size = new System.Drawing.Size(554, 16);
            this.lbResumo.TabIndex = 5;
            this.lbResumo.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed at varius eros, vita" +
    "e sagittis diam";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::nCafeteria.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 368);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackgroundImage = global::nCafeteria.Properties.Resources.menu1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.toolStripTextBox1,
            this.btnPedido,
            this.toolStripTextBox2,
            this.btnAdm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnInicio
            // 
            this.btnInicio.AutoSize = false;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(120, 23);
            this.btnInicio.Text = "Início";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(1, 0, 220, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(0, 23);
            // 
            // btnPedido
            // 
            this.btnPedido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.White;
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(115, 26);
            this.btnPedido.Text = "Realizar Pedido";
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.ForeColor = System.Drawing.Color.White;
            this.toolStripTextBox2.Margin = new System.Windows.Forms.Padding(1, 0, 215, 0);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(0, 23);
            // 
            // btnAdm
            // 
            this.btnAdm.AutoSize = false;
            this.btnAdm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.White;
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(120, 23);
            this.btnAdm.Text = "Painel";
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            // 
            // FrmConcluido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbResumo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbObgd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConcluido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumo do Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbObgd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbResumo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnInicio;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem btnPedido;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem btnAdm;
    }
}