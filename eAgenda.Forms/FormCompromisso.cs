using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using eAgenda.Dominio.ContatoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Forms
{
    public partial class FormCompromisso : Form
    {
        Contato contato;
        ControladorContato controladorContato;
        Compromisso compromisso;
        ControladorCompromisso controladorCompromisso;
        int id;

        public FormCompromisso()
        {
            controladorContato = new ControladorContato();
            controladorCompromisso = new ControladorCompromisso();
            InitializeComponent();
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            txtAssunto.Text = "";
            txtPresencial.Text = "";
            txtRemoto.Text = "";

            txtPresencial.Visible = false;
            txtRemoto.Visible = false;
            labelPresencial.Visible = false;
            labelRemoto.Visible = false;
            listContatos.Visible = false;

            listContatos.Items.Clear();

            List<Contato> visualizarTodosContatos = controladorContato.SelecionarTodos();

            foreach (var item in visualizarTodosContatos)
            {
                listContatos.Items.Add(item);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonRemoto_CheckedChanged(object sender, EventArgs e)
        {
            txtPresencial.Visible = false;
            labelPresencial.Visible = false;
            txtRemoto.Visible = true;
            labelRemoto.Visible = true;
        }

        private void radioButtonPresencial_CheckedChanged(object sender, EventArgs e)
        {
            txtRemoto.Visible = false;
            labelRemoto.Visible = false;
            txtPresencial.Visible = true;
            labelPresencial.Visible = true;
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {
            listContatos.Visible = true;
        }

        private void radioButtonNao_CheckedChanged(object sender, EventArgs e)
        {
            listContatos.Visible = false;
        }
    }
}
