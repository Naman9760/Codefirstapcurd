using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Codefirstapcurd.Models
{
    public class Employes
    {
        [Key]
        public int Eid { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Mob { get; set; }
        public int salary { get; set; }
    }
}