
namespace ImplementacaoBD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.pnIAlterar = new System.Windows.Forms.Panel();
            this.txtCpfAluno = new System.Windows.Forms.TextBox();
            this.txtNmAluno = new System.Windows.Forms.TextBox();
            this.txtIdAluno = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.pnIAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(12, 12);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(776, 181);
            this.dgvAluno.TabIndex = 0;
            this.dgvAluno.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAluno_CellMouseDoubleClick);
            // 
            // pnIAlterar
            // 
            this.pnIAlterar.Controls.Add(this.btnAddAluno);
            this.pnIAlterar.Controls.Add(this.txtCpfAluno);
            this.pnIAlterar.Controls.Add(this.txtNmAluno);
            this.pnIAlterar.Controls.Add(this.txtIdAluno);
            this.pnIAlterar.Controls.Add(this.btnExcluir);
            this.pnIAlterar.Controls.Add(this.btnAlterar);
            this.pnIAlterar.Controls.Add(this.label3);
            this.pnIAlterar.Controls.Add(this.label2);
            this.pnIAlterar.Controls.Add(this.label1);
            this.pnIAlterar.Location = new System.Drawing.Point(12, 199);
            this.pnIAlterar.Name = "pnIAlterar";
            this.pnIAlterar.Size = new System.Drawing.Size(762, 193);
            this.pnIAlterar.TabIndex = 9;
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Location = new System.Drawing.Point(501, 53);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(206, 20);
            this.txtCpfAluno.TabIndex = 16;
            // 
            // txtNmAluno
            // 
            this.txtNmAluno.Location = new System.Drawing.Point(262, 53);
            this.txtNmAluno.Name = "txtNmAluno";
            this.txtNmAluno.Size = new System.Drawing.Size(206, 20);
            this.txtNmAluno.TabIndex = 15;
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.Location = new System.Drawing.Point(17, 53);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(206, 20);
            this.txtIdAluno.TabIndex = 14;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(451, 106);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(339, 106);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF do aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do aluno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID do aluno:";
            // 
            // btnAddAluno
            // 
            this.btnAddAluno.Location = new System.Drawing.Point(227, 105);
            this.btnAddAluno.Name = "btnAddAluno";
            this.btnAddAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAddAluno.TabIndex = 17;
            this.btnAddAluno.Text = "Adicionar";
            this.btnAddAluno.UseVisualStyleBackColor = true;
            this.btnAddAluno.Click += new System.EventHandler(this.btnAddAluno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnIAlterar);
            this.Controls.Add(this.dgvAluno);
            this.Name = "Form1";
            this.Text = "e";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.pnIAlterar.ResumeLayout(false);
            this.pnIAlterar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Panel pnIAlterar;
        private System.Windows.Forms.TextBox txtCpfAluno;
        private System.Windows.Forms.TextBox txtNmAluno;
        private System.Windows.Forms.TextBox txtIdAluno;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAluno;
    }
}

