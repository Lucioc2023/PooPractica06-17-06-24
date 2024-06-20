namespace Ejercicio01.Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre=null!;
        private int partidosJugados;
        private double promedioGoles;
        private int totalGoles;

        public Jugador(int dniJ, string nombreJ,
            int partidosJugadosJ, int totalGolesJ)
        {
            dni = dniJ;
            nombre=nombreJ;
            partidosJugados = partidosJugadosJ;
            totalGoles=totalGolesJ;
        }
        public Jugador(int dniJ, string nombreJ) : this(dniJ,nombreJ,20,0)
        { 
        }
        public double GetPromedioGoles()
        {
            promedioGoles = totalGoles / partidosJugados;
            return promedioGoles;
        }
        public string MostrarDatos()
        {
            return $" DNI N°: {dni} - {nombre} -  Jugó {partidosJugados} partidos - Goles: {totalGoles} -  Promedio Gol: {GetPromedioGoles()}";
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1 is null || j2 is null)
            {
                return false;
            }
            return j1.dni==j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1==j2);
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Jugador jugador))
            {
                return false;
            }
            else
            {
                return this == jugador;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int has = 17;
                return has+=23*dni.GetHashCode();
            }
        }
    }
}
