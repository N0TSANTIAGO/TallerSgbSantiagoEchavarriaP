using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbSantiagoEchavarriaP
{
    class Usuarios
    {
        string[] Usuario = new string[100 ];
        int i, aux;
        public void CrearUsuario()
        {
            Console.WriteLine("Creacion De Usuario");
            Console.WriteLine("ingresa Nombre");
            Usuario[aux] = Console.ReadLine();
        }
        public void ModificarUsusario()
        {

        }
    }
}
