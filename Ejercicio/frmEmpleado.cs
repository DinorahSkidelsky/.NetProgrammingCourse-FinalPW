using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            cboCasado.Items.Add("Si");
            cboCasado.Items.Add("No");
        }

        private bool GetCasado(string casado)
        {
            if (casado == "Si")
                return true;
            return false;
        }

        private string CasadoBoolToString(bool casado)

        {
            if (casado)

            {
                return "Si";
            }

            return "No";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Empleado nuevo = new Empleado();
            EmpleadoConexion conexion = new EmpleadoConexion();

            nuevo.NombreCompleto = textNombreCompleto.Text;
            nuevo.DNI = textDNI.Text;
            nuevo.Edad = int.Parse(textEdad.Text);

            cboCasado.SelectedItem = CasadoBoolToString(nuevo.Casado);
            cboCasado.SelectedItem.ToString();

            nuevo.Salario = decimal.Parse(textSalario.Text);

            conexion.agregar(nuevo);
            conexion.modificar(nuevo);
            conexion.eliminar(nuevo);

            MessageBox.Show("Se agregó satisfactoriamente.");
            Close();
        }
    }
}
