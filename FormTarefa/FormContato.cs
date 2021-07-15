using eAgenda.Controladores.ContatoModule;
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

namespace FormContato
{
    public partial class FormContato : Form
    {
        Contato contato;
        ControladorContato controladorContato;
        int id;
        public FormContato()
        {
            controladorContato = new ControladorContato();
            InitializeComponent();
            AtualizarTela();
        }

        #region métodos privados
        private void AtualizarTela()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCargo.Text = "";
            txtEmpresa.Text = "";
            txtTelefone.Text = "";

            listContatos.Items.Clear();

            List<Contato> visualizarTodosContatos = controladorContato.SelecionarTodos();

            foreach (var item in visualizarTodosContatos)
            {
                listContatos.Items.Add(item);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;
            string telefone = txtTelefone.Text;
            contato = new Contato(nome, email, telefone, empresa, cargo);
            string verifica = controladorContato.InserirNovo(contato);

            if (verifica == "ESTA_VALIDO")
                MessageBox.Show("CONTATO INSERIDO");
            else
                MessageBox.Show("INFELIZMENTE O CONTATO NÃO FOI INSERIDO, TENTE NOVAMENTE.");

            AtualizarTela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;
            string telefone = txtTelefone.Text;
            contato = new Contato(nome, email, telefone, empresa, cargo);
            string verifica = controladorContato.Editar(id, contato);
            if (verifica == "ESTA_VALIDO")
                MessageBox.Show("CONTATO EDITADO");
            else
                MessageBox.Show("INFELIZMENTE O CONTATO NÃO FOI EDITADO, TENTE NOVAMENTE.");
            AtualizarTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Contato contato = listContatos.SelectedItem as Contato;
            int id = contato.Id;

            controladorContato.Excluir(id);
            AtualizarTela();
        }

        private void listContatos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Contato contato = listContatos.SelectedItem as Contato;
            txtNome.Text = contato.Nome;
            txtEmail.Text = contato.Email;
            txtCargo.Text = contato.Cargo;
            txtEmpresa.Text = contato.Empresa;
            txtTelefone.Text = contato.Telefone;

            id = contato.Id;
        }
        #endregion
    }
}
