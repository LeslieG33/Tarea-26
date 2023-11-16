namespace Tarea_26
{
    partial class frmTarea26
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
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdSalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(18, 38);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(161, 20);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Introduce un número:";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(185, 34);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 24);
            this.txtN.TabIndex = 1;
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcular.Location = new System.Drawing.Point(39, 105);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(83, 28);
            this.cmdCalcular.TabIndex = 2;
            this.cmdCalcular.Text = "&Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(150, 105);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(83, 28);
            this.cmdLimpiar.TabIndex = 3;
            this.cmdLimpiar.Text = "&Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdSalida
            // 
            this.cmdSalida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalida.Location = new System.Drawing.Point(259, 105);
            this.cmdSalida.Name = "cmdSalida";
            this.cmdSalida.Size = new System.Drawing.Size(83, 28);
            this.cmdSalida.TabIndex = 4;
            this.cmdSalida.Text = "&Salida";
            this.cmdSalida.UseVisualStyleBackColor = true;
            this.cmdSalida.Click += new System.EventHandler(this.cmdSalida_Click);
            // 
            // frmTarea26
            // 
            this.AcceptButton = this.cmdCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CancelButton = this.cmdSalida;
            this.ClientSize = new System.Drawing.Size(369, 160);
            this.Controls.Add(this.cmdSalida);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.Name = "frmTarea26";
            this.Text = "Factorial de un número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdSalida;
    }
}

