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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnAñadirArticulo = new System.Windows.Forms.Button();
            this.btnDarDeBajaArticulo = new System.Windows.Forms.Button();
            this.btnEditarArticulo = new System.Windows.Forms.Button();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(117, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del artículo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(117, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(119, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion del artículo";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(303, 38);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stock";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(116, 59);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 4;
            this.lblUbicacion.Text = "Ubicacion";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(117, 79);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría";
            // 
            // btnAñadirArticulo
            // 
            this.btnAñadirArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAñadirArticulo.BackgroundImage")));
            this.btnAñadirArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadirArticulo.Location = new System.Drawing.Point(287, 59);
            this.btnAñadirArticulo.Name = "btnAñadirArticulo";
            this.btnAñadirArticulo.Size = new System.Drawing.Size(32, 23);
            this.btnAñadirArticulo.TabIndex = 6;
            this.btnAñadirArticulo.UseVisualStyleBackColor = true;
            // 
            // btnDarDeBajaArticulo
            // 
            this.btnDarDeBajaArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDarDeBajaArticulo.BackgroundImage")));
            this.btnDarDeBajaArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDarDeBajaArticulo.Location = new System.Drawing.Point(325, 59);
            this.btnDarDeBajaArticulo.Name = "btnDarDeBajaArticulo";
            this.btnDarDeBajaArticulo.Size = new System.Drawing.Size(31, 23);
            this.btnDarDeBajaArticulo.TabIndex = 7;
            this.btnDarDeBajaArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEditarArticulo
            // 
            this.btnEditarArticulo.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditarArticulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarArticulo.BackgroundImage")));
            this.btnEditarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarArticulo.Location = new System.Drawing.Point(339, 3);
            this.btnEditarArticulo.Name = "btnEditarArticulo";
            this.btnEditarArticulo.Size = new System.Drawing.Size(31, 27);
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
            // ArticuloCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBoxArticulo);
            this.Controls.Add(this.btnEditarArticulo);
            this.Controls.Add(this.btnDarDeBajaArticulo);
            this.Controls.Add(this.btnAñadirArticulo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Name = "ArticuloCard";
            this.Size = new System.Drawing.Size(371, 104);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnAñadirArticulo;
        private System.Windows.Forms.Button btnDarDeBajaArticulo;
        private System.Windows.Forms.Button btnEditarArticulo;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
    }
}
