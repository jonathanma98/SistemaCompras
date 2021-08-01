
namespace CapaPresentacion.Forms
{
    partial class frmSelecReportes
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelIngresos = new System.Windows.Forms.Panel();
            this.btn1PorFecha = new System.Windows.Forms.Button();
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.btnCompraProveedores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.btnVentaID = new System.Windows.Forms.Button();
            this.btnTotalCompraClientes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.btnProducCantidadVentas = new System.Windows.Forms.Button();
            this.btnProductoCantidad = new System.Windows.Forms.Button();
            this.btnProductoFecha = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.panelIngresos.SuspendLayout();
            this.panelProveedores.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panelProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(122, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control dinero";
            // 
            // panelIngresos
            // 
            this.panelIngresos.BackColor = System.Drawing.Color.Gainsboro;
            this.panelIngresos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIngresos.Controls.Add(this.btn1PorFecha);
            this.panelIngresos.Location = new System.Drawing.Point(77, 99);
            this.panelIngresos.Name = "panelIngresos";
            this.panelIngresos.Size = new System.Drawing.Size(153, 275);
            this.panelIngresos.TabIndex = 2;
            // 
            // btn1PorFecha
            // 
            this.btn1PorFecha.AutoEllipsis = true;
            this.btn1PorFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn1PorFecha.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btn1PorFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn1PorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1PorFecha.ForeColor = System.Drawing.Color.Blue;
            this.btn1PorFecha.Image = global::CapaPresentacion.Properties.Resources.icons8_documento_30_1_;
            this.btn1PorFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1PorFecha.Location = new System.Drawing.Point(3, 16);
            this.btn1PorFecha.Name = "btn1PorFecha";
            this.btn1PorFecha.Size = new System.Drawing.Size(144, 42);
            this.btn1PorFecha.TabIndex = 2;
            this.btn1PorFecha.Text = "Ver por fecha";
            this.btn1PorFecha.UseVisualStyleBackColor = false;
            this.btn1PorFecha.Click += new System.EventHandler(this.btn1PorFecha_Click);
            // 
            // panelProveedores
            // 
            this.panelProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelProveedores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProveedores.Controls.Add(this.btnCompraProveedores);
            this.panelProveedores.Location = new System.Drawing.Point(338, 99);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(153, 275);
            this.panelProveedores.TabIndex = 2;
            // 
            // btnCompraProveedores
            // 
            this.btnCompraProveedores.AutoEllipsis = true;
            this.btnCompraProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCompraProveedores.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnCompraProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCompraProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompraProveedores.ForeColor = System.Drawing.Color.Blue;
            this.btnCompraProveedores.Image = global::CapaPresentacion.Properties.Resources.icons8_documento_30_1_;
            this.btnCompraProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompraProveedores.Location = new System.Drawing.Point(3, 16);
            this.btnCompraProveedores.Name = "btnCompraProveedores";
            this.btnCompraProveedores.Size = new System.Drawing.Size(144, 42);
            this.btnCompraProveedores.TabIndex = 5;
            this.btnCompraProveedores.Text = "Productos asociados";
            this.btnCompraProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompraProveedores.UseVisualStyleBackColor = false;
            this.btnCompraProveedores.Click += new System.EventHandler(this.btnCompraProveedores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proveedores";
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientes.Controls.Add(this.btnVentaID);
            this.panelClientes.Controls.Add(this.btnTotalCompraClientes);
            this.panelClientes.Location = new System.Drawing.Point(595, 99);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(153, 275);
            this.panelClientes.TabIndex = 2;
            // 
            // btnVentaID
            // 
            this.btnVentaID.AutoEllipsis = true;
            this.btnVentaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVentaID.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnVentaID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnVentaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaID.ForeColor = System.Drawing.Color.Blue;
            this.btnVentaID.Image = global::CapaPresentacion.Properties.Resources.icons8_documento_30_1_;
            this.btnVentaID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentaID.Location = new System.Drawing.Point(3, 91);
            this.btnVentaID.Name = "btnVentaID";
            this.btnVentaID.Size = new System.Drawing.Size(144, 42);
            this.btnVentaID.TabIndex = 3;
            this.btnVentaID.Text = "Ventas por cliente";
            this.btnVentaID.UseVisualStyleBackColor = false;
            this.btnVentaID.Click += new System.EventHandler(this.btnVentaID_Click);
            // 
            // btnTotalCompraClientes
            // 
            this.btnTotalCompraClientes.AutoEllipsis = true;
            this.btnTotalCompraClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTotalCompraClientes.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnTotalCompraClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnTotalCompraClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalCompraClientes.ForeColor = System.Drawing.Color.Blue;
            this.btnTotalCompraClientes.Image = global::CapaPresentacion.Properties.Resources.icons8_documento_30_1_;
            this.btnTotalCompraClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalCompraClientes.Location = new System.Drawing.Point(0, 16);
            this.btnTotalCompraClientes.Name = "btnTotalCompraClientes";
            this.btnTotalCompraClientes.Size = new System.Drawing.Size(150, 42);
            this.btnTotalCompraClientes.TabIndex = 2;
            this.btnTotalCompraClientes.Text = "Acumulado de compras";
            this.btnTotalCompraClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTotalCompraClientes.UseVisualStyleBackColor = false;
            this.btnTotalCompraClientes.Click += new System.EventHandler(this.btnTotalCompraClientes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(644, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cliente";
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.Maroon;
            this.panelProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductos.Controls.Add(this.btnProducCantidadVentas);
            this.panelProductos.Controls.Add(this.btnProductoCantidad);
            this.panelProductos.Controls.Add(this.btnProductoFecha);
            this.panelProductos.Location = new System.Drawing.Point(857, 99);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(153, 275);
            this.panelProductos.TabIndex = 2;
            // 
            // btnProducCantidadVentas
            // 
            this.btnProducCantidadVentas.AutoEllipsis = true;
            this.btnProducCantidadVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProducCantidadVentas.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnProducCantidadVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnProducCantidadVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducCantidadVentas.ForeColor = System.Drawing.Color.Blue;
            this.btnProducCantidadVentas.Image = global::CapaPresentacion.Properties.Resources.icons8_documento_30_1_;
            this.btnProducCantidadVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducCantidadVentas.Location = new System.Drawing.Point(3, 169);
            this.btnProducCantidadVentas.Name = "btnProducCantidadVentas";
            this.btnProducCantidadVentas.Size = new System.Drawing.Size(144, 42);
            this.btnProducCantidadVentas.TabIndex = 4;
            this.btnProducCantidadVentas.Text = "Productos total ventas";
            this.btnProducCantidadVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducCantidadVentas.UseVisualStyleBackColor = false;
            this.btnProducCantidadVentas.Click += new System.EventHandler(this.btnProducCantidadVentas_Click);
            // 
            // btnProductoCantidad
            // 
            this.btnProductoCantidad.AutoEllipsis = true;
            this.btnProductoCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProductoCantidad.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnProductoCantidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnProductoCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoCantidad.ForeColor = System.Drawing.Color.Blue;
            this.btnProductoCantidad.Image = global::CapaPresentacion.Properties.Resources.icons8_documento_30_1_;
            this.btnProductoCantidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoCantidad.Location = new System.Drawing.Point(3, 91);
            this.btnProductoCantidad.Name = "btnProductoCantidad";
            this.btnProductoCantidad.Size = new System.Drawing.Size(144, 42);
            this.btnProductoCantidad.TabIndex = 3;
            this.btnProductoCantidad.Text = "Por cantidad producto";
            this.btnProductoCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductoCantidad.UseVisualStyleBackColor = false;
            this.btnProductoCantidad.Click += new System.EventHandler(this.btnProductoCantidad_Click);
            // 
            // btnProductoFecha
            // 
            this.btnProductoFecha.AutoEllipsis = true;
            this.btnProductoFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProductoFecha.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.btnProductoFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnProductoFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductoFecha.ForeColor = System.Drawing.Color.Blue;
            this.btnProductoFecha.Image = global::CapaPresentacion.Properties.Resources.icons8_documento_30_1_;
            this.btnProductoFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductoFecha.Location = new System.Drawing.Point(3, 16);
            this.btnProductoFecha.Name = "btnProductoFecha";
            this.btnProductoFecha.Size = new System.Drawing.Size(144, 42);
            this.btnProductoFecha.TabIndex = 2;
            this.btnProductoFecha.Text = "Por fecha registrado";
            this.btnProductoFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductoFecha.UseVisualStyleBackColor = false;
            this.btnProductoFecha.Click += new System.EventHandler(this.btnProductoFecha_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(902, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Productos";
            // 
            // timer1
            // 
            this.timer1.Interval = 24;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 27;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 27;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 27;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // btnProductos
            // 
            this.btnProductos.AutoSize = true;
            this.btnProductos.BackColor = System.Drawing.Color.Maroon;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnProductos.ForeColor = System.Drawing.Color.Tomato;
            this.btnProductos.Image = global::CapaPresentacion.Properties.Resources.icons8_carpeta_30_1_;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(857, 60);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(153, 42);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AutoEllipsis = true;
            this.btnClientes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.Tomato;
            this.btnClientes.Image = global::CapaPresentacion.Properties.Resources.icons8_carpeta_30_1_;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(595, 60);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(153, 42);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clienes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.AutoEllipsis = true;
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnProveedores.ForeColor = System.Drawing.Color.Tomato;
            this.btnProveedores.Image = global::CapaPresentacion.Properties.Resources.icons8_carpeta_30_1_;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(338, 60);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(153, 42);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Provedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnIngresos
            // 
            this.btnIngresos.AutoEllipsis = true;
            this.btnIngresos.BackColor = System.Drawing.Color.Gainsboro;
            this.btnIngresos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIngresos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ForeColor = System.Drawing.Color.Tomato;
            this.btnIngresos.Image = global::CapaPresentacion.Properties.Resources.icons8_carpeta_30_1_;
            this.btnIngresos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresos.Location = new System.Drawing.Point(77, 60);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(153, 42);
            this.btnIngresos.TabIndex = 1;
            this.btnIngresos.Text = "Control dinero";
            this.btnIngresos.UseVisualStyleBackColor = false;
            this.btnIngresos.Click += new System.EventHandler(this.btnIngresos_Click);
            // 
            // frmSelecReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1051, 617);
            this.Controls.Add(this.panelIngresos);
            this.Controls.Add(this.panelProveedores);
            this.Controls.Add(this.btnIngresos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelClientes);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelecReportes";
            this.Text = "Realizar Reporte";
            this.Load += new System.EventHandler(this.frmSelecReportes_Load);
            this.panelIngresos.ResumeLayout(false);
            this.panelProveedores.ResumeLayout(false);
            this.panelClientes.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Panel panelIngresos;
        private System.Windows.Forms.Button btn1PorFecha;
        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.Button btnVentaID;
        private System.Windows.Forms.Button btnTotalCompraClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Button btnProducCantidadVentas;
        private System.Windows.Forms.Button btnProductoCantidad;
        private System.Windows.Forms.Button btnProductoFecha;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button btnCompraProveedores;
    }
}