
using Ejercicio01.Entidades;

namespace Ejercicio01.Windows
{

    public partial class frmJugadorAE : Form
    {
        private Jugador jugador;
        public frmJugadorAE()
        {
            InitializeComponent();
        }

        public Jugador GetJugador()
        {
            return jugador;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int dni = int.Parse(txtDni.Text);//convierto a entero
                jugador = new Jugador(dni,txtNombreJugador.Text);//paso los datos
                DialogResult=DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            return true;
        }
    }
}
