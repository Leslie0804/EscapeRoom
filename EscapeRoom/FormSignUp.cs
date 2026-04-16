namespace EscapeRoom
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(txtEnterName.Text))
            {
                MessageBox.Show("Por favor ingresa tu nombre antes de comenzar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GameState.Instance.NombreJugador = txtEnterName.Text.Trim();
            FormGame frm = new FormGame();
            this.Hide();
            frm.ShowDialog();
            this.Close();

            if (System.IO.File.Exists("estadisticas.txt"))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("estadisticas.txt") { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("Aún no hay estadísticas registradas.", "Estadísticas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
