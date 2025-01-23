using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Mi_Primera_Vez.Datos;

namespace _01_Mi_Primera_Vez.Logica
{
    public class cls_usuario
    {
        private dao_usuario dao = new dao_usuario();

        public DataTable ObtenerUsuarios()
        {
            return dao.LeerUsuarios();
        }

        public void AgregarUsuario(string nombre, string correo, string contraseña, string rol)
        {
            // Validaciones si es necesario
            dao.CrearUsuario(nombre, correo, contraseña, rol);
        }

        public void EditarUsuario(int id, string nombre, string correo, string contraseña, string rol)
        {
            // Validaciones si es necesario
            dao.ActualizarUsuario(id, nombre, correo, contraseña, rol);
        }

        public void BorrarUsuario(int id)
        {
            // Validaciones si es necesario
            dao.EliminarUsuario(id);
        }
    }
}

