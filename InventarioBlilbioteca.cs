using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerSgbSantiagoEchavarriaP
{
    class InventarioBlilbioteca
    {
        string[,] Libro = new string[100,4];
        bool[] CantidadLibro = new bool[100];
        string[] EstadoLibro = new string[100];
        int i,aux;
        string BuscaNombre, BuscaCodigo;
        public void VerificacionEstadoCodigo()
        {
            for (i = 0; i < 100; i++)
            {
                if (Libro[i, 0] == BuscaNombre)
                {
                    i = aux;
                }
            }
            if (EstadoLibro[aux] == "Disponible")
            {
                Console.WriteLine("El libro esta Disponible");
            }
            else if (EstadoLibro[aux] == " ")
            {
                Console.WriteLine("Libro No Disponible");
            }
        }
        public void VerificacionEstadoNombre()
        {
            for(i=0;i<100;i++)
            {
                if(Libro[i,1]==BuscaCodigo)
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
