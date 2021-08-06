
namespace CapaPresentacion.Forms
{
    partial class frmFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.labeltipocedula = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.dateTimeFactura = new System.Windows.Forms.DateTimePicker();
            this.labelIdFactura = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.cbTipoFactura = new System.Windows.Forms.ComboBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.dataGVDetalleFactura = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelIdAsociado = new System.Windows.Forms.Label();
            this.labelTotalFactura = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.LabelPara = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelANombreDe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMostraPanel2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerListaFacuta = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnVerProveedores = new System.Windows.Forms.Button();
            this.btnVerCliente = new System.Windows.Forms.Button();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.buttonconsultar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pictureFlecha2 = new System.Windows.Forms.PictureBox();
            this.pictureFlecha1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkCodigoP = new System.Windows.Forms.CheckBox();
            this.checkNombreP = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetalleFactura)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlecha2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlecha1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 150;
            this.label2.Text = "Detalle factura:";
            // 
            // labeltipocedula
            // 
            this.labeltipocedula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labeltipocedula.AutoSize = true;
            this.labeltipocedula.BackColor = System.Drawing.Color.Transparent;
            this.labeltipocedula.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipocedula.Location = new System.Drawing.Point(495, 230);
            this.labeltipocedula.Name = "labeltipocedula";
            this.labeltipocedula.Size = new System.Drawing.Size(124, 19);
            this.labeltipocedula.TabIndex = 133;
            this.labeltipocedula.Text = "Tipo factura:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(676, 261);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(147, 19);
            this.labelId.TabIndex = 128;
            this.labelId.Text = "Codigo factura :";
            // 
            // dateTimeFactura
            // 
            this.dateTimeFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimeFactura.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimeFactura.Location = new System.Drawing.Point(247, 228);
            this.dateTimeFactura.Name = "dateTimeFactura";
            this.dateTimeFactura.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFactura.TabIndex = 153;
            // 
            // labelIdFactura
            // 
            this.labelIdFactura.AutoSize = true;
            this.labelIdFactura.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFactura.Location = new System.Drawing.Point(842, 283);
            this.labelIdFactura.Name = "labelIdFactura";
            this.labelIdFactura.Size = new System.Drawing.Size(18, 19);
            this.labelIdFactura.TabIndex = 157;
            this.labelIdFactura.Text = "?";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(168, 230);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(67, 19);
            this.labelFecha.TabIndex = 158;
            this.labelFecha.Text = "Fecha :";
            // 
            // cbTipoFactura
            // 
            this.cbTipoFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTipoFactura.FormattingEnabled = true;
            this.cbTipoFactura.Location = new System.Drawing.Point(625, 228);
            this.cbTipoFactura.Name = "cbTipoFactura";
            this.cbTipoFactura.Size = new System.Drawing.Size(121, 21);
            this.cbTipoFactura.TabIndex = 160;
            this.cbTipoFactura.SelectedIndexChanged += new System.EventHandler(this.cbTipoFactura_SelectedIndexChanged);
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(168, 261);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(116, 19);
            this.labelCliente.TabIndex = 161;
            this.labelCliente.Text = "A nombre de:";
            // 
            // dataGVDetalleFactura
            // 
            this.dataGVDetalleFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGVDetalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVDetalleFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVDetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Impuesto,
            this.Descuento,
            this.SubTotal});
            this.dataGVDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDetalleFactura.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGVDetalleFactura.Location = new System.Drawing.Point(0, 0);
            this.dataGVDetalleFactura.MultiSelect = false;
            this.dataGVDetalleFactura.Name = "dataGVDetalleFactura";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVDetalleFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGVDetalleFactura.Size = new System.Drawing.Size(756, 286);
            this.dataGVDetalleFactura.TabIndex = 162;
            this.dataGVDetalleFactura.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVDetalleFactura_CellEndEdit);
            this.dataGVDetalleFactura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGVDetalleFactura_MouseClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // labelIdAsociado
            // 
            this.labelIdAsociado.AutoSize = true;
            this.labelIdAsociado.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdAsociado.Location = new System.Drawing.Point(290, 293);
            this.labelIdAsociado.Name = "labelIdAsociado";
            this.labelIdAsociado.Size = new System.Drawing.Size(18, 19);
            this.labelIdAsociado.TabIndex = 165;
            this.labelIdAsociado.Text = "?";
            // 
            // labelTotalFactura
            // 
            this.labelTotalFactura.AutoSize = true;
            this.labelTotalFactura.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFactura.Location = new System.Drawing.Point(827, 639);
            this.labelTotalFactura.Name = "labelTotalFactura";
            this.labelTotalFactura.Size = new System.Drawing.Size(23, 25);
            this.labelTotalFactura.TabIndex = 168;
            this.labelTotalFactura.Text = "?";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.Location = new System.Drawing.Point(740, 639);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(67, 19);
            this.labeltotal.TabIndex = 167;
            this.labeltotal.Text = "Total :";
            // 
            // LabelPara
            // 
            this.LabelPara.AutoSize = true;
            this.LabelPara.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPara.Location = new System.Drawing.Point(828, 283);
            this.LabelPara.Name = "LabelPara";
            this.LabelPara.Size = new System.Drawing.Size(18, 19);
            this.LabelPara.TabIndex = 170;
            this.LabelPara.Text = "?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewProductos);
            this.panel1.Location = new System.Drawing.Point(172, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 192);
            this.panel1.TabIndex = 166;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.PrecioVenta,
            this.dataGridViewTextBoxColumn2,
            this.Tamaño});
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewProductos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductos.MultiSelect = false;
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.Size = new System.Drawing.Size(727, 192);
            this.dataGridViewProductos.TabIndex = 165;
            this.dataGridViewProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellDoubleClick_1);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(961, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscador";
            // 
            // txtBusProducto
            // 
            this.txtBusProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusProducto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusProducto.ForeColor = System.Drawing.Color.White;
            this.txtBusProducto.Location = new System.Drawing.Point(905, 57);
            this.txtBusProducto.Multiline = true;
            this.txtBusProducto.Name = "txtBusProducto";
            this.txtBusProducto.Size = new System.Drawing.Size(191, 33);
            this.txtBusProducto.TabIndex = 0;
            this.txtBusProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusProducto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 171;
            this.label3.Text = "Cedula:";
            // 
            // labelANombreDe
            // 
            this.labelANombreDe.AutoSize = true;
            this.labelANombreDe.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelANombreDe.Location = new System.Drawing.Point(290, 261);
            this.labelANombreDe.Name = "labelANombreDe";
            this.labelANombreDe.Size = new System.Drawing.Size(18, 19);
            this.labelANombreDe.TabIndex = 172;
            this.labelANombreDe.Text = "?";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.btnMostraPanel2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnVerListaFacuta);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1115, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 747);
            this.panel2.TabIndex = 176;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnMostraPanel2
            // 
            this.btnMostraPanel2.Location = new System.Drawing.Point(-6, 334);
            this.btnMostraPanel2.Name = "btnMostraPanel2";
            this.btnMostraPanel2.Size = new System.Drawing.Size(16, 41);
            this.btnMostraPanel2.TabIndex = 179;
            this.btnMostraPanel2.Text = "|";
            this.btnMostraPanel2.UseVisualStyleBackColor = true;
            this.btnMostraPanel2.Click += new System.EventHandler(this.btnMostraPanel2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.icons8_apoyo_16_1_;
            this.pictureBox2.Location = new System.Drawing.Point(115, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 19);
            this.pictureBox2.TabIndex = 182;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.prueba_1_;
            this.pictureBox1.Location = new System.Drawing.Point(112, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 181;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 57);
            this.label4.TabIndex = 180;
            this.label4.Text = "Si tocas ingresa podras ver la lista de \r\nfactura que has ingresado, podras \r\nlla" +
    "mar una factura para editar o eliminar.";
            // 
            // btnVerListaFacuta
            // 
            this.btnVerListaFacuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVerListaFacuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerListaFacuta.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnVerListaFacuta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerListaFacuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerListaFacuta.Image = global::CapaPresentacion.Properties.Resources.icons8_prismáticos_30_1_;
            this.btnVerListaFacuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerListaFacuta.Location = new System.Drawing.Point(115, 341);
            this.btnVerListaFacuta.Name = "btnVerListaFacuta";
            this.btnVerListaFacuta.Size = new System.Drawing.Size(149, 41);
            this.btnVerListaFacuta.TabIndex = 178;
            this.btnVerListaFacuta.Text = "Ingresar";
            this.btnVerListaFacuta.UseVisualStyleBackColor = false;
            this.btnVerListaFacuta.Click += new System.EventHandler(this.btnVerListaFacuta_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGVDetalleFactura);
            this.panel3.Location = new System.Drawing.Point(172, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 286);
            this.panel3.TabIndex = 177;
            // 
            // btnManual
            // 
            this.btnManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.ForeColor = System.Drawing.Color.White;
            this.btnManual.Image = global::CapaPresentacion.Properties.Resources.icons8_editar_16_1_;
            this.btnManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManual.Location = new System.Drawing.Point(961, 306);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(80, 23);
            this.btnManual.TabIndex = 174;
            this.btnManual.Text = "Manual";
            this.btnManual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManual.UseVisualStyleBackColor = false;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnVerProveedores
            // 
            this.btnVerProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProveedores.ForeColor = System.Drawing.Color.White;
            this.btnVerProveedores.Image = global::CapaPresentacion.Properties.Resources.icons8_búsqueda_16_1_;
            this.btnVerProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerProveedores.Location = new System.Drawing.Point(773, 305);
            this.btnVerProveedores.Name = "btnVerProveedores";
            this.btnVerProveedores.Size = new System.Drawing.Size(96, 23);
            this.btnVerProveedores.TabIndex = 163;
            this.btnVerProveedores.Text = "Proveedor";
            this.btnVerProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerProveedores.UseVisualStyleBackColor = false;
            this.btnVerProveedores.Click += new System.EventHandler(this.btnVerProveedores_Click);
            // 
            // btnVerCliente
            // 
            this.btnVerCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCliente.ForeColor = System.Drawing.Color.White;
            this.btnVerCliente.Image = global::CapaPresentacion.Properties.Resources.icons8_búsqueda_16_1_;
            this.btnVerCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerCliente.Location = new System.Drawing.Point(875, 305);
            this.btnVerCliente.Name = "btnVerCliente";
            this.btnVerCliente.Size = new System.Drawing.Size(80, 23);
            this.btnVerCliente.TabIndex = 164;
            this.btnVerCliente.Text = "Cliente";
            this.btnVerCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerCliente.UseVisualStyleBackColor = false;
            this.btnVerCliente.Click += new System.EventHandler(this.btnVerCliente_Click);
            // 
            // buttonguardar
            // 
            this.buttonguardar.BackColor = System.Drawing.Color.Lime;
            this.buttonguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonguardar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.Image = global::CapaPresentacion.Properties.Resources.credit_card_22167;
            this.buttonguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonguardar.Location = new System.Drawing.Point(543, 626);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(173, 53);
            this.buttonguardar.TabIndex = 154;
            this.buttonguardar.Text = "Ingresar";
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // buttonconsultar
            // 
            this.buttonconsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonconsultar.FlatAppearance.BorderSize = 0;
            this.buttonconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconsultar.Image = global::CapaPresentacion.Properties.Resources.icons8_búsqueda_64_1_;
            this.buttonconsultar.Location = new System.Drawing.Point(976, 96);
            this.buttonconsultar.Name = "buttonconsultar";
            this.buttonconsultar.Size = new System.Drawing.Size(65, 57);
            this.buttonconsultar.TabIndex = 169;
            this.buttonconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonconsultar.UseVisualStyleBackColor = true;
            this.buttonconsultar.Click += new System.EventHandler(this.buttonconsultar_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 24;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.CausesValidation = false;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::CapaPresentacion.Properties.Resources.credit_card_22167;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(351, 627);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(173, 53);
            this.btnModificar.TabIndex = 178;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.CausesValidation = false;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.credit_card_22167;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(172, 627);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 53);
            this.btnEliminar.TabIndex = 179;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::CapaPresentacion.Properties.Resources.icons8_actualizar_16_1_;
            this.btnLimpiar.Location = new System.Drawing.Point(12, 235);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 49);
            this.btnLimpiar.TabIndex = 180;
            this.btnLimpiar.Text = "Limpiar área";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pictureFlecha2
            // 
            this.pictureFlecha2.Image = global::CapaPresentacion.Properties.Resources.arrow_top_15599;
            this.pictureFlecha2.Location = new System.Drawing.Point(809, 217);
            this.pictureFlecha2.Name = "pictureFlecha2";
            this.pictureFlecha2.Size = new System.Drawing.Size(28, 41);
            this.pictureFlecha2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFlecha2.TabIndex = 183;
            this.pictureFlecha2.TabStop = false;
            this.pictureFlecha2.Visible = false;
            // 
            // pictureFlecha1
            // 
            this.pictureFlecha1.Image = global::CapaPresentacion.Properties.Resources.Download_25378;
            this.pictureFlecha1.Location = new System.Drawing.Point(809, 217);
            this.pictureFlecha1.Name = "pictureFlecha1";
            this.pictureFlecha1.Size = new System.Drawing.Size(28, 41);
            this.pictureFlecha1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFlecha1.TabIndex = 182;
            this.pictureFlecha1.TabStop = false;
            this.pictureFlecha1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.business_color_money_13_icon_icons_com_53448;
            this.pictureBox3.Location = new System.Drawing.Point(752, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(54, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 181;
            this.pictureBox3.TabStop = false;
            // 
            // checkCodigoP
            // 
            this.checkCodigoP.AutoSize = true;
            this.checkCodigoP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCodigoP.Location = new System.Drawing.Point(905, 19);
            this.checkCodigoP.Name = "checkCodigoP";
            this.checkCodigoP.Size = new System.Drawing.Size(73, 21);
            this.checkCodigoP.TabIndex = 184;
            this.checkCodigoP.Text = "Codigo";
            this.checkCodigoP.UseVisualStyleBackColor = true;
            this.checkCodigoP.CheckedChanged += new System.EventHandler(this.checkCodigoP_CheckedChanged);
            // 
            // checkNombreP
            // 
            this.checkNombreP.AutoSize = true;
            this.checkNombreP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNombreP.Location = new System.Drawing.Point(1016, 19);
            this.checkNombreP.Name = "checkNombreP";
            this.checkNombreP.Size = new System.Drawing.Size(79, 21);
            this.checkNombreP.TabIndex = 185;
            this.checkNombreP.Text = "Nombre";
            this.checkNombreP.UseVisualStyleBackColor = true;
            this.checkNombreP.CheckedChanged += new System.EventHandler(this.checkNombreP_CheckedChanged);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1125, 747);
            this.Controls.Add(this.checkNombreP);
            this.Controls.Add(this.checkCodigoP);
            this.Controls.Add(this.pictureFlecha2);
            this.Controls.Add(this.pictureFlecha1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelTotalFactura);
            this.Controls.Add(this.btnVerProveedores);
            this.Controls.Add(this.labelANombreDe);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.btnVerCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.txtBusProducto);
            this.Controls.Add(this.labelIdAsociado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoFactura);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dateTimeFactura);
            this.Controls.Add(this.buttonconsultar);
            this.Controls.Add(this.labeltipocedula);
            this.Controls.Add(this.labelIdFactura);
            this.Controls.Add(this.LabelPara);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFactura_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetalleFactura)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlecha2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFlecha1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeltipocedula;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DateTimePicker dateTimeFactura;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Label labelIdFactura;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.ComboBox cbTipoFactura;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.DataGridView dataGVDetalleFactura;
        private System.Windows.Forms.Button btnVerProveedores;
        private System.Windows.Forms.Button btnVerCliente;
        private System.Windows.Forms.Label labelIdAsociado;
        private System.Windows.Forms.Label labelTotalFactura;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Button buttonconsultar;
        private System.Windows.Forms.Label LabelPara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelANombreDe;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Button btnVerListaFacuta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMostraPanel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.PictureBox pictureFlecha2;
        private System.Windows.Forms.PictureBox pictureFlecha1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkCodigoP;
        private System.Windows.Forms.CheckBox checkNombreP;
    }
}