using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eAgenda.Forms;

namespace eAgenda.Forms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnTarefa_Click(object sender, EventArgs e)
        {
            FormTarefa.FormTarefa formTarefa = new FormTarefa.FormTarefa();
            formTarefa.ShowDialog();
        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            FormContato.FormContato formContato = new FormContato.FormContato();
            formContato.ShowDialog();
        }

        private void btnCompromisso_Click(object sender, EventArgs e)
        {
            FormCompromisso formCompromisso = new FormCompromisso();
            formCompromisso.ShowDialog();
        }
    }
}
