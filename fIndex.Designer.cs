
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIndex));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btEditarMedicacion = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblK1nteiro = new System.Windows.Forms.Label();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.lblK5Prog = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiario)).BeginInit();
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
            this.dtpData.Location = new System.Drawing.Point(57, 284);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 3;
            // 
            // lblMedicación
            // 
            this.lblMedicación.AutoSize = true;
            this.lblMedicación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicación.Location = new System.Drawing.Point(114, 134);
            this.lblMedicación.Name = "lblMedicación";
            this.lblMedicación.Size = new System.Drawing.Size(92, 16);
            this.lblMedicación.TabIndex = 0;
            this.lblMedicación.Text = "Medicación:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(128, 261);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 16);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // nudDoses
            // 
            this.nudDoses.Location = new System.Drawing.Point(165, 191);
            this.nudDoses.Name = "nudDoses";
            this.nudDoses.Size = new System.Drawing.Size(55, 20);
            this.nudDoses.TabIndex = 2;
            this.nudDoses.ValueChanged += new System.EventHandler(this.nudDoses_ValueChanged);
            // 
            // lblDoses
            // 
            this.lblDoses.AutoSize = true;
            this.lblDoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoses.Location = new System.Drawing.Point(94, 192);
            this.lblDoses.Name = "lblDoses";
            this.lblDoses.Size = new System.Drawing.Size(57, 16);
            this.lblDoses.TabIndex = 0;
            this.lblDoses.Text = "Doses:";
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.Location = new System.Drawing.Point(520, 135);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(69, 16);
            this.lblResume.TabIndex = 0;
            this.lblResume.Text = "Resume:";
            // 
            // cbxMedicacion
            // 
            this.cbxMedicacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedicacion.FormattingEnabled = true;
            this.cbxMedicacion.Location = new System.Drawing.Point(72, 157);
            this.cbxMedicacion.Name = "cbxMedicacion";
            this.cbxMedicacion.Size = new System.Drawing.Size(121, 21);
            this.cbxMedicacion.TabIndex = 1;
            this.cbxMedicacion.SelectedIndexChanged += new System.EventHandler(this.cbxMedicacion_SelectedIndexChanged);
            // 
            // lbxInfoResumida
            // 
            this.lbxInfoResumida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbxInfoResumida.FormattingEnabled = true;
            this.lbxInfoResumida.Location = new System.Drawing.Point(52, 221);
            this.lbxInfoResumida.Name = "lbxInfoResumida";
            this.lbxInfoResumida.Size = new System.Drawing.Size(211, 30);
            this.lbxInfoResumida.TabIndex = 0;
            // 
            // txbObservacions
            // 
            this.txbObservacions.Location = new System.Drawing.Point(52, 335);
            this.txbObservacions.Multiline = true;
            this.txbObservacions.Name = "txbObservacions";
            this.txbObservacions.Size = new System.Drawing.Size(211, 62);
            this.txbObservacions.TabIndex = 4;
            // 
            // lblObservacions
            // 
            this.lblObservacions.AutoSize = true;
            this.lblObservacions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacions.Location = new System.Drawing.Point(106, 316);
            this.lblObservacions.Name = "lblObservacions";
            this.lblObservacions.Size = new System.Drawing.Size(108, 16);
            this.lblObservacions.TabIndex = 0;
            this.lblObservacions.Text = "Observacions:";
            // 
            // btGardar
            // 
            this.btGardar.Location = new System.Drawing.Point(32, 412);
            this.btGardar.Name = "btGardar";
            this.btGardar.Size = new System.Drawing.Size(75, 23);
            this.btGardar.TabIndex = 5;
            this.btGardar.Text = "GARDAR";
            this.btGardar.UseVisualStyleBackColor = true;
            this.btGardar.Click += new System.EventHandler(this.bts_CRUD_Click);
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
            this.lblTitulo.TabIndex = 0;
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
            this.btEditar.Location = new System.Drawing.Point(120, 412);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 6;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.bts_CRUD_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(208, 412);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 7;
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
            this.pnlCRUD.Size = new System.Drawing.Size(264, 322);
            this.pnlCRUD.TabIndex = 0;
            // 
            // btEditarMedicacion
            // 
            this.btEditarMedicacion.Location = new System.Drawing.Point(198, 157);
            this.btEditarMedicacion.Name = "btEditarMedicacion";
            this.btEditarMedicacion.Size = new System.Drawing.Size(45, 22);
            this.btEditarMedicacion.TabIndex = 8;
            this.btEditarMedicacion.Text = "Editar";
            this.btEditarMedicacion.UseVisualStyleBackColor = true;
            this.btEditarMedicacion.Click += new System.EventHandler(this.btEditarMedicacion_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.lblFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFooter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFooter.Location = new System.Drawing.Point(-2, 467);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(804, 45);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblK1nteiro
            // 
            this.lblK1nteiro.AutoSize = true;
            this.lblK1nteiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.lblK1nteiro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK1nteiro.ForeColor = System.Drawing.Color.White;
            this.lblK1nteiro.Location = new System.Drawing.Point(688, 479);
            this.lblK1nteiro.Name = "lblK1nteiro";
            this.lblK1nteiro.Size = new System.Drawing.Size(72, 20);
            this.lblK1nteiro.TabIndex = 0;
            this.lblK1nteiro.Text = "@k1nteiro";
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.lblCopyRight.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.ForeColor = System.Drawing.Color.White;
            this.lblCopyRight.Location = new System.Drawing.Point(4, 475);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(498, 26);
            this.lblCopyRight.TabIndex = 0;
            this.lblCopyRight.Text = "Desenvolvido íntegramente por Sergio Quinteiro Varela. Proxecto educacional, non " +
    "comercial.\r\nQueda prohibida a súa distribución. Todos os dereitos reservados ao " +
    "desenvolvedor.\r\n";
            // 
            // lblK5Prog
            // 
            this.lblK5Prog.AutoSize = true;
            this.lblK5Prog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.lblK5Prog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK5Prog.ForeColor = System.Drawing.Color.White;
            this.lblK5Prog.Location = new System.Drawing.Point(561, 480);
            this.lblK5Prog.Name = "lblK5Prog";
            this.lblK5Prog.Size = new System.Drawing.Size(80, 19);
            this.lblK5Prog.TabIndex = 0;
            this.lblK5Prog.Text = "K5 Prog ©";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DataHora";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle1;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.ToolTipText = "columna Data";
            // 
            // Observacions
            // 
            this.Observacions.DataPropertyName = "Observacions";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Observacions.DefaultCellStyle = dataGridViewCellStyle2;
            this.Observacions.HeaderText = "Observacións";
            this.Observacions.Name = "Observacions";
            this.Observacions.ReadOnly = true;
            this.Observacions.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Observacions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Observacions.ToolTipText = "columna Observacións";
            this.Observacions.Width = 190;
            // 
            // Doses
            // 
            this.Doses.DataPropertyName = "VecesDia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Doses.DefaultCellStyle = dataGridViewCellStyle3;
            this.Doses.HeaderText = "Doses";
            this.Doses.Name = "Doses";
            this.Doses.ReadOnly = true;
            this.Doses.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Doses.ToolTipText = "columna Doses";
            this.Doses.Width = 50;
            // 
            // Medicacion
            // 
            this.Medicacion.DataPropertyName = "Nome";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Medicacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.Medicacion.HeaderText = "Medicación";
            this.Medicacion.Name = "Medicacion";
            this.Medicacion.ReadOnly = true;
            this.Medicacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Medicacion.ToolTipText = "columna Medicación";
            // 
            // dgvDiario
            // 
            this.dgvDiario.AllowUserToAddRows = false;
            this.dgvDiario.AllowUserToDeleteRows = false;
            this.dgvDiario.AllowUserToResizeColumns = false;
            this.dgvDiario.AllowUserToResizeRows = false;
            this.dgvDiario.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medicacion,
            this.Doses,
            this.Observacions,
            this.Data});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiario.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDiario.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDiario.Location = new System.Drawing.Point(310, 164);
            this.dgvDiario.MultiSelect = false;
            this.dgvDiario.Name = "dgvDiario";
            this.dgvDiario.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDiario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiario.Size = new System.Drawing.Size(460, 280);
            this.dgvDiario.TabIndex = 0;
            this.dgvDiario.TabStop = false;
            this.dgvDiario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResumen_CellClick);
            // 
            // fIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(799, 511);
            this.Controls.Add(this.lblK5Prog);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.lblK1nteiro);
            this.Controls.Add(this.lblFooter);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.dgvDiario);
            this.Controls.Add(this.btGardar);
            this.Controls.Add(this.lblObservacions);
            this.Controls.Add(this.txbObservacions);
            this.Controls.Add(this.lbxInfoResumida);
            this.Controls.Add(this.cbxMedicacion);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDoses);
            this.Controls.Add(this.nudDoses);
            this.Controls.Add(this.btEditarMedicacion);
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
            this.Load += new System.EventHandler(this.fIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDoses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiario)).EndInit();
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
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label lblK1nteiro;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Label lblK5Prog;
        private System.Windows.Forms.Button btEditarMedicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicacion;
        private System.Windows.Forms.DataGridView dgvDiario;
    }
}

