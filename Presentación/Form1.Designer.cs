namespace SistemaInventario.Presentación
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnMostrarTodo = new System.Windows.Forms.CheckBox();
            this.flowCategorias = new System.Windows.Forms.FlowLayoutPanel();
            this.categoria1 = new System.Windows.Forms.Button();
            this.categoria2 = new System.Windows.Forms.Button();
            this.categoria3 = new System.Windows.Forms.Button();
            this.categoria4 = new System.Windows.Forms.Button();
            this.categoria5 = new System.Windows.Forms.Button();
            this.panelSubcategorias = new System.Windows.Forms.Panel();
            this.clbSubcategorias = new System.Windows.Forms.CheckedListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.flowCategorias.SuspendLayout();
            this.panelSubcategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(698, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 34);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(759, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 30);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(133, 230);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(394, 373);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Artículo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(394, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.AutoSize = true;
            this.btnMostrarTodo.Location = new System.Drawing.Point(133, 66);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(85, 17);
            this.btnMostrarTodo.TabIndex = 13;
            this.btnMostrarTodo.Text = "Mostrar todo";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.CheckedChanged += new System.EventHandler(this.btnMostrarTodo_CheckedChanged);
            // 
            // flowCategorias
            // 
            this.flowCategorias.AutoSize = true;
            this.flowCategorias.Controls.Add(this.categoria1);
            this.flowCategorias.Controls.Add(this.categoria2);
            this.flowCategorias.Controls.Add(this.categoria3);
            this.flowCategorias.Controls.Add(this.categoria4);
            this.flowCategorias.Controls.Add(this.categoria5);
            this.flowCategorias.Location = new System.Drawing.Point(133, 98);
            this.flowCategorias.Name = "flowCategorias";
            this.flowCategorias.Size = new System.Drawing.Size(657, 31);
            this.flowCategorias.TabIndex = 14;
            // 
            // categoria1
            // 
            this.categoria1.AutoSize = true;
            this.categoria1.Location = new System.Drawing.Point(3, 3);
            this.categoria1.Name = "categoria1";
            this.categoria1.Size = new System.Drawing.Size(140, 23);
            this.categoria1.TabIndex = 0;
            this.categoria1.Text = "Equipamiento de cómputo";
            this.categoria1.UseVisualStyleBackColor = true;
            // 
            // categoria2
            // 
            this.categoria2.AutoSize = true;
            this.categoria2.Location = new System.Drawing.Point(149, 3);
            this.categoria2.Name = "categoria2";
            this.categoria2.Size = new System.Drawing.Size(114, 23);
            this.categoria2.TabIndex = 1;
            this.categoria2.Text = "Impresión y escaneo";
            this.categoria2.UseVisualStyleBackColor = true;
            this.categoria2.Click += new System.EventHandler(this.button5_Click);
            // 
            // categoria3
            // 
            this.categoria3.AutoSize = true;
            this.categoria3.Location = new System.Drawing.Point(269, 3);
            this.categoria3.Name = "categoria3";
            this.categoria3.Size = new System.Drawing.Size(142, 23);
            this.categoria3.TabIndex = 2;
            this.categoria3.Text = "Consumibles y refacciones";
            this.categoria3.UseVisualStyleBackColor = true;
            // 
            // categoria4
            // 
            this.categoria4.AutoSize = true;
            this.categoria4.Location = new System.Drawing.Point(417, 3);
            this.categoria4.Name = "categoria4";
            this.categoria4.Size = new System.Drawing.Size(109, 23);
            this.categoria4.TabIndex = 3;
            this.categoria4.Text = "Conectividad y red";
            this.categoria4.UseVisualStyleBackColor = true;
            // 
            // categoria5
            // 
            this.categoria5.AutoSize = true;
            this.categoria5.Location = new System.Drawing.Point(532, 3);
            this.categoria5.Name = "categoria5";
            this.categoria5.Size = new System.Drawing.Size(122, 23);
            this.categoria5.TabIndex = 4;
            this.categoria5.Text = "Herramientas y utilería";
            this.categoria5.UseVisualStyleBackColor = true;
            // 
            // panelSubcategorias
            // 
            this.panelSubcategorias.Controls.Add(this.clbSubcategorias);
            this.panelSubcategorias.Location = new System.Drawing.Point(133, 135);
            this.panelSubcategorias.Name = "panelSubcategorias";
            this.panelSubcategorias.Size = new System.Drawing.Size(657, 55);
            this.panelSubcategorias.TabIndex = 15;
            this.panelSubcategorias.Visible = false;
            // 
            // clbSubcategorias
            // 
            this.clbSubcategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSubcategorias.FormattingEnabled = true;
            this.clbSubcategorias.Location = new System.Drawing.Point(0, 0);
            this.clbSubcategorias.Name = "clbSubcategorias";
            this.clbSubcategorias.Size = new System.Drawing.Size(657, 55);
            this.clbSubcategorias.TabIndex = 0;
            this.clbSubcategorias.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(136, 197);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Aplicar filtros";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 661);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panelSubcategorias);
            this.Controls.Add(this.flowCategorias);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowCategorias.ResumeLayout(false);
            this.flowCategorias.PerformLayout();
            this.panelSubcategorias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox btnMostrarTodo;
        private System.Windows.Forms.FlowLayoutPanel flowCategorias;
        private System.Windows.Forms.Button categoria1;
        private System.Windows.Forms.Button categoria2;
        private System.Windows.Forms.Button categoria3;
        private System.Windows.Forms.Button categoria4;
        private System.Windows.Forms.Button categoria5;
        private System.Windows.Forms.Panel panelSubcategorias;
        private System.Windows.Forms.CheckedListBox clbSubcategorias;
        private System.Windows.Forms.Button button9;
    }
}