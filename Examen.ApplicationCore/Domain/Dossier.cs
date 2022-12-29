using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Dossier
    {
        [Key]
        [DataType(DataType.Date)]

        public DateTime DateDepot { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public float Frais { get; set; }

        public  bool Clos { get; set; }
        [ForeignKey("Client")]
        public int ClientFk { get; set; }
        [ForeignKey("Avocat")]
        public int AvocatFk { get; set; }
        public virtual Client Client { get; set; }
        public virtual Avocat   Avocat { get; set; }

    }
}
