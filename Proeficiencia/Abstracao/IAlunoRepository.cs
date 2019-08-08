using Proeficiencia.CrossCutting.Models;

namespace Proeficiencia.Abstracao
{
    public interface IAlunoRepository
    {
        bool CadastrarAluno(Aluno aluno);

        Aluno AlterarAluno(Aluno aluno);

        bool DeletarAluno(int id);

        Aluno ConsultarAluno();
    }
}