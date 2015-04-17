namespace AppComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRojo = new System.Windows.Forms.Label();
            this.lblRosa = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.bbtColor = new System.Windows.Forms.Button();
            this.cmbRojo = new System.Windows.Forms.ComboBox();
            this.cmbRosa = new System.Windows.Forms.ComboBox();
            this.cmbAzul = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.Location = new System.Drawing.Point(35, 16);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(29, 13);
            this.lblRojo.TabIndex = 0;
            this.lblRojo.Text = "Rojo";
            // 
            // lblRosa
            // 
            this.lblRosa.AutoSize = true;
            this.lblRosa.Location = new System.Drawing.Point(32, 71);
            this.lblRosa.Name = "lblRosa";
            this.lblRosa.Size = new System.Drawing.Size(32, 13);
            this.lblRosa.TabIndex = 1;
            this.lblRosa.Text = "Rosa";
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(32, 117);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(27, 13);
            this.lblAzul.TabIndex = 2;
            this.lblAzul.Text = "Azul";
            // 
            // bbtColor
            // 
            this.bbtColor.Location = new System.Drawing.Point(81, 186);
            this.bbtColor.Name = "bbtColor";
            this.bbtColor.Size = new System.Drawing.Size(136, 23);
            this.bbtColor.TabIndex = 6;
            this.bbtColor.Text = "Colorear Fondo";
            this.bbtColor.UseVisualStyleBackColor = true;
            this.bbtColor.Click += new System.EventHandler(this.bbtColor_Click);
            // 
            // cmbRojo
            // 
            this.cmbRojo.FormattingEnabled = true;
            this.cmbRojo.Location = new System.Drawing.Point(96, 13);
            this.cmbRojo.Name = "cmbRojo";
            this.cmbRojo.Size = new System.Drawing.Size(121, 21);
            this.cmbRojo.TabIndex = 7;
            // 
            // cmbRosa
            // 
            this.cmbRosa.FormattingEnabled = true;
            this.cmbRosa.Location = new System.Drawing.Point(96, 68);
            this.cmbRosa.Name = "cmbRosa";
            this.cmbRosa.Size = new System.Drawing.Size(121, 21);
            this.cmbRosa.TabIndex = 8;
            // 
            // cmbAzul
            // 
            this.cmbAzul.FormattingEnabled = true;
            this.cmbAzul.Location = new System.Drawing.Point(96, 114);
            this.cmbAzul.Name = "cmbAzul";
            this.cmbAzul.Size = new System.Drawing.Size(121, 21);
            this.cmbAzul.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmbAzul);
            this.Controls.Add(this.cmbRosa);
            this.Controls.Add(this.cmbRojo);
            this.Controls.Add(this.bbtColor);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.lblRosa);
            this.Controls.Add(this.lblRojo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.Label lblRosa;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.Button bbtColor;
        private System.Windows.Forms.ComboBox cmbRojo;
        private System.Windows.Forms.ComboBox cmbRosa;
        private System.Windows.Forms.ComboBox cmbAzul;
    }
}

