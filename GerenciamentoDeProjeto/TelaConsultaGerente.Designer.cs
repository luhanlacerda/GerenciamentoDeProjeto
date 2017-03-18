namespace GerenciamentoDeProjeto
{
    partial class TelaConsultaGerente
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listViewGerentes = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(71, 31);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(145, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(315, 31);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewGerentes
            // 
            this.listViewGerentes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Código,
            this.Nome});
            this.listViewGerentes.FullRowSelect = true;
            this.listViewGerentes.Location = new System.Drawing.Point(30, 111);
            this.listViewGerentes.Name = "listViewGerentes";
            this.listViewGerentes.Size = new System.Drawing.Size(385, 171);
            this.listViewGerentes.TabIndex = 5;
            this.listViewGerentes.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TelaConsultaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 336);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listViewGerentes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "TelaConsultaGerente";
            this.Text = "TelaConsultaGerente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewGerentes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Código;
        private System.Windows.Forms.ColumnHeader Nome;
    }
}