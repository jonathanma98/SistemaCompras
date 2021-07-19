
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labeltitulo1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labeltipocedula = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.dateTimeFactura = new System.Windows.Forms.DateTimePicker();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonmodificar = new System.Windows.Forms.Button();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.labelIdFactura = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.cbTipoFactura = new System.Windows.Forms.ComboBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.dataGVDetalleFactura = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerProveedores = new System.Windows.Forms.Button();
            this.btnVerCliente = new System.Windows.Forms.Button();
            this.labelIdAsociado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamaño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotalFactura = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.buttonconsultar = new System.Windows.Forms.Button();
            this.LabelPara = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetalleFactura)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltitulo1
            // 
            this.labeltitulo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltitulo1.AutoSize = true;
            this.labeltitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo1.Location = new System.Drawing.Point(480, 9);
            this.labeltitulo1.Name = "labeltitulo1";
            this.labeltitulo1.Size = new System.Drawing.Size(166, 24);
            this.labeltitulo1.TabIndex = 152;
            this.labeltitulo1.Text = "Salon de belleza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 150;
            this.label2.Text = "Detalle factura:";
            // 
            // labeltipocedula
            // 
            this.labeltipocedula.AutoSize = true;
            this.labeltipocedula.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipocedula.Location = new System.Drawing.Point(437, 96);
            this.labeltipocedula.Name = "labeltipocedula";
            this.labeltipocedula.Size = new System.Drawing.Size(124, 19);
            this.labeltipocedula.TabIndex = 133;
            this.labeltipocedula.Text = "Tipo factura:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(52, 48);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(73, 19);
            this.labelId.TabIndex = 128;
            this.labelId.Text = "Codigo :";
            // 
            // dateTimeFactura
            // 
            this.dateTimeFactura.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimeFactura.Location = new System.Drawing.Point(520, 55);
            this.dateTimeFactura.Name = "dateTimeFactura";
            this.dateTimeFactura.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFactura.TabIndex = 153;
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.Red;
            this.buttoneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Image = global::CapaPresentacion.Properties.Resources.icons8_eliminar_16_1_;
            this.buttoneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoneliminar.Location = new System.Drawing.Point(633, 269);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(88, 31);
            this.buttoneliminar.TabIndex = 156;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmodificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodificar.Image = global::CapaPresentacion.Properties.Resources.icons8_editar_16_1_;
            this.buttonmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonmodificar.Location = new System.Drawing.Point(633, 351);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(88, 31);
            this.buttonmodificar.TabIndex = 155;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonmodificar.UseVisualStyleBackColor = false;
            // 
            // buttonguardar
            // 
            this.buttonguardar.BackColor = System.Drawing.Color.Lime;
            this.buttonguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonguardar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.Image = global::CapaPresentacion.Properties.Resources.icons8_marcapáginas_16_2_;
            this.buttonguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonguardar.Location = new System.Drawing.Point(633, 444);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(87, 31);
            this.buttonguardar.TabIndex = 154;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // labelIdFactura
            // 
            this.labelIdFactura.AutoSize = true;
            this.labelIdFactura.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFactura.Location = new System.Drawing.Point(150, 48);
            this.labelIdFactura.Name = "labelIdFactura";
            this.labelIdFactura.Size = new System.Drawing.Size(18, 19);
            this.labelIdFactura.TabIndex = 157;
            this.labelIdFactura.Text = "?";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(434, 56);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(67, 19);
            this.labelFecha.TabIndex = 158;
            this.labelFecha.Text = "Fecha :";
            // 
            // cbTipoFactura
            // 
            this.cbTipoFactura.FormattingEnabled = true;
            this.cbTipoFactura.Location = new System.Drawing.Point(567, 97);
            this.cbTipoFactura.Name = "cbTipoFactura";
            this.cbTipoFactura.Size = new System.Drawing.Size(121, 21);
            this.cbTipoFactura.TabIndex = 160;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(52, 100);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVDetalleFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Impuesto,
            this.SubTotal});
            this.dataGVDetalleFactura.Location = new System.Drawing.Point(56, 241);
            this.dataGVDetalleFactura.Name = "dataGVDetalleFactura";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVDetalleFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVDetalleFactura.Size = new System.Drawing.Size(540, 243);
            this.dataGVDetalleFactura.TabIndex = 162;
            this.dataGVDetalleFactura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGVDetalleFactura_MouseClick);
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
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // btnVerProveedores
            // 
            this.btnVerProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVerProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProveedores.ForeColor = System.Drawing.Color.White;
            this.btnVerProveedores.Image = global::CapaPresentacion.Properties.Resources.icons8_búsqueda_16_1_;
            this.btnVerProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerProveedores.Location = new System.Drawing.Point(166, 122);
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
            this.btnVerCliente.Location = new System.Drawing.Point(268, 121);
            this.btnVerCliente.Name = "btnVerCliente";
            this.btnVerCliente.Size = new System.Drawing.Size(80, 23);
            this.btnVerCliente.TabIndex = 164;
            this.btnVerCliente.Text = "Cliente";
            this.btnVerCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerCliente.UseVisualStyleBackColor = false;
            this.btnVerCliente.Click += new System.EventHandler(this.btnVerCliente_Click);
            // 
            // labelIdAsociado
            // 
            this.labelIdAsociado.AutoSize = true;
            this.labelIdAsociado.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdAsociado.Location = new System.Drawing.Point(174, 99);
            this.labelIdAsociado.Name = "labelIdAsociado";
            this.labelIdAsociado.Size = new System.Drawing.Size(18, 19);
            this.labelIdAsociado.TabIndex = 165;
            this.labelIdAsociado.Text = "?";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewProductos);
            this.panel1.Location = new System.Drawing.Point(960, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 510);
            this.panel1.TabIndex = 166;
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.PrecioVenta,
            this.dataGridViewTextBoxColumn2,
            this.Tamaño});
            this.dataGridViewProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProductos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(146, 510);
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
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio venta";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Tamaño
            // 
            this.Tamaño.HeaderText = "Tamaño";
            this.Tamaño.Name = "Tamaño";
            // 
            // labelTotalFactura
            // 
            this.labelTotalFactura.AutoSize = true;
            this.labelTotalFactura.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalFactura.Location = new System.Drawing.Point(562, 500);
            this.labelTotalFactura.Name = "labelTotalFactura";
            this.labelTotalFactura.Size = new System.Drawing.Size(18, 19);
            this.labelTotalFactura.TabIndex = 168;
            this.labelTotalFactura.Text = "?";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.Location = new System.Drawing.Point(480, 500);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(67, 19);
            this.labeltotal.TabIndex = 167;
            this.labeltotal.Text = "Total :";
            // 
            // buttonconsultar
            // 
            this.buttonconsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonconsultar.FlatAppearance.BorderSize = 0;
            this.buttonconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconsultar.Image = global::CapaPresentacion.Properties.Resources.icons8_búsqueda_64_1_;
            this.buttonconsultar.Location = new System.Drawing.Point(726, 97);
            this.buttonconsultar.Name = "buttonconsultar";
            this.buttonconsultar.Size = new System.Drawing.Size(65, 57);
            this.buttonconsultar.TabIndex = 169;
            this.buttonconsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonconsultar.UseVisualStyleBackColor = true;
            this.buttonconsultar.Click += new System.EventHandler(this.buttonconsultar_Click_1);
            // 
            // LabelPara
            // 
            this.LabelPara.AutoSize = true;
            this.LabelPara.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPara.Location = new System.Drawing.Point(126, 48);
            this.LabelPara.Name = "LabelPara";
            this.LabelPara.Size = new System.Drawing.Size(18, 19);
            this.LabelPara.TabIndex = 170;
            this.LabelPara.Text = "?";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1106, 543);
            this.Controls.Add(this.LabelPara);
            this.Controls.Add(this.buttonconsultar);
            this.Controls.Add(this.labelTotalFactura);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelIdAsociado);
            this.Controls.Add(this.btnVerCliente);
            this.Controls.Add(this.btnVerProveedores);
            this.Controls.Add(this.dataGVDetalleFactura);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.cbTipoFactura);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelIdFactura);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonmodificar);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.dateTimeFactura);
            this.Controls.Add(this.labeltitulo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labeltipocedula);
            this.Controls.Add(this.labelId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFactura";
            this.Text = "frmFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetalleFactura)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltitulo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeltipocedula;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.DateTimePicker dateTimeFactura;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonmodificar;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Label labelIdFactura;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.ComboBox cbTipoFactura;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.DataGridView dataGVDetalleFactura;
        private System.Windows.Forms.Button btnVerProveedores;
        private System.Windows.Forms.Button btnVerCliente;
        private System.Windows.Forms.Label labelIdAsociado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamaño;
        private System.Windows.Forms.Label labelTotalFactura;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Button buttonconsultar;
        private System.Windows.Forms.Label LabelPara;
    }
}