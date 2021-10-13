
namespace Taller_02_POO
{
    partial class frm_bienvenida
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
            this.btn_venta = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_venta
            // 
            this.btn_venta.Location = new System.Drawing.Point(89, 186);
            this.btn_venta.Name = "btn_venta";
            this.btn_venta.Size = new System.Drawing.Size(94, 29);
            this.btn_venta.TabIndex = 0;
            this.btn_venta.Text = "Venta nueva";
            this.btn_venta.UseVisualStyleBackColor = true;
            // 
            // btn_inventario
            // 
            this.btn_inventario.Location = new System.Drawing.Point(254, 186);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(94, 29);
            this.btn_inventario.TabIndex = 1;
            this.btn_inventario.Text = "Consultar inventarios";
            this.btn_inventario.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(431, 185);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(94, 29);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir del sistema";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenido:";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(450, 32);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(0, 20);
            this.lb_nombre.TabIndex = 4;
            // 
            // frm_bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 320);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_inventario);
            this.Controls.Add(this.btn_venta);
            this.Name = "frm_bienvenida";
            this.Text = "menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_venta;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_nombre;
    }
}