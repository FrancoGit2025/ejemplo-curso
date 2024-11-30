namespace ejemplo1
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listViewElementos = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.rdbWizard = new System.Windows.Forms.RadioButton();
            this.rdbMuggle = new System.Windows.Forms.RadioButton();
            this.rdbSkibs = new System.Windows.Forms.RadioButton();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.numFavorito = new System.Windows.Forms.NumericUpDown();
            this.lblNumFavorito = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(173, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(359, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(65, 617);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 30);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listViewElementos
            // 
            this.listViewElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewElementos.HideSelection = false;
            this.listViewElementos.Location = new System.Drawing.Point(117, 419);
            this.listViewElementos.Name = "listViewElementos";
            this.listViewElementos.Size = new System.Drawing.Size(451, 181);
            this.listViewElementos.TabIndex = 6;
            this.listViewElementos.UseCompatibleStateImageBehavior = false;
            this.listViewElementos.View = System.Windows.Forms.View.List;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(62, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "nombre:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(62, 83);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(173, 83);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(359, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(65, 118);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(131, 17);
            this.ckbChocolate.TabIndex = 2;
            this.ckbChocolate.Text = "te gusta el chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(59, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(189, 31);
            this.lblPerfil.TabIndex = 7;
            this.lblPerfil.Text = "Perfil persona:";
            // 
            // rdbWizard
            // 
            this.rdbWizard.AutoSize = true;
            this.rdbWizard.Checked = true;
            this.rdbWizard.Location = new System.Drawing.Point(16, 57);
            this.rdbWizard.Name = "rdbWizard";
            this.rdbWizard.Size = new System.Drawing.Size(55, 17);
            this.rdbWizard.TabIndex = 0;
            this.rdbWizard.TabStop = true;
            this.rdbWizard.Text = "wizard";
            this.rdbWizard.UseVisualStyleBackColor = true;
            // 
            // rdbMuggle
            // 
            this.rdbMuggle.AutoSize = true;
            this.rdbMuggle.Location = new System.Drawing.Point(98, 57);
            this.rdbMuggle.Name = "rdbMuggle";
            this.rdbMuggle.Size = new System.Drawing.Size(59, 17);
            this.rdbMuggle.TabIndex = 1;
            this.rdbMuggle.Text = "muggle";
            this.rdbMuggle.UseVisualStyleBackColor = true;
            // 
            // rdbSkibs
            // 
            this.rdbSkibs.AutoSize = true;
            this.rdbSkibs.Location = new System.Drawing.Point(189, 57);
            this.rdbSkibs.Name = "rdbSkibs";
            this.rdbSkibs.Size = new System.Drawing.Size(51, 17);
            this.rdbSkibs.TabIndex = 2;
            this.rdbSkibs.Text = "Skibs";
            this.rdbSkibs.UseVisualStyleBackColor = true;
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxTipo.Controls.Add(this.rdbSkibs);
            this.groupBoxTipo.Controls.Add(this.rdbMuggle);
            this.groupBoxTipo.Controls.Add(this.rdbWizard);
            this.groupBoxTipo.Location = new System.Drawing.Point(145, 150);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(304, 137);
            this.groupBoxTipo.TabIndex = 3;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(62, 325);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(71, 13);
            this.lblColor.TabIndex = 12;
            this.lblColor.Text = "color favorito:";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(149, 325);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(389, 21);
            this.cboColorFavorito.TabIndex = 4;
            // 
            // numFavorito
            // 
            this.numFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numFavorito.Location = new System.Drawing.Point(149, 382);
            this.numFavorito.Name = "numFavorito";
            this.numFavorito.Size = new System.Drawing.Size(389, 20);
            this.numFavorito.TabIndex = 5;
            // 
            // lblNumFavorito
            // 
            this.lblNumFavorito.AutoSize = true;
            this.lblNumFavorito.Location = new System.Drawing.Point(62, 384);
            this.lblNumFavorito.Name = "lblNumFavorito";
            this.lblNumFavorito.Size = new System.Drawing.Size(85, 13);
            this.lblNumFavorito.TabIndex = 15;
            this.lblNumFavorito.Text = "Numero favorito:";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVerPerfil.Location = new System.Drawing.Point(173, 617);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(87, 30);
            this.btnVerPerfil.TabIndex = 8;
            this.btnVerPerfil.Text = "Ver &perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 673);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblNumFavorito);
            this.Controls.Add(this.numFavorito);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.listViewElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.MaximumSize = new System.Drawing.Size(758, 712);
            this.MinimumSize = new System.Drawing.Size(599, 668);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView listViewElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.RadioButton rdbWizard;
        private System.Windows.Forms.RadioButton rdbMuggle;
        private System.Windows.Forms.RadioButton rdbSkibs;
        private System.Windows.Forms.GroupBox groupBoxTipo;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.NumericUpDown numFavorito;
        private System.Windows.Forms.Label lblNumFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

