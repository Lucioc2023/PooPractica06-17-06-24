using System.Net;
using System.Text;

namespace Ejercicio01.Entidades
{
    public class Equipo
    {
        private int cantidadJugadores;
        private List<Jugador> jugadores= null!;
        private string nombre =null!;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string nombreE, int cantidad):this()
        {
            nombre = nombreE;
            cantidadJugadores= cantidad>0?cantidad:3;
            //si cantidad de jugadores es mayor que cero entonces que le pase cantidad
            // de lo contrario por defecto cantidad tendra 5 jugadores
        }
        public int GetCantidadJugadores()
        {
            return cantidadJugadores;
        }
        //22:18 clase 27-05-2024
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e is null || j is null)
            {
                return false;
            }
            if (e.jugadores.Count == e.GetCantidadJugadores())
            {
                return false;
            }
            if (e!=j)
            {
                e.jugadores?.Add(j);
                return true;
            }
            return false;
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            if (e is null || j is null)// si no traen nada se va 
            {
                return false;
            }
            if (e.jugadores is null)// si no esta la lista instanciada se va 
            {
                return false;
            }
            if (e.GetCantidadJugadores()== 0)// si no tiene jugadores se va
            {
                return false;
            }
            if (e.jugadores.Contains(j))//Contains se va a fijar en la en "e"(Equipo)
                                        // si el jugador "j" existe
            {
                return true;// si existe es verdadero
            }
            return false;// si no es falso
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e==j );
        }
        public static explicit operator string(Equipo e)//31:00 min
        {        
            StringBuilder sb= new StringBuilder();//Creo el StringBuilder sb
            sb.AppendLine($"El Equipo se llama: {e.nombre}");//pongo el nombre del Equipo
            sb.AppendLine($"(Jugadores): ");//pongo una linea que diga Jugadores
            string jugadoresEquipo= string.Empty;// creo una variable string.Empty(Empty = Vacia)
            if (e.jugadores !=null && e.jugadores.Any())// si la lista jugadores(Any devuelve un bool y me dice si tiene o no un elemento)
                                                        // no es nula y hay jugadores
            {
                jugadoresEquipo = string.Join(Environment.NewLine,//Join(Environment.NewLine
                                                          //pasa a la linea siguiente
                    e.jugadores.Select(j => j.MostrarDatos()));// seleciona de la lista
                                                               //Muestra los datos

            }
            else
            {
                jugadoresEquipo = "Sin Jugadores";
            }
            sb.AppendLine(jugadoresEquipo);
            return sb.ToString();
            
        }

        public override bool Equals(object obj)
        {
            if (obj is null|| !(obj is Equipo equipo))// si los objetos son distintos
            {
                return false;
            }
            if (GetCantidadJugadores()!= equipo.GetCantidadJugadores())//si cantidades son distintas
            {
                return false;
            }
            if (nombre != equipo.nombre)// si el nombre es distinto
            {
                return false;
            }
            return nombre == equipo.nombre &&
                GetCantidadJugadores()== equipo.GetCantidadJugadores() &&
                jugadores.SequenceEqual(equipo.jugadores);//SequenceEqual determina 
                                                         //comparando los elementos
                                                         //de acuerdo al criterio de
                                                         //comparacion que establecimos
        }

        public override int GetHashCode()//tengo que incluir todo lo que
                                         //inclui en el Equals
        {
            unchecked
            {
                int hash = 17;
                hash += 23 * nombre.GetHashCode();
                if (jugadores is not null)
                {
                    foreach (var j in jugadores)
                    {
                        hash += 23 * j.GetHashCode();// llamo a j.GetHashCode
                                                     // de jugador que escribi antes
                    } 
                }
                return hash;
            }
        }
        public int GetCantidad() => jugadores.Count;
    }
}
