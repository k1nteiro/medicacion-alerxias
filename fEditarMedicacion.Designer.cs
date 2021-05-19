
namespace MedicacionAlerxias
{
    partial class fEditarMedicacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditarMedicacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMedicacion = new System.Windows.Forms.DataGridView();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFondoHeader = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResumenMedicación = new System.Windows.Forms.Label();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.txbInfoResumida = new System.Windows.Forms.TextBox();
            this.lblInfoResumida = new System.Windows.Forms.Label();
            this.txbTratamento = new System.Windows.Forms.TextBox();
            this.txbLaboratorio = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblTratamento = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btGardar = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoResumida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedicacion
            // 
            this.dgvMedicacion.AllowUserToAddRows = false;
            this.dgvMedicacion.AllowUserToDeleteRows = false;
            this.dgvMedicacion.AllowUserToResizeColumns = false;
            this.dgvMedicacion.AllowUserToResizeRows = false;
            this.dgvMedicacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMedicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Laboratorio,
            this.Tratamento,
            this.InfoResumida});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicacion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMedicacion.GridColor = System.Drawing.SystemColors.Control;
            this.dgvMedicacion.Location = new System.Drawing.Point(317, 164);
            this.dgvMedicacion.MultiSelect = false;
            this.dgvMedicacion.Name = "dgvMedicacion";
            this.dgvMedicacion.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMedicacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMedicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicacion.Size = new System.Drawing.Size(460, 280);
            this.dgvMedicacion.TabIndex = 0;
            this.dgvMedicacion.TabStop = false;
            this.dgvMedicacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicacion_CellClick);
            this.dgvMedicacion.Sorted += new System.EventHandler(this.dgvMedicacion_Sorted);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(7, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(268, 87);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(561, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "K5 Prog ©";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(498, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desenvolvido íntegramente por Sergio Quinteiro Varela. Proxecto educacional, non " +
    "comercial.\r\nQueda prohibida a súa distribución. Todos os dereitos reservados ao " +
    "desenvolvedor.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(688, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "@k1nteiro";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(-2, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 45);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResumenMedicación
            // 
            this.lblResumenMedicación.AutoSize = true;
            this.lblResumenMedicación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenMedicación.Location = new System.Drawing.Point(475, 135);
            this.lblResumenMedicación.Name = "lblResumenMedicación";
            this.lblResumenMedicación.Size = new System.Drawing.Size(161, 16);
            this.lblResumenMedicación.TabIndex = 0;
            this.lblResumenMedicación.Text = "Resumen Medicación:";
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCRUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCRUD.Controls.Add(this.txbInfoResumida);
            this.pnlCRUD.Controls.Add(this.lblInfoResumida);
            this.pnlCRUD.Controls.Add(this.txbTratamento);
            this.pnlCRUD.Controls.Add(this.txbLaboratorio);
            this.pnlCRUD.Controls.Add(this.txbNome);
            this.pnlCRUD.Controls.Add(this.lblTratamento);
            this.pnlCRUD.Controls.Add(this.lblLaboratorio);
            this.pnlCRUD.Controls.Add(this.lblNome);
            this.pnlCRUD.Controls.Add(this.btEliminar);
            this.pnlCRUD.Controls.Add(this.btLimpar);
            this.pnlCRUD.Controls.Add(this.btGardar);
            this.pnlCRUD.Location = new System.Drawing.Point(25, 164);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(264, 280);
            this.pnlCRUD.TabIndex = 0;
            // 
            // txbInfoResumida
            // 
            this.txbInfoResumida.Location = new System.Drawing.Point(33, 202);
            this.txbInfoResumida.Name = "txbInfoResumida";
            this.txbInfoResumida.Size = new System.Drawing.Size(200, 20);
            this.txbInfoResumida.TabIndex = 4;
            this.txbInfoResumida.TextChanged += new System.EventHandler(this.txbs_Campos_TextChanged);
            // 
            // lblInfoResumida
            // 
            this.lblInfoResumida.AutoSize = true;
            this.lblInfoResumida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoResumida.Location = new System.Drawing.Point(78, 184);
            this.lblInfoResumida.Name = "lblInfoResumida";
            this.lblInfoResumida.Size = new System.Drawing.Size(115, 16);
            this.lblInfoResumida.TabIndex = 0;
            this.lblInfoResumida.Text = "Info. Resumida:";
            // 
            // txbTratamento
            // 
            this.txbTratamento.Location = new System.Drawing.Point(33, 124);
            this.txbTratamento.Multiline = true;
            this.txbTratamento.Name = "txbTratamento";
            this.txbTratamento.Size = new System.Drawing.Size(200, 50);
            this.txbTratamento.TabIndex = 3;
            this.txbTratamento.TextChanged += new System.EventHandler(this.txbs_Campos_TextChanged);
            // 
            // txbLaboratorio
            // 
            this.txbLaboratorio.Location = new System.Drawing.Point(68, 78);
            this.txbLaboratorio.Name = "txbLaboratorio";
            this.txbLaboratorio.Size = new System.Drawing.Size(125, 20);
            this.txbLaboratorio.TabIndex = 2;
            this.txbLaboratorio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbLaboratorio.TextChanged += new System.EventHandler(this.txbs_Campos_TextChanged);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(68, 30);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(125, 20);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbNome.TextChanged += new System.EventHandler(this.txbs_Campos_TextChanged);
            // 
            // lblTratamento
            // 
            this.lblTratamento.AutoSize = true;
            this.lblTratamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamento.Location = new System.Drawing.Point(90, 106);
            this.lblTratamento.Name = "lblTratamento";
            this.lblTratamento.Size = new System.Drawing.Size(91, 16);
            this.lblTratamento.TabIndex = 0;
            this.lblTratamento.Text = "Tratamento:";
            // 
            // lblLaboratorio
            // 
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorio.Location = new System.Drawing.Point(86, 59);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(92, 16);
            this.lblLaboratorio.TabIndex = 0;
            this.lblLaboratorio.Text = "Laboratorio:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(110, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(182, 247);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 7;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.bts_CRUD_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(94, 247);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 6;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.bts_CRUD_Click);
            // 
            // btGardar
            // 
            this.btGardar.Location = new System.Drawing.Point(6, 247);
            this.btGardar.Name = "btGardar";
            this.btGardar.Size = new System.Drawing.Size(75, 23);
            this.btGardar.TabIndex = 5;
            this.btGardar.Text = "GARDAR";
            this.btGardar.UseVisualStyleBackColor = true;
            this.btGardar.Click += new System.EventHandler(this.bts_CRUD_Click);
            // 
            // btAtras
            // 
            this.btAtras.BackColor = System.Drawing.SystemColors.Control;
            this.btAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAtras.BackgroundImage")));
            this.btAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAtras.FlatAppearance.BorderSize = 0;
            this.btAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtras.Location = new System.Drawing.Point(12, 100);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(40, 35);
            this.btAtras.TabIndex = 8;
            this.btAtras.UseVisualStyleBackColor = false;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Inserir Medicación:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nome.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.ToolTipText = "columna Medicación";
            this.Nome.Width = 125;
            // 
            // Laboratorio
            // 
            this.Laboratorio.DataPropertyName = "Laboratorio";
            this.Laboratorio.HeaderText = "Laboratorio";
            this.Laboratorio.Name = "Laboratorio";
            this.Laboratorio.ReadOnly = true;
            this.Laboratorio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Laboratorio.ToolTipText = "columna Laboratorio";
            this.Laboratorio.Width = 75;
            // 
            // Tratamento
            // 
            this.Tratamento.DataPropertyName = "Tratamento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tratamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tratamento.HeaderText = "Tratamento";
            this.Tratamento.Name = "Tratamento";
            this.Tratamento.ReadOnly = true;
            this.Tratamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tratamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tratamento.ToolTipText = "columna Tratamento";
            this.Tratamento.Width = 150;
            // 
            // InfoResumida
            // 
            this.InfoResumida.DataPropertyName = "InfoResumida";
            this.InfoResumida.HeaderText = "Resumen";
            this.InfoResumida.Name = "InfoResumida";
            this.InfoResumida.ReadOnly = true;
            this.InfoResumida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoResumida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.InfoResumida.ToolTipText = "columna Resumen";
            this.InfoResumida.Width = 90;
            // 
            // fEditarMedicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.lblResumenMedicación);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFondoHeader);
            this.Controls.Add(this.dgvMedicacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEditarMedicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicación Alerxias";
            this.Load += new System.EventHandler(this.fEditarMedicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlCRUD.ResumeLayout(false);
            this.pnlCRUD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicacion;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFondoHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResumenMedicación;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btGardar;
        private System.Windows.Forms.TextBox txbLaboratorio;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblTratamento;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbTratamento;
        private System.Windows.Forms.TextBox txbInfoResumida;
        private System.Windows.Forms.Label lblInfoResumida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoResumida;
    }
}