using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO.Model
{
    public partial class Gestor
    {
        public Gestor()
        {
            Citizens = new HashSet<Citizen>();
            Gestorxcabins = new HashSet<Gestorxcabin>();
            Registers = new HashSet<Register>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Gestorxcabin> Gestorxcabins { get; set; }
        public virtual ICollection<Register> Registers { get; set; }
    }
}
