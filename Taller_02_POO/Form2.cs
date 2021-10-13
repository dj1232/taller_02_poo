using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Taller_02_POO
{
    public partial class frm_bienvenida : Form
    {
        public frm_bienvenida()
        {
            InitializeComponent();       
        }
        public void nombre(string nombre)
        {
            Usuario ingreso = new Usuario();
            lb_nombre.Text = nombre;
        }
        
    }
}
