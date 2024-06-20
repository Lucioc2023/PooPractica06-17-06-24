using Ejercicio02.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio02.Datos
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores = null!;

        private Competencia()
        {
            competidores=new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidoresA, short cantidadVueltasA) : this()
        {
            if (cantidadCompetidoresA ==0)
            {
                cantidadCompetidoresA = 3;
                cantidadVueltas = cantidadVueltasA;
            }
            else
            {
                cantidadCompetidores = cantidadCompetidoresA;
                cantidadVueltas = cantidadVueltasA;
            }
                          
        }
        public short GetCantidadCompetidores()
        {
            return cantidadCompetidores;
        }
        public short GetCantidadVueltas()
        {
            return cantidadVueltas;
        }
        public short SetCantidadCompetidores(short cantidad)
        {
           cantidadCompetidores = cantidad;
            return cantidadCompetidores;
        }
        //public short CantidadCompetidores { get; set; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        public List<AutoF1> Competidores { get => competidores; set => competidores = value; }
        
        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c is null || a is null) return false;
            if (c.competidores.Count == c.GetCantidadCompetidores()) return false;
            if (c!=a)
            {
                c.competidores.Add(a);//Agrega un nuevo AutoF1 a las lista comtetidores
                return true;
            }
            return false;
            
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            if (c is null || a is null) return false;// si no traen nada se va
            if (c.Competidores is null) return false;// si no esta la lista instanciada se va 
            if (c.GetCantidadCompetidores() == 0) return false;// si no tiene jugadores se va
            if (c.competidores.Contains(a)) //Contains se va a fijar en la en "c"(Competencia)
                                            // si el competidor "a" existe
            {
                return true;// si existe es verdadero
            }
            else
            {
                return false;// si no es falso
            }            
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c==a);
        }

        public override bool Equals(object obj)
        {
            if (obj is null || !(obj is Competencia competencia)) return false;
            if (GetCantidadCompetidores() != competencia.GetCantidadCompetidores()) return false;
            if (GetCantidadVueltas()!= competencia.GetCantidadVueltas()) return false;
            // Por el si son iguales -TIENE LA MISMA CANTIDAD DE COMPETIDORES
            return (GetCantidadCompetidores() == competencia.GetCantidadCompetidores() &&
                GetCantidadVueltas() == competencia.GetCantidadVueltas() &&//CANTIDAD DE VUELTAS
                competidores.SequenceEqual(competencia.competidores));//E IGUALES ELEMENTOS EN LA LISTA
            
        }
        //        VER CODIGO GET HASH CODE
        // DEBE TENER LOS MISMOS ELEMENTOS QUE EL EQUALS
        // NO SE COMO SE PONEN CUANDO TIENEN METODOS
        //      - GetCantidadCompetidores()
        //      - GetCantidadVueltas()
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;                
                if (competidores is not null)
                {
                    foreach (var autof1 in competidores)
                    {
                        hash += 23 * autof1.GetHashCode();// llamo a j.GetHashCode
                                                     // de jugador que escribi antes
                    }
                }
                return hash;
            }
        }
        public int GetCantidad() => competidores.Count;
    }
}
