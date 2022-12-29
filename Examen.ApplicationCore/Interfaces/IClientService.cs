using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IClientService : IService<Client>
    { 
        public IList<Client> GetClientsAvocat(Avocat avocat);
    }
}
