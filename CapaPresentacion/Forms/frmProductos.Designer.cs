
namespace CapaPresentacion.Forms
{
    partial class frmProductos
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
            this.labelnombre = new System.Windows.Forms.Label();
            this.comboBoxcategoria = new System.Windows.Forms.ComboBox();
            this.labelcategoria = new System.Windows.Forms.Label();
            this.textBoxvalorventa = new System.Windows.Forms.TextBox();
            this.labelvalorventa = new System.Windows.Forms.Label();
            this.labelnav = new System.Windows.Forms.Label();
            this.labeltitulo1 = new System.Windows.Forms.Label();
            this.textBoxdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerfechacompra = new System.Windows.Forms.DateTimePicker();
            this.mskcodigo = new System.Windows.Forms.MaskedTextBox();
            this.textvalorcompra = new System.Windows.Forms.TextBox();
            this.textexistencia = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.labelfecchacompra = new System.Windows.Forms.Label();
            this.labelvalorcompra = new System.Windows.Forms.Label();
            this.labelcantidad = new System.Windows.Forms.Label();
            this.labeltipocedula = new System.Windows.Forms.Label();
            this.labelcedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTamaño = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAdquirido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.btnSeleProveedor = new System.Windows.Forms.Button();
            this.btnCantidaProductos = new System.Windows.Forms.Button();
            this.buttonconsultar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonmodificar = new System.Windows.Forms.Button();
            this.buttonguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnombre
            // 
            this.labelnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(73, 124);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(79, 19);
            this.labelnombre.TabIndex = 160;
            this.labelnombre.Text = "Nombre:";
            // 
            // comboBoxcategoria
            // 
            this.comboBoxcategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxcategoria.FormattingEnabled = true;
            this.comboBoxcategoria.Location = new System.Drawing.Point(161, 203);
            this.comboBoxcategoria.Name = "comboBoxcategoria";
            this.comboBoxcategoria.Size = new System.Drawing.Size(125, 21);
            this.comboBoxcategoria.TabIndex = 159;
            this.comboBoxcategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxcategoria_SelectedIndexChanged);
            // 
            // labelcategoria
            // 
            this.labelcategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelcategoria.AutoSize = true;
            this.labelcategoria.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcategoria.Location = new System.Drawing.Point(53, 202);
            this.labelcategoria.Name = "labelcategoria";
            this.labelcategoria.Size = new System.Drawing.Size(99, 19);
            this.labelcategoria.TabIndex = 158;
            this.labelcategoria.Text = "Categoria:";
            // 
            // textBoxvalorventa
            // 
            this.textBoxvalorventa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxvalorventa.Location = new System.Drawing.Point(161, 299);
            this.textBoxvalorventa.Name = "textBoxvalorventa";
            this.textBoxvalorventa.Size = new System.Drawing.Size(200, 20);
            this.textBoxvalorventa.TabIndex = 157;
            this.textBoxvalorventa.TextChanged += new System.EventHandler(this.textBoxvalorventa_TextChanged);
            // 
            // labelvalorventa
            // 
            this.labelvalorventa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelvalorventa.AutoSize = true;
            this.labelvalorventa.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalorventa.Location = new System.Drawing.Point(33, 300);
            this.labelvalorventa.Name = "labelvalorventa";
            this.labelvalorventa.Size = new System.Drawing.Size(118, 19);
            this.labelvalorventa.TabIndex = 156;
            this.labelvalorventa.Text = "Valor venta:";
            // 
            // labelnav
            // 
            this.labelnav.AutoSize = true;
            this.labelnav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnav.Location = new System.Drawing.Point(84, 28);
            this.labelnav.Name = "labelnav";
            this.labelnav.Size = new System.Drawing.Size(277, 24);
            this.labelnav.TabIndex = 155;
            this.labelnav.Text = "Mantenimiento de Productos";
            // 
            // labeltitulo1
            // 
            this.labeltitulo1.AutoSize = true;
            this.labeltitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo1.Location = new System.Drawing.Point(424, 28);
            this.labeltitulo1.Name = "labeltitulo1";
            this.labeltitulo1.Padding = new System.Windows.Forms.Padding(6);
            this.labeltitulo1.Size = new System.Drawing.Size(178, 36);
            this.labeltitulo1.TabIndex = 154;
            this.labeltitulo1.Text = "Salon de belleza";
            // 
            // textBoxdescripcion
            // 
            this.textBoxdescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxdescripcion.Location = new System.Drawing.Point(161, 154);
            this.textBoxdescripcion.Multiline = true;
            this.textBoxdescripcion.Name = "textBoxdescripcion";
            this.textBoxdescripcion.Size = new System.Drawing.Size(202, 34);
            this.textBoxdescripcion.TabIndex = 153;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 152;
            this.label2.Text = "Descripcion:";
            // 
            // dateTimePickerfechacompra
            // 
            this.dateTimePickerfechacompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerfechacompra.Location = new System.Drawing.Point(161, 335);
            this.dateTimePickerfechacompra.Name = "dateTimePickerfechacompra";
            this.dateTimePickerfechacompra.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerfechacompra.TabIndex = 150;
            // 
            // mskcodigo
            // 
            this.mskcodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mskcodigo.Location = new System.Drawing.Point(161, 93);
            this.mskcodigo.Mask = "#-####-####";
            this.mskcodigo.Name = "mskcodigo";
            this.mskcodigo.Size = new System.Drawing.Size(125, 20);
            this.mskcodigo.TabIndex = 149;
            this.mskcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskcodigo_KeyPress);
            // 
            // textvalorcompra
            // 
            this.textvalorcompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textvalorcompra.Location = new System.Drawing.Point(161, 273);
            this.textvalorcompra.Name = "textvalorcompra";
            this.textvalorcompra.Size = new System.Drawing.Size(200, 20);
            this.textvalorcompra.TabIndex = 148;
            this.textvalorcompra.TextChanged += new System.EventHandler(this.textvalorcompra_TextChanged);
            this.textvalorcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textvalorcompra_KeyPress);
            // 
            // textexistencia
            // 
            this.textexistencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textexistencia.Location = new System.Drawing.Point(161, 375);
            this.textexistencia.Name = "textexistencia";
            this.textexistencia.Size = new System.Drawing.Size(200, 20);
            this.textexistencia.TabIndex = 147;
            this.textexistencia.TextChanged += new System.EventHandler(this.textexistencia_TextChanged);
            // 
            // textnombre
            // 
            this.textnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textnombre.Location = new System.Drawing.Point(161, 123);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(135, 20);
            this.textnombre.TabIndex = 146;
            // 
            // labelfecchacompra
            // 
            this.labelfecchacompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelfecchacompra.AutoSize = true;
            this.labelfecchacompra.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecchacompra.Location = new System.Drawing.Point(21, 335);
            this.labelfecchacompra.Name = "labelfecchacompra";
            this.labelfecchacompra.Size = new System.Drawing.Size(130, 19);
            this.labelfecchacompra.TabIndex = 141;
            this.labelfecchacompra.Text = "Fecha compra:";
            // 
            // labelvalorcompra
            // 
            this.labelvalorcompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelvalorcompra.AutoSize = true;
            this.labelvalorcompra.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalorcompra.Location = new System.Drawing.Point(22, 272);
            this.labelvalorcompra.Name = "labelvalorcompra";
            this.labelvalorcompra.Size = new System.Drawing.Size(131, 19);
            this.labelvalorcompra.TabIndex = 140;
            this.labelvalorcompra.Text = "Valor compra:";
            // 
            // labelcantidad
            // 
            this.labelcantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelcantidad.AutoSize = true;
            this.labelcantidad.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcantidad.Location = new System.Drawing.Point(48, 374);
            this.labelcantidad.Name = "labelcantidad";
            this.labelcantidad.Size = new System.Drawing.Size(103, 19);
            this.labelcantidad.TabIndex = 139;
            this.labelcantidad.Text = "Existencia:";
            // 
            // labeltipocedula
            // 
            this.labeltipocedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeltipocedula.AutoSize = true;
            this.labeltipocedula.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipocedula.Location = new System.Drawing.Point(73, 235);
            this.labeltipocedula.Name = "labeltipocedula";
            this.labeltipocedula.Size = new System.Drawing.Size(78, 19);
            this.labeltipocedula.TabIndex = 138;
            this.labeltipocedula.Text = "Tamaño:";
            // 
            // labelcedula
            // 
            this.labelcedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelcedula.AutoSize = true;
            this.labelcedula.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcedula.Location = new System.Drawing.Point(88, 94);
            this.labelcedula.Name = "labelcedula";
            this.labelcedula.Size = new System.Drawing.Size(64, 19);
            this.labelcedula.TabIndex = 137;
            this.labelcedula.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 161;
            this.label1.Text = "Proveedor:";
            // 
            // mskTamaño
            // 
            this.mskTamaño.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mskTamaño.Location = new System.Drawing.Point(161, 235);
            this.mskTamaño.Mask = "####.kg";
            this.mskTamaño.Name = "mskTamaño";
            this.mskTamaño.Size = new System.Drawing.Size(172, 20);
            this.mskTamaño.TabIndex = 163;
            this.mskTamaño.ValidatingType = typeof(int);
            this.mskTamaño.TextChanged += new System.EventHandler(this.mskTamaño_TextChanged);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.PrecioVenta,
            this.Proveedor,
            this.FAdquirido,
            this.Descripcion,
            this.Cantidad,
            this.FormaMedida,
            this.Tamaño});
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(439, 529);
            this.dataGridViewProductos.TabIndex = 164;
            this.dataGridViewProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio compra";
            this.Precio.Name = "Precio";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio venta";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Preveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // FAdquirido
            // 
            this.FAdquirido.HeaderText = "Fecha ingreso";
            this.FAdquirido.Name = "FAdquirido";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcon";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // FormaMedida
            // 
            this.FormaMedida.HeaderText = "Forma de medida";
            this.FormaMedida.Name = "FormaMedida";
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.Name = "Tamaño";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewProductos);
            this.panel1.Location = new System.Drawing.Point(666, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 529);
            this.panel1.TabIndex = 165;
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxProveedor.Enabled = false;
            this.textBoxProveedor.Location = new System.Drawing.Point(161, 407);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(200, 20);
            this.textBoxProveedor.TabIndex = 168;
            this.textBoxProveedor.TextChanged += new System.EventHandler(this.textBoxProveedor_TextChanged);
            // 
            // btnSeleProveedor
            // 
            this.btnSeleProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSeleProveedor.AutoEllipsis = true;
            this.btnSeleProveedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeleProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleProveedor.FlatAppearance.BorderSize = 0;
            this.btnSeleProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleProveedor.Image = global::CapaPresentacion.Properties.Resources.icons8_prismáticos_30_1_;
            this.btnSeleProveedor.Location = new System.Drawing.Point(380, 402);
            this.btnSeleProveedor.Name = "btnSeleProveedor";
            this.btnSeleProveedor.Size = new System.Drawing.Size(39, 30);
            this.btnSeleProveedor.TabIndex = 169;
            this.btnSeleProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleProveedor.UseVisualStyleBackColor = true;
            this.btnSeleProveedor.Click += new System.EventHandler(this.btnSeleProveedor_Click);
            // 
            // btnCantidaProductos
            // 
            this.btnCantidaProductos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCantidaProductos.AutoEllipsis = true;
            this.btnCantidaProductos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCantidaProductos.BackColor = System.Drawing.Color.Gray;
            this.btnCantidaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCantidaProductos.FlatAppearance.BorderSize = 0;
            this.btnCantidaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCantidaProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidaProductos.Image = global::CapaPresentacion.Properties.Resources.icons8_documento_16_1_;
            this.btnCantidaProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCantidaProductos.Location = new System.Drawing.Point(428, 402);
            this.btnCantidaProductos.Name = "btnCantidaProductos";
            this.btnCantidaProductos.Size = new System.Drawing.Size(98, 30);
            this.btnCantidaProductos.TabIndex = 167;
            this.btnCantidaProductos.Text = "Información";
            this.btnCantidaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCantidaProductos.UseVisualStyleBackColor = false;
            this.btnCantidaProductos.Visible = false;
            this.btnCantidaProductos.Click += new System.EventHandler(this.btnCantidaProductos_Click);
            // 
            // buttonconsultar
            // 
            this.buttonconsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonconsultar.FlatAppearance.BorderSize = 0;
            this.buttonconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconsultar.Image = global::CapaPresentacion.Properties.Resources.icons8_búsqueda_64_1_;
            this.buttonconsultar.Location = new System.Drawing.Point(518, 67);
            this.buttonconsultar.Name = "buttonconsultar";
            this.buttonconsultar.Size = new System.Drawing.Size(65, 57);
            this.buttonconsultar.TabIndex = 145;
            this.buttonconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonconsultar.UseVisualStyleBackColor = true;
            this.buttonconsultar.Click += new System.EventHandler(this.buttonconsultar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttoneliminar.BackColor = System.Drawing.Color.Red;
            this.buttoneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Image = global::CapaPresentacion.Properties.Resources.icons8_eliminar_16_1_;
            this.buttoneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoneliminar.Location = new System.Drawing.Point(78, 473);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(88, 31);
            this.buttoneliminar.TabIndex = 144;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmodificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodificar.Image = global::CapaPresentacion.Properties.Resources.icons8_editar_16_1_;
            this.buttonmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonmodificar.Location = new System.Drawing.Point(237, 473);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(88, 31);
            this.buttonmodificar.TabIndex = 143;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonmodificar.UseVisualStyleBackColor = false;
            this.buttonmodificar.Click += new System.EventHandler(this.buttonmodificar_Click);
            // 
            // buttonguardar
            // 
            this.buttonguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonguardar.BackColor = System.Drawing.Color.Lime;
            this.buttonguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonguardar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.Image = global::CapaPresentacion.Properties.Resources.icons8_marcapáginas_16_2_;
            this.buttonguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonguardar.Location = new System.Drawing.Point(371, 473);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(88, 31);
            this.buttonguardar.TabIndex = 142;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1105, 529);
            this.Controls.Add(this.btnSeleProveedor);
            this.Controls.Add(this.textBoxProveedor);
            this.Controls.Add(this.btnCantidaProductos);
            this.Controls.Add(this.labeltitulo1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mskTamaño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.comboBoxcategoria);
            this.Controls.Add(this.labelcategoria);
            this.Controls.Add(this.textBoxvalorventa);
            this.Controls.Add(this.labelvalorventa);
            this.Controls.Add(this.labelnav);
            this.Controls.Add(this.textBoxdescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerfechacompra);
            this.Controls.Add(this.mskcodigo);
            this.Controls.Add(this.textvalorcompra);
            this.Controls.Add(this.textexistencia);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.buttonconsultar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonmodificar);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.labelfecchacompra);
            this.Controls.Add(this.labelvalorcompra);
            this.Controls.Add(this.labelcantidad);
            this.Controls.Add(this.labeltipocedula);
            this.Controls.Add(this.labelcedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "Registrar Producto";
            this.Load += new System.EventHandler(this.frmProductos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.ComboBox comboBoxcategoria;
        private System.Windows.Forms.Label labelcategoria;
        private System.Windows.Forms.TextBox textBoxvalorventa;
        private System.Windows.Forms.Label labelvalorventa;
        private System.Windows.Forms.Label labelnav;
        private System.Windows.Forms.Label labeltitulo1;
        private System.Windows.Forms.TextBox textBoxdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerfechacompra;
        private System.Windows.Forms.MaskedTextBox mskcodigo;
        private System.Windows.Forms.TextBox textvalorcompra;
        private System.Windows.Forms.TextBox textexistencia;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Button buttonconsultar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonmodificar;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Label labelfecchacompra;
        private System.Windows.Forms.Label labelvalorcompra;
        private System.Windows.Forms.Label labelcantidad;
        private System.Windows.Forms.Label labeltipocedula;
        private System.Windows.Forms.Label labelcedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskTamaño;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAdquirido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.Button btnCantidaProductos;
        private System.Windows.Forms.Button btnSeleProveedor;
    }
}