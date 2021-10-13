using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_02_POO
{
    class Usuario
    {
        protected string perfil;

        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        protected string contra;

        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }
        public string [] usuario_base = new string[3];
        public string [] contra_base = new string[3];
        
        public bool validar(string usuario, string Contra)
        {
            bool test = true;
            usuario_base[0] = "admin";
            contra_base[0] = Encriptar.GetSHA256("admin123");
            usuario_base[1] = "vendedor";
            contra_base[1] =  Encriptar.GetSHA256("Vendedor123");
            usuario_base[2] = "Invitado";
            contra_base[2] =  Encriptar.GetSHA256("invitadoinvitado123");

            for(int i = 0; i < 3; i++)
            {
                if(usuario == usuario_base[i] && Contra == contra_base[i])
                {
                    test = true;
                    break;
                    
                }
                else
                {
                    test = false;
                    
                }
            }
            return test;
            
        }
        
    }
}
