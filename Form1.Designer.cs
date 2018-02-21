namespace Practica_2_2_Evaluacion
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.boton_inteligente = new System.Windows.Forms.Button();
            this.boton_preferencia = new System.Windows.Forms.Button();
            this.boton_normal = new System.Windows.Forms.Button();
            this.boton_averia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.semaforo3 = new System.Windows.Forms.PictureBox();
            this.semaforo4 = new System.Windows.Forms.PictureBox();
            this.semaforo1 = new System.Windows.Forms.PictureBox();
            this.semafaro2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.semafaro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.splitContainer1.Panel1.Controls.Add(this.boton_inteligente);
            this.splitContainer1.Panel1.Controls.Add(this.boton_preferencia);
            this.splitContainer1.Panel1.Controls.Add(this.boton_normal);
            this.splitContainer1.Panel1.Controls.Add(this.boton_averia);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.semaforo3);
            this.splitContainer1.Panel2.Controls.Add(this.semaforo4);
            this.splitContainer1.Panel2.Controls.Add(this.semaforo1);
            this.splitContainer1.Panel2.Controls.Add(this.semafaro2);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(833, 403);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 0;
            // 
            // boton_inteligente
            // 
            this.boton_inteligente.BackColor = System.Drawing.Color.RosyBrown;
            this.boton_inteligente.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_inteligente.ForeColor = System.Drawing.Color.Aquamarine;
            this.boton_inteligente.Location = new System.Drawing.Point(101, 333);
            this.boton_inteligente.Name = "boton_inteligente";
            this.boton_inteligente.Size = new System.Drawing.Size(77, 35);
            this.boton_inteligente.TabIndex = 3;
            this.boton_inteligente.Text = "Modo Inteligente";
            this.boton_inteligente.UseVisualStyleBackColor = false;
            this.boton_inteligente.Click += new System.EventHandler(this.boton_inteligente_Click);
            // 
            // boton_preferencia
            // 
            this.boton_preferencia.BackColor = System.Drawing.Color.RosyBrown;
            this.boton_preferencia.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_preferencia.ForeColor = System.Drawing.Color.Aquamarine;
            this.boton_preferencia.Location = new System.Drawing.Point(101, 253);
            this.boton_preferencia.Name = "boton_preferencia";
            this.boton_preferencia.Size = new System.Drawing.Size(77, 35);
            this.boton_preferencia.TabIndex = 2;
            this.boton_preferencia.Text = "Modo Preferencia";
            this.boton_preferencia.UseVisualStyleBackColor = false;
            this.boton_preferencia.Click += new System.EventHandler(this.boton_preferencia_Click);
            // 
            // boton_normal
            // 
            this.boton_normal.BackColor = System.Drawing.Color.RosyBrown;
            this.boton_normal.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_normal.ForeColor = System.Drawing.Color.Aquamarine;
            this.boton_normal.Location = new System.Drawing.Point(101, 174);
            this.boton_normal.Name = "boton_normal";
            this.boton_normal.Size = new System.Drawing.Size(77, 35);
            this.boton_normal.TabIndex = 1;
            this.boton_normal.Text = "Modo Normal";
            this.boton_normal.UseVisualStyleBackColor = false;
            this.boton_normal.Click += new System.EventHandler(this.boton_normal_Click);
            // 
            // boton_averia
            // 
            this.boton_averia.BackColor = System.Drawing.Color.RosyBrown;
            this.boton_averia.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_averia.ForeColor = System.Drawing.Color.Aquamarine;
            this.boton_averia.Location = new System.Drawing.Point(101, 92);
            this.boton_averia.Name = "boton_averia";
            this.boton_averia.Size = new System.Drawing.Size(77, 35);
            this.boton_averia.TabIndex = 0;
            this.boton_averia.Text = "Avería";
            this.boton_averia.UseVisualStyleBackColor = false;
            this.boton_averia.Click += new System.EventHandler(this.boton_averia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(81, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPCIONES";
            // 
            // semaforo3
            // 
            this.semaforo3.Image = global::Practica_2_2_Evaluacion.Properties.Resources.semaforo_ambar;
            this.semaforo3.Location = new System.Drawing.Point(12, 54);
            this.semaforo3.Name = "semaforo3";
            this.semaforo3.Size = new System.Drawing.Size(51, 73);
            this.semaforo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.semaforo3.TabIndex = 4;
            this.semaforo3.TabStop = false;
            // 
            // semaforo4
            // 
            this.semaforo4.Image = global::Practica_2_2_Evaluacion.Properties.Resources.semaforo_ambar;
            this.semaforo4.Location = new System.Drawing.Point(376, 12);
            this.semaforo4.Name = "semaforo4";
            this.semaforo4.Size = new System.Drawing.Size(51, 73);
            this.semaforo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.semaforo4.TabIndex = 3;
            this.semaforo4.TabStop = false;
            // 
            // semaforo1
            // 
            this.semaforo1.Image = global::Practica_2_2_Evaluacion.Properties.Resources.semaforo_ambar;
            this.semaforo1.Location = new System.Drawing.Point(490, 278);
            this.semaforo1.Name = "semaforo1";
            this.semaforo1.Size = new System.Drawing.Size(51, 73);
            this.semaforo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.semaforo1.TabIndex = 2;
            this.semaforo1.TabStop = false;
            // 
            // semafaro2
            // 
            this.semafaro2.Image = global::Practica_2_2_Evaluacion.Properties.Resources.semaforo_ambar;
            this.semafaro2.Location = new System.Drawing.Point(130, 305);
            this.semafaro2.Name = "semafaro2";
            this.semafaro2.Size = new System.Drawing.Size(51, 73);
            this.semafaro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.semafaro2.TabIndex = 1;
            this.semafaro2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica_2_2_Evaluacion.Properties.Resources.cross_roads_signals;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 403);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Mapa de Carretera";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.semaforo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.semafaro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_inteligente;
        private System.Windows.Forms.Button boton_preferencia;
        private System.Windows.Forms.Button boton_normal;
        private System.Windows.Forms.Button boton_averia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox semafaro2;
        private System.Windows.Forms.PictureBox semaforo3;
        private System.Windows.Forms.PictureBox semaforo4;
        private System.Windows.Forms.PictureBox semaforo1;
    }
}

