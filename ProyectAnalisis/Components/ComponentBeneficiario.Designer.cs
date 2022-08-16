namespace ProyectAnalisis.Components
{
    partial class ComponentBeneficiario
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
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lbDNI = new System.Windows.Forms.MaskedTextBox();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(102)))));
            this.bunifuCards1.Controls.Add(this.lbDNI);
            this.bunifuCards1.Controls.Add(this.lbCorreo);
            this.bunifuCards1.Controls.Add(this.lbNumero);
            this.bunifuCards1.Controls.Add(this.lbNombre);
            this.bunifuCards1.Controls.Add(this.label29);
            this.bunifuCards1.Controls.Add(this.label30);
            this.bunifuCards1.Controls.Add(this.label31);
            this.bunifuCards1.Controls.Add(this.label32);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1230, 150);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbCorreo.Location = new System.Drawing.Point(775, 83);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(190, 27);
            this.lbCorreo.TabIndex = 16;
            this.lbCorreo.Text = "Juanmg@gmail.com";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNumero.Location = new System.Drawing.Point(775, 46);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(92, 27);
            this.lbNumero.TabIndex = 15;
            this.lbNumero.Text = "98784531";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNombre.Location = new System.Drawing.Point(210, 46);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(193, 27);
            this.lbNombre.TabIndex = 13;
            this.lbNombre.Text = "Juan Manuel Galvez";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(586, 83);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(183, 27);
            this.label29.TabIndex = 12;
            this.label29.Text = "Correo electronico:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(582, 46);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(187, 27);
            this.label30.TabIndex = 11;
            this.label30.Text = "Numero telefonico:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(22, 83);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(58, 27);
            this.label31.TabIndex = 10;
            this.label31.Text = "DNI:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(22, 46);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(182, 27);
            this.label32.TabIndex = 9;
            this.label32.Text = "Nombre completo:";
            // 
            // lbDNI
            // 
            this.lbDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbDNI.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDNI.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbDNI.Location = new System.Drawing.Point(100, 83);
            this.lbDNI.Mask = "####-####-#####";
            this.lbDNI.Name = "lbDNI";
            this.lbDNI.Size = new System.Drawing.Size(205, 27);
            this.lbDNI.TabIndex = 17;
            // 
            // ComponentBeneficiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bunifuCards1);
            this.MaximumSize = new System.Drawing.Size(1700, 150);
            this.MinimumSize = new System.Drawing.Size(1230, 150);
            this.Name = "ComponentBeneficiario";
            this.Size = new System.Drawing.Size(1230, 150);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.MaskedTextBox lbDNI;
    }
}
