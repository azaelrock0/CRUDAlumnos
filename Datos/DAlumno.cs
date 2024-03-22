using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;
using System.Configuration;

namespace Datos
{
    public class DAlumno
    {
        string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        public List<Alumno> Consultar()
        {
            SqlCommand comando;
            List<Alumno> listaAlumnos = new List<Alumno>();
            string query = "consultarAlumnos";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                comando = new SqlCommand(query, con);
                comando.Parameters.Add("@id",-1);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Alumno alumno = new Alumno();
                    alumno.id = Convert.ToInt32(reader["id"]);
                    alumno.nombre = reader["nombre"].ToString();
                    alumno.primerApellido = reader["primerApellido"].ToString();
                    alumno.segundoApellido = reader["segundoApellido"].ToString();
                    alumno.correo = reader["correo"].ToString();
                    alumno.telefono = reader["telefono"].ToString();
                    alumno.fechaNacimiento = DateTime.Parse(reader["fechaNacimiento"].ToString());
                    alumno.curp = reader["curp"].ToString();
                    if(reader["sueldo"].ToString() != "")
                    alumno.sueldo = decimal.Parse(reader["sueldo"].ToString());
                    alumno.idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"]);
                    alumno.idEstatus = Convert.ToInt32(reader["idEstatus"]);
                    listaAlumnos.Add(alumno);
                }
                con.Close();
            }
            return listaAlumnos;
        }
        public Alumno Consultar(int id)
        {
            SqlCommand comando;
            Alumno alu = new Alumno();
            string query = $"consultarAlumnos";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                comando = new SqlCommand(query, con);
                comando.Parameters.Add("@id", id);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                var hola = reader.Read();
                alu.id = Convert.ToInt32(reader["id"]);
                alu.nombre = reader["nombre"].ToString();
                alu.primerApellido = reader["primerApellido"].ToString();
                alu.segundoApellido = reader["segundoApellido"].ToString();
                alu.correo = reader["correo"].ToString();
                alu.telefono = reader["telefono"].ToString();
                alu.fechaNacimiento = DateTime.Parse(reader["fechaNacimiento"].ToString());
                alu.curp = reader["curp"].ToString();
                if(reader["sueldo"].ToString() != "")
                alu.sueldo = decimal.Parse(reader["sueldo"].ToString());
                alu.idEstadoOrigen = Convert.ToInt32(reader["idEstadoOrigen"]);
                alu.idEstatus = Convert.ToInt32(reader["idEstatus"]);
                con.Close();
            }

            return alu;
        }
        public void Agregar(Alumno alumno)
        {
            SqlCommand comando;
            string query = $"agregarAlumnos";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nom", alumno.nombre);
                comando.Parameters.Add("@pap", alumno.primerApellido);
                comando.Parameters.Add("@sap", alumno.segundoApellido);
                comando.Parameters.Add("@cor", alumno.correo);
                comando.Parameters.Add("@tel", alumno.telefono);
                comando.Parameters.Add("@fna", alumno.fechaNacimiento.ToString("dd - MM - yyyy"));
                comando.Parameters.Add("@cur", alumno.curp);
                if(alumno.sueldo != null)
                comando.Parameters.Add("@sdo", alumno.sueldo);
                else
                    comando.Parameters.Add("@sdo", DBNull.Value);
                comando.Parameters.Add("@idEo", alumno.idEstadoOrigen);
                comando.Parameters.Add("@idEs", alumno.idEstatus);

                con.Open();
                comando.ExecuteReader();
                con.Close();
            }
        }
        public void Actualizar(Alumno alumno)
        {
            SqlCommand comando;
            string query = "actualizarAlumnos";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", alumno.id);
                comando.Parameters.Add("@nom", alumno.nombre);
                comando.Parameters.Add("@pap", alumno.primerApellido);
                comando.Parameters.Add("@sap", alumno.segundoApellido);
                comando.Parameters.Add("@cor", alumno.correo);
                comando.Parameters.Add("@tel", alumno.telefono);
                comando.Parameters.Add("@fna", alumno.fechaNacimiento.ToString("dd - MM - yyyy"));
                comando.Parameters.Add("@cur", alumno.curp);
                if (alumno.sueldo != null)
                    comando.Parameters.Add("@sdo", alumno.sueldo);
                else
                    comando.Parameters.Add("@sdo", DBNull.Value);
                comando.Parameters.Add("@idEo", alumno.idEstadoOrigen);
                comando.Parameters.Add("@idEs", alumno.idEstatus);
                con.Open();
                comando.ExecuteReader();
                con.Close();
            }
        }
        public void Eliminar(int id)
        {
            SqlCommand comando;
            string query = $"EliminarAlumnos";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", id);
                con.Open();
                comando.ExecuteReader();
                con.Close();
            }
        }
        public List<ItemTablaISR> ConsultarTablaISR()
        {
            SqlCommand comando;
            List<ItemTablaISR> listaISR = new List<ItemTablaISR>();
            string query = "SELECT * FROM TablaISR";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    listaISR.Add(
                    new ItemTablaISR()
                    {
                        limiteInferior = Convert.ToDecimal(reader["LimInf"]),
                        limiteSuperior = Convert.ToDecimal(reader["LimSup"]),
                        cuotaFija = Convert.ToDecimal(reader["CuotaFija"]),
                        excedente = Convert.ToDecimal(reader["ExedLimInf"]),
                        subsidio = Convert.ToDecimal(reader["Subsidio"])
                    }
                );
                }
                con.Close();
            }
            return listaISR;
        }
    }
}
