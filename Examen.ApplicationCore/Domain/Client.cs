using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Client
    {
        [Key]
        public int CIN { get; set; }
        public string Nom   { get; set; }
        public string PreNom { get; set; }
        public virtual IList<Dossier> Dossiers { get; set; }



    }
}
