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
    public partial class FormAñadir : Form
    {
        Repository repo;

        public FormAñadir()
        {
            InitializeComponent();
        }

        private void click_añadir(object sender, EventArgs e)
        {
            AlumnoModel alumno = new AlumnoModel(Convert.ToInt32(tb_id.Text), tb_nombre.Text, tb_apellido.Text, tb_dni.Text);

            repo = new Repository();
            repo.Post(alumno);
        }
    }
}
