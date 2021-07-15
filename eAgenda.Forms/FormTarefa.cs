using System;
using System.Collections.Generic;
using System.Windows.Forms;
using eAgenda.Dominio.TarefaModule;
using eAgenda.Controladores.TarefaModule;

namespace FormTarefa
{
    public partial class FormTarefa : Form
    {
        Tarefa tarefa;
        ControladorTarefa controladorTarefa;
        int id;
        public FormTarefa()
        {   
            controladorTarefa = new ControladorTarefa();
            InitializeComponent();
            AtualizarTela();
        }

        #region métodos privados
        private void AtualizarTela()
        {
            AtivaBotoes();

            dtConclusao.Enabled = false;
            dtCriacao.Enabled = false;
            txtPercentual.Enabled = false;

            txtTitulo.Enabled = true;
            txtPercentual.Enabled = true;
            txtPercentual.Enabled = true;
            comboBoxPrioridade.Enabled = true;

            txtPercentual.Text = ""; 
            txtTitulo.Text = "";

            comboBoxPrioridade.SelectedItem = null;
            listTarefas.Items.Clear();
            listPendentes.Items.Clear();
            listConcluidos.Items.Clear();

            List<Tarefa> visualizarTodasTarefas = controladorTarefa.SelecionarTodos();
            List<Tarefa> visualizarPendentes = controladorTarefa.SelecionarTodasTarefasPendentes();
            List<Tarefa> visualizarConcluidos = controladorTarefa.SelecionarTodasTarefasConcluidas();

            foreach (var item in visualizarTodasTarefas)
            {
                listTarefas.Items.Add(item);
            }

            foreach (var item in visualizarPendentes)
            {
                listPendentes.Items.Add(item);
            }

            foreach (var item in visualizarConcluidos)
            {
                listConcluidos.Items.Add(item);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tarefa = new Tarefa(txtTitulo.Text, DateTime.Now, (PrioridadeEnum)comboBoxPrioridade.SelectedIndex);
            string verifica = controladorTarefa.InserirNovo(tarefa);

            if (verifica == "ESTA_VALIDO")
                MessageBox.Show("TAREFA INSERIDA");
            else
                MessageBox.Show("INFELIZMENTE A TAREFA NÃO FOI INSERIDA, TENTE NOVAMENTE.");

            AtualizarTela();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefa = listPendentes.SelectedItem as Tarefa;
            int id = tarefa.Id;

            controladorTarefa.Excluir(id);
            AtualizarTela();
        }

        private void listPendentes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AtivaBotoes();

            int prioridade = 0;
            txtTitulo.Enabled = true;
            txtPercentual.Enabled = true;
            txtPercentual.Enabled = true;
            comboBoxPrioridade.Enabled = true;

            Tarefa tarefa = listPendentes.SelectedItem as Tarefa;
            txtTitulo.Text = tarefa.Titulo;
            txtPercentual.Text = tarefa.Percentual.ToString();
            switch (tarefa.Prioridade.ToString())
            {

                case "Prioridade Alta": prioridade = 2; break;
                case "Prioridade Normal": prioridade = 1; break;
                case  "Prioridade Baixa": prioridade = 0; break;
            }
            comboBoxPrioridade.SelectedIndex = prioridade;
            dtCriacao.Value = tarefa.DataCriacao;
            
            id = tarefa.Id;
        }

        private void listConcluido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Tarefa tarefa = listConcluidos.SelectedItem as Tarefa;
            Visualizar(tarefa);
        }

        private void Visualizar(Tarefa tarefa)
        {
            int prioridade = 0;
            txtTitulo.Enabled = false;
            txtPercentual.Enabled = false;
            comboBoxPrioridade.Enabled = false;
            DesativaBotoes();


            txtTitulo.Text = tarefa.Titulo;
            txtPercentual.Text = tarefa.Percentual.ToString();
            switch (tarefa.Prioridade.ToString())
            {

                case "Prioridade Alta": prioridade = 2; break;
                case "Prioridade Normal": prioridade = 1; break;
                case "Prioridade Baixa": prioridade = 0; break;
            }
            comboBoxPrioridade.SelectedIndex = prioridade;
            dtCriacao.Value = tarefa.DataCriacao;
            if (tarefa.DataConclusao != null)
                dtConclusao.Value = (DateTime)tarefa.DataConclusao;
            else
                dtConclusao.Value = new DateTime(1800, 12, 30);
            

            id = tarefa.Id;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int percentual = 0;

            if (percentual == 100)
            {
                controladorTarefa.AtualizarPercentual(id, percentual);
                MessageBox.Show("TAREFA CONCLUÍDA");
            }
            else
            {
                tarefa = new Tarefa(txtTitulo.Text, DateTime.Now, (PrioridadeEnum)comboBoxPrioridade.SelectedIndex);
                string verifica = controladorTarefa.Editar(id, tarefa);
                controladorTarefa.AtualizarPercentual(id, percentual);
                if (verifica == "ESTA_VALIDO")
                    MessageBox.Show("TAREFA EDITADA");
                else
                    MessageBox.Show("INFELIZMENTE A TAREFA NÃO FOI EDITADA, TENTE NOVAMENTE.");
            }
            AtualizarTela();
        }
        #endregion

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            AtualizarTela();
        }

        private void listTarefas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Tarefa tarefa = listTarefas.SelectedItem as Tarefa;
            Visualizar(tarefa);
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
    }
}
