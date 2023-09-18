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
            clProdutos = new DataGridViewTextBoxColumn();
            clValor = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clNome, clProdutos, clValor });
            dataGridView1.Location = new Point(24, 53);
            dataGridView1.Margin = new Padding(15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(752, 373);
            dataGridView1.TabIndex = 0;
            // 
            // clNome
            // 
            clNome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clNome.HeaderText = "Nome";
            clNome.Name = "clNome";
            // 
            // clProdutos
            // 
            clProdutos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clProdutos.HeaderText = "Produtos";
            clProdutos.Name = "clProdutos";
            // 
            // clValor
            // 
            clValor.HeaderText = "ValorTotal";
            clValor.Name = "clValor";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(343, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
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
            // 
            // Consultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Consultar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clNome;
        private DataGridViewTextBoxColumn clProdutos;
        private DataGridViewTextBoxColumn clValor;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button button1;
    }
}