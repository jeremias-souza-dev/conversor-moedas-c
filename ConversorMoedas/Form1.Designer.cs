namespace ConversorMoedas
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            panelInputs = new TableLayoutPanel();
            lblValor = new Label();
            txtValor = new TextBox();
            lblOrigem = new Label();
            cmbOrigem = new ComboBox();
            lblDestino = new Label();
            cmbDestino = new ComboBox();
            btnConverter = new Button();
            lblResultado = new Label();
            panelInputs.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(20, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(360, 56);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Conversor de Moedas";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelInputs
            // 
            panelInputs.ColumnCount = 2;
            panelInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            panelInputs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            panelInputs.Controls.Add(lblValor, 0, 0);
            panelInputs.Controls.Add(txtValor, 1, 0);
            panelInputs.Controls.Add(lblOrigem, 0, 1);
            panelInputs.Controls.Add(cmbOrigem, 1, 1);
            panelInputs.Controls.Add(lblDestino, 0, 2);
            panelInputs.Controls.Add(cmbDestino, 1, 2);
            panelInputs.Location = new Point(20, 100);
            panelInputs.Margin = new Padding(3, 4, 3, 4);
            panelInputs.Name = "panelInputs";
            panelInputs.Padding = new Padding(5, 6, 5, 6);
            panelInputs.RowCount = 3;
            panelInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            panelInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            panelInputs.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            panelInputs.Size = new Size(360, 188);
            panelInputs.TabIndex = 1;
            // 
            // lblValor
            // 
            lblValor.Anchor = AnchorStyles.Left;
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 10F);
            lblValor.Location = new Point(8, 23);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(53, 23);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtValor.Font = new Font("Segoe UI", 10F);
            txtValor.Location = new Point(113, 20);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(239, 30);
            txtValor.TabIndex = 1;
            // 
            // lblOrigem
            // 
            lblOrigem.Anchor = AnchorStyles.Left;
            lblOrigem.AutoSize = true;
            lblOrigem.Font = new Font("Segoe UI", 10F);
            lblOrigem.Location = new Point(8, 70);
            lblOrigem.Name = "lblOrigem";
            lblOrigem.Size = new Size(67, 46);
            lblOrigem.TabIndex = 2;
            lblOrigem.Text = "De (ex: BRL)";
            // 
            // cmbOrigem
            // 
            cmbOrigem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbOrigem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigem.Font = new Font("Segoe UI", 10F);
            cmbOrigem.FormattingEnabled = true;
            cmbOrigem.Items.AddRange(new object[] { "BRL - Real Brasileiro", "USD - Dólar Americano", "EUR - Euro", "GBP - Libra Esterlina", "JPY - Iene Japonês", "AUD - Dólar Australiano", "CAD - Dólar Canadense", "CHF - Franco Suíço", "CNY - Yuan Chinês", "ARS - Peso Argentino", "MXN - Peso Mexicano", "CLP - Peso Chileno", "ZAR - Rand Sul-Africano", "NZD - Dólar Neozelandês", "TRY - Lira Turca" });
            cmbOrigem.Location = new Point(113, 77);
            cmbOrigem.Margin = new Padding(3, 4, 3, 4);
            cmbOrigem.Name = "cmbOrigem";
            cmbOrigem.Size = new Size(239, 31);
            cmbOrigem.TabIndex = 3;
            // 
            // lblDestino
            // 
            lblDestino.Anchor = AnchorStyles.Left;
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 10F);
            lblDestino.Location = new Point(8, 129);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(79, 46);
            lblDestino.TabIndex = 4;
            lblDestino.Text = "Para (ex: USD)";
            // 
            // cmbDestino
            // 
            cmbDestino.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.Font = new Font("Segoe UI", 10F);
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "BRL - Real Brasileiro", "USD - Dólar Americano", "EUR - Euro", "GBP - Libra Esterlina", "JPY - Iene Japonês", "AUD - Dólar Australiano", "CAD - Dólar Canadense", "CHF - Franco Suíço", "CNY - Yuan Chinês", "ARS - Peso Argentino", "MXN - Peso Mexicano", "CLP - Peso Chileno", "ZAR - Rand Sul-Africano", "NZD - Dólar Neozelandês", "TRY - Lira Turca" });
            cmbDestino.Location = new Point(113, 136);
            cmbDestino.Margin = new Padding(3, 4, 3, 4);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(239, 31);
            cmbDestino.TabIndex = 5;
            // 
            // btnConverter
            // 
            btnConverter.BackColor = Color.DodgerBlue;
            btnConverter.Dock = DockStyle.Bottom;
            btnConverter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConverter.ForeColor = SystemColors.ButtonHighlight;
            btnConverter.Location = new Point(20, 413);
            btnConverter.Margin = new Padding(3, 4, 3, 4);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(360, 62);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = false;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResultado
            // 
            lblResultado.Dock = DockStyle.Bottom;
            lblResultado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResultado.Location = new Point(20, 351);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(360, 62);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 500);
            Controls.Add(lblResultado);
            Controls.Add(btnConverter);
            Controls.Add(panelInputs);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Padding = new Padding(20, 25, 20, 25);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor de Moedas";
            panelInputs.ResumeLayout(false);
            panelInputs.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel panelInputs;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblOrigem;
        private System.Windows.Forms.ComboBox cmbOrigem;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblResultado;
    }
}
