
namespace CapaPresentacion.Forms
{
    partial class frmControlDinero
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea21 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend21 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea22 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend22 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartControlDinero = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labeldescripcion = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDinero)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.panelSuperior.Controls.Add(this.labelHora);
            this.panelSuperior.Controls.Add(this.labelDate);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(943, 75);
            this.panelSuperior.TabIndex = 0;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(444, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 35);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "l";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(445, 35);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(28, 30);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "l";
            // 
            // panelInferior
            // 
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 495);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(943, 21);
            this.panelInferior.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartVentas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartControlDinero, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 420);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // chartVentas
            // 
            this.chartVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chartVentas.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chartVentas.BackSecondaryColor = System.Drawing.Color.Fuchsia;
            this.chartVentas.BorderlineColor = System.Drawing.Color.Black;
            this.chartVentas.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            this.chartVentas.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea21.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea21.Name = "ChartArea1";
            this.chartVentas.ChartAreas.Add(chartArea21);
            this.chartVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            legend21.Name = "Legend1";
            this.chartVentas.Legends.Add(legend21);
            this.chartVentas.Location = new System.Drawing.Point(474, 3);
            this.chartVentas.Name = "chartVentas";
            series31.ChartArea = "ChartArea1";
            series31.IsValueShownAsLabel = true;
            series31.Legend = "Legend1";
            series31.Name = "Ventas";
            this.chartVentas.Series.Add(series31);
            this.chartVentas.Size = new System.Drawing.Size(466, 204);
            this.chartVentas.TabIndex = 0;
            this.chartVentas.Text = "chart1";
            // 
            // chartControlDinero
            // 
            this.chartControlDinero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControlDinero.BackColor = System.Drawing.Color.Black;
            this.chartControlDinero.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea22.Name = "ChartArea1";
            this.chartControlDinero.ChartAreas.Add(chartArea22);
            legend22.Name = "Legend1";
            this.chartControlDinero.Legends.Add(legend22);
            this.chartControlDinero.Location = new System.Drawing.Point(474, 213);
            this.chartControlDinero.Name = "chartControlDinero";
            series32.BorderWidth = 3;
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series32.Color = System.Drawing.Color.Lime;
            series32.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series32.LabelBorderWidth = 5;
            series32.Legend = "Legend1";
            series32.Name = "Ingreso";
            series33.BorderWidth = 3;
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series33.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series33.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series33.LabelBorderWidth = 5;
            series33.Legend = "Legend1";
            series33.Name = "Gastos";
            this.chartControlDinero.Series.Add(series32);
            this.chartControlDinero.Series.Add(series33);
            this.chartControlDinero.Size = new System.Drawing.Size(466, 204);
            this.chartControlDinero.TabIndex = 2;
            this.chartControlDinero.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Fuchsia;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.buttonguardar);
            this.panel1.Controls.Add(this.labeldescripcion);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 204);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Representa un tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.IntegralHeight = false;
            this.cbTipo.Location = new System.Drawing.Point(257, 29);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(172, 21);
            this.cbTipo.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripcion.Location = new System.Drawing.Point(26, 94);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(403, 73);
            this.txtDescripcion.TabIndex = 3;
            // 
            // labeldescripcion
            // 
            this.labeldescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labeldescripcion.AutoSize = true;
            this.labeldescripcion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldescripcion.Location = new System.Drawing.Point(23, 71);
            this.labeldescripcion.Name = "labeldescripcion";
            this.labeldescripcion.Size = new System.Drawing.Size(145, 20);
            this.labeldescripcion.TabIndex = 2;
            this.labeldescripcion.Text = "Descripcion para guia";
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMonto.Location = new System.Drawing.Point(26, 29);
            this.txtMonto.Multiline = true;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(175, 29);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto de dinero";
            // 
            // buttonguardar
            // 
            this.buttonguardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonguardar.BackColor = System.Drawing.Color.Lime;
            this.buttonguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonguardar.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.buttonguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonguardar.Image = global::CapaPresentacion.Properties.Resources.icons8_marcapáginas_16_2_;
            this.buttonguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonguardar.Location = new System.Drawing.Point(158, 170);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(88, 31);
            this.buttonguardar.TabIndex = 143;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // frmControlDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Name = "frmControlDinero";
            this.Text = "frmControlDinero";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDinero)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartControlDinero;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labeldescripcion;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Button buttonguardar;
    }
}