
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
            this.comboBoxtamaño = new System.Windows.Forms.ComboBox();
            this.dateTimePickerfechacompra = new System.Windows.Forms.DateTimePicker();
            this.mskcodigo = new System.Windows.Forms.MaskedTextBox();
            this.textvalorcompra = new System.Windows.Forms.TextBox();
            this.textexistencia = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.buttonconsultar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonmodificar = new System.Windows.Forms.Button();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.labelfecchacompra = new System.Windows.Forms.Label();
            this.labelvalorcompra = new System.Windows.Forms.Label();
            this.labelcantidad = new System.Windows.Forms.Label();
            this.labeltipocedula = new System.Windows.Forms.Label();
            this.labelcedula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelnombre
            // 
            this.labelnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(118, 97);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(79, 19);
            this.labelnombre.TabIndex = 160;
            this.labelnombre.Text = "Nombre:";
            // 
            // comboBoxcategoria
            // 
            this.comboBoxcategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxcategoria.FormattingEnabled = true;
            this.comboBoxcategoria.Location = new System.Drawing.Point(206, 176);
            this.comboBoxcategoria.Name = "comboBoxcategoria";
            this.comboBoxcategoria.Size = new System.Drawing.Size(125, 21);
            this.comboBoxcategoria.TabIndex = 159;
            // 
            // labelcategoria
            // 
            this.labelcategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelcategoria.AutoSize = true;
            this.labelcategoria.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcategoria.Location = new System.Drawing.Point(98, 175);
            this.labelcategoria.Name = "labelcategoria";
            this.labelcategoria.Size = new System.Drawing.Size(99, 19);
            this.labelcategoria.TabIndex = 158;
            this.labelcategoria.Text = "Categoria:";
            // 
            // textBoxvalorventa
            // 
            this.textBoxvalorventa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxvalorventa.Location = new System.Drawing.Point(206, 272);
            this.textBoxvalorventa.Name = "textBoxvalorventa";
            this.textBoxvalorventa.Size = new System.Drawing.Size(200, 20);
            this.textBoxvalorventa.TabIndex = 157;
            // 
            // labelvalorventa
            // 
            this.labelvalorventa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelvalorventa.AutoSize = true;
            this.labelvalorventa.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelvalorventa.Location = new System.Drawing.Point(78, 273);
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
            this.labeltitulo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltitulo1.AutoSize = true;
            this.labeltitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo1.Location = new System.Drawing.Point(398, 28);
            this.labeltitulo1.Name = "labeltitulo1";
            this.labeltitulo1.Size = new System.Drawing.Size(166, 24);
            this.labeltitulo1.TabIndex = 154;
            this.labeltitulo1.Text = "Salon de belleza";
            // 
            // textBoxdescripcion
            // 
            this.textBoxdescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxdescripcion.Location = new System.Drawing.Point(206, 127);
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
            this.label2.Location = new System.Drawing.Point(83, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 152;
            this.label2.Text = "Descripcion:";
            // 
            // comboBoxtamaño
            // 
            this.comboBoxtamaño.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxtamaño.FormattingEnabled = true;
            this.comboBoxtamaño.Location = new System.Drawing.Point(206, 209);
            this.comboBoxtamaño.Name = "comboBoxtamaño";
            this.comboBoxtamaño.Size = new System.Drawing.Size(125, 21);
            this.comboBoxtamaño.TabIndex = 151;
            // 
            // dateTimePickerfechacompra
            // 
            this.dateTimePickerfechacompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerfechacompra.Location = new System.Drawing.Point(206, 308);
            this.dateTimePickerfechacompra.Name = "dateTimePickerfechacompra";
            this.dateTimePickerfechacompra.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerfechacompra.TabIndex = 150;
            // 
            // mskcodigo
            // 
            this.mskcodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mskcodigo.Location = new System.Drawing.Point(206, 66);
            this.mskcodigo.Mask = "#-####-####";
            this.mskcodigo.Name = "mskcodigo";
            this.mskcodigo.Size = new System.Drawing.Size(125, 20);
            this.mskcodigo.TabIndex = 149;
            // 
            // textvalorcompra
            // 
            this.textvalorcompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textvalorcompra.Location = new System.Drawing.Point(206, 246);
            this.textvalorcompra.Name = "textvalorcompra";
            this.textvalorcompra.Size = new System.Drawing.Size(200, 20);
            this.textvalorcompra.TabIndex = 148;
            // 
            // textexistencia
            // 
            this.textexistencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textexistencia.Location = new System.Drawing.Point(206, 350);
            this.textexistencia.Name = "textexistencia";
            this.textexistencia.Size = new System.Drawing.Size(200, 20);
            this.textexistencia.TabIndex = 147;
            // 
            // textnombre
            // 
            this.textnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textnombre.Location = new System.Drawing.Point(206, 96);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(135, 20);
            this.textnombre.TabIndex = 146;
            // 
            // buttonconsultar
            // 
            this.buttonconsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconsultar.Location = new System.Drawing.Point(250, 394);
            this.buttonconsultar.Name = "buttonconsultar";
            this.buttonconsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonconsultar.TabIndex = 145;
            this.buttonconsultar.Text = "Consultar";
            this.buttonconsultar.UseVisualStyleBackColor = true;
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttoneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Location = new System.Drawing.Point(88, 394);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(75, 23);
            this.buttoneliminar.TabIndex = 144;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodificar.Location = new System.Drawing.Point(168, 394);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(75, 23);
            this.buttonmodificar.TabIndex = 143;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.UseVisualStyleBackColor = true;
            // 
            // buttonguardar
            // 
            this.buttonguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.Location = new System.Drawing.Point(331, 394);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(75, 23);
            this.buttonguardar.TabIndex = 142;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            // 
            // labelfecchacompra
            // 
            this.labelfecchacompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelfecchacompra.AutoSize = true;
            this.labelfecchacompra.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecchacompra.Location = new System.Drawing.Point(66, 308);
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
            this.labelvalorcompra.Location = new System.Drawing.Point(67, 245);
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
            this.labelcantidad.Location = new System.Drawing.Point(93, 349);
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
            this.labeltipocedula.Location = new System.Drawing.Point(118, 208);
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
            this.labelcedula.Location = new System.Drawing.Point(133, 67);
            this.labelcedula.Name = "labelcedula";
            this.labelcedula.Size = new System.Drawing.Size(64, 19);
            this.labelcedula.TabIndex = 137;
            this.labelcedula.Text = "Codigo";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.comboBoxcategoria);
            this.Controls.Add(this.labelcategoria);
            this.Controls.Add(this.textBoxvalorventa);
            this.Controls.Add(this.labelvalorventa);
            this.Controls.Add(this.labelnav);
            this.Controls.Add(this.labeltitulo1);
            this.Controls.Add(this.textBoxdescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxtamaño);
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
            this.Name = "frmProductos";
            this.Text = "frmProductos";
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
        private System.Windows.Forms.ComboBox comboBoxtamaño;
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
    }
}