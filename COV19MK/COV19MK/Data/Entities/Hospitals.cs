using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COV19MK.Data.Entities
{
    public class Hospitals
    {
        [Key]
        public int Id { get; set; }

        //[StringLength(255)]
        //public string Name { get; set; }

        //[StringLength(50)]
        //public string Location { get; set; }

        //public int Infected { get; set; }
        //public int Recupurated { get; set; }
        //public int Dead { get; set; }
    }
}
