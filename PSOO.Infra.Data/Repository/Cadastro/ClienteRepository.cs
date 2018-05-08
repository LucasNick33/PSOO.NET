using PSOO.Domain.Entity.Cadastro;
using PSOO.Domain.Interfaces.Cadastro;
using PSOO.Infra.Data.Repository.Common;
using System.Collections.Generic;

namespace PSOO.Infra.Data.Repository.Cadastro
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository()
        {

        }        
    }
}
