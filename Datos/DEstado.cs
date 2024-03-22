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
    public class DEstado
    {
        public List<Estado> Consultar()
        {
            SqlCommand comando;
            List<Estado> listaEstados = new List<Estado>();
            string connectionString = @"Data Source=DESKTOP-JDVOH45;Initial Catalog=InstitutoTich;Integrated Security=True";
            string query = "consultarEstados";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                comando = new SqlCommand(query, con);
                comando.Parameters.Add("@id", -1);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Estado estado = new Estado();
                    estado.id = Convert.ToInt32(reader["id"]);
                    estado.nombre = reader["nombre"].ToString();
                    listaEstados.Add(estado);
                }
                con.Close();
            }
            return listaEstados;
        }
        public Estado Consultar(int id)
        {
            SqlCommand comando;
            Estado est = new Estado();
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-JDVOH45";
            builder.InitialCatalog = "InstitutoTich";
            builder.IntegratedSecurity = true;

            string connectionString = builder.ToString();
            //string connectionString = @"Data Source=DESKTOP-JDVOH45;Initial Catalog=InstitutoTich;Integrated Security=True";
            string query = $"consultarEstados";

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
