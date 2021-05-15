
namespace MedicacionAlerxias
{
    partial class fIndex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIndex));
            this.lblFondoHeader = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblMedicación = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.nudDoses = new System.Windows.Forms.NumericUpDown();
            this.lblDoses = new System.Windows.Forms.Label();
            this.lblResume = new System.Windows.Forms.Label();
            this.cbxMedicacion = new System.Windows.Forms.ComboBox();
            this.lbxInfoResumida = new System.Windows.Forms.ListBox();
            this.txbObservacions = new System.Windows.Forms.TextBox();
            this.lblObservacions = new System.Windows.Forms.Label();
            this.btGardar = new System.Windows.Forms.Button();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.Medicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFondoHeader
            // 
            this.lblFondoHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.lblFondoHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFondoHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFondoHeader.Location = new System.Drawing.Point(-1, -2);
            this.lblFondoHeader.Name = "lblFondoHeader";
            this.lblFondoHeader.Size = new System.Drawing.Size(804, 102);
            this.lblFondoHeader.TabIndex = 0;
            this.lblFondoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(57, 164);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 1;
            // 
            // lblMedicación
            // 
            this.lblMedicación.AutoSize = true;
            this.lblMedicación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicación.Location = new System.Drawing.Point(69, 196);
            this.lblMedicación.Name = "lblMedicación";
            this.lblMedicación.Size = new System.Drawing.Size(92, 16);
            this.lblMedicación.TabIndex = 0;
            this.lblMedicación.Text = "Medicación:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(128, 132);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 16);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // nudDoses
            // 
            this.nudDoses.Location = new System.Drawing.Point(208, 225);
            this.nudDoses.Name = "nudDoses";
            this.nudDoses.Size = new System.Drawing.Size(55, 20);
            this.nudDoses.TabIndex = 3;
            this.nudDoses.ValueChanged += new System.EventHandler(this.nudDoses_ValueChanged);
            // 
            // lblDoses
            // 
            this.lblDoses.AutoSize = true;
            this.lblDoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoses.Location = new System.Drawing.Point(206, 196);
            this.lblDoses.Name = "lblDoses";
            this.lblDoses.Size = new System.Drawing.Size(57, 16);
            this.lblDoses.TabIndex = 0;
            this.lblDoses.Text = "Doses:";
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.Location = new System.Drawing.Point(521, 132);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(69, 16);
            this.lblResume.TabIndex = 0;
            this.lblResume.Text = "Resume:";
            // 
            // cbxMedicacion
            // 
            this.cbxMedicacion.FormattingEnabled = true;
            this.cbxMedicacion.Location = new System.Drawing.Point(52, 224);
            this.cbxMedicacion.Name = "cbxMedicacion";
            this.cbxMedicacion.Size = new System.Drawing.Size(121, 21);
            this.cbxMedicacion.TabIndex = 2;
            this.cbxMedicacion.SelectedIndexChanged += new System.EventHandler(this.cbxMedicacion_SelectedIndexChanged);
            // 
            // lbxInfoResumida
            // 
            this.lbxInfoResumida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbxInfoResumida.FormattingEnabled = true;
            this.lbxInfoResumida.Location = new System.Drawing.Point(52, 255);
            this.lbxInfoResumida.Name = "lbxInfoResumida";
            this.lbxInfoResumida.Size = new System.Drawing.Size(211, 30);
            this.lbxInfoResumida.TabIndex = 0;
            // 
            // txbObservacions
            // 
            this.txbObservacions.Location = new System.Drawing.Point(52, 314);
            this.txbObservacions.Multiline = true;
            this.txbObservacions.Name = "txbObservacions";
            this.txbObservacions.Size = new System.Drawing.Size(211, 62);
            this.txbObservacions.TabIndex = 4;
            // 
            // lblObservacions
            // 
            this.lblObservacions.AutoSize = true;
            this.lblObservacions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacions.Location = new System.Drawing.Point(106, 295);
            this.lblObservacions.Name = "lblObservacions";
            this.lblObservacions.Size = new System.Drawing.Size(108, 16);
            this.lblObservacions.TabIndex = 0;
            this.lblObservacions.Text = "Observacions:";
            // 
            // btGardar
            // 
            this.btGardar.Location = new System.Drawing.Point(32, 391);
            this.btGardar.Name = "btGardar";
            this.btGardar.Size = new System.Drawing.Size(75, 23);
            this.btGardar.TabIndex = 5;
            this.btGardar.Text = "GARDAR";
            this.btGardar.UseVisualStyleBackColor = true;
            this.btGardar.Click += new System.EventHandler(this.bts_CRUD_Click);
            // 
            // dgvResumen
            // 
            this.dgvResumen.AllowUserToAddRows = false;
            this.dgvResumen.AllowUserToDeleteRows = false;
            this.dgvResumen.AllowUserToResizeColumns = false;
            this.dgvResumen.AllowUserToResizeRows = false;
            this.dgvResumen.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicacion,
            this.Doses,
            this.Observacions,
            this.Data});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResumen.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvResumen.GridColor = System.Drawing.SystemColors.Control;
            this.dgvResumen.Location = new System.Drawing.Point(317, 164);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.RowHeadersVisible = false;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvResumen.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResumen.Size = new System.Drawing.Size(460, 250);
            this.dgvResumen.TabIndex = 6;
            this.dgvResumen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResumen_CellClick);
            // 
            // Medicacion
            // 
            this.Medicacion.DataPropertyName = "Nome";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Medicacion.DefaultCellStyle = dataGridViewCellStyle19;
            this.Medicacion.HeaderText = "Medicación";
            this.Medicacion.Name = "Medicacion";
            this.Medicacion.ReadOnly = true;
            this.Medicacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Medicacion.ToolTipText = "columna Medicación";
            // 
            // Doses
            // 
            this.Doses.DataPropertyName = "VecesDia";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Doses.DefaultCellStyle = dataGridViewCellStyle20;
            this.Doses.HeaderText = "Doses";
            this.Doses.Name = "Doses";
            this.Doses.ReadOnly = true;
            this.Doses.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Doses.ToolTipText = "columna Doses";
            this.Doses.Width = 50;
            // 
            // Observacions
            // 
            this.Observacions.DataPropertyName = "Observacions";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Observacions.DefaultCellStyle = dataGridViewCellStyle21;
            this.Observacions.HeaderText = "Observacións";
            this.Observacions.Name = "Observacions";
            this.Observacions.ReadOnly = true;
            this.Observacions.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Observacions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Observacions.ToolTipText = "columna Observacións";
            this.Observacions.Width = 190;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DataHora";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.Format = "dd/MM/yyyy";
            dataGridViewCellStyle22.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle22;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.ToolTipText = "columna Data";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(319, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(441, 40);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "MEDICACIÓN ALERXIAS";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(7, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(268, 87);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(120, 391);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 10;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.bts_CRUD_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(208, 391);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.bts_CRUD_Click);
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCRUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCRUD.Location = new System.Drawing.Point(25, 122);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(264, 301);
            this.pnlCRUD.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(-2, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 45);
            this.label1.TabIndex = 13;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(688, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "@k1nteiro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Desenvolvido íntegramente por Sergio Quinteiro Varela. Proxecto educacional, non " +
    "comercial.\r\nQueda prohibida a súa distribución. Todos os dereitos reservados ao " +
    "desenvolvedor.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(561, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "K5 Prog ©";
            // 
            // fIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(799, 486);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.dgvResumen);
            this.Controls.Add(this.btGardar);
            this.Controls.Add(this.lblObservacions);
            this.Controls.Add(this.txbObservacions);
            this.Controls.Add(this.lbxInfoResumida);
            this.Controls.Add(this.cbxMedicacion);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.lblDoses);
            this.Controls.Add(this.nudDoses);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblMedicación);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFondoHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicación Alerxias";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing_Event);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDoses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFondoHeader;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblMedicación;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.NumericUpDown nudDoses;
        private System.Windows.Forms.Label lblDoses;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.ComboBox cbxMedicacion;
        private System.Windows.Forms.ListBox lbxInfoResumida;
        private System.Windows.Forms.TextBox txbObservacions;
        private System.Windows.Forms.Label lblObservacions;
        private System.Windows.Forms.Button btGardar;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

