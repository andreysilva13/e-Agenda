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
            dtConclusao.Enabled = false;
            dtCriacao.Enabled = false;
            txtPercentual.Enabled = false;

            txtPercentual.Text = ""; 
            txtPrioridade.Text = ""; 
            txtTitulo.Text = "";

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
            string titulo = txtTitulo.Text;
            int prioridade = Convert.ToInt32(txtPrioridade.Text);
            tarefa = new Tarefa(titulo, DateTime.Now, (PrioridadeEnum)prioridade);
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
            txtTitulo.Enabled = true;
            txtPercentual.Enabled = true;
            txtPrioridade.Enabled = true;
            txtPercentual.Enabled = true;

            Tarefa tarefa = listPendentes.SelectedItem as Tarefa;
            txtTitulo.Text = tarefa.Titulo;
            txtPercentual.Text = tarefa.Percentual.ToString();
            txtPrioridade.Text = tarefa.Prioridade.ToString();
            dtCriacao.Value = tarefa.DataCriacao;
            
            id = tarefa.Id;
        }

        private void listConcluido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTitulo.Enabled = false;
            txtPercentual.Enabled = false;
            txtPrioridade.Enabled = false;

            Tarefa tarefa = listConcluidos.SelectedItem as Tarefa;
            txtTitulo.Text = tarefa.Titulo;
            txtPercentual.Text = tarefa.Percentual.ToString();
            txtPrioridade.Text = tarefa.Prioridade.ToString();
            dtCriacao.Value = tarefa.DataCriacao;
            dtConclusao.Value = (DateTime)tarefa.DataConclusao;
            
            id = tarefa.Id;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {   
            string titulo = txtTitulo.Text;
            int prioridade = Convert.ToInt32(txtPrioridade.Text);
            int percentual = Convert.ToInt32(txtPercentual.Text);
            if (percentual == 100)
            {
                controladorTarefa.AtualizarPercentual(id, percentual);
                MessageBox.Show("TAREFA CONCLUÍDA");
            }
            else
            {
                tarefa = new Tarefa(titulo, DateTime.Now, (PrioridadeEnum)prioridade);
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
    }
}
