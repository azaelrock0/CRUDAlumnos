using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class DEstatusAlumno
    {
        public List<EstatusAlumno> Consultar()
        {
            SqlCommand comando;
            List<EstatusAlumno> listaEstatus = new List<EstatusAlumno>();
            string connectionString = @"Data Source=DESKTOP-JDVOH45;Initial Catalog=InstitutoTich;Integrated Security=True";
            string query = "consultarEstatusAlumnos";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                comando = new SqlCommand(query, con);
                comando.Parameters.Add("@id", -1);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    EstatusAlumno estatus = new EstatusAlumno();
                    estatus.id = Convert.ToInt32(reader["id"]);
                    estatus.nombre = reader["nombre"].ToString();
                    listaEstatus.Add(estatus);
                }
                con.Close();
            }
            return listaEstatus;
        }
        public EstatusAlumno Consultar(int id)
        {
            SqlCommand comando;
            EstatusAlumno est = new EstatusAlumno();
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-JDVOH45";
            builder.InitialCatalog = "InstitutoTich";
            builder.IntegratedSecurity = true;

            string connectionString = builder.ToString();
            //string connectionString = @"Data Source=DESKTOP-JDVOH45;Initial Catalog=InstitutoTich;Integrated Security=True";
            string query = $"consultarEstatusAlumnos";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                comando = new SqlCommand(query, con);
                comando.Parameters.Add("@id", id);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                var hola = reader.Read();
                est.id = Convert.ToInt32(reader["id"]);
                est.nombre = reader["nombre"].ToString();
                con.Close();
            }

            return est;
        }
    }
}
