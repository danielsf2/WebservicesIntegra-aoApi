using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WebServiceConsumer.com.webservice.consumer.modelos;
using WebServiceConsumer.com.webservice.consumer.requests;

namespace WebServiceConsumer
{
    public partial class formTurma : Form
    {

        private Turma alunoCadastrar;
        private Turma turmaExibir;

        public formTurma()
        {
           
            InitializeComponent();
            atualizarTurmas();
        }

        private void formTurma_Load(object sender, EventArgs e)
        {
           
            alunoCadastrar = new Turma();
            turmaExibir = new Turma();

        }//formTurma_Load

        private void btnTurma_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma()
            {
                ano = Convert.ToInt32(textTurmaAno.Text),
                curso = textTurmaNome.Text
            };

            Turma response = new Turma();

            Requests.PostRequest(turma, ref response, Constantes.API_SALVAR_TURMA);

            MessageBox.Show(response.ExibeTurma(Requests.PostRequest(turma, ref response,
               Constantes.API_SALVAR_ALUNO)), "Cadastro de Turmas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            atualizarTurmas();

            textTurmaAno.Text = "";
            textTurmaNome.Text = "";
        }//btnTurma_Click

        private void comboBoxTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            alunoCadastrar = (Turma)comboBoxTurmas.SelectedItem;
        }//comboBoxTurmas_SelectedIndexChanged

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {

            Aluno aluno = new Aluno()
            {
                id_turma = alunoCadastrar.id,
                matriculado = checkBoxAlunoMatriculado.Checked,
                nome = textAlunoNome.Text
            };

            Aluno response = new Aluno();

            MessageBox.Show(response.ExibeAluno(Requests.PostRequest(aluno, ref response, 
                Constantes.API_SALVAR_ALUNO)), "Cadastro de Alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            checkBoxAlunoMatriculado.Checked = false;
            textAlunoNome.Text = "";
        }//btnCadastrarAluno_Click

        private void comboBoxPesquisarTurmas_SelectedIndexChanged(object sender, EventArgs e)
        {
            turmaExibir = (Turma)comboBoxPesquisarTurmas.SelectedItem;
        }//comboBoxPesquisarTurmas_SelectedIndexChanged

        private void atualizarTurmas()
        {
            List<Turma> turmas = new List<Turma>();
            Requests.GetRequest(ref turmas, Constantes.API_CONSULTAR_TURMAS);

            comboBoxTurmas.Items.AddRange(turmas.ToArray());
            comboBoxPesquisarTurmas.Items.AddRange(turmas.ToArray());
        }

        private void btnPesquisarTurma_Click(object sender, EventArgs e)
        {

            List<Aluno> alunosTurma = new List<Aluno>();

            Requests.GetRequest(ref alunosTurma, Constantes.API_CONSULTAR + turmaExibir.id);

            MessageBox.Show(turmaExibir.relatorioTurma(alunosTurma), "Relatório da Turma");

        }//btnPesquisarTurma_Click

    }//partial class formTurma 
}
