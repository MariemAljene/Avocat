using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IDossierService:IService<Dossier>
    {
        void ReductionDossier(Dossier dossier);
    }
}
