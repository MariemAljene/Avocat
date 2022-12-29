using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ClientService : Service<Client>, IClientService
    {
        public ClientService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IList<Client> GetClientsAvocat(Avocat avocat)
        { IList<Client> clients = new List<Client>();

          foreach(Dossier dossier in avocat.Dossiers)
            {
                if (DateTime.Now.Day- dossier.DateDepot.Date.Day<10)
                {
                    clients.Append(dossier.Client);
                }
                
            } 
          return clients;
        }
    }
}
