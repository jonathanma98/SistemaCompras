
namespace CapaPresentacion.Forms
{
    partial class frmProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelnav = new System.Windows.Forms.Label();
            this.comboBoxcalificacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltitulo1 = new System.Windows.Forms.Label();
            this.textBoxdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxtipocedula = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxtelefono = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxcedula = new System.Windows.Forms.MaskedTextBox();
            this.textdireccion = new System.Windows.Forms.TextBox();
            this.textapellido1 = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.buttonconsultar = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonmodificar = new System.Windows.Forms.Button();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labeltipocedula = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelapelliido1 = new System.Windows.Forms.Label();
            this.labeltelefono = new System.Windows.Forms.Label();
            this.labelcedula = new System.Windows.Forms.Label();
            this.dataGridViewProveedor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelnav
            // 
            this.labelnav.AutoSize = true;
            this.labelnav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnav.Location = new System.Drawing.Point(50, 20);
            this.labelnav.Name = "labelnav";
            this.labelnav.Size = new System.Drawing.Size(302, 24);
            this.labelnav.TabIndex = 158;
            this.labelnav.Text = "Mantenimiento de Proveedores";
            // 
            // comboBoxcalificacion
            // 
            this.comboBoxcalificacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxcalificacion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxcalificacion.ForeColor = System.Drawing.Color.Black;
            this.comboBoxcalificacion.FormattingEnabled = true;
            this.comboBoxcalificacion.ItemHeight = 20;
            this.comboBoxcalificacion.Location = new System.Drawing.Point(37, 372);
            this.comboBoxcalificacion.Name = "comboBoxcalificacion";
            this.comboBoxcalificacion.Size = new System.Drawing.Size(125, 28);
            this.comboBoxcalificacion.TabIndex = 157;
            this.comboBoxcalificacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxcalificacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 156;
            this.label1.Text = "Calificacion:";
            // 
            // labeltitulo1
            // 
            this.labeltitulo1.AutoSize = true;
            this.labeltitulo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeltitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo1.Location = new System.Drawing.Point(0, 0);
            this.labeltitulo1.Name = "labeltitulo1";
            this.labeltitulo1.Padding = new System.Windows.Forms.Padding(5);
            this.labeltitulo1.Size = new System.Drawing.Size(176, 34);
            this.labeltitulo1.TabIndex = 155;
            this.labeltitulo1.Text = "Salon de belleza";
            // 
            // textBoxdescripcion
            // 
            this.textBoxdescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxdescripcion.Location = new System.Drawing.Point(37, 296);
            this.textBoxdescripcion.Multiline = true;
            this.textBoxdescripcion.Name = "textBoxdescripcion";
            this.textBoxdescripcion.Size = new System.Drawing.Size(172, 51);
            this.textBoxdescripcion.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 153;
            this.label2.Text = "Descripcion:";
            // 
            // comboBoxtipocedula
            // 
            this.comboBoxtipocedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxtipocedula.FormattingEnabled = true;
            this.comboBoxtipocedula.Location = new System.Drawing.Point(241, 99);
            this.comboBoxtipocedula.Name = "comboBoxtipocedula";
            this.comboBoxtipocedula.Size = new System.Drawing.Size(108, 21);
            this.comboBoxtipocedula.TabIndex = 152;
            this.comboBoxtipocedula.SelectedIndexChanged += new System.EventHandler(this.comboBoxtipocedula_SelectedIndexChanged);
            this.comboBoxtipocedula.Click += new System.EventHandler(this.comboBoxtipocedula_Click);
            // 
            // maskedTextBoxtelefono
            // 
            this.maskedTextBoxtelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedTextBoxtelefono.Location = new System.Drawing.Point(243, 237);
            this.maskedTextBoxtelefono.Mask = "####-####";
            this.maskedTextBoxtelefono.Name = "maskedTextBoxtelefono";
            this.maskedTextBoxtelefono.Size = new System.Drawing.Size(125, 20);
            this.maskedTextBoxtelefono.TabIndex = 150;
            // 
            // maskedTextBoxcedula
            // 
            this.maskedTextBoxcedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedTextBoxcedula.Location = new System.Drawing.Point(37, 100);
            this.maskedTextBoxcedula.Mask = "#-####-####";
            this.maskedTextBoxcedula.Name = "maskedTextBoxcedula";
            this.maskedTextBoxcedula.Size = new System.Drawing.Size(165, 20);
            this.maskedTextBoxcedula.TabIndex = 149;
            // 
            // textdireccion
            // 
            this.textdireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textdireccion.Location = new System.Drawing.Point(243, 296);
            this.textdireccion.Name = "textdireccion";
            this.textdireccion.Size = new System.Drawing.Size(140, 20);
            this.textdireccion.TabIndex = 148;
            // 
            // textapellido1
            // 
            this.textapellido1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textapellido1.Location = new System.Drawing.Point(241, 171);
            this.textapellido1.Name = "textapellido1";
            this.textapellido1.Size = new System.Drawing.Size(165, 20);
            this.textapellido1.TabIndex = 146;
            // 
            // textemail
            // 
            this.textemail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textemail.Location = new System.Drawing.Point(37, 237);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(167, 20);
            this.textemail.TabIndex = 145;
            // 
            // textnombre
            // 
            this.textnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textnombre.Location = new System.Drawing.Point(37, 171);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(165, 20);
            this.textnombre.TabIndex = 144;
            // 
            // buttonconsultar
            // 
            this.buttonconsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonconsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconsultar.Location = new System.Drawing.Point(341, 466);
            this.buttonconsultar.Name = "buttonconsultar";
            this.buttonconsultar.Size = new System.Drawing.Size(75, 33);
            this.buttonconsultar.TabIndex = 143;
            this.buttonconsultar.Text = "Consultar";
            this.buttonconsultar.UseVisualStyleBackColor = false;
            this.buttonconsultar.Click += new System.EventHandler(this.buttonconsultar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttoneliminar.BackColor = System.Drawing.Color.Red;
            this.buttoneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Location = new System.Drawing.Point(39, 466);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(75, 33);
            this.buttoneliminar.TabIndex = 142;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodificar.Location = new System.Drawing.Point(135, 466);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(75, 33);
            this.buttonmodificar.TabIndex = 141;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.UseVisualStyleBackColor = false;
            this.buttonmodificar.Click += new System.EventHandler(this.buttonmodificar_Click);
            // 
            // buttonguardar
            // 
            this.buttonguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.Location = new System.Drawing.Point(216, 466);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(75, 33);
            this.buttonguardar.TabIndex = 140;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // labeldireccion
            // 
            this.labeldireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion.Location = new System.Drawing.Point(242, 274);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(95, 19);
            this.labeldireccion.TabIndex = 138;
            this.labeldireccion.Text = "Direccion:";
            // 
            // labelemail
            // 
            this.labelemail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(35, 215);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(61, 19);
            this.labelemail.TabIndex = 137;
            this.labelemail.Text = "Email:";
            // 
            // labeltipocedula
            // 
            this.labeltipocedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeltipocedula.AutoSize = true;
            this.labeltipocedula.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipocedula.Location = new System.Drawing.Point(237, 78);
            this.labeltipocedula.Name = "labeltipocedula";
            this.labeltipocedula.Size = new System.Drawing.Size(112, 19);
            this.labeltipocedula.TabIndex = 136;
            this.labeltipocedula.Text = "Tipo Cedula:";
            // 
            // labelnombre
            // 
            this.labelnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(33, 149);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(79, 19);
            this.labelnombre.TabIndex = 135;
            this.labelnombre.Text = "Nombre:";
            // 
            // labelapelliido1
            // 
            this.labelapelliido1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelapelliido1.AutoSize = true;
            this.labelapelliido1.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapelliido1.Location = new System.Drawing.Point(237, 149);
            this.labelapelliido1.Name = "labelapelliido1";
            this.labelapelliido1.Size = new System.Drawing.Size(96, 19);
            this.labelapelliido1.TabIndex = 134;
            this.labelapelliido1.Text = "Apellidos:";
            // 
            // labeltelefono
            // 
            this.labeltelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeltelefono.AutoSize = true;
            this.labeltelefono.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelefono.Location = new System.Drawing.Point(239, 215);
            this.labeltelefono.Name = "labeltelefono";
            this.labeltelefono.Size = new System.Drawing.Size(91, 19);
            this.labeltelefono.TabIndex = 132;
            this.labeltelefono.Text = "Telefono:";
            // 
            // labelcedula
            // 
            this.labelcedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelcedula.AutoSize = true;
            this.labelcedula.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcedula.Location = new System.Drawing.Point(33, 78);
            this.labelcedula.Name = "labelcedula";
            this.labelcedula.Size = new System.Drawing.Size(72, 19);
            this.labelcedula.TabIndex = 131;
            this.labelcedula.Text = "Cedula:";
            // 
            // dataGridViewProveedor
            // 
            this.dataGridViewProveedor.AllowUserToAddRows = false;
            this.dataGridViewProveedor.AllowUserToDeleteRows = false;
            this.dataGridViewProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridViewProveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TipoId,
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Email,
            this.Descripcion,
            this.Calificacion});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProveedor.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewProveedor.Location = new System.Drawing.Point(2, 34);
            this.dataGridViewProveedor.MultiSelect = false;
            this.dataGridViewProveedor.Name = "dataGridViewProveedor";
            this.dataGridViewProveedor.Size = new System.Drawing.Size(473, 484);
            this.dataGridViewProveedor.TabIndex = 159;
            this.dataGridViewProveedor.Visible = false;
            this.dataGridViewProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProveedor_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Cedula";
            this.id.Name = "id";
            // 
            // TipoId
            // 
            this.TipoId.HeaderText = "Tipo Cedula";
            this.TipoId.Name = "TipoId";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefeno";
            this.Telefono.Name = "Telefono";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridViewProveedor);
            this.panel1.Controls.Add(this.labeltitulo1);
            this.panel1.Location = new System.Drawing.Point(463, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 518);
            this.panel1.TabIndex = 160;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(938, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelnav);
            this.Controls.Add(this.comboBoxcalificacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxdescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxtipocedula);
            this.Controls.Add(this.maskedTextBoxtelefono);
            this.Controls.Add(this.maskedTextBoxcedula);
            this.Controls.Add(this.textdireccion);
            this.Controls.Add(this.textapellido1);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.buttonconsultar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonmodificar);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.labeldireccion);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labeltipocedula);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelapelliido1);
            this.Controls.Add(this.labeltelefono);
            this.Controls.Add(this.labelcedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedores";
            this.Text = "Registrar Proveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnav;
        private System.Windows.Forms.ComboBox comboBoxcalificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltitulo1;
        private System.Windows.Forms.TextBox textBoxdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxtipocedula;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxtelefono;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxcedula;
        private System.Windows.Forms.TextBox textdireccion;
        private System.Windows.Forms.TextBox textapellido1;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.Button buttonconsultar;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonmodificar;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labeltipocedula;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelapelliido1;
        private System.Windows.Forms.Label labeltelefono;
        private System.Windows.Forms.Label labelcedula;
        private System.Windows.Forms.DataGridView dataGridViewProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.Panel panel1;
    }
}