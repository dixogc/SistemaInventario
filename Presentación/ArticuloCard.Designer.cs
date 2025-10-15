namespace SistemaInventario.Presentación
{
    partial class ArticuloCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticuloCard));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAñadirArticulo = new System.Windows.Forms.Button();
            this.btnDisminuirArticulo = new System.Windows.Forms.Button();
            this.btnEditarArticulo = new System.Windows.Forms.Button();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            this.btnActualizarStock = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblConteo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(117, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(164, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del artículo";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.SystemColors.Control;
            this.lblStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(169, 90);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(20, 22);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "#";
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(118, 40);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(73, 15);
            this.lblUbicacion.TabIndex = 4;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(119, 60);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 15);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría";
            // 
            // btnAñadirArticulo
            // 
            this.btnAñadirArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.btnAñadirArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAñadirArticulo.BackgroundImage")));
            this.btnAñadirArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadirArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirArticulo.Location = new System.Drawing.Point(121, 90);
            this.btnAñadirArticulo.Name = "btnAñadirArticulo";
            this.btnAñadirArticulo.Size = new System.Drawing.Size(32, 23);
            this.btnAñadirArticulo.TabIndex = 6;
            this.btnAñadirArticulo.UseVisualStyleBackColor = false;
            this.btnAñadirArticulo.Click += new System.EventHandler(this.btnAñadirArticulo_Click);
            // 
            // btnDisminuirArticulo
            // 
            this.btnDisminuirArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisminuirArticulo.BackgroundImage")));
            this.btnDisminuirArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDisminuirArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisminuirArticulo.Location = new System.Drawing.Point(207, 90);
            this.btnDisminuirArticulo.Name = "btnDisminuirArticulo";
            this.btnDisminuirArticulo.Size = new System.Drawing.Size(31, 23);
            this.btnDisminuirArticulo.TabIndex = 7;
            this.btnDisminuirArticulo.UseVisualStyleBackColor = true;
            this.btnDisminuirArticulo.Click += new System.EventHandler(this.btnDarDeBajaArticulo_Click);
            // 
            // btnEditarArticulo
            // 
            this.btnEditarArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditarArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarArticulo.BackgroundImage")));
            this.btnEditarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarArticulo.Location = new System.Drawing.Point(409, 3);
            this.btnEditarArticulo.Name = "btnEditarArticulo";
            this.btnEditarArticulo.Size = new System.Drawing.Size(37, 25);
            this.btnEditarArticulo.TabIndex = 8;
            this.btnEditarArticulo.UseVisualStyleBackColor = false;
            this.btnEditarArticulo.Click += new System.EventHandler(this.btnEditarArticulo_Click);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(10, 13);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(100, 79);
            this.pictureBoxArticulo.TabIndex = 9;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // btnActualizarStock
            // 
            this.btnActualizarStock.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarStock.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarStock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarStock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarStock.Location = new System.Drawing.Point(207, 133);
            this.btnActualizarStock.Name = "btnActualizarStock";
            this.btnActualizarStock.Size = new System.Drawing.Size(123, 23);
            this.btnActualizarStock.TabIndex = 11;
            this.btnActualizarStock.Text = "Actualizar stock";
            this.btnActualizarStock.UseVisualStyleBackColor = false;
            this.btnActualizarStock.Click += new System.EventHandler(this.btnAñadirStock_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(122, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblConteo
            // 
            this.lblConteo.AutoSize = true;
            this.lblConteo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteo.Location = new System.Drawing.Point(118, 116);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(54, 15);
            this.lblConteo.TabIndex = 13;
            this.lblConteo.Text = "Conteo";
            this.lblConteo.Click += new System.EventHandler(this.lblConteo_Click);
            // 
            // ArticuloCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblConteo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizarStock);
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.btnEditarArticulo);
            this.Controls.Add(this.btnDisminuirArticulo);
            this.Controls.Add(this.btnAñadirArticulo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblNombre);
            this.Name = "ArticuloCard";
            this.Size = new System.Drawing.Size(458, 165);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAñadirArticulo;
        private System.Windows.Forms.Button btnDisminuirArticulo;
        private System.Windows.Forms.Button btnEditarArticulo;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
        private System.Windows.Forms.Button btnActualizarStock;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblConteo;
    }
}
