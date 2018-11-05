namespace control_pacientes
{
    partial class ConsultaPanel
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoctores = new System.Windows.Forms.ComboBox();
            this.cmbPacientes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarEnfermedad = new System.Windows.Forms.Button();
            this.dgvEnfermedades = new System.Windows.Forms.DataGridView();
            this.cmbEnfermedades = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAgregarMedicamento = new System.Windows.Forms.Button();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.cmbMedicamentos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelTipo = new System.Windows.Forms.Label();
            this.dtpFechaVacuna = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarVacuna = new System.Windows.Forms.Button();
            this.dgvVacunas = new System.Windows.Forms.DataGridView();
            this.cmbTiposVacuna = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtpCita = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarCita = new System.Windows.Forms.Button();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enfermedadID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVacunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnfermedades)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAgregar);
            this.flowLayoutPanel1.Controls.Add(this.btnGuardar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1168, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(39, 194);
            this.flowLayoutPanel1.TabIndex = 46;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::control_pacientes.Properties.Resources.add_button_inside_black_circle;
            this.btnAgregar.Location = new System.Drawing.Point(3, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(33, 33);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::control_pacientes.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(3, 42);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(33, 33);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::control_pacientes.Properties.Resources.cancel_button;
            this.btnCancelar.Location = new System.Drawing.Point(3, 81);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(33, 33);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(2, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Doctor";
            // 
            // cmbDoctores
            // 
            this.cmbDoctores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDoctores.FormattingEnabled = true;
            this.cmbDoctores.Location = new System.Drawing.Point(6, 47);
            this.cmbDoctores.Name = "cmbDoctores";
            this.cmbDoctores.Size = new System.Drawing.Size(228, 24);
            this.cmbDoctores.TabIndex = 51;
            // 
            // cmbPacientes
            // 
            this.cmbPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacientes.FormattingEnabled = true;
            this.cmbPacientes.Location = new System.Drawing.Point(313, 47);
            this.cmbPacientes.Name = "cmbPacientes";
            this.cmbPacientes.Size = new System.Drawing.Size(228, 24);
            this.cmbPacientes.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(309, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Paciente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDoctores);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbPacientes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(26, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 119);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarEnfermedad);
            this.groupBox2.Controls.Add(this.dgvEnfermedades);
            this.groupBox2.Controls.Add(this.cmbEnfermedades);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(26, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 293);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnóstico";
            // 
            // btnAgregarEnfermedad
            // 
            this.btnAgregarEnfermedad.BackgroundImage = global::control_pacientes.Properties.Resources.add_button_inside_black_circle;
            this.btnAgregarEnfermedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarEnfermedad.FlatAppearance.BorderSize = 0;
            this.btnAgregarEnfermedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEnfermedad.Location = new System.Drawing.Point(228, 58);
            this.btnAgregarEnfermedad.Name = "btnAgregarEnfermedad";
            this.btnAgregarEnfermedad.Size = new System.Drawing.Size(24, 24);
            this.btnAgregarEnfermedad.TabIndex = 53;
            this.btnAgregarEnfermedad.UseVisualStyleBackColor = true;
            this.btnAgregarEnfermedad.Click += new System.EventHandler(this.btnAgregarEnfermedad_Click);
            // 
            // dgvEnfermedades
            // 
            this.dgvEnfermedades.AllowUserToAddRows = false;
            this.dgvEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnfermedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.enfermedadID,
            this.nombreEnfermedad});
            this.dgvEnfermedades.Location = new System.Drawing.Point(7, 97);
            this.dgvEnfermedades.Name = "dgvEnfermedades";
            this.dgvEnfermedades.Size = new System.Drawing.Size(245, 190);
            this.dgvEnfermedades.TabIndex = 52;
            // 
            // cmbEnfermedades
            // 
            this.cmbEnfermedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEnfermedades.FormattingEnabled = true;
            this.cmbEnfermedades.Location = new System.Drawing.Point(6, 58);
            this.cmbEnfermedades.Name = "cmbEnfermedades";
            this.cmbEnfermedades.Size = new System.Drawing.Size(207, 24);
            this.cmbEnfermedades.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(2, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Enfermedad";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAgregarMedicamento);
            this.groupBox3.Controls.Add(this.dgvMedicamentos);
            this.groupBox3.Controls.Add(this.cmbMedicamentos);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(309, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 293);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Medicamentos";
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.BackgroundImage = global::control_pacientes.Properties.Resources.add_button_inside_black_circle;
            this.btnAgregarMedicamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarMedicamento.FlatAppearance.BorderSize = 0;
            this.btnAgregarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(228, 58);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(24, 24);
            this.btnAgregarMedicamento.TabIndex = 53;
            this.btnAgregarMedicamento.UseVisualStyleBackColor = true;
            this.btnAgregarMedicamento.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicamentoID,
            this.nombreMedicamento});
            this.dgvMedicamentos.Location = new System.Drawing.Point(7, 97);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.Size = new System.Drawing.Size(245, 190);
            this.dgvMedicamentos.TabIndex = 52;
            // 
            // cmbMedicamentos
            // 
            this.cmbMedicamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMedicamentos.FormattingEnabled = true;
            this.cmbMedicamentos.Location = new System.Drawing.Point(6, 58);
            this.cmbMedicamentos.Name = "cmbMedicamentos";
            this.cmbMedicamentos.Size = new System.Drawing.Size(207, 24);
            this.cmbMedicamentos.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(2, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Medicamento";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelTipo);
            this.groupBox4.Controls.Add(this.dtpFechaVacuna);
            this.groupBox4.Controls.Add(this.btnAgregarVacuna);
            this.groupBox4.Controls.Add(this.dgvVacunas);
            this.groupBox4.Controls.Add(this.cmbTiposVacuna);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(596, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(428, 293);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Vacunas";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTipo.Location = new System.Drawing.Point(219, 35);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(39, 20);
            this.labelTipo.TabIndex = 56;
            this.labelTipo.Text = "Tipo";
            // 
            // dtpFechaVacuna
            // 
            this.dtpFechaVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaVacuna.Location = new System.Drawing.Point(7, 58);
            this.dtpFechaVacuna.Name = "dtpFechaVacuna";
            this.dtpFechaVacuna.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaVacuna.TabIndex = 55;
            // 
            // btnAgregarVacuna
            // 
            this.btnAgregarVacuna.BackgroundImage = global::control_pacientes.Properties.Resources.add_button_inside_black_circle;
            this.btnAgregarVacuna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarVacuna.FlatAppearance.BorderSize = 0;
            this.btnAgregarVacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVacuna.Location = new System.Drawing.Point(388, 55);
            this.btnAgregarVacuna.Name = "btnAgregarVacuna";
            this.btnAgregarVacuna.Size = new System.Drawing.Size(24, 24);
            this.btnAgregarVacuna.TabIndex = 53;
            this.btnAgregarVacuna.UseVisualStyleBackColor = true;
            this.btnAgregarVacuna.Click += new System.EventHandler(this.btnAgregarVacuna_Click);
            // 
            // dgvVacunas
            // 
            this.dgvVacunas.AllowUserToAddRows = false;
            this.dgvVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaVacuna,
            this.tipoVacunaID,
            this.tipoVacuna});
            this.dgvVacunas.Location = new System.Drawing.Point(7, 97);
            this.dgvVacunas.Name = "dgvVacunas";
            this.dgvVacunas.Size = new System.Drawing.Size(415, 190);
            this.dgvVacunas.TabIndex = 52;
            // 
            // cmbTiposVacuna
            // 
            this.cmbTiposVacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTiposVacuna.FormattingEnabled = true;
            this.cmbTiposVacuna.Location = new System.Drawing.Point(223, 56);
            this.cmbTiposVacuna.Name = "cmbTiposVacuna";
            this.cmbTiposVacuna.Size = new System.Drawing.Size(159, 24);
            this.cmbTiposVacuna.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtpCita);
            this.groupBox5.Controls.Add(this.btnAgregarCita);
            this.groupBox5.Controls.Add(this.dgvCitas);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(676, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(448, 139);
            this.groupBox5.TabIndex = 59;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Citas";
            // 
            // dtpCita
            // 
            this.dtpCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCita.Location = new System.Drawing.Point(0, 49);
            this.dtpCita.Name = "dtpCita";
            this.dtpCita.Size = new System.Drawing.Size(200, 22);
            this.dtpCita.TabIndex = 54;
            // 
            // btnAgregarCita
            // 
            this.btnAgregarCita.BackgroundImage = global::control_pacientes.Properties.Resources.add_button_inside_black_circle;
            this.btnAgregarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCita.FlatAppearance.BorderSize = 0;
            this.btnAgregarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCita.Location = new System.Drawing.Point(216, 46);
            this.btnAgregarCita.Name = "btnAgregarCita";
            this.btnAgregarCita.Size = new System.Drawing.Size(24, 24);
            this.btnAgregarCita.TabIndex = 53;
            this.btnAgregarCita.UseVisualStyleBackColor = true;
            this.btnAgregarCita.Click += new System.EventHandler(this.btnAgregarCita_Click);
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtFechaCita});
            this.dgvCitas.Location = new System.Drawing.Point(246, 19);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.Size = new System.Drawing.Size(196, 100);
            this.dgvCitas.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(2, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha";
            // 
            // txtFechaCita
            // 
            this.txtFechaCita.HeaderText = "Fecha";
            this.txtFechaCita.Name = "txtFechaCita";
            this.txtFechaCita.Width = 150;
            // 
            // enfermedadID
            // 
            this.enfermedadID.HeaderText = "id";
            this.enfermedadID.Name = "enfermedadID";
            this.enfermedadID.Visible = false;
            // 
            // nombreEnfermedad
            // 
            this.nombreEnfermedad.HeaderText = "Nombre";
            this.nombreEnfermedad.Name = "nombreEnfermedad";
            this.nombreEnfermedad.Width = 200;
            // 
            // medicamentoID
            // 
            this.medicamentoID.HeaderText = "id";
            this.medicamentoID.Name = "medicamentoID";
            this.medicamentoID.Visible = false;
            // 
            // nombreMedicamento
            // 
            this.nombreMedicamento.HeaderText = "Nombre";
            this.nombreMedicamento.Name = "nombreMedicamento";
            this.nombreMedicamento.Width = 200;
            // 
            // fechaVacuna
            // 
            this.fechaVacuna.HeaderText = "Fecha";
            this.fechaVacuna.Name = "fechaVacuna";
            this.fechaVacuna.Width = 190;
            // 
            // tipoVacunaID
            // 
            this.tipoVacunaID.HeaderText = "id";
            this.tipoVacunaID.Name = "tipoVacunaID";
            this.tipoVacunaID.Visible = false;
            // 
            // tipoVacuna
            // 
            this.tipoVacuna.HeaderText = "Tipo de vacuna";
            this.tipoVacuna.Name = "tipoVacuna";
            this.tipoVacuna.Width = 190;
            // 
            // ConsultaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ConsultaPanel";
            this.Size = new System.Drawing.Size(1210, 514);
            this.Load += new System.EventHandler(this.ConsultaPanel_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnfermedades)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoctores;
        private System.Windows.Forms.ComboBox cmbPacientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarEnfermedad;
        private System.Windows.Forms.DataGridView dgvEnfermedades;
        private System.Windows.Forms.ComboBox cmbEnfermedades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAgregarMedicamento;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.ComboBox cmbMedicamentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.DateTimePicker dtpFechaVacuna;
        private System.Windows.Forms.Button btnAgregarVacuna;
        private System.Windows.Forms.DataGridView dgvVacunas;
        private System.Windows.Forms.ComboBox cmbTiposVacuna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dtpCita;
        private System.Windows.Forms.Button btnAgregarCita;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn enfermedadID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicamentoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVacunaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVacuna;
    }
}
