namespace control_pacientes.UserControls
{
    partial class HomePanel
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarConsulta = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.pnlConsulta = new control_pacientes.ConsultaPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.btnAgregarConsulta);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 82);
            this.panel1.TabIndex = 1;
            // 
            // btnAgregarConsulta
            // 
            this.btnAgregarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarConsulta.Image = global::control_pacientes.Properties.Resources.file__2_;
            this.btnAgregarConsulta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarConsulta.Location = new System.Drawing.Point(127, 3);
            this.btnAgregarConsulta.Name = "btnAgregarConsulta";
            this.btnAgregarConsulta.Size = new System.Drawing.Size(118, 76);
            this.btnAgregarConsulta.TabIndex = 5;
            this.btnAgregarConsulta.Text = "Consulta";
            this.btnAgregarConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarConsulta.UseVisualStyleBackColor = false;
            this.btnAgregarConsulta.Click += new System.EventHandler(this.btnAgregarConsulta_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = global::control_pacientes.Properties.Resources.house__1_;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInicio.Location = new System.Drawing.Point(3, 3);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(118, 76);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlConsulta
            // 
            this.pnlConsulta.Location = new System.Drawing.Point(4, 89);
            this.pnlConsulta.Name = "pnlConsulta";
            this.pnlConsulta.Size = new System.Drawing.Size(1246, 530);
            this.pnlConsulta.TabIndex = 2;
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlConsulta);
            this.Controls.Add(this.panel1);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(1352, 648);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarConsulta;
        private System.Windows.Forms.Button btnInicio;
        private ConsultaPanel pnlConsulta;
    }
}
