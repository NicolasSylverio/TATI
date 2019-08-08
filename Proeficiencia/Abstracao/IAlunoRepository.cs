using Proeficiencia.CrossCutting.Models;
using System;

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
