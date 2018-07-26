using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsRedis
{
    public partial class FormEditar : Form
    {
        Repository repo;

        public FormEditar()
        {
            InitializeComponent();
        }

        private void click_editar(object sender, EventArgs e)
        {
            AlumnoModel alumno = new AlumnoModel(Convert.ToInt32(tb_id.Text), tb_nombre.Text, tb_apellido.Text, tb_dni.Text);

            repo = new Repository();
            repo.Post(alumno);

            MessageBox.Show("Alumno editado correctamente!");
            tb_id.Clear();
            tb_nombre.Clear();
            tb_apellido.Clear();
            tb_dni.Clear();
        }
    }
}
