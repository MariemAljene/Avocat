using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class SpecialiteService : Service<Specialite>, ISpecialiteService
    {
        public SpecialiteService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public int nbDossierParSpecialite(Specialite specialite)
        {
            int count = 0;
            foreach (Avocat avocat in specialite.Avocats)
            {
                count += avocat.Dossiers.Count();

            }
            return count; 
        }

        public Specialite specialite()
        {   IEnumerable<Specialite> specialites=GetAll();
            Specialite specialite1 = (Specialite)specialites.Take(1);
            int max = 0;
            foreach(Specialite specialite in specialites)
            { 
                if(specialite.Avocats.Count()>max)
                {
                    max = specialite.Avocats.Count();
                    specialite1 = specialite;
                }

            }
            return specialite1; 
        }
    }
}
