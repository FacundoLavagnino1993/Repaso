using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona UnaPersona = new Persona("Jose");
            Fabrica UnaAutomotriz = new Fabrica("Ford");
            Vehiculo UnAuto = new Vehiculo(UnaPersona, UnaAutomotriz, "2016");

            
            

            Console.Write(UnaAutomotriz.nombre);
            Console.Write(UnAuto.Dueño.nombre);

/*
            Persona A = new Persona("a");
            Persona B = new Persona("b");
            B.nombre = "Jose";
            A.nombre = B.nombre;
            Persona C = new Persona("c");
            C = A;
            A.nombre = B.nombre;
            B.nombre = "Maria";
            Console.WriteLine(C.nombre);

            UnAuto = "2017";
*/
            Fabrica Fab = new Fabrica("Ford");
            Vehiculo Uno = new Vehiculo("2016");
            Vehiculo Dos = new Vehiculo("1990");

            Fab.Agregar(Uno);
            Fab.Agregar(Dos);
            Fab.Agregar(new Vehiculo("2000"));
            Uno.año = "1999";
            Fab.Mostrar();

            Vehiculo tres = new Vehiculo("1980");
            Uno = Dos;
            Dos.año = "1870";
            Uno = tres;
            tres.año = "1850";
            Uno.año = "1900";
            Fab.Mostrar();


        }
    }
}
