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

        public static List<Cliente> listaCliente = new List<Cliente>();

        public static void AgregarCliente(Cliente w)
        {
            listaCliente.Add(w);
        }

        public static void EditarCliente(Cliente w, int indice)
        {
            Cliente.listaCliente[indice] = w;

        }
        public static void EliminarCliente(Cliente cliente)
        {
            listaCliente.Remove(cliente);
        }

        public static List<Cliente> ObtenerCliente()
        {
            return listaCliente;
        }

        public override string ToString()
        {
            return this.NombreApellido;
        }

    }
}
