
namespace CapaPresentacion.Forms
{
    partial class frmRegistrarclientes
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
            this.labelnav = new System.Windows.Forms.Label();
            this.labeltitulo1 = new System.Windows.Forms.Label();
            this.comboBoxtipocedula = new System.Windows.Forms.ComboBox();
            this.dateTimePickerfechanacimiento = new System.Windows.Forms.DateTimePicker();
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
            this.labelfechanacimiento = new System.Windows.Forms.Label();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labeltipocedula = new System.Windows.Forms.Label();
            this.labelnombre = new System.Windows.Forms.Label();
            this.labelapelliidos = new System.Windows.Forms.Label();
            this.labeltelefono = new System.Windows.Forms.Label();
            this.labelcedula = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnav
            // 
            this.labelnav.AutoSize = true;
            this.labelnav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnav.Location = new System.Drawing.Point(64, 27);
            this.labelnav.Name = "labelnav";
            this.labelnav.Size = new System.Drawing.Size(258, 24);
            this.labelnav.TabIndex = 127;
            this.labelnav.Text = "Mantenimiento de Clientes";
            // 
            // labeltitulo1
            // 
            this.labeltitulo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltitulo1.AutoSize = true;
            this.labeltitulo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo1.Location = new System.Drawing.Point(155, 19);
            this.labeltitulo1.Name = "labeltitulo1";
            this.labeltitulo1.Size = new System.Drawing.Size(166, 24);
            this.labeltitulo1.TabIndex = 126;
            this.labeltitulo1.Text = "Salon de belleza";
            // 
            // comboBoxtipocedula
            // 
            this.comboBoxtipocedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxtipocedula.FormattingEnabled = true;
            this.comboBoxtipocedula.Location = new System.Drawing.Point(208, 112);
            this.comboBoxtipocedula.Name = "comboBoxtipocedula";
            this.comboBoxtipocedula.Size = new System.Drawing.Size(152, 21);
            this.comboBoxtipocedula.TabIndex = 125;
            this.comboBoxtipocedula.SelectedIndexChanged += new System.EventHandler(this.comboBoxtipocedula_SelectedIndexChanged);
            // 
            // dateTimePickerfechanacimiento
            // 
            this.dateTimePickerfechanacimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerfechanacimiento.Location = new System.Drawing.Point(16, 363);
            this.dateTimePickerfechanacimiento.Name = "dateTimePickerfechanacimiento";
            this.dateTimePickerfechanacimiento.Size = new System.Drawing.Size(222, 20);
            this.dateTimePickerfechanacimiento.TabIndex = 124;
            // 
            // maskedTextBoxtelefono
            // 
            this.maskedTextBoxtelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedTextBoxtelefono.Location = new System.Drawing.Point(208, 235);
            this.maskedTextBoxtelefono.Mask = "####-####";
            this.maskedTextBoxtelefono.Name = "maskedTextBoxtelefono";
            this.maskedTextBoxtelefono.Size = new System.Drawing.Size(152, 20);
            this.maskedTextBoxtelefono.TabIndex = 123;
            // 
            // maskedTextBoxcedula
            // 
            this.maskedTextBoxcedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.maskedTextBoxcedula.Location = new System.Drawing.Point(21, 112);
            this.maskedTextBoxcedula.Mask = "#-####-####";
            this.maskedTextBoxcedula.Name = "maskedTextBoxcedula";
            this.maskedTextBoxcedula.Size = new System.Drawing.Size(154, 20);
            this.maskedTextBoxcedula.TabIndex = 122;
            // 
            // textdireccion
            // 
            this.textdireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textdireccion.Location = new System.Drawing.Point(122, 278);
            this.textdireccion.Multiline = true;
            this.textdireccion.Name = "textdireccion";
            this.textdireccion.Size = new System.Drawing.Size(217, 43);
            this.textdireccion.TabIndex = 121;
            // 
            // textapellido1
            // 
            this.textapellido1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textapellido1.Location = new System.Drawing.Point(208, 172);
            this.textapellido1.Name = "textapellido1";
            this.textapellido1.Size = new System.Drawing.Size(152, 20);
            this.textapellido1.TabIndex = 119;
            // 
            // textemail
            // 
            this.textemail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textemail.Location = new System.Drawing.Point(21, 235);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(154, 20);
            this.textemail.TabIndex = 118;
            // 
            // textnombre
            // 
            this.textnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textnombre.Location = new System.Drawing.Point(21, 172);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(154, 20);
            this.textnombre.TabIndex = 117;
            // 
            // buttonconsultar
            // 
            this.buttonconsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconsultar.Location = new System.Drawing.Point(204, 407);
            this.buttonconsultar.Name = "buttonconsultar";
            this.buttonconsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonconsultar.TabIndex = 116;
            this.buttonconsultar.Text = "Consultar";
            this.buttonconsultar.UseVisualStyleBackColor = true;
            this.buttonconsultar.Click += new System.EventHandler(this.buttonconsultar_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttoneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.Location = new System.Drawing.Point(42, 407);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(75, 23);
            this.buttoneliminar.TabIndex = 115;
            this.buttoneliminar.Text = "Eliminar";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonmodificar
            // 
            this.buttonmodificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodificar.Location = new System.Drawing.Point(122, 407);
            this.buttonmodificar.Name = "buttonmodificar";
            this.buttonmodificar.Size = new System.Drawing.Size(75, 23);
            this.buttonmodificar.TabIndex = 114;
            this.buttonmodificar.Text = "Modificar";
            this.buttonmodificar.UseVisualStyleBackColor = true;
            this.buttonmodificar.Click += new System.EventHandler(this.buttonmodificar_Click);
            // 
            // buttonguardar
            // 
            this.buttonguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.Location = new System.Drawing.Point(285, 407);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(75, 23);
            this.buttonguardar.TabIndex = 113;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = true;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // labelfechanacimiento
            // 
            this.labelfechanacimiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelfechanacimiento.AutoSize = true;
            this.labelfechanacimiento.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfechanacimiento.Location = new System.Drawing.Point(12, 341);
            this.labelfechanacimiento.Name = "labelfechanacimiento";
            this.labelfechanacimiento.Size = new System.Drawing.Size(162, 19);
            this.labelfechanacimiento.TabIndex = 112;
            this.labelfechanacimiento.Text = "Fecha Nacimiento:";
            // 
            // labeldireccion
            // 
            this.labeldireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion.Location = new System.Drawing.Point(22, 277);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(95, 19);
            this.labeldireccion.TabIndex = 111;
            this.labeldireccion.Text = "Direccion:";
            // 
            // labelemail
            // 
            this.labelemail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(17, 213);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(61, 19);
            this.labelemail.TabIndex = 110;
            this.labelemail.Text = "Email:";
            // 
            // labeltipocedula
            // 
            this.labeltipocedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeltipocedula.AutoSize = true;
            this.labeltipocedula.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltipocedula.Location = new System.Drawing.Point(204, 90);
            this.labeltipocedula.Name = "labeltipocedula";
            this.labeltipocedula.Size = new System.Drawing.Size(112, 19);
            this.labeltipocedula.TabIndex = 109;
            this.labeltipocedula.Text = "Tipo Cedula:";
            // 
            // labelnombre
            // 
            this.labelnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelnombre.AutoSize = true;
            this.labelnombre.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombre.Location = new System.Drawing.Point(17, 150);
            this.labelnombre.Name = "labelnombre";
            this.labelnombre.Size = new System.Drawing.Size(79, 19);
            this.labelnombre.TabIndex = 108;
            this.labelnombre.Text = "Nombre:";
            // 
            // labelapelliidos
            // 
            this.labelapelliidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelapelliidos.AutoSize = true;
            this.labelapelliidos.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelapelliidos.Location = new System.Drawing.Point(204, 150);
            this.labelapelliidos.Name = "labelapelliidos";
            this.labelapelliidos.Size = new System.Drawing.Size(96, 19);
            this.labelapelliidos.TabIndex = 107;
            this.labelapelliidos.Text = "Apellidos:";
            // 
            // labeltelefono
            // 
            this.labeltelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeltelefono.AutoSize = true;
            this.labeltelefono.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelefono.Location = new System.Drawing.Point(204, 213);
            this.labeltelefono.Name = "labeltelefono";
            this.labeltelefono.Size = new System.Drawing.Size(91, 19);
            this.labeltelefono.TabIndex = 105;
            this.labeltelefono.Text = "Telefono:";
            // 
            // labelcedula
            // 
            this.labelcedula.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelcedula.AutoSize = true;
            this.labelcedula.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcedula.Location = new System.Drawing.Point(17, 90);
            this.labelcedula.Name = "labelcedula";
            this.labelcedula.Size = new System.Drawing.Size(67, 19);
            this.labelcedula.TabIndex = 104;
            this.labelcedula.Text = "Cedula";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewClientes);
            this.panel1.Controls.Add(this.labeltitulo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(397, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 479);
            this.panel1.TabIndex = 128;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TipoId,
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Email,
            this.Direcion});
            this.dataGridViewClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewClientes.Location = new System.Drawing.Point(0, 46);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(525, 433);
            this.dataGridViewClientes.TabIndex = 127;
            this.dataGridViewClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Cedula";
            this.Id.Name = "Id";
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
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Direcion
            // 
            this.Direcion.HeaderText = "Direcion";
            this.Direcion.Name = "Direcion";
            // 
            // frmRegistrarclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(922, 479);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelnav);
            this.Controls.Add(this.comboBoxtipocedula);
            this.Controls.Add(this.dateTimePickerfechanacimiento);
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
            this.Controls.Add(this.labelfechanacimiento);
            this.Controls.Add(this.labeldireccion);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labeltipocedula);
            this.Controls.Add(this.labelnombre);
            this.Controls.Add(this.labelapelliidos);
            this.Controls.Add(this.labeltelefono);
            this.Controls.Add(this.labelcedula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistrarclientes";
            this.Text = "frmRegistrarclientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnav;
        private System.Windows.Forms.Label labeltitulo1;
        private System.Windows.Forms.ComboBox comboBoxtipocedula;
        private System.Windows.Forms.DateTimePicker dateTimePickerfechanacimiento;
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
        private System.Windows.Forms.Label labelfechanacimiento;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labeltipocedula;
        private System.Windows.Forms.Label labelnombre;
        private System.Windows.Forms.Label labelapelliidos;
        private System.Windows.Forms.Label labeltelefono;
        private System.Windows.Forms.Label labelcedula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direcion;
    }
}