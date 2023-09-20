namespace Cafeteria
{
    partial class FrmConsultar
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
            dataGridView1 = new DataGridView();
            clNome = new DataGridViewTextBoxColumn();
            clPedido = new DataGridViewTextBoxColumn();
            clValor = new DataGridViewTextBoxColumn();
            dtpConsulta = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clNome, clPedido, clValor });
            dataGridView1.Location = new Point(24, 283);
            dataGridView1.Margin = new Padding(15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(752, 143);
            dataGridView1.TabIndex = 0;
            // 
            // clNome
            // 
            clNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clNome.FillWeight = 61.85567F;
            clNome.HeaderText = "Nome";
            clNome.Name = "clNome";
            // 
            // clPedido
            // 
            clPedido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clPedido.FillWeight = 138.144333F;
            clPedido.HeaderText = "Pedido";
            clPedido.Name = "clPedido";
            // 
            // clValor
            // 
            clValor.HeaderText = "ValorTotal";
            clValor.Name = "clValor";
            // 
            // dtpConsulta
            // 
            dtpConsulta.Location = new Point(343, 12);
            dtpConsulta.Name = "dtpConsulta";
            dtpConsulta.Size = new Size(200, 23);
            dtpConsulta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 18);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 2;
            label1.Text = "Selecione a data para a consulta";
            // 
            // button1
            // 
            button1.Location = new Point(579, 11);
            button1.Name = "button1";
            button1.Size = new Size(88, 28);
            button1.TabIndex = 3;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 148);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // FrmConsultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dtpConsulta);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConsultar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dtpConsulta;
        private Label label1;
        private Button button1;
        private DataGridViewTextBoxColumn clNome;
        private DataGridViewTextBoxColumn clPedido;
        private DataGridViewTextBoxColumn clValor;
        private Label label2;
    }
}