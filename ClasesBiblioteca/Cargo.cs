using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesBiblioteca
{
    public class Cargo
    {
        public string cargo { get; set; }

        public void ObtenerDatosCargo(){}

        public static List<Cargo> listaCargo = new List<Cargo>();

        public static void AgregarCargo(Cargo c)
        {
            listaCargo.Add(c);
        }

        public static void EditarCargo(Cargo c, int indice)
        {
            Cargo.listaCargo[indice] = c;

        }
        public static void EliminarCargo(Cargo cargo)
        {
            listaCargo.Remove(cargo);
        }

        public static List<Cargo> ObtenerCargo()
        {
            return listaCargo;
        }

        public override string ToString()
        {
            return this.cargo;
        }
    }
}
