using Ejercicio01.Entidades;

namespace Ejercicio01.Windows
{
    public partial class frmEquipo : Form
    {
        private Equipo equipo;
        public frmEquipo()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                equipo = new Equipo(txtEquipo.Text, (int)nudCantidad.Value);
                btnCrear.Enabled = false;
                btnAgregarJugador.Enabled = true;
                txtEquipo.Enabled = false;
                nudCantidad.Enabled = false;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            return valido;
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            frmJugadorAE frm = new frmJugadorAE() { Text = "Agregar Jugador" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Jugador? jugador = frm.GetJugador();//17;34 29/05/2024
            if (jugador is null) return;
            if (equipo is not null)
            {
                if (equipo + jugador)
                {
                    var r = new DataGridViewRow();
                    r.CreateCells(dgvDatos);
                    SetearFila(r, jugador);
                    AgregarFila(r);
                }
            }
        }

        private void SetearFila(DataGridViewRow r, Jugador jugador)
        {
            r.Cells[colJugador.Index].Value = jugador.MostrarDatos();
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);                       
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
