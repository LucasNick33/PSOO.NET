using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSOO.Domain.Services.Cadastro
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteValidator _clienteValidator;

        public ClienteService(IClienteRepository clienteRepository,
            IClienteValidator clienteValidator) : base(clienteRepository, clienteValidator)
        {
            _clienteRepository = clienteRepository;
            _clienteValidator = clienteValidator;
            _clienteValidator.SetService(this);
        }
    }
}
