using Proeficiencia.CrossCutting.Models;
using System.Data.Entity;

namespace Proeficiencia.Repository
{
    public class LoginRepository : Repository<Login>
    {
        public LoginRepository(Context context) 
            : base(context)
        {

        }

        public Login GetByLogin(string login)
        {
            return Context
                .Set<Login>()
                .FirstOrDefaultAsync(x => x.Nome == login)
                .Result;
        }
    }
}
