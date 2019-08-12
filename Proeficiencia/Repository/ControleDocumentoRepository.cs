using Proeficiencia.CrossCutting.Models;

namespace Proeficiencia.Repository
{
    public class ControleDocumentoRepository : Repository<ControleDocumento>
    {
        public ControleDocumentoRepository(Context context)
            : base(context)
        {

        }
    }
}