using Ejercicio02.Datos;
using Ejercicio02.Entidades;

namespace Ejercicio02.Windows
{
    public partial class frmCompetencia : Form
    {
        private Competencia? competencia;
        public frmCompetencia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("¿Está seguro que desea salir?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                competencia = new Competencia((short)nudCantidadCompetidores.Value,
                                              (short)nudCantidadVueltas.Value);
                btnCrear.Enabled = false;
                btnAgregarAutoF1.Enabled = true;
                nudCantidadCompetidores.Enabled = false;
                nudCantidadVueltas.Enabled = false;
                btnAgregarAutoF1.BackColor = Color.Blue;
                btnAgregarAutoF1.ForeColor = Color.White;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();

            if (nudCantidadCompetidores.Value <= 0)
            {
                errorProvider1.SetError(nudCantidadCompetidores, "La cantidad de competidores debe ser mayor que cero.");
                return false;
            }

            if (nudCantidadVueltas.Value <= 0)
            {
                errorProvider1.SetError(nudCantidadVueltas, "La cantidad de vueltas debe ser mayor que cero.");
                return false;
            }

            return true;
           
        }

        private void btnAgregarAutoF1_Click(object sender, EventArgs e)
        {
            frmAutoF1AE frm = new frmAutoF1AE() { Text = "Agregar Auto F1" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            AutoF1? autoF1 = frm.GetAutoF1();
            if (autoF1 is null) return;
            if (competencia is  not null )
            {
                if (competencia + autoF1)
                {
                    var r = new DataGridViewRow();
                    r.CreateCells(dgvDatos);
                    SetearFila(r,autoF1);
                    AgregarFila(r);
                }
            }
        }

        private void SetearFila(DataGridViewRow r, AutoF1 autoF1)
        {
            r.Cells[colAutoF1.Index].Value = autoF1.MostrarDatos();
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }
    }
}
