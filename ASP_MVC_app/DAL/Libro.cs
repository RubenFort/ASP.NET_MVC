using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP_MVC_app.DAL
{
    public class Libro
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["libroconn"].ToString();
            con = new SqlConnection(constring);
        }

        public bool AgregarLibro(Models.Libro libro)
        {
            connection();
            SqlCommand cmd = new SqlCommand("AgregarLibro", con);
            cmd.CommandType = CommandType.StoredProcedure; //Procedimiento almacenado creado previamente llamado "AgregarLibro"

            cmd.Parameters.AddWithValue("@nombre", libro.Nombre);
            cmd.Parameters.AddWithValue("@edad", libro.Paginas);
            cmd.Parameters.AddWithValue("@descrip", libro.Descrip);
            cmd.Parameters.AddWithValue("@correo", libro.CorreoContacto);
            cmd.Parameters.AddWithValue("@adoptado", 0);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if(i >= 1) // Si i es >= 1 es que la "NonQuery" se ejecutó correctamente
                return true;
            else
                return false;
        }
    }
}