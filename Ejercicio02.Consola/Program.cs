using Ejercicio02.Datos;
using Ejercicio02.Entidades;
using MiDLL;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creacion de Competencia");
            short cantidadDeCompetidores = (short)ConsoleExtensions.ReadShort("Ingrese un numero de Competidores");
            short cantidadDeVueltas =(short) ConsoleExtensions.ReadShort("Ingrese un numero de vueltas");
            Competencia competencia = CraerCompetencia(cantidadDeCompetidores,cantidadDeVueltas);
            InscripcionCompetencia(competencia);
            MostarDatosDeLaCompetencia(competencia);
            ConsoleExtensions.EsperarPresionDeTecla();
        }

        private static void MostarDatosDeLaCompetencia(Competencia competencia)
        {
            Console.WriteLine(competencia.ToString());//ARREGLAR!! NO SE ESTA MOSTRANDO
        }

        private static void InscripcionCompetencia(Competencia competencia)
        {
            do
            {
                AutoF1 autoF1 = CrearCompetidor();
                if (competencia + autoF1)
                {
                    Console.WriteLine($"{autoF1.MostrarDatos()} contratado");
                }
                else
                {
                    Console.WriteLine("Auto existente o ya no hay cupo");
                }
            } while (competencia.GetCantidad()<competencia.GetCantidadCompetidores());
        }

        private static AutoF1 CrearCompetidor()
        {
            short numeroA = (short)ConsoleExtensions.ReadShort("Ingrese el numero de Auto");
            string escuderia = ConsoleExtensions.ReadString("Ingrese el nombre");
            return new AutoF1(numeroA, escuderia);
        }

        private static Competencia CraerCompetencia(short cantidadDeCompetidores, short cantidadDeVueltas)
        {
            return new Competencia(cantidadDeCompetidores,cantidadDeVueltas);
        }
    }
}
