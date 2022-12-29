using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class DossierService : Service<Dossier>, IDossierService
    {
        public DossierService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void ReductionDossier(Dossier dossier)
        {
            int count = 0;
            Avocat avocat = dossier.Avocat;
            foreach(Dossier dossier1 in avocat.Dossiers)
            {
                if (dossier1.Clos.Equals(true)) 
                    count++;
            } 
            if(count > 3)
            {
                foreach (Dossier dossier1 in avocat.Dossiers)
                {
                    dossier1.Frais = (float)(dossier1.Frais * 0.7);
                }

            }
           
           
        }
    }
}
