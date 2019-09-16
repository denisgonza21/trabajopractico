using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{   //clase cliente
    public class Cliente : Persona
    {
        
        public DateTime FechaInscripcion { get; set;}

        public string ObtenerDatosCliente()
        {
            return $"{NombreApellido} con documneto nro {Documento} domiciliado en {Direccion} con nro de telefono:{Telefono}, inscripto en fecha {FechaInscripcion}";
        }

    }
}
