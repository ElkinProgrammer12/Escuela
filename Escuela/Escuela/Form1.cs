using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();
        Profesor profesor = new Profesor();
        Estudiante estudiante = new Estudiante();
        CultureInfo formato = new CultureInfo("es-CO");

        public Form1()
        {
            InitializeComponent();
        }

        public void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (radProfesor.Checked)
                {
                    profesor.Nombre = txtNombre.Text;
                    profesor.Sueldo = Convert.ToDouble(txtSueldo.Text);
                    MessageBox.Show("Registro existoso del profesor");

                }
                if (radEstudiante.Checked)
                {
                    estudiante.Nombre = txtNombre.Text;
                    estudiante.Calificacion = Convert.ToInt32(txtCalificacion.Text);
                    MessageBox.Show("Registro existoso del estudiante");
                }
            }
            catch
            {
                MessageBox.Show("No has colocado la información en las casillas");
            }
            
        }

        private void grbDatos_Enter(object sender, EventArgs e)
        {
            if (radProfesor.Checked)
            {
                txtCalificacion.Enabled = false;
                txtSueldo.Enabled = true;
            }
            else if (radEstudiante.Checked)
            {
                txtSueldo.Enabled = false;
                txtCalificacion.Enabled = true;
            }
        }

        private void btnMostrarDatos_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (radProfesor.Checked && profesor.Nombre != null && profesor.Sueldo != 0)
                {
                    MessageBox.Show("El profesor: " + profesor.Nombre + ", tiene un sueldo de: " + profesor.Sueldo.ToString("C", formato) + "\n" + profesor.Asistir() + "\n" + profesor.Enseñar());
                }
                else if (radEstudiante.Checked && estudiante.Nombre != null && estudiante.Calificacion != 0)
                {
                    MessageBox.Show("El estudiante: " + estudiante.Nombre + ", tiene una calificacion de: " + estudiante.Calificacion + "\n" + estudiante.Asistir() + "\n" + estudiante.Estudiar());
                }
            }
            catch
            {
                MessageBox.Show("No has colocado la información en las casillas");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
