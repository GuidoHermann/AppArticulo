namespace presentacion
{
    partial class frmAltaArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPreico = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.pbxNuevoArticulo = new System.Windows.Forms.PictureBox();
            this.btnAltaArticulo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCodigoError = new System.Windows.Forms.Label();
            this.lblNombreError = new System.Windows.Forms.Label();
            this.lblPrecioError = new System.Windows.Forms.Label();
            this.lblCodigoNecesario = new System.Windows.Forms.Label();
            this.lblNombreNecesario = new System.Windows.Forms.Label();
            this.lblPrecioNecesario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevoArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(54, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(49, 82);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(26, 139);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.Location = new System.Drawing.Point(36, 196);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(72, 16);
            this.lblImagen.TabIndex = 3;
            this.lblImagen.Text = "UrlImagen:";
            // 
            // lblPreico
            // 
            this.lblPreico.AutoSize = true;
            this.lblPreico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreico.Location = new System.Drawing.Point(59, 367);
            this.lblPreico.Name = "lblPreico";
            this.lblPreico.Size = new System.Drawing.Size(49, 16);
            this.lblPreico.TabIndex = 4;
            this.lblPreico.Text = "Precio:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(60, 252);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 16);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(39, 309);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(208, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(208, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(114, 138);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(113, 195);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(208, 20);
            this.txtUrlImagen.TabIndex = 10;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(113, 366);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(208, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(113, 251);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(208, 21);
            this.cboMarca.TabIndex = 12;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(113, 308);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(208, 21);
            this.cboCategoria.TabIndex = 13;
            // 
            // pbxNuevoArticulo
            // 
            this.pbxNuevoArticulo.Location = new System.Drawing.Point(327, 24);
            this.pbxNuevoArticulo.Name = "pbxNuevoArticulo";
            this.pbxNuevoArticulo.Size = new System.Drawing.Size(361, 361);
            this.pbxNuevoArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxNuevoArticulo.TabIndex = 14;
            this.pbxNuevoArticulo.TabStop = false;
            this.pbxNuevoArticulo.Click += new System.EventHandler(this.pbxNuevoArticulo_Click);
            // 
            // btnAltaArticulo
            // 
            this.btnAltaArticulo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAltaArticulo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAltaArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAltaArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btnAltaArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaArticulo.Location = new System.Drawing.Point(57, 441);
            this.btnAltaArticulo.Name = "btnAltaArticulo";
            this.btnAltaArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnAltaArticulo.TabIndex = 15;
            this.btnAltaArticulo.Text = "Añadir";
            this.btnAltaArticulo.UseVisualStyleBackColor = false;
            this.btnAltaArticulo.Click += new System.EventHandler(this.btnAltaArticulo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(246, 441);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCodigoError
            // 
            this.lblCodigoError.AutoSize = true;
            this.lblCodigoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoError.ForeColor = System.Drawing.Color.DeepPink;
            this.lblCodigoError.Location = new System.Drawing.Point(111, 47);
            this.lblCodigoError.Name = "lblCodigoError";
            this.lblCodigoError.Size = new System.Drawing.Size(0, 16);
            this.lblCodigoError.TabIndex = 17;
            this.lblCodigoError.Click += new System.EventHandler(this.lblCodigoError_Click);
            // 
            // lblNombreError
            // 
            this.lblNombreError.AutoSize = true;
            this.lblNombreError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreError.ForeColor = System.Drawing.Color.DeepPink;
            this.lblNombreError.Location = new System.Drawing.Point(110, 104);
            this.lblNombreError.Name = "lblNombreError";
            this.lblNombreError.Size = new System.Drawing.Size(0, 16);
            this.lblNombreError.TabIndex = 18;
            // 
            // lblPrecioError
            // 
            this.lblPrecioError.AutoSize = true;
            this.lblPrecioError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioError.ForeColor = System.Drawing.Color.DeepPink;
            this.lblPrecioError.Location = new System.Drawing.Point(110, 393);
            this.lblPrecioError.Name = "lblPrecioError";
            this.lblPrecioError.Size = new System.Drawing.Size(0, 16);
            this.lblPrecioError.TabIndex = 19;
            // 
            // lblCodigoNecesario
            // 
            this.lblCodigoNecesario.AutoSize = true;
            this.lblCodigoNecesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoNecesario.ForeColor = System.Drawing.Color.DeepPink;
            this.lblCodigoNecesario.Location = new System.Drawing.Point(33, 18);
            this.lblCodigoNecesario.Name = "lblCodigoNecesario";
            this.lblCodigoNecesario.Size = new System.Drawing.Size(25, 31);
            this.lblCodigoNecesario.TabIndex = 20;
            this.lblCodigoNecesario.Text = "*";
            this.lblCodigoNecesario.MouseHover += new System.EventHandler(this.lblCodigoNecesario_MouseHover);
            // 
            // lblNombreNecesario
            // 
            this.lblNombreNecesario.AutoSize = true;
            this.lblNombreNecesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreNecesario.ForeColor = System.Drawing.Color.DeepPink;
            this.lblNombreNecesario.Location = new System.Drawing.Point(23, 70);
            this.lblNombreNecesario.Name = "lblNombreNecesario";
            this.lblNombreNecesario.Size = new System.Drawing.Size(25, 31);
            this.lblNombreNecesario.TabIndex = 21;
            this.lblNombreNecesario.Text = "*";
            this.lblNombreNecesario.MouseHover += new System.EventHandler(this.lblNombreNecesario_MouseHover);
            // 
            // lblPrecioNecesario
            // 
            this.lblPrecioNecesario.AutoSize = true;
            this.lblPrecioNecesario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioNecesario.ForeColor = System.Drawing.Color.DeepPink;
            this.lblPrecioNecesario.Location = new System.Drawing.Point(36, 354);
            this.lblPrecioNecesario.Name = "lblPrecioNecesario";
            this.lblPrecioNecesario.Size = new System.Drawing.Size(25, 31);
            this.lblPrecioNecesario.TabIndex = 22;
            this.lblPrecioNecesario.Text = "*";
            this.lblPrecioNecesario.MouseHover += new System.EventHandler(this.lblPrecioNecesario_MouseHover);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 498);
            this.Controls.Add(this.lblPrecioNecesario);
            this.Controls.Add(this.lblNombreNecesario);
            this.Controls.Add(this.lblCodigoNecesario);
            this.Controls.Add(this.lblPrecioError);
            this.Controls.Add(this.lblNombreError);
            this.Controls.Add(this.lblCodigoError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAltaArticulo);
            this.Controls.Add(this.pbxNuevoArticulo);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPreico);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAltaArticulo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxNuevoArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPreico;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.PictureBox pbxNuevoArticulo;
        private System.Windows.Forms.Button btnAltaArticulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCodigoError;
        private System.Windows.Forms.Label lblNombreError;
        private System.Windows.Forms.Label lblPrecioError;
        private System.Windows.Forms.Label lblCodigoNecesario;
        private System.Windows.Forms.Label lblNombreNecesario;
        private System.Windows.Forms.Label lblPrecioNecesario;
    }
}