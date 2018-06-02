namespace WindowsFormsApp1
{
    partial class Funciones
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
            this.label_opciones = new System.Windows.Forms.Label();
            this.repartirOrdenes = new System.Windows.Forms.Label();
            this.mostrarServicios = new System.Windows.Forms.Label();
            this.mostrarAgentes = new System.Windows.Forms.Label();
            this.boton_temporal = new System.Windows.Forms.Button();
            this.textBox_temporal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imagen_barra = new System.Windows.Forms.PictureBox();
            this.Ayuda = new System.Windows.Forms.Label();
            this.picture_amarillo = new System.Windows.Forms.PictureBox();
            this.picture_naranja = new System.Windows.Forms.PictureBox();
            this.picture_verde = new System.Windows.Forms.PictureBox();
            this.ayuda_colores = new System.Windows.Forms.PictureBox();
            this.titulo_tabla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_barra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_amarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_naranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuda_colores)).BeginInit();
            this.SuspendLayout();
            // 
            // label_opciones
            // 
            this.label_opciones.AutoSize = true;
            this.label_opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_opciones.Location = new System.Drawing.Point(873, 10);
            this.label_opciones.Name = "label_opciones";
            this.label_opciones.Size = new System.Drawing.Size(152, 37);
            this.label_opciones.TabIndex = 0;
            this.label_opciones.Text = "Opciones";
            // 
            // repartirOrdenes
            // 
            this.repartirOrdenes.AutoSize = true;
            this.repartirOrdenes.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repartirOrdenes.Location = new System.Drawing.Point(863, 368);
            this.repartirOrdenes.Name = "repartirOrdenes";
            this.repartirOrdenes.Size = new System.Drawing.Size(180, 33);
            this.repartirOrdenes.TabIndex = 5;
            this.repartirOrdenes.Text = "Repartir ordenes";
            // 
            // mostrarServicios
            // 
            this.mostrarServicios.AutoSize = true;
            this.mostrarServicios.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarServicios.Location = new System.Drawing.Point(959, 234);
            this.mostrarServicios.Name = "mostrarServicios";
            this.mostrarServicios.Size = new System.Drawing.Size(183, 33);
            this.mostrarServicios.TabIndex = 2;
            this.mostrarServicios.Text = "Mostrar Servicios";
            // 
            // mostrarAgentes
            // 
            this.mostrarAgentes.AutoSize = true;
            this.mostrarAgentes.BackColor = System.Drawing.Color.Transparent;
            this.mostrarAgentes.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarAgentes.Location = new System.Drawing.Point(867, 101);
            this.mostrarAgentes.Name = "mostrarAgentes";
            this.mostrarAgentes.Size = new System.Drawing.Size(176, 33);
            this.mostrarAgentes.TabIndex = 1;
            this.mostrarAgentes.Text = "Mostrar Agentes";
            this.mostrarAgentes.Click += new System.EventHandler(this.mostrarAgentes_Click);
            // 
            // boton_temporal
            // 
            this.boton_temporal.Location = new System.Drawing.Point(737, 30);
            this.boton_temporal.Name = "boton_temporal";
            this.boton_temporal.Size = new System.Drawing.Size(99, 21);
            this.boton_temporal.TabIndex = 10;
            this.boton_temporal.Text = "button1";
            this.boton_temporal.UseVisualStyleBackColor = true;
            this.boton_temporal.Click += new System.EventHandler(this.boton_temporal_Click);
            // 
            // textBox_temporal
            // 
            this.textBox_temporal.Location = new System.Drawing.Point(538, 32);
            this.textBox_temporal.Name = "textBox_temporal";
            this.textBox_temporal.Size = new System.Drawing.Size(185, 20);
            this.textBox_temporal.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 369);
            this.dataGridView1.TabIndex = 11;
            // 
            // imagen_barra
            // 
            this.imagen_barra.Image = global::WindowsFormsApp1.Properties.Resources.barra1;
            this.imagen_barra.Location = new System.Drawing.Point(764, 130);
            this.imagen_barra.Name = "imagen_barra";
            this.imagen_barra.Size = new System.Drawing.Size(31, 282);
            this.imagen_barra.TabIndex = 14;
            this.imagen_barra.TabStop = false;
            // 
            // Ayuda
            // 
            this.Ayuda.AutoSize = true;
            this.Ayuda.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ayuda.Location = new System.Drawing.Point(1093, 489);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(96, 42);
            this.Ayuda.TabIndex = 12;
            this.Ayuda.Text = "Ayuda";
            // 
            // picture_amarillo
            // 
            this.picture_amarillo.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;
            this.picture_amarillo.Location = new System.Drawing.Point(842, 69);
            this.picture_amarillo.Name = "picture_amarillo";
            this.picture_amarillo.Size = new System.Drawing.Size(234, 112);
            this.picture_amarillo.TabIndex = 6;
            this.picture_amarillo.TabStop = false;
            this.picture_amarillo.Visible = false;
            // 
            // picture_naranja
            // 
            this.picture_naranja.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
            this.picture_naranja.Location = new System.Drawing.Point(943, 198);
            this.picture_naranja.Name = "picture_naranja";
            this.picture_naranja.Size = new System.Drawing.Size(234, 112);
            this.picture_naranja.TabIndex = 7;
            this.picture_naranja.TabStop = false;
            this.picture_naranja.Visible = false;
            // 
            // picture_verde
            // 
            this.picture_verde.Image = global::WindowsFormsApp1.Properties.Resources.verde;
            this.picture_verde.Location = new System.Drawing.Point(842, 327);
            this.picture_verde.Name = "picture_verde";
            this.picture_verde.Size = new System.Drawing.Size(234, 112);
            this.picture_verde.TabIndex = 8;
            this.picture_verde.TabStop = false;
            this.picture_verde.Visible = false;
            // 
            // ayuda_colores
            // 
            this.ayuda_colores.Image = global::WindowsFormsApp1.Properties.Resources.ayuda;
            this.ayuda_colores.Location = new System.Drawing.Point(1082, 459);
            this.ayuda_colores.Name = "ayuda_colores";
            this.ayuda_colores.Size = new System.Drawing.Size(117, 82);
            this.ayuda_colores.TabIndex = 13;
            this.ayuda_colores.TabStop = false;
            this.ayuda_colores.Visible = false;
            // 
            // titulo_tabla
            // 
            this.titulo_tabla.AutoSize = true;
            this.titulo_tabla.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_tabla.Location = new System.Drawing.Point(326, 41);
            this.titulo_tabla.Name = "titulo_tabla";
            this.titulo_tabla.Size = new System.Drawing.Size(83, 33);
            this.titulo_tabla.TabIndex = 15;
            this.titulo_tabla.Text = "label1";
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 550);
            this.Controls.Add(this.titulo_tabla);
            this.Controls.Add(this.imagen_barra);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.boton_temporal);
            this.Controls.Add(this.textBox_temporal);
            this.Controls.Add(this.repartirOrdenes);
            this.Controls.Add(this.mostrarServicios);
            this.Controls.Add(this.mostrarAgentes);
            this.Controls.Add(this.label_opciones);
            this.Controls.Add(this.picture_amarillo);
            this.Controls.Add(this.picture_naranja);
            this.Controls.Add(this.picture_verde);
            this.Controls.Add(this.ayuda_colores);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Funciones";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_barra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_amarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_naranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayuda_colores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_opciones;
        private System.Windows.Forms.Label mostrarAgentes;
        private System.Windows.Forms.Label mostrarServicios;
        private System.Windows.Forms.Label repartirOrdenes;
        private System.Windows.Forms.PictureBox picture_amarillo;
        private System.Windows.Forms.PictureBox picture_naranja;
        private System.Windows.Forms.PictureBox picture_verde;
        private System.Windows.Forms.Button boton_temporal;
        private System.Windows.Forms.TextBox textBox_temporal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Ayuda;
        private System.Windows.Forms.PictureBox ayuda_colores;
        private System.Windows.Forms.PictureBox imagen_barra;
        private System.Windows.Forms.Label titulo_tabla;
    }
}