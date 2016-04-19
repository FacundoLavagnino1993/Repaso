using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Vehiculo
    {
        public Persona Dueño;
        private Fabrica UnaAutomotriz;
        public string año;
        

        // Concepto de sobrecarga = para que dos metodos iguales funcionen tienen que tener distintos parametros,
        // en este caso los constructores varian de su tipo static para el private y de instancia que es el public.
        static Vehiculo()
        {
        
        }

        public  Vehiculo()
        {
            
        }

        public Vehiculo(Persona UnaPersona, Fabrica UnaFabrica, string año)
        {
            this.Dueño = UnaPersona;
            this.UnaAutomotriz = UnaFabrica;
            this.año = año;
        }

        public Vehiculo(string año)
        {
            this.año = año;    
        }
        
        public static implicit operator Vehiculo(string año) // Ver metodo implicito. Este metodo retorna una nueva instancia de vehiculo solo con el dato del año, por ese motivo los otros dos valores quedan en null.
        {                                                    // Ver ejercicio 7;
            return new Vehiculo(año);
        }

      


    }
}
