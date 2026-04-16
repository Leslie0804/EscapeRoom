using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoom
{
    public partial class FormIntroduction : Form
    {
        public FormIntroduction()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void lblIntroduction_Click(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {        
            //manda  a llamar el nombre del jugador y luego abre el formulario del escritorio
            GameState.Instance.NombreJugador = txtEnterName.Text.Trim();
            FormGame frm = new FormGame();
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }
    }
}
