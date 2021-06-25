using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO
{
    public partial class VaccinationProcess
    {
        public VaccinationProcess()
        {
            SecondaryEffects = new HashSet<SecondaryEffect>();
        }

        public int Id { get; set; }
        public string VaccunationDay { get; set; }
        public string VaccunationTime { get; set; }
        public string CurrentStep { get; set; }
        public string SecondVaccinationDay { get; set; }
        public string SecondVaccinationTime { get; set; }
        public string VaccunationPlace { get; set; }
        public int IdConsult { get; set; }

        public virtual Consult IdConsultNavigation { get; set; }
        public virtual ICollection<SecondaryEffect> SecondaryEffects { get; set; }
    }
}
