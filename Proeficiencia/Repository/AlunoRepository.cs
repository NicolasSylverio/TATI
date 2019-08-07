using Proeficiencia.CrossCutting.Models;

namespace Proeficiencia.Repository
{
    public class AlunoRepository : Repository<Aluno>
    {
        public AlunoRepository(Context context)
            : base(context)
        {

        }
    }
}