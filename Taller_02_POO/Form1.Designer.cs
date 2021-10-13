
namespace Taller_02_POO
{
    partial class frm_ingreso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al sistema de ventas Don Diego\r\n         Favor ingresar credenciales\r\n" +
    "\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:\r\n";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(71, 220);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(94, 29);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(325, 220);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(94, 29);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(148, 81);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(218, 27);
            this.txt_usuario.TabIndex = 5;
            // 
            // txt_contra
            // 
            this.txt_contra.Location = new System.Drawing.Point(147, 154);
            this.txt_contra.Name = "txt_contra";
            this.txt_contra.PasswordChar = '*';
            this.txt_contra.Size = new System.Drawing.Size(219, 27);
            this.txt_contra.TabIndex = 6;
            // 
            // frm_ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 269);
            this.Controls.Add(this.txt_contra);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_ingreso";
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contra;
    }
}

