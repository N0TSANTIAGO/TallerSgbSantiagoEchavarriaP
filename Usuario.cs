using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbSantiagoEchavarriaP
{
    class Usuarios
    {
        string[] Usuario = new string[100];
        int i, aux,check;
        public void CrearUsuario()
        {
            Console.WriteLine("Creacion De Usuario");
            Console.WriteLine("ingresa Nombre");
            Usuario[aux] = Console.ReadLine();
            for(i=0;i<100;i++)
            {
                if (Usuario[aux] ==Usuario[i])
                {
                    check = 1;
                }
            }
            while(check==1)
            {
                Console.WriteLine("Usuario ya Creado");
                Console.WriteLine("Ingresa otro Nombre");
                Usuario[aux] = Console.ReadLine();
                for (i = 0; i < 100; i++)
                {
                    if (Usuario[aux] == Usuario[i])
                    {
                        check = 1;
                    }
                    else
                    {
                        check = 0;
                    }
                }
            }
           
        }
    }
}
