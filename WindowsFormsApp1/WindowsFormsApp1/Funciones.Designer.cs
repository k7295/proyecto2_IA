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
            this.picture_amarillo = new System.Windows.Forms.PictureBox();
            this.picture_naranja = new System.Windows.Forms.PictureBox();
            this.picture_verde = new System.Windows.Forms.PictureBox();
            this.boton_temporal = new System.Windows.Forms.Button();
            this.textBox_temporal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picture_amarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_naranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_opciones
            // 
            this.label_opciones.AutoSize = true;
            this.label_opciones.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_opciones.Location = new System.Drawing.Point(646, 13);
            this.label_opciones.Name = "label_opciones";
            this.label_opciones.Size = new System.Drawing.Size(144, 42);
            this.label_opciones.TabIndex = 0;
            this.label_opciones.Text = "Opciones";
            // 
            // repartirOrdenes
            // 
            this.repartirOrdenes.AutoSize = true;
            this.repartirOrdenes.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repartirOrdenes.Location = new System.Drawing.Point(573, 371);
            this.repartirOrdenes.Name = "repartirOrdenes";
            this.repartirOrdenes.Size = new System.Drawing.Size(180, 33);
            this.repartirOrdenes.TabIndex = 5;
            this.repartirOrdenes.Text = "Repartir ordenes";
            // 
            // mostrarServicios
            // 
            this.mostrarServicios.AutoSize = true;
            this.mostrarServicios.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarServicios.Location = new System.Drawing.Point(669, 237);
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
            this.mostrarAgentes.Location = new System.Drawing.Point(577, 104);
            this.mostrarAgentes.Name = "mostrarAgentes";
            this.mostrarAgentes.Size = new System.Drawing.Size(176, 33);
            this.mostrarAgentes.TabIndex = 1;
            this.mostrarAgentes.Text = "Mostrar Agentes";
            // 
            // picture_amarillo
            // 
            this.picture_amarillo.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;
            this.picture_amarillo.Location = new System.Drawing.Point(552, 72);
            this.picture_amarillo.Name = "picture_amarillo";
            this.picture_amarillo.Size = new System.Drawing.Size(234, 112);
            this.picture_amarillo.TabIndex = 6;
            this.picture_amarillo.TabStop = false;
            this.picture_amarillo.Visible = false;
            // 
            // picture_naranja
            // 
            this.picture_naranja.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
            this.picture_naranja.Location = new System.Drawing.Point(653, 201);
            this.picture_naranja.Name = "picture_naranja";
            this.picture_naranja.Size = new System.Drawing.Size(234, 112);
            this.picture_naranja.TabIndex = 7;
            this.picture_naranja.TabStop = false;
            this.picture_naranja.Visible = false;
            // 
            // picture_verde
            // 
            this.picture_verde.Image = global::WindowsFormsApp1.Properties.Resources.verde;
            this.picture_verde.Location = new System.Drawing.Point(552, 330);
            this.picture_verde.Name = "picture_verde";
            this.picture_verde.Size = new System.Drawing.Size(234, 112);
            this.picture_verde.TabIndex = 8;
            this.picture_verde.TabStop = false;
            this.picture_verde.Visible = false;
            // 
            // boton_temporal
            // 
            this.boton_temporal.Location = new System.Drawing.Point(534, 28);
            this.boton_temporal.Name = "boton_temporal";
            this.boton_temporal.Size = new System.Drawing.Size(99, 21);
            this.boton_temporal.TabIndex = 10;
            this.boton_temporal.Text = "button1";
            this.boton_temporal.UseVisualStyleBackColor = true;
            // 
            // textBox_temporal
            // 
            this.textBox_temporal.Location = new System.Drawing.Point(335, 30);
            this.textBox_temporal.Name = "textBox_temporal";
            this.textBox_temporal.Size = new System.Drawing.Size(185, 20);
            this.textBox_temporal.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(508, 304);
            this.dataGridView1.TabIndex = 11;
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 466);
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
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Funciones";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picture_amarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_naranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}