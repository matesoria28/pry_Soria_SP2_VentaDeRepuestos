namespace pry_Soria_SP2_VentaDeRepuestos
{
    partial class VentaDeRepuestos
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
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNumero = new Label();
            lblDescripcion = new Label();
            Datos = new TabControl();
            tbcIngreso = new TabPage();
            ltbDescripcion = new ListBox();
            mskPrecio = new MaskedTextBox();
            cmbNumero = new ComboBox();
            cmbMarca = new ComboBox();
            btnRegistrar = new Button();
            cmbOrigen = new ComboBox();
            lblPrecio = new Label();
            tbcDatos = new TabPage();
            lblOrigen2 = new Label();
            lblMarca2 = new Label();
            cmbOrigenFiltro = new ComboBox();
            cboMarcaFiltro = new ComboBox();
            dgvDatos = new DataGridView();
            colMarca = new DataGridViewTextBoxColumn();
            colOrigen = new DataGridViewTextBoxColumn();
            colNumero = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            Datos.SuspendLayout();
            tbcIngreso.SuspendLayout();
            tbcDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(6, 16);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Marca:";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(230, 16);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(46, 15);
            lblOrigen.TabIndex = 4;
            lblOrigen.Text = "Origen:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(6, 55);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 5;
            lblNumero.Text = "Numero:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(6, 96);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripcion:";
            // 
            // Datos
            // 
            Datos.Controls.Add(tbcIngreso);
            Datos.Controls.Add(tbcDatos);
            Datos.Location = new Point(12, 12);
            Datos.Name = "Datos";
            Datos.SelectedIndex = 0;
            Datos.Size = new Size(478, 383);
            Datos.TabIndex = 21;
            // 
            // tbcIngreso
            // 
            tbcIngreso.Controls.Add(ltbDescripcion);
            tbcIngreso.Controls.Add(mskPrecio);
            tbcIngreso.Controls.Add(cmbNumero);
            tbcIngreso.Controls.Add(cmbMarca);
            tbcIngreso.Controls.Add(btnRegistrar);
            tbcIngreso.Controls.Add(cmbOrigen);
            tbcIngreso.Controls.Add(lblPrecio);
            tbcIngreso.Controls.Add(lblMarca);
            tbcIngreso.Controls.Add(lblOrigen);
            tbcIngreso.Controls.Add(lblNumero);
            tbcIngreso.Controls.Add(lblDescripcion);
            tbcIngreso.Location = new Point(4, 24);
            tbcIngreso.Name = "tbcIngreso";
            tbcIngreso.Padding = new Padding(3);
            tbcIngreso.Size = new Size(470, 355);
            tbcIngreso.TabIndex = 0;
            tbcIngreso.Text = "Ingreso";
            tbcIngreso.UseVisualStyleBackColor = true;
            // 
            // ltbDescripcion
            // 
            ltbDescripcion.FormattingEnabled = true;
            ltbDescripcion.ItemHeight = 15;
            ltbDescripcion.Location = new Point(6, 125);
            ltbDescripcion.Name = "ltbDescripcion";
            ltbDescripcion.Size = new Size(443, 154);
            ltbDescripcion.TabIndex = 14;
            // 
            // mskPrecio
            // 
            mskPrecio.Location = new Point(282, 55);
            mskPrecio.Mask = "$9999999999";
            mskPrecio.Name = "mskPrecio";
            mskPrecio.Size = new Size(167, 23);
            mskPrecio.TabIndex = 13;
            mskPrecio.ValidatingType = typeof(int);
            // 
            // cmbNumero
            // 
            cmbNumero.FormattingEnabled = true;
            cmbNumero.Location = new Point(73, 52);
            cmbNumero.Name = "cmbNumero";
            cmbNumero.Size = new Size(141, 23);
            cmbNumero.TabIndex = 12;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "(P) Peugeot", "(F) Fiat", "(R) Renault" });
            cmbMarca.Location = new Point(73, 13);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(141, 23);
            cmbMarca.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(340, 310);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(109, 23);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "(I) Importado", "(N) Nacional" });
            cmbOrigen.Location = new Point(282, 13);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(167, 23);
            cmbOrigen.TabIndex = 9;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(230, 55);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "precio:";
            // 
            // tbcDatos
            // 
            tbcDatos.Controls.Add(lblOrigen2);
            tbcDatos.Controls.Add(lblMarca2);
            tbcDatos.Controls.Add(cmbOrigenFiltro);
            tbcDatos.Controls.Add(cboMarcaFiltro);
            tbcDatos.Controls.Add(dgvDatos);
            tbcDatos.Location = new Point(4, 24);
            tbcDatos.Name = "tbcDatos";
            tbcDatos.Padding = new Padding(3);
            tbcDatos.Size = new Size(470, 355);
            tbcDatos.TabIndex = 1;
            tbcDatos.Text = "Datos";
            tbcDatos.UseVisualStyleBackColor = true;
            // 
            // lblOrigen2
            // 
            lblOrigen2.AutoSize = true;
            lblOrigen2.Location = new Point(236, 53);
            lblOrigen2.Name = "lblOrigen2";
            lblOrigen2.Size = new Size(43, 15);
            lblOrigen2.TabIndex = 4;
            lblOrigen2.Text = "Origen";
            // 
            // lblMarca2
            // 
            lblMarca2.AutoSize = true;
            lblMarca2.Location = new Point(17, 53);
            lblMarca2.Name = "lblMarca2";
            lblMarca2.Size = new Size(40, 15);
            lblMarca2.TabIndex = 3;
            lblMarca2.Text = "Marca";
            // 
            // cmbOrigenFiltro
            // 
            cmbOrigenFiltro.FormattingEnabled = true;
            cmbOrigenFiltro.Location = new Point(285, 45);
            cmbOrigenFiltro.Name = "cmbOrigenFiltro";
            cmbOrigenFiltro.Size = new Size(121, 23);
            cmbOrigenFiltro.TabIndex = 2;
            // 
            // cboMarcaFiltro
            // 
            cboMarcaFiltro.FormattingEnabled = true;
            cboMarcaFiltro.Location = new Point(63, 45);
            cboMarcaFiltro.Name = "cboMarcaFiltro";
            cboMarcaFiltro.Size = new Size(121, 23);
            cboMarcaFiltro.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMarca, colOrigen, colNumero, colPrecio, colDescripcion });
            dgvDatos.Location = new Point(6, 83);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(446, 252);
            dgvDatos.TabIndex = 0;
            dgvDatos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "Marca";
            colMarca.Name = "colMarca";
            // 
            // colOrigen
            // 
            colOrigen.HeaderText = "Origen";
            colOrigen.Name = "colOrigen";
            // 
            // colNumero
            // 
            colNumero.HeaderText = "Numero";
            colNumero.Name = "colNumero";
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.Name = "colDescripcion";
            // 
            // VentaDeRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 469);
            Controls.Add(Datos);
            Name = "VentaDeRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Venta de Repuestos";
            Datos.ResumeLayout(false);
            tbcIngreso.ResumeLayout(false);
            tbcIngreso.PerformLayout();
            tbcDatos.ResumeLayout(false);
            tbcDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblMarca;
        private Label lblOrigen;
        private Label lblNumero;
        private Label lblDescripcion;
        private Button btnIngresarRepuestos;
        private TabControl Datos;
        private TabPage tbcIngreso;
        private ComboBox cboMarcaFiltro;
        private ListBox listBox1;
        private Label lblPrecio;
        private TabPage tbcDatos;
        private DataGridView dgvDatos;
        private Button btnRegistrar;
        private ComboBox cmbOrigen;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colOrigen;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colDescripcion;
        private ListBox ltbDescripcion;
        private MaskedTextBox mskPrecio;
        private ComboBox cmbNumero;
        private ComboBox cmbMarca;
        private ComboBox cmbOrigenFiltro;
        private Label lblOrigen2;
        private Label lblMarca2;
    }
}
