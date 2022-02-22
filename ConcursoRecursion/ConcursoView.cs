using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcursoRecursion
{
    public partial class ConcursoView : Form
    {
        private ConcursoModel _model;
        private int _tiempo;

        public ConcursoView()
        {
            InitializeComponent();
            _model = new ConcursoModel();
            _tiempo = 0;
        }

        private void ConcursoTimer_Tick(object sender, EventArgs e)
        {
            _tiempo--;
            TiempoTextBox.Text = _tiempo.ToString();
            if(_tiempo == 0)
            {
                ConcursoTimer.Stop();
                ConcursoTimer.Enabled = false;
                TiempoTextBox.BackColor = Color.Red;
            }
        }

        private void IniciarButton_Click(object sender, EventArgs e)
        {
            ConcursoTimer.Enabled = true;
            ConcursoTimer.Start();
            TiempoTextBox.BackColor = Color.LightGreen;
        }

        private void NuevoRetoButton_Click(object sender, EventArgs e)
        {
            Reto reto = _model.SiguienteReto();
            _tiempo = reto.Tiempo;
            if (reto != null)
            {
                RetoTextBox.Text = reto.Pregunta;
                TiempoTextBox.Text = reto.Tiempo.ToString();
            }
        }

        private void PausarButton_Click(object sender, EventArgs e)
        {
            ConcursoTimer.Stop();
            ConcursoTimer.Enabled = false;
            TiempoTextBox.BackColor = Color.Red;
        }
    }
}
