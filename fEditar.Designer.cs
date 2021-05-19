
namespace MedicacionAlerxias
{
    partial class fEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditar));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblFondoHeader = new System.Windows.Forms.Label();
            this.lblObservacions = new System.Windows.Forms.Label();
            this.txbObservacions = new System.Windows.Forms.TextBox();
            this.lbxInfoResumida = new System.Windows.Forms.ListBox();
            this.cbxMedicacion = new System.Windows.Forms.ComboBox();
            this.lblDoses = new System.Windows.Forms.Label();
            this.nudDoses = new System.Windows.Forms.NumericUpDown();
            this.lblData = new System.Windows.Forms.Label();
            this.lblMedicación = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGardar = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoses)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(66, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(268, 87);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            // 
            // lblFondoHeader
            // 
            this.lblFondoHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(224)))));
            this.lblFondoHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFondoHeader.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFondoHeader.Location = new System.Drawing.Point(-1, -2);
            this.lblFondoHeader.Name = "lblFondoHeader";
            this.lblFondoHeader.Size = new System.Drawing.Size(400, 102);
            this.lblFondoHeader.TabIndex = 10;
            this.lblFondoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblObservacions
            // 
            this.lblObservacions.AutoSize = true;
            this.lblObservacions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacions.Location = new System.Drawing.Point(149, 284);
            this.lblObservacions.Name = "lblObservacions";
            this.lblObservacions.Size = new System.Drawing.Size(108, 16);
            this.lblObservacions.TabIndex = 13;
            this.lblObservacions.Text = "Observacions:";
            // 
            // txbObservacions
            // 
            this.txbObservacions.Location = new System.Drawing.Point(95, 303);
            this.txbObservacions.Multiline = true;
            this.txbObservacions.Name = "txbObservacions";
            this.txbObservacions.Size = new System.Drawing.Size(211, 62);
            this.txbObservacions.TabIndex = 21;
            this.txbObservacions.TextChanged += new System.EventHandler(this.txbObservacions_TextChanged);
            // 
            // lbxInfoResumida
            // 
            this.lbxInfoResumida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbxInfoResumida.FormattingEnabled = true;
            this.lbxInfoResumida.Location = new System.Drawing.Point(95, 244);
            this.lbxInfoResumida.Name = "lbxInfoResumida";
            this.lbxInfoResumida.Size = new System.Drawing.Size(211, 30);
            this.lbxInfoResumida.TabIndex = 14;
            // 
            // cbxMedicacion
            // 
            this.cbxMedicacion.FormattingEnabled = true;
            this.cbxMedicacion.Location = new System.Drawing.Point(95, 213);
            this.cbxMedicacion.Name = "cbxMedicacion";
            this.cbxMedicacion.Size = new System.Drawing.Size(121, 21);
            this.cbxMedicacion.TabIndex = 19;
            this.cbxMedicacion.SelectedIndexChanged += new System.EventHandler(this.cbxMedicacion_SelectedIndexChanged);
            // 
            // lblDoses
            // 
            this.lblDoses.AutoSize = true;
            this.lblDoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoses.Location = new System.Drawing.Point(249, 185);
            this.lblDoses.Name = "lblDoses";
            this.lblDoses.Size = new System.Drawing.Size(57, 16);
            this.lblDoses.TabIndex = 15;
            this.lblDoses.Text = "Doses:";
            // 
            // nudDoses
            // 
            this.nudDoses.Location = new System.Drawing.Point(251, 214);
            this.nudDoses.Name = "nudDoses";
            this.nudDoses.Size = new System.Drawing.Size(55, 20);
            this.nudDoses.TabIndex = 20;
            this.nudDoses.ValueChanged += new System.EventHandler(this.nudDoses_ValueChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(171, 121);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 16);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "Data:";
            // 
            // lblMedicación
            // 
            this.lblMedicación.AutoSize = true;
            this.lblMedicación.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicación.Location = new System.Drawing.Point(112, 185);
            this.lblMedicación.Name = "lblMedicación";
            this.lblMedicación.Size = new System.Drawing.Size(92, 16);
            this.lblMedicación.TabIndex = 17;
            this.lblMedicación.Text = "Medicación:";
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy";
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(100, 153);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 18;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(215, 386);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 23;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.bts_Gardar_Cancelar_Click);
            // 
            // btGardar
            // 
            this.btGardar.Location = new System.Drawing.Point(110, 386);
            this.btGardar.Name = "btGardar";
            this.btGardar.Size = new System.Drawing.Size(75, 23);
            this.btGardar.TabIndex = 22;
            this.btGardar.Text = "GARDAR";
            this.btGardar.UseVisualStyleBackColor = true;
            this.btGardar.Click += new System.EventHandler(this.bts_Gardar_Cancelar_Click);
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
            this.btAtras.TabIndex = 24;
            this.btAtras.UseVisualStyleBackColor = false;
            this.btAtras.Click += new System.EventHandler(this.bts_Gardar_Cancelar_Click);
            // 
            // fEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(399, 431);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGardar);
            this.Controls.Add(this.lblObservacions);
            this.Controls.Add(this.txbObservacions);
            this.Controls.Add(this.lbxInfoResumida);
            this.Controls.Add(this.cbxMedicacion);
            this.Controls.Add(this.lblDoses);
            this.Controls.Add(this.nudDoses);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblMedicación);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblFondoHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicaciónAlerxias";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblFondoHeader;
        private System.Windows.Forms.Label lblObservacions;
        private System.Windows.Forms.TextBox txbObservacions;
        private System.Windows.Forms.ListBox lbxInfoResumida;
        private System.Windows.Forms.ComboBox cbxMedicacion;
        private System.Windows.Forms.Label lblDoses;
        private System.Windows.Forms.NumericUpDown nudDoses;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblMedicación;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGardar;
        private System.Windows.Forms.Button btAtras;
    }
}