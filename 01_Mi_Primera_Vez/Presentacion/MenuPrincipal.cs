using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void btnPerosnal_Click(object sender, EventArgs e)
        {
            CUPersonal cuusuario = new CUPersonal();
            PanelGeneral.Controls.Clear();
            cuusuario.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(cuusuario);
            
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CUusuario cuusuario = new CUusuario(); 
            PanelGeneral.Controls.Clear();
            cuusuario.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(cuusuario);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Asistencias.frmAsistencias frmAsistencias = new Asistencias.frmAsistencias();
            frmAsistencias.ShowDialog();
        }
    }
}

