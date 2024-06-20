namespace Ejercicio01.Entidades
{
    public class Tenista
    {
        private int dni;
        private string nombre = null!;
        private int partidosJugados;
        private double promedioGoles;
        private int totalGoles;

        public Tenista(int dniT, string nombreT,
            int partidosJugadosT, int totalGolesT)
        {
            dni = dniT;
            nombre = nombreT;
            partidosJugados = partidosJugadosT;
            totalGoles = totalGolesT;
        }
        public Tenista(int dniT, string nombreT) : this(dniT, nombreT, 20, 0)
        { }
        public double GetPromedioGoles()
        {
            promedioGoles = totalGoles / partidosJugados;
            return promedioGoles;
        }
        public string MostrarDatos()
        {
            return $"{dni} - {nombre} - {partidosJugados} - {totalGoles} - {GetPromedioGoles()}";
        }
        public static bool operator ==(Tenista t1, Tenista t2)
        {
            if (t1 is null || t2 is null)
            {
                return false;
            }
            return t1.dni == t2.dni;
        }
        public static bool operator !=(Tenista t1, Tenista t2)
        {
            return !(t1==t2);
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Tenista tenista))
            {
                return false;
            }
            else
            {
                return this == tenista;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int has = 17;
                return has += 23 * dni.GetHashCode();
            }
        }
    }
}
