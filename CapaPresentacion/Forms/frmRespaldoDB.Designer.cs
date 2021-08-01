
namespace CapaPresentacion.Forms
{
    partial class frmRespaldoDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRespaldoDB));
            this.textBoxRutaRestaurar = new System.Windows.Forms.TextBox();
            this.textBoxRutaGuardar = new System.Windows.Forms.TextBox();
            this.labelrutarestaurar = new System.Windows.Forms.Label();
            this.labelrutaguardar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonRestaurar = new System.Windows.Forms.Button();
            this.buttonRutaRestaurar = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonRuta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxRutaRestaurar
            // 
            this.textBoxRutaRestaurar.Location = new System.Drawing.Point(208, 371);
            this.textBoxRutaRestaurar.Name = "textBoxRutaRestaurar";
            this.textBoxRutaRestaurar.Size = new System.Drawing.Size(326, 20);
            this.textBoxRutaRestaurar.TabIndex = 26;
            // 
            // textBoxRutaGuardar
            // 
            this.textBoxRutaGuardar.Location = new System.Drawing.Point(206, 256);
            this.textBoxRutaGuardar.Name = "textBoxRutaGuardar";
            this.textBoxRutaGuardar.Size = new System.Drawing.Size(326, 20);
            this.textBoxRutaGuardar.TabIndex = 25;
            // 
            // labelrutarestaurar
            // 
            this.labelrutarestaurar.AutoSize = true;
            this.labelrutarestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrutarestaurar.Location = new System.Drawing.Point(41, 365);
            this.labelrutarestaurar.Name = "labelrutarestaurar";
            this.labelrutarestaurar.Size = new System.Drawing.Size(163, 24);
            this.labelrutarestaurar.TabIndex = 24;
            this.labelrutarestaurar.Text = "Ruta a restaurar:";
            // 
            // labelrutaguardar
            // 
            this.labelrutaguardar.AutoSize = true;
            this.labelrutaguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrutaguardar.Location = new System.Drawing.Point(41, 252);
            this.labelrutaguardar.Name = "labelrutaguardar";
            this.labelrutaguardar.Size = new System.Drawing.Size(159, 24);
            this.labelrutaguardar.TabIndex = 23;
            this.labelrutaguardar.Text = "Ruta a guardar: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.labeltitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 22;
            // 
            // labeltitulo
            // 
            this.labeltitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.ForeColor = System.Drawing.Color.DeepPink;
            this.labeltitulo.Location = new System.Drawing.Point(12, 35);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(564, 25);
            this.labeltitulo.TabIndex = 5;
            this.labeltitulo.Text = "Backup y restauración de base datos en SQL Server";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescripcion.BackColor = System.Drawing.Color.Pink;
            this.textBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescripcion.Location = new System.Drawing.Point(12, 128);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(776, 96);
            this.textBoxDescripcion.TabIndex = 31;
            this.textBoxDescripcion.Text = resources.GetString("textBoxDescripcion.Text");
            // 
            // buttonRestaurar
            // 
            this.buttonRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestaurar.Image = global::CapaPresentacion.Properties.Resources.backup_and_restore_15493__1_;
            this.buttonRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestaurar.Location = new System.Drawing.Point(565, 419);
            this.buttonRestaurar.Name = "buttonRestaurar";
            this.buttonRestaurar.Size = new System.Drawing.Size(136, 56);
            this.buttonRestaurar.TabIndex = 30;
            this.buttonRestaurar.Text = "           Restaurar";
            this.buttonRestaurar.UseVisualStyleBackColor = true;
            this.buttonRestaurar.Click += new System.EventHandler(this.buttonRestaurar_Click);
            // 
            // buttonRutaRestaurar
            // 
            this.buttonRutaRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRutaRestaurar.Image = global::CapaPresentacion.Properties.Resources._1486505375_files_folder_search_magnifying_glass_file_search_magnifier_storage_81440__2_;
            this.buttonRutaRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRutaRestaurar.Location = new System.Drawing.Point(565, 371);
            this.buttonRutaRestaurar.Name = "buttonRutaRestaurar";
            this.buttonRutaRestaurar.Size = new System.Drawing.Size(102, 45);
            this.buttonRutaRestaurar.TabIndex = 29;
            this.buttonRutaRestaurar.Text = "       Ruta";
            this.buttonRutaRestaurar.UseVisualStyleBackColor = true;
            this.buttonRutaRestaurar.Click += new System.EventHandler(this.buttonRutaRestaurar_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackup.Image = global::CapaPresentacion.Properties.Resources.Drive_Backup_23188;
            this.buttonBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBackup.Location = new System.Drawing.Point(563, 297);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(138, 54);
            this.buttonBackup.TabIndex = 28;
            this.buttonBackup.Text = "         Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonRuta
            // 
            this.buttonRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRuta.Image = global::CapaPresentacion.Properties.Resources._1486505375_files_folder_search_magnifying_glass_file_search_magnifier_storage_81440__2_;
            this.buttonRuta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRuta.Location = new System.Drawing.Point(563, 246);
            this.buttonRuta.Name = "buttonRuta";
            this.buttonRuta.Size = new System.Drawing.Size(104, 45);
            this.buttonRuta.TabIndex = 27;
            this.buttonRuta.Text = "       Ruta";
            this.buttonRuta.UseVisualStyleBackColor = true;
            this.buttonRuta.Click += new System.EventHandler(this.buttonRuta_Click);
            // 
            // frmRespaldoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.buttonRestaurar);
            this.Controls.Add(this.buttonRutaRestaurar);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.buttonRuta);
            this.Controls.Add(this.textBoxRutaRestaurar);
            this.Controls.Add(this.textBoxRutaGuardar);
            this.Controls.Add(this.labelrutarestaurar);
            this.Controls.Add(this.labelrutaguardar);
            this.Controls.Add(this.panel1);
            this.Name = "frmRespaldoDB";
            this.Text = "Copia de seguridad";
            this.Load += new System.EventHandler(this.frmRespaldoDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRestaurar;
        private System.Windows.Forms.Button buttonRutaRestaurar;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Button buttonRuta;
        private System.Windows.Forms.TextBox textBoxRutaRestaurar;
        private System.Windows.Forms.TextBox textBoxRutaGuardar;
        private System.Windows.Forms.Label labelrutarestaurar;
        private System.Windows.Forms.Label labelrutaguardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
    }
}