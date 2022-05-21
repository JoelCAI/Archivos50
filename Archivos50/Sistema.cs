using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos50
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();

            Console.Clear();
            /* Creo variable de tipo Archivo */
            TextWriter archivo;

            string ruta = "Holamundo.txt";

            /* La inicializo y la instancio. Digo que se va a llamar en la pc un archivo con este nombre "HolaMundo.txt" */
            archivo = new StreamWriter(ruta);

            string mensaje = Validador.ValidarStringNoVacio("\n Ingrese el texto que será guardado");

            archivo.WriteLine(mensaje);

            archivo.Close();

            string mensajeDos = Validador.ValidarStringNoVacio("\n Ingrese el nombre del archivo que quiere leer");

            Validador.ValidarPath(mensajeDos);

            Validador.Despedida();



        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}