
namespace FormContato
{
    partial class FormContato
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
            this.listContatoDoCargo = new System.Windows.Forms.ListBox();
            this.tabControlVisualizacao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listCargos = new System.Windows.Forms.ListBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.labelEmpresa = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.labelPercentual = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnLimparTela = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.tabControlVisualizacao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox);
            this.panel1.Controls.Add(this.btnLimparTela);
            this.panel1.Controls.Add(this.tabControlVisualizacao);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.txtEmpresa);
            this.panel1.Controls.Add(this.labelEmpresa);
            this.panel1.Controls.Add(this.txtCargo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.labelPercentual);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 254);
            this.panel1.TabIndex = 0;
            // 
            // listContatoDoCargo
            // 
            this.listContatoDoCargo.FormattingEnabled = true;
            this.listContatoDoCargo.Location = new System.Drawing.Point(6, 13);
            this.listContatoDoCargo.Name = "listContatoDoCargo";
            this.listContatoDoCargo.Size = new System.Drawing.Size(251, 69);
            this.listContatoDoCargo.TabIndex = 18;
            this.listContatoDoCargo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listContatoDoCargo_MouseDoubleClick);
            // 
            // tabControlVisualizacao
            // 
            this.tabControlVisualizacao.Controls.Add(this.tabPage1);
            this.tabControlVisualizacao.Controls.Add(this.tabPage2);
            this.tabControlVisualizacao.Location = new System.Drawing.Point(368, 11);
            this.tabControlVisualizacao.Name = "tabControlVisualizacao";
            this.tabControlVisualizacao.SelectedIndex = 0;
            this.tabControlVisualizacao.Size = new System.Drawing.Size(267, 117);
            this.tabControlVisualizacao.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listContatos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(259, 91);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TODOS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.Location = new System.Drawing.Point(3, 3);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(253, 82);
            this.listContatos.TabIndex = 16;
            this.listContatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listContatos_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listCargos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(259, 91);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "P/ CARGOS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listCargos
            // 
            this.listCargos.FormattingEnabled = true;
            this.listCargos.Location = new System.Drawing.Point(3, 3);
            this.listCargos.Name = "listCargos";
            this.listCargos.Size = new System.Drawing.Size(253, 82);
            this.listCargos.TabIndex = 17;
            this.listCargos.Click += new System.EventHandler(this.listCargos_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(398, 228);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(479, 228);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(560, 228);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(121, 78);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txtEmpresa.TabIndex = 15;
            // 
            // labelEmpresa
            // 
            this.labelEmpresa.AutoSize = true;
            this.labelEmpresa.Location = new System.Drawing.Point(121, 62);
            this.labelEmpresa.Name = "labelEmpresa";
            this.labelEmpresa.Size = new System.Drawing.Size(59, 13);
            this.labelEmpresa.TabIndex = 14;
            this.labelEmpresa.Text = "EMPRESA";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(10, 78);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CARGO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(254, 27);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 11;
            // 
            // labelPercentual
            // 
            this.labelPercentual.AutoSize = true;
            this.labelPercentual.Location = new System.Drawing.Point(254, 11);
            this.labelPercentual.Name = "labelPercentual";
            this.labelPercentual.Size = new System.Drawing.Size(63, 13);
            this.labelPercentual.TabIndex = 10;
            this.labelPercentual.Text = "TELEFONE";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 27);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(118, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(121, 11);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "EMAIL";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(10, 11);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(39, 13);
            this.labelNome.TabIndex = 6;
            this.labelNome.Text = "NOME";
            // 
            // btnLimparTela
            // 
            this.btnLimparTela.Location = new System.Drawing.Point(317, 228);
            this.btnLimparTela.Name = "btnLimparTela";
            this.btnLimparTela.Size = new System.Drawing.Size(75, 23);
            this.btnLimparTela.TabIndex = 21;
            this.btnLimparTela.Text = "ATUALIZAR";
            this.btnLimparTela.UseVisualStyleBackColor = true;
            this.btnLimparTela.Click += new System.EventHandler(this.btnLimparTela_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.listContatoDoCargo);
            this.groupBox.Location = new System.Drawing.Point(368, 134);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(263, 88);
            this.groupBox.TabIndex = 22;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "CONTATOS NO CARGO";
            // 
            // FormContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 258);
            this.Controls.Add(this.panel1);
            this.Name = "FormContato";
            this.Text = "Contatos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlVisualizacao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label labelPercentual;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label labelEmpresa;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabControl tabControlVisualizacao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listCargos;
        private System.Windows.Forms.ListBox listContatoDoCargo;
        private System.Windows.Forms.Button btnLimparTela;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

