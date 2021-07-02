using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO
{
    public partial class SecondaryEffect
    {
        public int Id { get; set; }
        public int IdVaccinationProcess { get; set; }
        public string SeccondaryEffects { get; set; }

        public virtual VaccinationProcess IdVaccinationProcessNavigation { get; set; }
    }
}
