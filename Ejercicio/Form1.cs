using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEmpleado ventanaEmpleado = new frmEmpleado();
            ventanaEmpleado.ShowDialog();
            cargar();
        }
        private void cargar()
        {
            EmpleadoConexion conexion = new EmpleadoConexion();
            dgvEmpleados.DataSource = conexion.listarEmpleados();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmEmpleado ventanaEmpleado = new frmEmpleado();
            ventanaEmpleado.ShowDialog();
            cargar();
        }
    }
}
