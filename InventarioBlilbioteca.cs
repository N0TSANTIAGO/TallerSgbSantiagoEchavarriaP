using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbSantiagoEchavarriaP
{
    class InventarioBlilbioteca
    {
        string[,] Libro = new string[100,3];
        string[] EstadoLibro = new string[100];
        int i,aux;
        string BuscaNombre, ;
        public void VerificacionEstadoNombre()
        {
            for(i=0;i<100;i++)
            {
                if(Libro[i,0]== BuscaNombre)
                {
                    i = aux;
                }
            }
            if(EstadoLibro[aux]=="Disponible")
            {
                Console.WriteLine("El libro esta Disponible");
            }
            else if(EstadoLibro[aux]==" ")
            {
                Console.WriteLine("Libro No Disponible");
            }
        }
        public void Control_Inventario()
        {

        }

    }
}
