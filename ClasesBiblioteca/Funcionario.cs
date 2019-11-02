using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{
    public class Funcionario: Persona
    {
        public DateTime fechaInicio { get; set; }
        public Cargo cargo { get; set; }


        public string ObtenerDatosFuncionario()
        {
            return $"{NombreApellido} con documneto nro {Documento} domiciliado en {Direccion} con nro de telefono:{Telefono}, inicio sus actividades en fecha {fechaInicio}";
        }
    }
}
