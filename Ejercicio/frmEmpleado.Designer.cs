
namespace Ejercicio
{
    partial class frmEmpleado
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
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelCasado = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.cboCasado = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.Location = new System.Drawing.Point(116, 83);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(110, 15);
            this.labelNombreCompleto.TabIndex = 0;
            this.labelNombreCompleto.Text = "Nombre Completo:";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(116, 127);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(30, 15);
            this.labelDNI.TabIndex = 1;
            this.labelDNI.Text = "DNI:";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(116, 172);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(36, 15);
            this.labelEdad.TabIndex = 2;
            this.labelEdad.Text = "Edad:";
            // 
            // labelCasado
            // 
            this.labelCasado.AutoSize = true;
            this.labelCasado.Location = new System.Drawing.Point(116, 217);
            this.labelCasado.Name = "labelCasado";
            this.labelCasado.Size = new System.Drawing.Size(49, 15);
            this.labelCasado.TabIndex = 3;
            this.labelCasado.Text = "Casado:";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(116, 262);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(45, 15);
            this.labelSalario.TabIndex = 4;
            this.labelSalario.Text = "Salario:";
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(243, 82);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(100, 23);
            this.textNombreCompleto.TabIndex = 5;
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(243, 124);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(100, 23);
            this.textDNI.TabIndex = 6;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(243, 164);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(100, 23);
            this.textEdad.TabIndex = 7;
            // 
            // textSalario
            // 
            this.textSalario.Location = new System.Drawing.Point(243, 254);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(100, 23);
            this.textSalario.TabIndex = 9;
            // 
            // cboCasado
            // 
            this.cboCasado.FormattingEnabled = true;
            this.cboCasado.Location = new System.Drawing.Point(243, 209);
            this.cboCasado.Name = "cboCasado";
            this.cboCasado.Size = new System.Drawing.Size(100, 23);
            this.cboCasado.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(135, 310);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(253, 310);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 411);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboCasado);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.textNombreCompleto);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.labelCasado);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelNombreCompleto);
            this.Name = "frmEmpleado";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelCasado;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.ComboBox cboCasado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}