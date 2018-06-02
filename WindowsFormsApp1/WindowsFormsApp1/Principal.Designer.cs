namespace WindowsFormsApp1
{
    partial class Principal
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
            this.Titulo_GE = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_temporal = new System.Windows.Forms.TextBox();
            this.boton_temporal = new System.Windows.Forms.Button();
            this.label_iniciar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture_rojo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rojo)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo_GE
            // 
            this.Titulo_GE.AutoSize = true;
            this.Titulo_GE.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_GE.Location = new System.Drawing.Point(250, 33);
            this.Titulo_GE.Name = "Titulo_GE";
            this.Titulo_GE.Size = new System.Drawing.Size(322, 61);
            this.Titulo_GE.TabIndex = 0;
            this.Titulo_GE.Text = "General Electric ";
            this.Titulo_GE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Distribution System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please follow all the instructions";
            // 
            // textBox_temporal
            // 
            this.textBox_temporal.Location = new System.Drawing.Point(310, 248);
            this.textBox_temporal.Name = "textBox_temporal";
            this.textBox_temporal.Size = new System.Drawing.Size(185, 20);
            this.textBox_temporal.TabIndex = 5;
            // 
            // boton_temporal
            // 
            this.boton_temporal.Location = new System.Drawing.Point(509, 246);
            this.boton_temporal.Name = "boton_temporal";
            this.boton_temporal.Size = new System.Drawing.Size(99, 21);
            this.boton_temporal.TabIndex = 6;
            this.boton_temporal.Text = "Accept";
            this.boton_temporal.UseVisualStyleBackColor = true;
            this.boton_temporal.Click += new System.EventHandler(this.boton_temporal_Click);
            // 
            // label_iniciar
            // 
            this.label_iniciar.AutoSize = true;
            this.label_iniciar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_iniciar.Location = new System.Drawing.Point(366, 327);
            this.label_iniciar.Name = "label_iniciar";
            this.label_iniciar.Size = new System.Drawing.Size(56, 23);
            this.label_iniciar.TabIndex = 4;
            this.label_iniciar.Text = "Start";
            this.label_iniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.audio_icon3;
            this.pictureBox1.Location = new System.Drawing.Point(356, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 26);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // picture_rojo
            // 
            this.picture_rojo.Image = global::WindowsFormsApp1.Properties.Resources.rojo1;
            this.picture_rojo.Location = new System.Drawing.Point(328, 274);
            this.picture_rojo.Name = "picture_rojo";
            this.picture_rojo.Size = new System.Drawing.Size(145, 132);
            this.picture_rojo.TabIndex = 7;
            this.picture_rojo.TabStop = false;
            this.picture_rojo.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(839, 426);
            this.Controls.Add(this.boton_temporal);
            this.Controls.Add(this.textBox_temporal);
            this.Controls.Add(this.label_iniciar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titulo_GE);
            this.Controls.Add(this.picture_rojo);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "General Electric";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rojo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo_GE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_iniciar;
        private System.Windows.Forms.TextBox textBox_temporal;
        private System.Windows.Forms.Button boton_temporal;
        private System.Windows.Forms.PictureBox picture_rojo;
    }
}

