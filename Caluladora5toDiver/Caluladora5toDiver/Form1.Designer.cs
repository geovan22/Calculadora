namespace Caluladora5toDiver
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
            this.cmdResultado = new System.Windows.Forms.Button();
            this.cbxOperacion = new System.Windows.Forms.ComboBox();
            this.lblop = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.lblv1 = new System.Windows.Forms.Label();
            this.lblv2 = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdResultado
            // 
            this.cmdResultado.Location = new System.Drawing.Point(184, 259);
            this.cmdResultado.Name = "cmdResultado";
            this.cmdResultado.Size = new System.Drawing.Size(75, 23);
            this.cmdResultado.TabIndex = 0;
            this.cmdResultado.Text = "Resultado";
            this.cmdResultado.UseVisualStyleBackColor = true;
            this.cmdResultado.Click += new System.EventHandler(this.cmdResultado_Click);
            // 
            // cbxOperacion
            // 
            this.cbxOperacion.FormattingEnabled = true;
            this.cbxOperacion.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicación",
            "División"});
            this.cbxOperacion.Location = new System.Drawing.Point(207, 115);
            this.cbxOperacion.Name = "cbxOperacion";
            this.cbxOperacion.Size = new System.Drawing.Size(121, 21);
            this.cbxOperacion.TabIndex = 1;
            // 
            // lblop
            // 
            this.lblop.AutoSize = true;
            this.lblop.Location = new System.Drawing.Point(117, 122);
            this.lblop.Name = "lblop";
            this.lblop.Size = new System.Drawing.Size(56, 13);
            this.lblop.TabIndex = 2;
            this.lblop.Text = "Operacion";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.BackColor = System.Drawing.Color.Red;
            this.lblres.Font = new System.Drawing.Font("Pristina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblres.Location = new System.Drawing.Point(211, 162);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(48, 63);
            this.lblres.TabIndex = 3;
            this.lblres.Text = "0";
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.Location = new System.Drawing.Point(98, 30);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(40, 13);
            this.lblv1.TabIndex = 4;
            this.lblv1.Text = "Valor 1";
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.Location = new System.Drawing.Point(98, 73);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(40, 13);
            this.lblv2.TabIndex = 5;
            this.lblv2.Text = "Valor 2";
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(207, 23);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(100, 20);
            this.txtv1.TabIndex = 6;
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(207, 66);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(100, 20);
            this.txtv2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 294);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.lblv1);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lblop);
            this.Controls.Add(this.cbxOperacion);
            this.Controls.Add(this.cmdResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdResultado;
        private System.Windows.Forms.ComboBox cbxOperacion;
        private System.Windows.Forms.Label lblop;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Label lblv1;
        private System.Windows.Forms.Label lblv2;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
    }
}

