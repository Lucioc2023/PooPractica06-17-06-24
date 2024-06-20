using Ejercicio01.Entidades;
using MiDLL;

namespace Ejercicio01.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //48:54 min 27/05/2024 DLL
            Console.WriteLine("Creacion de Equipos");
            string nombreEquipo = ConsoleExtensions.ReadString("Ingrese el nombre del Equipo: ");
            int cantidadJugadores = ConsoleExtensions.ReadInt("Ingrese la cantidad de Jugadores");
            Equipo equipo = CrearEquipo(nombreEquipo,cantidadJugadores);
            ContratarJugadores(equipo);
            MostrarDatosDelEquipo(equipo);
            ConsoleExtensions.EsperarPresionDeTecla();
        }

        private static void MostrarDatosDelEquipo(Equipo equipo)
        {
            Console.WriteLine((string)equipo);
        }

        private static void ContratarJugadores(Equipo equipo)
        {
            do
            {
                Jugador jugador = CrearJugador();
                if (equipo+jugador)
                {
                    Console.WriteLine($"{jugador.MostrarDatos()} contratado");
                }
                else
                {
                    Console.WriteLine("Jugador existente o ya no hay cupo");
                }
            } while (equipo.GetCantidad()<equipo.GetCantidadJugadores());
        }

        private static Jugador CrearJugador()
        {
            var dni = ConsoleExtensions.ReadInt("Ingrese el DNI del Jugador: ");
            var nombre = ConsoleExtensions.ReadString("Ingrese el nombre de Jugador");
            return new Jugador(dni, nombre);
        }

        private static Equipo CrearEquipo(string nombreEquipo, int cantidadJugadores)
        {
            return new Equipo(nombreEquipo, cantidadJugadores);
        }
    }
}
