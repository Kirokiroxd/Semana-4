using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _01_Mi_Primera_Vez.Logica;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class CUusuario : UserControl
    {
       private cls_usuario logicaUsuario = new cls_usuario();

        public CUusuario()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = logicaUsuario.ObtenerUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            logicaUsuario.AgregarUsuario(txtNombre.Text, txtCorreo.Text, txtContraseña.Text, txtRol.Text);
            MessageBox.Show("Usuario agregado correctamente.");
            CargarUsuarios();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);
            logicaUsuario.EditarUsuario(id, txtNombre.Text, txtCorreo.Text, txtContraseña.Text, txtRol.Text);
            MessageBox.Show("Usuario actualizado correctamente.");
            CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["Id"].Value);
            logicaUsuario.BorrarUsuario(id);
            MessageBox.Show("Usuario eliminado correctamente.");
            CargarUsuarios();
        }
    }
}
    

