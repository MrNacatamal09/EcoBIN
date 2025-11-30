namespace ECOBIN
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EcoBIN = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbPass = new System.Windows.Forms.TextBox();
            this.chkMostrarPass = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.EcoBIN);
            this.groupBox1.Location = new System.Drawing.Point(0, -22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(802, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // EcoBIN
            // 
            this.EcoBIN.AutoSize = true;
            this.EcoBIN.BackColor = System.Drawing.Color.Transparent;
            this.EcoBIN.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EcoBIN.ForeColor = System.Drawing.SystemColors.Control;
            this.EcoBIN.Location = new System.Drawing.Point(244, 28);
            this.EcoBIN.Name = "EcoBIN";
            this.EcoBIN.Size = new System.Drawing.Size(324, 108);
            this.EcoBIN.TabIndex = 0;
            this.EcoBIN.Text = "EcoBIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio de Sesión";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CIF";
            // 
            // tbCif
            // 
            this.tbCif.BackColor = System.Drawing.Color.White;
            this.tbCif.Location = new System.Drawing.Point(310, 197);
            this.tbCif.Name = "tbCif";
            this.tbCif.Size = new System.Drawing.Size(221, 22);
            this.tbCif.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTRASEÑA";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIniciar.Font = new System.Drawing.Font("Sylfaen", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(328, 347);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(138, 37);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar sesión";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(312, 297);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(218, 22);
            this.tbNombre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre del Usuario";
            // 
            // mtbPass
            // 
            this.mtbPass.Location = new System.Drawing.Point(311, 250);
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.Size = new System.Drawing.Size(219, 22);
            this.mtbPass.TabIndex = 9;
            // 
            // chkMostrarPass
            // 
            this.chkMostrarPass.AutoSize = true;
            this.chkMostrarPass.Location = new System.Drawing.Point(509, 252);
            this.chkMostrarPass.Name = "chkMostrarPass";
            this.chkMostrarPass.Size = new System.Drawing.Size(18, 17);
            this.chkMostrarPass.TabIndex = 10;
            this.chkMostrarPass.UseVisualStyleBackColor = true;
            this.chkMostrarPass.CheckedChanged += new System.EventHandler(this.chkMostrarPass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.chkMostrarPass);
            this.Controls.Add(this.mtbPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "EcoBIN ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label EcoBIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mtbPass;
        private System.Windows.Forms.CheckBox chkMostrarPass;
    }
}

