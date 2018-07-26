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
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();

            RepositoryExchanges test = new RepositoryExchanges();
            test.GetAll();

            //Repository repo = new Repository();
            //repo.GetAll();
        }

        private void click_añadir(object sender, EventArgs e)
        {
            FormAñadir windowsFormAñadir = new FormAñadir();
            windowsFormAñadir.Show();
        }

        private void click_editar(object sender, EventArgs e)
        {
            FormEditar windowsFormEditar = new FormEditar();
            windowsFormEditar.Show();
        }

        private void click_eliminar(object sender, EventArgs e)
        {
            Repository repo = new Repository();
            repo.Delete(Convert.ToInt32(tb_id_eliminar.Text));

            MessageBox.Show("Alumno eliminado correctamente!");
            tb_id_eliminar.Clear();
        }
    }
}
