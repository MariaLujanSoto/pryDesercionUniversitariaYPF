namespace prySotoPOO
{
    partial class frmMain
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
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.txtDestreza = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Creador = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.Creador.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(132, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtFuerza
            // 
            this.txtFuerza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuerza.Location = new System.Drawing.Point(132, 61);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(49, 20);
            this.txtFuerza.TabIndex = 1;
            // 
            // txtDestreza
            // 
            this.txtDestreza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestreza.Location = new System.Drawing.Point(132, 114);
            this.txtDestreza.Name = "txtDestreza";
            this.txtDestreza.Size = new System.Drawing.Size(49, 20);
            this.txtDestreza.TabIndex = 2;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(200, 221);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(108, 28);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destreza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fuerza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Datos creados ...";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Creador
            // 
            this.Creador.Controls.Add(this.label3);
            this.Creador.Controls.Add(this.label2);
            this.Creador.Controls.Add(this.label1);
            this.Creador.Controls.Add(this.txtDestreza);
            this.Creador.Controls.Add(this.txtFuerza);
            this.Creador.Controls.Add(this.txtNombre);
            this.Creador.Location = new System.Drawing.Point(45, 29);
            this.Creador.Name = "Creador";
            this.Creador.Size = new System.Drawing.Size(262, 166);
            this.Creador.TabIndex = 0;
            this.Creador.TabStop = false;
            this.Creador.Text = "Creador";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(69, 339);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(208, 84);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 539);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.Creador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCrear);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creacion de Personaje";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Creador.ResumeLayout(false);
            this.Creador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.TextBox txtDestreza;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Creador;
        private System.Windows.Forms.Label lblInfo;
    }
}

