using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_opciones = new System.Windows.Forms.Label();
            this.repartirOrdenes = new System.Windows.Forms.Label();
            this.mostrarOrdenes = new System.Windows.Forms.Label();
            this.mostrarAgentes = new System.Windows.Forms.Label();
            this.boton_temporal = new System.Windows.Forms.Button();
            this.textBox_temporal = new System.Windows.Forms.TextBox();
            this.tabla_info = new System.Windows.Forms.DataGridView();
            this.Ayuda = new System.Windows.Forms.Label();
            this.picture_amarillo = new System.Windows.Forms.PictureBox();
            this.picture_naranja = new System.Windows.Forms.PictureBox();
            this.picture_verde = new System.Windows.Forms.PictureBox();
            this.ayuda_colores = new System.Windows.Forms.PictureBox();
            this.titulo_tabla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_info)).BeginInit();
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
            this.label_opciones.Location = new System.Drawing.Point(852, 35);
            this.label_opciones.Name = "label_opciones";
            this.label_opciones.Size = new System.Drawing.Size(128, 37);
            this.label_opciones.TabIndex = 0;
            this.label_opciones.Text = "Options";
            // 
            // repartirOrdenes
            // 
            this.repartirOrdenes.AutoSize = true;
            this.repartirOrdenes.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repartirOrdenes.Location = new System.Drawing.Point(784, 411);
            this.repartirOrdenes.Name = "repartirOrdenes";
            this.repartirOrdenes.Size = new System.Drawing.Size(139, 33);
            this.repartirOrdenes.TabIndex = 5;
            this.repartirOrdenes.Text = "Begin orders";
            // 
            // mostrarOrdenes
            // 
            this.mostrarOrdenes.AutoSize = true;
            this.mostrarOrdenes.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarOrdenes.Location = new System.Drawing.Point(880, 277);
            this.mostrarOrdenes.Name = "mostrarOrdenes";
            this.mostrarOrdenes.Size = new System.Drawing.Size(137, 33);
            this.mostrarOrdenes.TabIndex = 2;
            this.mostrarOrdenes.Text = "Show orders";
            // 
            // mostrarAgentes
            // 
            this.mostrarAgentes.AutoSize = true;
            this.mostrarAgentes.BackColor = System.Drawing.Color.Transparent;
            this.mostrarAgentes.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarAgentes.Location = new System.Drawing.Point(787, 139);
            this.mostrarAgentes.Name = "mostrarAgentes";
            this.mostrarAgentes.Size = new System.Drawing.Size(141, 33);
            this.mostrarAgentes.TabIndex = 1;
            this.mostrarAgentes.Text = "Show Agents";
            this.mostrarAgentes.Click += new System.EventHandler(this.mostrarAgentes_Click);
            // 
            // boton_temporal
            // 
            this.boton_temporal.Location = new System.Drawing.Point(647, 20);
            this.boton_temporal.Name = "boton_temporal";
            this.boton_temporal.Size = new System.Drawing.Size(99, 21);
            this.boton_temporal.TabIndex = 10;
            this.boton_temporal.Text = "Accept";
            this.boton_temporal.UseVisualStyleBackColor = true;
            this.boton_temporal.Click += new System.EventHandler(this.boton_temporal_Click);
            // 
            // textBox_temporal
            // 
            this.textBox_temporal.Location = new System.Drawing.Point(448, 22);
            this.textBox_temporal.Name = "textBox_temporal";
            this.textBox_temporal.Size = new System.Drawing.Size(185, 20);
            this.textBox_temporal.TabIndex = 9;
            // 
            // tabla_info
            // 
            this.tabla_info.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tabla_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabla_info.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla_info.BackgroundColor = System.Drawing.Color.White;
            this.tabla_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_info.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_info.Location = new System.Drawing.Point(19, 101);
            this.tabla_info.Margin = new System.Windows.Forms.Padding(10);
            this.tabla_info.Name = "tabla_info";
            this.tabla_info.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.tabla_info.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_info.Size = new System.Drawing.Size(614, 444);
            this.tabla_info.TabIndex = 11;
            // 
            // Ayuda
            // 
            this.Ayuda.AutoSize = true;
            this.Ayuda.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ayuda.Location = new System.Drawing.Point(907, 503);
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(191, 42);
            this.Ayuda.TabIndex = 12;
            this.Ayuda.Text = "Instructions(?)";
            // 
            // picture_amarillo
            // 
            this.picture_amarillo.Image = global::WindowsFormsApp1.Properties.Resources.amarillo;
            this.picture_amarillo.Location = new System.Drawing.Point(762, 107);
            this.picture_amarillo.Name = "picture_amarillo";
            this.picture_amarillo.Size = new System.Drawing.Size(234, 112);
            this.picture_amarillo.TabIndex = 6;
            this.picture_amarillo.TabStop = false;
            this.picture_amarillo.Visible = false;
            // 
            // picture_naranja
            // 
            this.picture_naranja.Image = global::WindowsFormsApp1.Properties.Resources.naranja;
            this.picture_naranja.Location = new System.Drawing.Point(864, 241);
            this.picture_naranja.Name = "picture_naranja";
            this.picture_naranja.Size = new System.Drawing.Size(234, 112);
            this.picture_naranja.TabIndex = 7;
            this.picture_naranja.TabStop = false;
            this.picture_naranja.Visible = false;
            // 
            // picture_verde
            // 
            this.picture_verde.Image = global::WindowsFormsApp1.Properties.Resources.verde;
            this.picture_verde.Location = new System.Drawing.Point(763, 370);
            this.picture_verde.Name = "picture_verde";
            this.picture_verde.Size = new System.Drawing.Size(234, 112);
            this.picture_verde.TabIndex = 8;
            this.picture_verde.TabStop = false;
            this.picture_verde.Visible = false;
            // 
            // ayuda_colores
            // 
            this.ayuda_colores.Image = global::WindowsFormsApp1.Properties.Resources.ayuda;
            this.ayuda_colores.Location = new System.Drawing.Point(951, 479);
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
            this.titulo_tabla.Location = new System.Drawing.Point(309, 43);
            this.titulo_tabla.Name = "titulo_tabla";
            this.titulo_tabla.Size = new System.Drawing.Size(83, 33);
            this.titulo_tabla.TabIndex = 15;
            this.titulo_tabla.Text = "label1";
            this.titulo_tabla.Visible = false;
            // 
            // Funciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 564);
            this.Controls.Add(this.titulo_tabla);
            this.Controls.Add(this.Ayuda);
            this.Controls.Add(this.tabla_info);
            this.Controls.Add(this.boton_temporal);
            this.Controls.Add(this.textBox_temporal);
            this.Controls.Add(this.repartirOrdenes);
            this.Controls.Add(this.mostrarOrdenes);
            this.Controls.Add(this.mostrarAgentes);
            this.Controls.Add(this.label_opciones);
            this.Controls.Add(this.picture_amarillo);
            this.Controls.Add(this.picture_naranja);
            this.Controls.Add(this.picture_verde);
            this.Controls.Add(this.ayuda_colores);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Funciones";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_info)).EndInit();
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
        private System.Windows.Forms.Label mostrarOrdenes;
        private System.Windows.Forms.Label repartirOrdenes;
        private System.Windows.Forms.PictureBox picture_amarillo;
        private System.Windows.Forms.PictureBox picture_naranja;
        private System.Windows.Forms.PictureBox picture_verde;
        private System.Windows.Forms.Button boton_temporal;
        private System.Windows.Forms.TextBox textBox_temporal;
        private System.Windows.Forms.DataGridView tabla_info;
        private System.Windows.Forms.Label Ayuda;
        private System.Windows.Forms.PictureBox ayuda_colores;
        private System.Windows.Forms.Label titulo_tabla;
    }
}