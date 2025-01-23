using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Mi_Primera_Vez.Datos
{
    public class dao_usuario
    {
        private conexion con = new conexion();

        public DataTable LeerUsuarios()
        {
            using (SqlConnection sqlCon = con.obtenerConexion())
            {
                string query = "SELECT * FROM Usuarios";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void CrearUsuario(string nombre, string correo, string contraseña, string rol)
        {
            using (SqlConnection sqlCon = con.obtenerConexion())
            {
                string query = "INSERT INTO Usuarios (Nombre, Email, Contraseña, Rol) VALUES (@Nombre, @Email, @Contraseña, @Rol)";
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Email", correo);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@Rol", rol);

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarUsuario(int id, string nombre, string correo, string contraseña, string rol)
        {
            using (SqlConnection sqlCon = con.obtenerConexion())
            {
                string query = "UPDATE Usuarios SET Nombre = @Nombre, Email = @Email, Contraseña = @Contraseña, Rol = @Rol WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Email", correo);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    cmd.Parameters.AddWithValue("@Rol", rol);

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EliminarUsuario(int id)
        {
            using (SqlConnection sqlCon = con.obtenerConexion())
            {
                string query = "DELETE FROM Usuarios WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    sqlCon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

