namespace ECOBIN.Ventanas_Adicionales
{
    partial class RankingGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RankingGen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRanking = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.registroDeMaterialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaTusPuntosEcoBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.dataGridViewRanking);
            this.groupBox1.Location = new System.Drawing.Point(-7, -21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 758);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewRanking
            // 
            this.dataGridViewRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRanking.Location = new System.Drawing.Point(139, 183);
            this.dataGridViewRanking.Name = "dataGridViewRanking";
            this.dataGridViewRanking.RowHeadersWidth = 51;
            this.dataGridViewRanking.RowTemplate.Height = 24;
            this.dataGridViewRanking.Size = new System.Drawing.Size(852, 532);
            this.dataGridViewRanking.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1083, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1077, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeMaterialesToolStripMenuItem,
            this.consultaTusPuntosEcoBINToolStripMenuItem,
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
            this.registroDeMaterialesToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.registroDeMaterialesToolStripMenuItem.Text = "Registro de materiales a reciclar";
            this.registroDeMaterialesToolStripMenuItem.Click += new System.EventHandler(this.registroDeMaterialesToolStripMenuItem_Click);
            // 
            // consultaTusPuntosEcoBINToolStripMenuItem
            // 
            this.consultaTusPuntosEcoBINToolStripMenuItem.Name = "consultaTusPuntosEcoBINToolStripMenuItem";
            this.consultaTusPuntosEcoBINToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.consultaTusPuntosEcoBINToolStripMenuItem.Text = "Consulta tus puntos EcoBIN";
            this.consultaTusPuntosEcoBINToolStripMenuItem.Click += new System.EventHandler(this.consultaTusPuntosEcoBINToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(305, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(141, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "RANKING GENERAL";
            // 
            // RankingGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 732);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RankingGen";
            this.Text = "Ranking General";
            this.Load += new System.EventHandler(this.RankingGen_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRanking)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem registroDeMaterialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaTusPuntosEcoBINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewRanking;
    }
}