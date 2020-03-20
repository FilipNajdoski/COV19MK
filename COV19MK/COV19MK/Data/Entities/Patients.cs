using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COV19MK.Data.Entities
{
    public class Patients
    {
        [Key]
        public int Id { get; set; }

        //Patients Informations
        
        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }
        
        //inficirani
        public bool StatusInfected { get; set; }

        public DateTime DateOfInfection { get; set; }

        [StringLength(255)]
        public string CauseOfInfection { get; set; }

        //izleceni
        public bool StatusRecuperated { get; set; }

        public DateTime DateOfRecuperation { get; set; }

        //pocinati
        public bool StatusDead { get; set; }

        public DateTime DateOfDeath { get; set; }   
    }
    public enum Gender
    {
        male,
        female
    }
}
