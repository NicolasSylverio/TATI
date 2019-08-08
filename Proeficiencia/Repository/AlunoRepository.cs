using Proeficiencia.Abstracao;
using Proeficiencia.CrossCutting.Models;

namespace Proeficiencia.Repository
{
    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository()
        {

        }

        public Aluno AlterarAluno(Aluno aluno)
        {
            throw new System.NotImplementedException();
        }

        public bool CadastrarAluno(Aluno aluno)
        {
            _context.Aluno.Add(aluno);

            return true;
        }

        public Aluno ConsultarAluno()
        {
            throw new System.NotImplementedException();
        }

        public bool DeletarAluno(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}