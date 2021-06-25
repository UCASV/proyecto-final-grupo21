using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.Model
{
    public partial class Sickness
    {
        public int Id { get; set; }
        public int IdCitizen { get; set; }
        public string Sickness1 { get; set; }

        public virtual Citizen IdCitizenNavigation { get; set; }
    }
}
