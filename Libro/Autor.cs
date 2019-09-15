using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{
    public class Autor:Persona
    {
        public string GeneroLiterario { get; set; }

        public string ObtenerDatosAutor()
        {
            return $"{NombreApellido} con documneto nro {Documento} domiciliado en {Direccion} con nro de telefono:{Telefono}, especializado en el genero {GeneroLiterario}";
        }
    }
}
