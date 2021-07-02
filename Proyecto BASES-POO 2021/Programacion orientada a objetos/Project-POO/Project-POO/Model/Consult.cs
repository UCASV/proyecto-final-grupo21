using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Project_POO
{
    public partial class Consult
    {
        public Consult()
        {
            VaccinationProcesses = new HashSet<VaccinationProcess>();
        }
        
        [Key]
        public int Id { get; set; }
        public string ConsultationDay { get; set; }
        public string ConsultationTime { get; set; }
        public int IdCabin { get; set; }
        public int IdCitizen { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Citizen IdCitizenNavigation { get; set; }
        public virtual ICollection<VaccinationProcess> VaccinationProcesses { get; set; }
    }
}
