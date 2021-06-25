using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO
{
    public partial class Citizen
    {
        public Citizen()
        {
            Consults = new HashSet<Consult>();
            Sicknesses = new HashSet<Sickness>();
        }

        public int Id { get; set; }
        public int IdGestor { get; set; }
        public int IdInstitution { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Dui { get; set; }
        public int Phone { get; set; }
        public string Adress { get; set; }
        public string FullName { get; set; }

        public virtual Gestor IdGestorNavigation { get; set; }
        public virtual Institution IdInstitutionNavigation { get; set; }
        public virtual ICollection<Consult> Consults { get; set; }
        public virtual ICollection<Sickness> Sicknesses { get; set; }
    }
}
