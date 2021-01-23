using System;
using System.Collections.Generic;
using System.Net.Http;

namespace WebServiceConsumer.com.webservice.consumer.modelos
{
    public class Turma
    {
        public Int32 id { get; set; }
        public Int32 ano { get; set; }
        public String curso { get; set; }

        public override string ToString()
        {
            return curso;
        }

        public String ExibeTurma(HttpResponseMessage responseResquest)
        {
            return "\t\nDados da Turma\n\nCódigo : " + id + "\nAno : " + ano + "\nCurso : " + curso +
                "\n\nResultado do Cadastro : " + responseResquest.StatusCode + "\n\n";
        }//ExibeAluno

        public String relatorioTurma(List<Aluno> alunos)
        {

            Int32 qtdMatricula = 0;

            foreach (Aluno al in alunos)
                if (al.matriculado == true)
                    qtdMatricula++;

            return "\n     A turma WebServices de ano " + ano + " do curso " + curso + " possui " +alunos.Count + " alunos, " +
                "dos quais " + qtdMatricula + " estão devidamente matriculados\n"; 

        }//relatorioTurma

    }//class Turma
}
