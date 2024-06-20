using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio02.Entidades
{
    public class AutoF1
    {
        private short numero;
        private string escuderia = null!;
        private bool enCompetencia;
        private short cantidadDeCombustible;
        private short vueltasRestantes;

        public AutoF1(short numeroA, string escuderiaA) : this(numeroA, escuderiaA,false,0,0 )
        { }
        public AutoF1(short numeroA, string escuderiaA, bool enCompetenciaA, short cantidadDeCombustibleA, short vueltasRestantesA)
        {
            numero = numeroA;
            escuderia = escuderiaA;
            enCompetencia = enCompetenciaA;
            cantidadDeCombustible = cantidadDeCombustibleA;
            vueltasRestantes = vueltasRestantesA;
        }
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2) 
        {
            if (auto1 is null || auto2 is null)
            {
                return false;
            }
            if (auto1.numero == auto2.numero && auto1.escuderia == auto2.escuderia)
            {
                return auto1 == auto2;
            }
            else
            {
                return false;
            }            
        }
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2) 
        {
            return !(auto1 == auto2);
        }

        
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public short CantidadDeCombustible { get => cantidadDeCombustible; set => cantidadDeCombustible = value; }
        public short VueltasRestantes { get => vueltasRestantes; set => vueltasRestantes = value; }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is AutoF1 autoF1))
            {
                return false;
            }
            else
            {
                return this==autoF1;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int has = 17;
                return has += 23 * numero.GetHashCode();
            }
        }

        public string MostrarDatos()
        {
            return $"N°: {numero} - Escuderia: {escuderia} - en Competencia: {enCompetencia} - Cantidad De Combustible: {cantidadDeCombustible} - Vueltas Restantes: {vueltasRestantes}";
        }
    }
}

        



