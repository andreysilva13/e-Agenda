﻿
namespace eAgenda.Forms
{
    partial class FormCompromisso
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
            this.labelAssunto = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtCompromisso = new System.Windows.Forms.DateTimePicker();
            this.dtHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dtHoraTermino = new System.Windows.Forms.DateTimePicker();
            this.labelHrInicio = new System.Windows.Forms.Label();
            this.labelHrFim = new System.Windows.Forms.Label();
            this.labelDataCompromisso = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonSim = new System.Windows.Forms.RadioButton();
            this.radioButtonNao = new System.Windows.Forms.RadioButton();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.radioButtonPresencial = new System.Windows.Forms.RadioButton();
            this.radioButtonRemoto = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtRemoto = new System.Windows.Forms.TextBox();
            this.labelRemoto = new System.Windows.Forms.Label();
            this.txtPresencial = new System.Windows.Forms.TextBox();
            this.labelPresencial = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAssunto
            // 
            this.labelAssunto.AutoSize = true;
            this.labelAssunto.Location = new System.Drawing.Point(13, 13);
            this.labelAssunto.Name = "labelAssunto";
            this.labelAssunto.Size = new System.Drawing.Size(59, 13);
            this.labelAssunto.TabIndex = 0;
            this.labelAssunto.Text = "ASSUNTO";
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(16, 30);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(164, 20);
            this.txtAssunto.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.txtPresencial);
            this.panel1.Controls.Add(this.labelPresencial);
            this.panel1.Controls.Add(this.txtRemoto);
            this.panel1.Controls.Add(this.labelRemoto);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.radioButtonRemoto);
            this.panel1.Controls.Add(this.radioButtonPresencial);
            this.panel1.Controls.Add(this.groupBox);
            this.panel1.Controls.Add(this.labelHrFim);
            this.panel1.Controls.Add(this.labelDataCompromisso);
            this.panel1.Controls.Add(this.labelHrInicio);
            this.panel1.Controls.Add(this.dtHoraTermino);
            this.panel1.Controls.Add(this.dtHoraInicio);
            this.panel1.Controls.Add(this.dtCompromisso);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 335);
            this.panel1.TabIndex = 2;
            // 
            // dtCompromisso
            // 
            this.dtCompromisso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCompromisso.Location = new System.Drawing.Point(183, 27);
            this.dtCompromisso.Name = "dtCompromisso";
            this.dtCompromisso.Size = new System.Drawing.Size(137, 20);
            this.dtCompromisso.TabIndex = 0;
            // 
            // dtHoraInicio
            // 
            this.dtHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraInicio.Location = new System.Drawing.Point(183, 66);
            this.dtHoraInicio.Name = "dtHoraInicio";
            this.dtHoraInicio.Size = new System.Drawing.Size(137, 20);
            this.dtHoraInicio.TabIndex = 1;
            // 
            // dtHoraTermino
            // 
            this.dtHoraTermino.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraTermino.Location = new System.Drawing.Point(183, 105);
            this.dtHoraTermino.Name = "dtHoraTermino";
            this.dtHoraTermino.Size = new System.Drawing.Size(137, 20);
            this.dtHoraTermino.TabIndex = 2;
            // 
            // labelHrInicio
            // 
            this.labelHrInicio.AutoSize = true;
            this.labelHrInicio.Location = new System.Drawing.Point(180, 50);
            this.labelHrInicio.Name = "labelHrInicio";
            this.labelHrInicio.Size = new System.Drawing.Size(73, 13);
            this.labelHrInicio.TabIndex = 3;
            this.labelHrInicio.Text = "HORA INICIO";
            // 
            // labelHrFim
            // 
            this.labelHrFim.AutoSize = true;
            this.labelHrFim.Location = new System.Drawing.Point(180, 89);
            this.labelHrFim.Name = "labelHrFim";
            this.labelHrFim.Size = new System.Drawing.Size(91, 13);
            this.labelHrFim.TabIndex = 4;
            this.labelHrFim.Text = "HORA TERMINO";
            // 
            // labelDataCompromisso
            // 
            this.labelDataCompromisso.AutoSize = true;
            this.labelDataCompromisso.Location = new System.Drawing.Point(180, 10);
            this.labelDataCompromisso.Name = "labelDataCompromisso";
            this.labelDataCompromisso.Size = new System.Drawing.Size(120, 13);
            this.labelDataCompromisso.TabIndex = 5;
            this.labelDataCompromisso.Text = "DATA COMPROMISSO";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.listContatos);
            this.groupBox.Controls.Add(this.radioButtonNao);
            this.groupBox.Controls.Add(this.radioButtonSim);
            this.groupBox.Location = new System.Drawing.Point(13, 149);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(307, 152);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "POSSUI CONTATO?";
            // 
            // radioButtonSim
            // 
            this.radioButtonSim.AutoSize = true;
            this.radioButtonSim.Location = new System.Drawing.Point(17, 20);
            this.radioButtonSim.Name = "radioButtonSim";
            this.radioButtonSim.Size = new System.Drawing.Size(44, 17);
            this.radioButtonSim.TabIndex = 0;
            this.radioButtonSim.TabStop = true;
            this.radioButtonSim.Text = "SIM";
            this.radioButtonSim.UseVisualStyleBackColor = true;
            this.radioButtonSim.CheckedChanged += new System.EventHandler(this.radioButtonSim_CheckedChanged);
            // 
            // radioButtonNao
            // 
            this.radioButtonNao.AutoSize = true;
            this.radioButtonNao.Location = new System.Drawing.Point(67, 20);
            this.radioButtonNao.Name = "radioButtonNao";
            this.radioButtonNao.Size = new System.Drawing.Size(48, 17);
            this.radioButtonNao.TabIndex = 1;
            this.radioButtonNao.TabStop = true;
            this.radioButtonNao.Text = "NÃO";
            this.radioButtonNao.UseVisualStyleBackColor = true;
            this.radioButtonNao.CheckedChanged += new System.EventHandler(this.radioButtonNao_CheckedChanged);
            // 
            // listContatos
            // 
            this.listContatos.FormattingEnabled = true;
            this.listContatos.Location = new System.Drawing.Point(138, 20);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(163, 121);
            this.listContatos.TabIndex = 2;
            // 
            // radioButtonPresencial
            // 
            this.radioButtonPresencial.AutoSize = true;
            this.radioButtonPresencial.Location = new System.Drawing.Point(13, 66);
            this.radioButtonPresencial.Name = "radioButtonPresencial";
            this.radioButtonPresencial.Size = new System.Drawing.Size(92, 17);
            this.radioButtonPresencial.TabIndex = 3;
            this.radioButtonPresencial.TabStop = true;
            this.radioButtonPresencial.Text = "PRESENCIAL";
            this.radioButtonPresencial.UseVisualStyleBackColor = true;
            this.radioButtonPresencial.CheckedChanged += new System.EventHandler(this.radioButtonPresencial_CheckedChanged);
            // 
            // radioButtonRemoto
            // 
            this.radioButtonRemoto.AutoSize = true;
            this.radioButtonRemoto.Location = new System.Drawing.Point(105, 66);
            this.radioButtonRemoto.Name = "radioButtonRemoto";
            this.radioButtonRemoto.Size = new System.Drawing.Size(72, 17);
            this.radioButtonRemoto.TabIndex = 7;
            this.radioButtonRemoto.TabStop = true;
            this.radioButtonRemoto.Text = "REMOTO";
            this.radioButtonRemoto.UseVisualStyleBackColor = true;
            this.radioButtonRemoto.CheckedChanged += new System.EventHandler(this.radioButtonRemoto_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(340, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(222, 291);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(214, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtRemoto
            // 
            this.txtRemoto.Location = new System.Drawing.Point(13, 105);
            this.txtRemoto.Name = "txtRemoto";
            this.txtRemoto.Size = new System.Drawing.Size(164, 20);
            this.txtRemoto.TabIndex = 4;
            // 
            // labelRemoto
            // 
            this.labelRemoto.AutoSize = true;
            this.labelRemoto.Location = new System.Drawing.Point(10, 88);
            this.labelRemoto.Name = "labelRemoto";
            this.labelRemoto.Size = new System.Drawing.Size(54, 13);
            this.labelRemoto.TabIndex = 3;
            this.labelRemoto.Text = "REMOTO";
            // 
            // txtPresencial
            // 
            this.txtPresencial.Location = new System.Drawing.Point(13, 105);
            this.txtPresencial.Name = "txtPresencial";
            this.txtPresencial.Size = new System.Drawing.Size(164, 20);
            this.txtPresencial.TabIndex = 10;
            // 
            // labelPresencial
            // 
            this.labelPresencial.AutoSize = true;
            this.labelPresencial.Location = new System.Drawing.Point(10, 88);
            this.labelPresencial.Name = "labelPresencial";
            this.labelPresencial.Size = new System.Drawing.Size(74, 13);
            this.labelPresencial.TabIndex = 9;
            this.labelPresencial.Text = "PRESENCIAL";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(344, 309);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(425, 309);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(506, 309);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FormCompromisso
            // 
            this.ClientSize = new System.Drawing.Size(588, 337);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.labelAssunto);
            this.Controls.Add(this.panel1);
            this.Name = "FormCompromisso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAssunto;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonRemoto;
        private System.Windows.Forms.RadioButton radioButtonPresencial;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.RadioButton radioButtonNao;
        private System.Windows.Forms.RadioButton radioButtonSim;
        private System.Windows.Forms.Label labelHrFim;
        private System.Windows.Forms.Label labelDataCompromisso;
        private System.Windows.Forms.Label labelHrInicio;
        private System.Windows.Forms.DateTimePicker dtHoraTermino;
        private System.Windows.Forms.DateTimePicker dtHoraInicio;
        private System.Windows.Forms.DateTimePicker dtCompromisso;
        private System.Windows.Forms.TextBox txtPresencial;
        private System.Windows.Forms.Label labelPresencial;
        private System.Windows.Forms.TextBox txtRemoto;
        private System.Windows.Forms.Label labelRemoto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
    }
}