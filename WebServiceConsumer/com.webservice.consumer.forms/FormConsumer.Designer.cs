
namespace WebServiceConsumer
{
    partial class formTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTurma));
            this.groupTurma = new System.Windows.Forms.GroupBox();
            this.groupBoxPesquisar = new System.Windows.Forms.GroupBox();
            this.btnPesquisarTurma = new System.Windows.Forms.Button();
            this.comboBoxPesquisarTurmas = new System.Windows.Forms.ComboBox();
            this.btnTurma = new System.Windows.Forms.Button();
            this.textTurmaAno = new System.Windows.Forms.TextBox();
            this.textTurmaNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupAluno = new System.Windows.Forms.GroupBox();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.checkBoxAlunoMatriculado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textAlunoNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTurmas = new System.Windows.Forms.ComboBox();
            this.groupTurma.SuspendLayout();
            this.groupBoxPesquisar.SuspendLayout();
            this.groupAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTurma
            // 
            this.groupTurma.Controls.Add(this.groupBoxPesquisar);
            this.groupTurma.Controls.Add(this.btnTurma);
            this.groupTurma.Controls.Add(this.textTurmaAno);
            this.groupTurma.Controls.Add(this.textTurmaNome);
            this.groupTurma.Controls.Add(this.label2);
            this.groupTurma.Controls.Add(this.label1);
            this.groupTurma.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTurma.Location = new System.Drawing.Point(10, 10);
            this.groupTurma.Name = "groupTurma";
            this.groupTurma.Size = new System.Drawing.Size(603, 169);
            this.groupTurma.TabIndex = 0;
            this.groupTurma.TabStop = false;
            this.groupTurma.Text = "Cadastrar Turma";
            // 
            // groupBoxPesquisar
            // 
            this.groupBoxPesquisar.Controls.Add(this.btnPesquisarTurma);
            this.groupBoxPesquisar.Controls.Add(this.comboBoxPesquisarTurmas);
            this.groupBoxPesquisar.Location = new System.Drawing.Point(337, 33);
            this.groupBoxPesquisar.Name = "groupBoxPesquisar";
            this.groupBoxPesquisar.Size = new System.Drawing.Size(248, 119);
            this.groupBoxPesquisar.TabIndex = 5;
            this.groupBoxPesquisar.TabStop = false;
            this.groupBoxPesquisar.Text = "Pesquisar Turma";
            // 
            // btnPesquisarTurma
            // 
            this.btnPesquisarTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarTurma.Location = new System.Drawing.Point(142, 75);
            this.btnPesquisarTurma.Name = "btnPesquisarTurma";
            this.btnPesquisarTurma.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarTurma.TabIndex = 9;
            this.btnPesquisarTurma.Text = "Pesquisar";
            this.btnPesquisarTurma.UseVisualStyleBackColor = true;
            this.btnPesquisarTurma.Click += new System.EventHandler(this.btnPesquisarTurma_Click);
            // 
            // comboBoxPesquisarTurmas
            // 
            this.comboBoxPesquisarTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPesquisarTurmas.FormattingEnabled = true;
            this.comboBoxPesquisarTurmas.Location = new System.Drawing.Point(29, 35);
            this.comboBoxPesquisarTurmas.Name = "comboBoxPesquisarTurmas";
            this.comboBoxPesquisarTurmas.Size = new System.Drawing.Size(188, 21);
            this.comboBoxPesquisarTurmas.TabIndex = 8;
            this.comboBoxPesquisarTurmas.SelectedIndexChanged += new System.EventHandler(this.comboBoxPesquisarTurmas_SelectedIndexChanged);
            // 
            // btnTurma
            // 
            this.btnTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurma.Location = new System.Drawing.Point(193, 129);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(106, 23);
            this.btnTurma.TabIndex = 4;
            this.btnTurma.Text = "Cadastrar Turma";
            this.btnTurma.UseVisualStyleBackColor = true;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // textTurmaAno
            // 
            this.textTurmaAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTurmaAno.Location = new System.Drawing.Point(72, 53);
            this.textTurmaAno.Name = "textTurmaAno";
            this.textTurmaAno.Size = new System.Drawing.Size(227, 20);
            this.textTurmaAno.TabIndex = 3;
            // 
            // textTurmaNome
            // 
            this.textTurmaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTurmaNome.Location = new System.Drawing.Point(81, 87);
            this.textTurmaNome.Name = "textTurmaNome";
            this.textTurmaNome.Size = new System.Drawing.Size(218, 20);
            this.textTurmaNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ano : ";
            // 
            // groupAluno
            // 
            this.groupAluno.Controls.Add(this.btnCadastrarAluno);
            this.groupAluno.Controls.Add(this.checkBoxAlunoMatriculado);
            this.groupAluno.Controls.Add(this.label5);
            this.groupAluno.Controls.Add(this.textAlunoNome);
            this.groupAluno.Controls.Add(this.label4);
            this.groupAluno.Controls.Add(this.label3);
            this.groupAluno.Controls.Add(this.comboBoxTurmas);
            this.groupAluno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAluno.Location = new System.Drawing.Point(10, 179);
            this.groupAluno.Name = "groupAluno";
            this.groupAluno.Size = new System.Drawing.Size(603, 230);
            this.groupAluno.TabIndex = 1;
            this.groupAluno.TabStop = false;
            this.groupAluno.Text = "Cadastrar Aluno";
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAluno.Location = new System.Drawing.Point(407, 150);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(106, 23);
            this.btnCadastrarAluno.TabIndex = 5;
            this.btnCadastrarAluno.Text = "Cadastrar Aluno";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // checkBoxAlunoMatriculado
            // 
            this.checkBoxAlunoMatriculado.AutoSize = true;
            this.checkBoxAlunoMatriculado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAlunoMatriculado.Location = new System.Drawing.Point(146, 105);
            this.checkBoxAlunoMatriculado.Name = "checkBoxAlunoMatriculado";
            this.checkBoxAlunoMatriculado.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAlunoMatriculado.TabIndex = 7;
            this.checkBoxAlunoMatriculado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Matriculado : ";
            // 
            // textAlunoNome
            // 
            this.textAlunoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAlunoNome.Location = new System.Drawing.Point(126, 62);
            this.textAlunoNome.Name = "textAlunoNome";
            this.textAlunoNome.Size = new System.Drawing.Size(387, 20);
            this.textAlunoNome.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Turma do Aluno : ";
            // 
            // comboBoxTurmas
            // 
            this.comboBoxTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTurmas.FormattingEnabled = true;
            this.comboBoxTurmas.Location = new System.Drawing.Point(173, 31);
            this.comboBoxTurmas.Name = "comboBoxTurmas";
            this.comboBoxTurmas.Size = new System.Drawing.Size(340, 21);
            this.comboBoxTurmas.TabIndex = 0;
            this.comboBoxTurmas.SelectedIndexChanged += new System.EventHandler(this.comboBoxTurmas_SelectedIndexChanged);
            // 
            // formTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 419);
            this.Controls.Add(this.groupAluno);
            this.Controls.Add(this.groupTurma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formTurma";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Turma Virtual";
            this.Load += new System.EventHandler(this.formTurma_Load);
            this.groupTurma.ResumeLayout(false);
            this.groupTurma.PerformLayout();
            this.groupBoxPesquisar.ResumeLayout(false);
            this.groupAluno.ResumeLayout(false);
            this.groupAluno.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTurma;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.TextBox textTurmaAno;
        private System.Windows.Forms.TextBox textTurmaNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupAluno;
        private System.Windows.Forms.TextBox textAlunoNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTurmas;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.CheckBox checkBoxAlunoMatriculado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxPesquisar;
        private System.Windows.Forms.Button btnPesquisarTurma;
        private System.Windows.Forms.ComboBox comboBoxPesquisarTurmas;
    }
}

