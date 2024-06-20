using Ejercicio02.Entidades;

namespace Ejercicio02.Windows
{
    public partial class frmAutoF1AE : Form
    {
        private AutoF1? autoF1;
        public frmAutoF1AE()
        {
            InitializeComponent();
        }

        public AutoF1? GetAutoF1()
        {
            return autoF1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                autoF1 = new AutoF1((short)nudNumeroAutoF1.Value, txtEscuderia.Text);
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            if (nudNumeroAutoF1.Value <= 0)
            {
                errorProvider1.SetError(nudNumeroAutoF1, "La numeracion debe ser mayor que cero.");
                return false;                
            }

            if (string.IsNullOrEmpty(txtEscuderia.Text))
            {
                errorProvider1.SetError(txtEscuderia, "El campo de escudería es obligatorio");
                return false;                
            }

            return true;
        }
    }
}
