using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Specialite
    {
        [Key]
        public int Id { get; set; }
        public string NomSpecialite { get; set; }

        public string Description { get; set; }
        public virtual IList<Avocat> Avocats { get; set; }

    }
}
