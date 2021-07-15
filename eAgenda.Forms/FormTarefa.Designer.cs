
namespace FormTarefa
{
    partial class FormTarefa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.btnLimparTela = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtConclusao = new System.Windows.Forms.DateTimePicker();
            this.dtCriacao = new System.Windows.Forms.DateTimePicker();
            this.tabControlPendentes = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listPendentes = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listConcluidos = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listTarefas = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.labelPercentual = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.labelPrioridade = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControlPendentes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxPrioridade);
            this.panel1.Controls.Add(this.btnLimparTela);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtConclusao);
            this.panel1.Controls.Add(this.dtCriacao);
            this.panel1.Controls.Add(this.tabControlPendentes);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.txtPercentual);
            this.panel1.Controls.Add(this.labelPercentual);
            this.panel1.Controls.Add(this.labelPrioridade);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.labelTituloTarefa);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 223);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Normal",
            "Alta"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(129, 31);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPrioridade.TabIndex = 16;
            // 
            // btnLimparTela
            // 
            this.btnLimparTela.Location = new System.Drawing.Point(275, 197);
            this.btnLimparTela.Name = "btnLimparTela";
            this.btnLimparTela.Size = new System.Drawing.Size(75, 23);
            this.btnLimparTela.TabIndex = 15;
            this.btnLimparTela.Text = "ATUALIZAR";
            this.btnLimparTela.UseVisualStyleBackColor = true;
            this.btnLimparTela.Click += new System.EventHandler(this.btnLimparTela_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "DATA DE CONCLUSÃO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "DATA DE CRIAÇÃO";
            // 
            // dtConclusao
            // 
            this.dtConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtConclusao.Location = new System.Drawing.Point(18, 162);
            this.dtConclusao.Name = "dtConclusao";
            this.dtConclusao.Size = new System.Drawing.Size(102, 20);
            this.dtConclusao.TabIndex = 12;
            this.dtConclusao.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // dtCriacao
            // 
            this.dtCriacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCriacao.Location = new System.Drawing.Point(18, 123);
            this.dtCriacao.Name = "dtCriacao";
            this.dtCriacao.Size = new System.Drawing.Size(102, 20);
            this.dtCriacao.TabIndex = 11;
            // 
            // tabControlPendentes
            // 
            this.tabControlPendentes.Controls.Add(this.tabPage2);
            this.tabControlPendentes.Controls.Add(this.tabPage3);
            this.tabControlPendentes.Controls.Add(this.tabPage1);
            this.tabControlPendentes.Location = new System.Drawing.Point(247, 9);
            this.tabControlPendentes.Name = "tabControlPendentes";
            this.tabControlPendentes.SelectedIndex = 0;
            this.tabControlPendentes.Size = new System.Drawing.Size(336, 148);
            this.tabControlPendentes.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listPendentes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 122);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PENDENTES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listPendentes
            // 
            this.listPendentes.FormattingEnabled = true;
            this.listPendentes.Location = new System.Drawing.Point(6, 7);
            this.listPendentes.Name = "listPendentes";
            this.listPendentes.Size = new System.Drawing.Size(316, 108);
            this.listPendentes.TabIndex = 7;
            this.listPendentes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPendentes_MouseDoubleClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listConcluidos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(328, 122);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CONCLUIDOS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listConcluidos
            // 
            this.listConcluidos.FormattingEnabled = true;
            this.listConcluidos.Location = new System.Drawing.Point(6, 7);
            this.listConcluidos.Name = "listConcluidos";
            this.listConcluidos.Size = new System.Drawing.Size(316, 108);
            this.listConcluidos.TabIndex = 7;
            this.listConcluidos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listConcluido_MouseDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listTarefas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TODAS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listTarefas
            // 
            this.listTarefas.FormattingEnabled = true;
            this.listTarefas.Location = new System.Drawing.Point(6, 6);
            this.listTarefas.Name = "listTarefas";
            this.listTarefas.Size = new System.Drawing.Size(316, 108);
            this.listTarefas.TabIndex = 6;
            this.listTarefas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listTarefas_MouseDoubleClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(356, 197);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(437, 197);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(518, 197);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtPercentual
            // 
            this.txtPercentual.Location = new System.Drawing.Point(129, 84);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(100, 20);
            this.txtPercentual.TabIndex = 5;
            // 
            // labelPercentual
            // 
            this.labelPercentual.AutoSize = true;
            this.labelPercentual.Location = new System.Drawing.Point(129, 68);
            this.labelPercentual.Name = "labelPercentual";
            this.labelPercentual.Size = new System.Drawing.Size(79, 13);
            this.labelPercentual.TabIndex = 4;
            this.labelPercentual.Text = "PERCENTUAL";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(18, 31);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(102, 73);
            this.txtTitulo.TabIndex = 1;
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Location = new System.Drawing.Point(18, 15);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(46, 13);
            this.labelTituloTarefa.TabIndex = 0;
            this.labelTituloTarefa.Text = "TITULO";
            // 
            // labelPrioridade
            // 
            this.labelPrioridade.AutoSize = true;
            this.labelPrioridade.Location = new System.Drawing.Point(129, 15);
            this.labelPrioridade.Name = "labelPrioridade";
            this.labelPrioridade.Size = new System.Drawing.Size(74, 13);
            this.labelPrioridade.TabIndex = 2;
            this.labelPrioridade.Text = "PRIORIDADE";
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 226);
            this.Controls.Add(this.panel1);
            this.Name = "FormTarefa";
            this.Text = "Tarefas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlPendentes.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label labelTituloTarefa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.Label labelPercentual;
        private System.Windows.Forms.TabControl tabControlPendentes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listTarefas;
        private System.Windows.Forms.ListBox listPendentes;
        private System.Windows.Forms.ListBox listConcluidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtConclusao;
        private System.Windows.Forms.DateTimePicker dtCriacao;
        private System.Windows.Forms.Button btnLimparTela;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
        private System.Windows.Forms.Label labelPrioridade;
    }
}

