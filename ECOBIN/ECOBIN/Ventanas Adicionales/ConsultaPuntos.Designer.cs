namespace ECOBIN.Ventanas_Adicionales
{
    partial class ConsultaPuntos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPuntos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.registroDeMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPuntos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewReciclaje = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptsObtenidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewMovimientos = new System.Windows.Forms.DataGridView();
            this.cldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDetalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCanje = new System.Windows.Forms.Button();
            this.comboBeneficios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReciclaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1116, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeMaterialesToolStripMenuItem,
            this.rankingGeneralToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // registroDeMaterialesToolStripMenuItem
            // 
            this.registroDeMaterialesToolStripMenuItem.Name = "registroDeMaterialesToolStripMenuItem";
            this.registroDeMaterialesToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.registroDeMaterialesToolStripMenuItem.Text = "Registro de Materiales";
            this.registroDeMaterialesToolStripMenuItem.Click += new System.EventHandler(this.registroDeMaterialesToolStripMenuItem_Click);
            // 
            // rankingGeneralToolStripMenuItem
            // 
            this.rankingGeneralToolStripMenuItem.Name = "rankingGeneralToolStripMenuItem";
            this.rankingGeneralToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.rankingGeneralToolStripMenuItem.Text = "Ranking General";
            this.rankingGeneralToolStripMenuItem.Click += new System.EventHandler(this.rankingGeneralToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(392, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "MiEcoBIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.labelPuntos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(385, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 106);
            this.panel1.TabIndex = 2;
            // 
            // labelPuntos
            // 
            this.labelPuntos.AutoSize = true;
            this.labelPuntos.BackColor = System.Drawing.Color.Transparent;
            this.labelPuntos.Font = new System.Drawing.Font("Mongolian Baiti", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntos.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPuntos.Location = new System.Drawing.Point(194, 18);
            this.labelPuntos.Name = "labelPuntos";
            this.labelPuntos.Size = new System.Drawing.Size(196, 71);
            this.labelPuntos.TabIndex = 1;
            this.labelPuntos.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tus puntos EcoBIN:";
            // 
            // dataGridViewReciclaje
            // 
            this.dataGridViewReciclaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReciclaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.tpMaterial,
            this.cDada,
            this.ptsObtenidos});
            this.dataGridViewReciclaje.Location = new System.Drawing.Point(46, 306);
            this.dataGridViewReciclaje.Name = "dataGridViewReciclaje";
            this.dataGridViewReciclaje.RowHeadersWidth = 51;
            this.dataGridViewReciclaje.RowTemplate.Height = 24;
            this.dataGridViewReciclaje.Size = new System.Drawing.Size(425, 187);
            this.dataGridViewReciclaje.TabIndex = 3;
            this.dataGridViewReciclaje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Fecha";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Time
            // 
            this.Time.HeaderText = "Hora";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.Width = 125;
            // 
            // tpMaterial
            // 
            this.tpMaterial.HeaderText = "Tipo de Material";
            this.tpMaterial.MinimumWidth = 6;
            this.tpMaterial.Name = "tpMaterial";
            this.tpMaterial.Width = 125;
            // 
            // cDada
            // 
            this.cDada.HeaderText = "Cantidad";
            this.cDada.MinimumWidth = 6;
            this.cDada.Name = "cDada";
            this.cDada.Width = 125;
            // 
            // ptsObtenidos
            // 
            this.ptsObtenidos.HeaderText = "Puntos Obtenidos";
            this.ptsObtenidos.MinimumWidth = 6;
            this.ptsObtenidos.Name = "ptsObtenidos";
            this.ptsObtenidos.Width = 125;
            // 
            // dataGridViewMovimientos
            // 
            this.dataGridViewMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cldate,
            this.clOperacion,
            this.clDetalles,
            this.clPuntos});
            this.dataGridViewMovimientos.Location = new System.Drawing.Point(529, 306);
            this.dataGridViewMovimientos.Name = "dataGridViewMovimientos";
            this.dataGridViewMovimientos.RowHeadersWidth = 51;
            this.dataGridViewMovimientos.RowTemplate.Height = 24;
            this.dataGridViewMovimientos.Size = new System.Drawing.Size(545, 187);
            this.dataGridViewMovimientos.TabIndex = 4;
            // 
            // cldate
            // 
            this.cldate.HeaderText = "Fecha";
            this.cldate.MinimumWidth = 6;
            this.cldate.Name = "cldate";
            this.cldate.Width = 125;
            // 
            // clOperacion
            // 
            this.clOperacion.HeaderText = "Operación";
            this.clOperacion.MinimumWidth = 6;
            this.clOperacion.Name = "clOperacion";
            this.clOperacion.Width = 125;
            // 
            // clDetalles
            // 
            this.clDetalles.HeaderText = "Detalles";
            this.clDetalles.MinimumWidth = 6;
            this.clDetalles.Name = "clDetalles";
            this.clDetalles.Width = 125;
            // 
            // clPuntos
            // 
            this.clPuntos.HeaderText = "Puntos (+/-)";
            this.clPuntos.MinimumWidth = 6;
            this.clPuntos.Name = "clPuntos";
            this.clPuntos.Width = 125;
            // 
            // btnCanje
            // 
            this.btnCanje.Location = new System.Drawing.Point(842, 522);
            this.btnCanje.Name = "btnCanje";
            this.btnCanje.Size = new System.Drawing.Size(232, 42);
            this.btnCanje.TabIndex = 5;
            this.btnCanje.Text = "Canjear Puntos";
            this.btnCanje.UseVisualStyleBackColor = true;
            this.btnCanje.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBeneficios
            // 
            this.comboBeneficios.FormattingEnabled = true;
            this.comboBeneficios.Items.AddRange(new object[] {
            "5 Horas Laborales (800 pts)",
            "10 Horas Laborales (1600 pts)",
            "1 Partido (1000 pts)",
            "2 Partidos (2000 pts)"});
            this.comboBeneficios.Location = new System.Drawing.Point(545, 532);
            this.comboBeneficios.Name = "comboBeneficios";
            this.comboBeneficios.Size = new System.Drawing.Size(259, 24);
            this.comboBeneficios.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Beneficio que desea obtener:";
            // 
            // ConsultaPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1116, 585);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBeneficios);
            this.Controls.Add(this.btnCanje);
            this.Controls.Add(this.dataGridViewMovimientos);
            this.Controls.Add(this.dataGridViewReciclaje);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaPuntos";
            this.Text = "Consulta tus puntos EcoBIN";
            this.Load += new System.EventHandler(this.ConsultaPuntos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReciclaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem registroDeMaterialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankingGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPuntos;
        private System.Windows.Forms.DataGridView dataGridViewReciclaje;
        private System.Windows.Forms.DataGridView dataGridViewMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPuntos;
        private System.Windows.Forms.Button btnCanje;
        private System.Windows.Forms.ComboBox comboBeneficios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptsObtenidos;
    }
}