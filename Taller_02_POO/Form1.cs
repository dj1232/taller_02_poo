using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Taller_02_POO
{
    public partial class frm_ingreso : Form
    {
        public frm_ingreso()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            bool test;
            Usuario ingreso = new Usuario();
            frm_bienvenida form_b = new frm_bienvenida();
            ingreso.Perfil = txt_usuario.Text;
            ingreso.Contra = txt_contra.Text;
            string contra_encrip = Encriptar.GetSHA256(ingreso.Contra);
            //string Contra = contra_encrip;
            test = ingreso.validar(ingreso.Perfil, contra_encrip);
            if (test)
            {
                MessageBox.Show("Bienvenido");
                form_b.nombre(ingreso.Perfil);
                form_b.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña invalidos");
                txt_usuario.Clear();
                txt_contra.Clear();                        
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
