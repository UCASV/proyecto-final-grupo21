using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO
{
    public partial class Cabin
    {
        public Cabin()
        {
            Consults = new HashSet<Consult>();
            Employees = new HashSet<Employee>();
            Gestorxcabins = new HashSet<Gestorxcabin>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Adress { get; set; }

        public virtual ICollection<Consult> Consults { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Gestorxcabin> Gestorxcabins { get; set; }
    }
}
