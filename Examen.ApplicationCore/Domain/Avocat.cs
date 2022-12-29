using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Avocat
    {
        [Key]
        public int AvocatId { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "This field is required!")]
        public string PreNom { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateEmbauche { get; set; }
        public virtual Specialite Specialite { get; set; } 
        public virtual IList<Dossier> Dossiers { get; set; }

    }
}
