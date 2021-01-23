using System;
using System.Net.Http;

namespace WebServiceConsumer.com.webservice.consumer.modelos
{
    public class Aluno
    {
        public Int32 id_aluno { get; set; }
        public Int32 id_turma { get; set; }
        public String nome { get; set; }
        public Boolean matriculado { get; set; }

        public String ExibeAluno(HttpResponseMessage responseResquest)
        {
            return "\t\nDados do Aluno\n\nCódigo : " + id_aluno + "\nCódigo da turma : " + id_turma + "\nNome : " + nome +
                "\nMatriculado : " + matriculado + "\n\nResultado do Cadastro : " + responseResquest.StatusCode + "\n\n"; 
        }//ExibeAluno

    }//class Aluno
}
