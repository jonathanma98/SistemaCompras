
namespace CapaPresentacion.Forms
{
    partial class frmPantallaPrincipal
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
            this.panelProveedores = new System.Windows.Forms.Panel();
            this.labelProveedores = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.labelProductos = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGastos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxPincipal = new System.Windows.Forms.PictureBox();
            this.panelProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProveedores
            // 
            this.panelProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelProveedores.Controls.Add(this.labelProveedores);
            this.panelProveedores.Controls.Add(this.pictureBox2);
            this.panelProveedores.Location = new System.Drawing.Point(36, 3);
            this.panelProveedores.Name = "panelProveedores";
            this.panelProveedores.Size = new System.Drawing.Size(138, 107);
            this.panelProveedores.TabIndex = 2;
            // 
            // labelProveedores
            // 
            this.labelProveedores.AutoSize = true;
            this.labelProveedores.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedores.Location = new System.Drawing.Point(3, 84);
            this.labelProveedores.Name = "labelProveedores";
            this.labelProveedores.Size = new System.Drawing.Size(107, 18);
            this.labelProveedores.TabIndex = 2;
            this.labelProveedores.Text = "Proveedores: ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.iconmonstr_delivery_1_240;
            this.pictureBox2.Location = new System.Drawing.Point(15, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelProductos.Controls.Add(this.labelProductos);
            this.panelProductos.Controls.Add(this.pictureBox3);
            this.panelProductos.Location = new System.Drawing.Point(220, 6);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(138, 107);
            this.panelProductos.TabIndex = 3;
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.Location = new System.Drawing.Point(3, 84);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(86, 18);
            this.labelProductos.TabIndex = 2;
            this.labelProductos.Text = "Productos ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources.iconmonstr_delivery_11_2401;
            this.pictureBox3.Location = new System.Drawing.Point(15, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.labelGastos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(421, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 107);
            this.panel1.TabIndex = 4;
            // 
            // labelGastos
            // 
            this.labelGastos.AutoSize = true;
            this.labelGastos.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGastos.Location = new System.Drawing.Point(3, 84);
            this.labelGastos.Name = "labelGastos";
            this.labelGastos.Size = new System.Drawing.Size(67, 18);
            this.labelGastos.TabIndex = 2;
            this.labelGastos.Text = "Gastos: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.iconmonstr_fax_3_240;
            this.pictureBox1.Location = new System.Drawing.Point(15, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(605, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 107);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresos: ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CapaPresentacion.Properties.Resources.noun_Hairstylist_3925549;
            this.pictureBox4.Location = new System.Drawing.Point(15, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(109, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panelProveedores);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panelProductos);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 116);
            this.panel3.TabIndex = 6;
            // 
            // pictureBoxPincipal
            // 
            this.pictureBoxPincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPincipal.Image = global::CapaPresentacion.Properties.Resources.PicsArt_07_13_02_52_25_1_;
            this.pictureBoxPincipal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPincipal.Name = "pictureBoxPincipal";
            this.pictureBoxPincipal.Size = new System.Drawing.Size(798, 450);
            this.pictureBoxPincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPincipal.TabIndex = 0;
            this.pictureBoxPincipal.TabStop = false;
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBoxPincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPantallaPrincipal";
            this.Text = "frmPantallaPrincipal";
            this.panelProveedores.ResumeLayout(false);
            this.panelProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelProductos.ResumeLayout(false);
            this.panelProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPincipal;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelProveedores;
        private System.Windows.Forms.Label labelProveedores;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelGastos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
    }
}