using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Fabrica
    {
        public string nombre;
        private List<Vehiculo> ListaDeAutos; // Instanciamos la lista

        public Fabrica (string nombre)
        {
            this.nombre = nombre;

            this.ListaDeAutos = new List<Vehiculo>(); // Agregamos la lista al constructor
        }
        public void Agregar (Vehiculo UnVehiculo)
        {
            this.ListaDeAutos.Add(UnVehiculo);        
        }
        
        public void Mostrar()
        {
            foreach (Vehiculo item in ListaDeAutos)
	        {
                Console.WriteLine(item.año);
	        }
        }
        
    }
}
