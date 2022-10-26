using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio
{
    class EmpleadoConexion
    {
        public List<Empleado> listarEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "data source=.; initial catalog=EMPLEADOS_DB; integrated security=true";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from Empleados";
            comando.Connection = conexion;
            conexion.Open();

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Empleado aux = new Empleado();
                aux.Id = lector.GetInt32(0);
                aux.NombreCompleto = lector.GetString(1);
                aux.DNI = lector.GetString(2);
                aux.Edad = lector.GetInt32(3);
                aux.Casado = lector.GetBoolean(4);
                aux.Salario = lector.GetDecimal(5);

                lista.Add(aux);
            }

            conexion.Close();

            return lista;
        }

        internal void agregar(Empleado nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            conexion.ConnectionString = "data source=.; initial catalog=EMPLEADOS_DB; integrated security=true";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into EMPLEADOS values ('" + nuevo.NombreCompleto + "', '" + nuevo.DNI + "', @edad, '" + nuevo.Casado + "', @salario)";
            comando.Parameters.AddWithValue("@edad", nuevo.Edad);
            comando.Parameters.AddWithValue("@salario", nuevo.Salario);
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        internal void eliminar(Empleado nuevo)
        {
            
        }

        internal void modificar(Empleado nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            conexion.ConnectionString = "data source=.; initial catalog=EMPLEADOS_DB; integrated security=true";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "update EMPLEADOS set NombreCompleto = '" + nuevo.NombreCompleto + "', DNI = '" + nuevo.DNI + "', Edad = @edad, Casado = '" + nuevo.Casado + "', Salario = @salario";
            comando.Parameters.AddWithValue("@edad", nuevo.Edad);
            comando.Parameters.AddWithValue("@salario", nuevo.Salario);
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}