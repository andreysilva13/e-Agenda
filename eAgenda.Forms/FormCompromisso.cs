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

        #region métodos privados
        private void AtualizarTela()
        {
            AtivaBotoes();

            DateTime dataFutura = DateTime.Now.AddDays(365);
            txtAssunto.Text = "";
            txtPresencial.Text = "";
            txtRemoto.Text = "";
            radioButtonSim.Checked = false;
            radioButtonNao.Checked = false;
            radioButtonRemoto.Checked = false;
            radioButtonPresencial.Checked = false;
            dtCompromisso.Value = DateTime.Now;
            dtHoraInicio.Value = DateTime.Now;
            dtHoraTermino.Value = DateTime.Now;

            txtPresencial.Visible = false;
            txtRemoto.Visible = false;
            labelPresencial.Visible = false;
            labelRemoto.Visible = false;
            listContatos.Visible = false;

            listContatos.Items.Clear();
            listFuturo.Items.Clear();
            listPassados.Items.Clear();

            List<Contato> visualizarTodosContatos = controladorContato.SelecionarTodos();
            List<Compromisso> visualizarCompromissosFuturo = controladorCompromisso.SelecionarCompromissosFuturos(DateTime.Now, dataFutura);
            List<Compromisso> visualizarCompromissosPassados = controladorCompromisso.SelecionarCompromissosPassados(DateTime.Now);

            foreach (var item in visualizarTodosContatos)
            {
                listContatos.Items.Add(item);
            }

            foreach (var item in visualizarCompromissosFuturo)
            {
                listFuturo.Items.Add(item);
            }

            foreach (var item in visualizarCompromissosPassados)
            {
                listPassados.Items.Add(item);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = null;
            string local = "", link = "";
            string assunto = txtAssunto.Text;
            DateTime dataCompromisso = dtCompromisso.Value;
            TimeSpan hrInicio = dtHoraInicio.Value.TimeOfDay;
            TimeSpan hrTermino = dtHoraTermino.Value.TimeOfDay;

            if (radioButtonPresencial.Checked)
            {
                local = txtPresencial.Text;
                link = null;
            }
            else if (radioButtonRemoto.Checked)
            {
                link = txtRemoto.Text;
                local = null;
            }

            if (radioButtonSim.Checked)
                contato = listContatos.SelectedItem as Contato;
            else if (radioButtonNao.Checked)
                contato = null;

            compromisso = new Compromisso(assunto, local, link, dataCompromisso, hrInicio, hrTermino, contato);
            string validar = controladorCompromisso.InserirNovo(compromisso);

            if (validar == "ESTA_VALIDO")
                MessageBox.Show("COMPROMISSO INSERIDO");
            else
                MessageBox.Show("ERRO AO TENTAR INSERIR UM COMPROMISSO, TENTE NOVAMENTE");

            AtualizarTela();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Compromisso compromisso = listFuturo.SelectedItem as Compromisso;
            int id = compromisso.Id;

            controladorCompromisso.Excluir(id);

            AtualizarTela();
        }

        private void listFuturo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AtivaBotoes();

            Compromisso compromisso = listFuturo.SelectedItem as Compromisso;
            id = compromisso.Id;
            txtAssunto.Text = compromisso.Assunto;
            dtCompromisso.Value = compromisso.Data;
            dtHoraInicio.Value = Convert.ToDateTime(compromisso.HoraInicio.ToString());
            dtHoraTermino.Value = Convert.ToDateTime(compromisso.HoraTermino.ToString());

            if (compromisso.Local != "")
            {
                radioButtonRemoto.Checked = false;
                radioButtonPresencial.Checked = true;
                txtPresencial.Text = compromisso.Local;
            }
            else if (compromisso.Link != "")
            {
                radioButtonPresencial.Checked = false;
                radioButtonRemoto.Checked = true;
                txtRemoto.Text = compromisso.Link;
            }

            if (compromisso.Contato != null)
            {
                radioButtonSim.Checked = true;
                listContatos.SelectedItem = compromisso.Contato;
            }
            else if (compromisso.Contato == null)
            {
                radioButtonNao.Checked = true;
            }
        }

        private void listPassados_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            DesativaBotoes();

            Compromisso compromisso = listPassados.SelectedItem as Compromisso;
            id = compromisso.Id;
            txtAssunto.Text = compromisso.Assunto;
            dtCompromisso.Value = compromisso.Data;
            dtHoraInicio.Value = Convert.ToDateTime(compromisso.HoraInicio.ToString());
            dtHoraTermino.Value = Convert.ToDateTime(compromisso.HoraTermino.ToString());

            if (compromisso.Local != "")
            {
                radioButtonRemoto.Checked = false;
                radioButtonPresencial.Checked = true;
                txtPresencial.Text = compromisso.Local;
            }
            else if (compromisso.Link != "")
            {
                radioButtonPresencial.Checked = false;
                radioButtonRemoto.Checked = true;
                txtRemoto.Text = compromisso.Link;
            }

            if (compromisso.Contato != null)
            {
                radioButtonSim.Checked = true;
                listContatos.SelectedItem = compromisso.Contato;
            }
            else if (compromisso.Contato == null)
            {
                radioButtonNao.Checked = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contato = null;
            string local = "", link = "";
            string assunto = txtAssunto.Text;
            DateTime dataCompromisso = dtCompromisso.Value;
            TimeSpan hrInicio = dtHoraInicio.Value.TimeOfDay;
            TimeSpan hrTermino = dtHoraTermino.Value.TimeOfDay;

            if (radioButtonPresencial.Checked)
            {
                local = txtPresencial.Text;
                link = null;
            }
            else if (radioButtonRemoto.Checked)
            {
                link = txtRemoto.Text;
                local = null;
            }

            if (radioButtonSim.Checked)
                contato = listContatos.SelectedItem as Contato;
            else if (radioButtonNao.Checked)
                contato = null;

            compromisso = new Compromisso(assunto, local, link, dataCompromisso, hrInicio, hrTermino, contato);
            string validar = controladorCompromisso.Editar(id, compromisso);

            if (validar == "ESTA_VALIDO")
                MessageBox.Show("COMPROMISSO EDITADO");
            else
                MessageBox.Show("ERRO AO TENTAR EDITAR UM COMPROMISSO, TENTE NOVAMENTE");

            AtualizarTela();
        }

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void AtivaBotoes()
        {
            btnEditar.Enabled = true;
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void DesativaBotoes()
        {
            btnEditar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
        }
        #endregion
    }
}
