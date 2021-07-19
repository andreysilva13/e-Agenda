
namespace eAgenda.Forms
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompromisso = new System.Windows.Forms.Button();
            this.btnContato = new System.Windows.Forms.Button();
            this.btnTarefa = new System.Windows.Forms.Button();
            this.labelEAgenda = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCompromisso);
            this.panel1.Controls.Add(this.btnContato);
            this.panel1.Controls.Add(this.btnTarefa);
            this.panel1.Controls.Add(this.labelEAgenda);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 346);
            this.panel1.TabIndex = 0;
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.BackColor = System.Drawing.Color.White;
            this.btnCompromisso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompromisso.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompromisso.Image = ((System.Drawing.Image)(resources.GetObject("btnCompromisso.Image")));
            this.btnCompromisso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompromisso.Location = new System.Drawing.Point(46, 245);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(139, 61);
            this.btnCompromisso.TabIndex = 3;
            this.btnCompromisso.Text = "COMPROMISSOS";
            this.btnCompromisso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompromisso.UseVisualStyleBackColor = false;
            this.btnCompromisso.Click += new System.EventHandler(this.btnCompromisso_Click);
            // 
            // btnContato
            // 
            this.btnContato.BackColor = System.Drawing.Color.White;
            this.btnContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContato.Image = ((System.Drawing.Image)(resources.GetObject("btnContato.Image")));
            this.btnContato.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContato.Location = new System.Drawing.Point(46, 157);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(139, 61);
            this.btnContato.TabIndex = 2;
            this.btnContato.Text = "CONTATOS";
            this.btnContato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContato.UseVisualStyleBackColor = false;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            // 
            // btnTarefa
            // 
            this.btnTarefa.BackColor = System.Drawing.Color.White;
            this.btnTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarefa.Image = ((System.Drawing.Image)(resources.GetObject("btnTarefa.Image")));
            this.btnTarefa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTarefa.Location = new System.Drawing.Point(46, 73);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(139, 61);
            this.btnTarefa.TabIndex = 1;
            this.btnTarefa.Text = "TAREFAS";
            this.btnTarefa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarefa.UseVisualStyleBackColor = false;
            this.btnTarefa.Click += new System.EventHandler(this.btnTarefa_Click);
            // 
            // labelEAgenda
            // 
            this.labelEAgenda.AutoSize = true;
            this.labelEAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEAgenda.Location = new System.Drawing.Point(41, 18);
            this.labelEAgenda.Name = "labelEAgenda";
            this.labelEAgenda.Size = new System.Drawing.Size(113, 25);
            this.labelEAgenda.TabIndex = 0;
            this.labelEAgenda.Text = "e-Agenda";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 351);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTarefa;
        private System.Windows.Forms.Label labelEAgenda;
        private System.Windows.Forms.Button btnCompromisso;
        private System.Windows.Forms.Button btnContato;
    }
}

