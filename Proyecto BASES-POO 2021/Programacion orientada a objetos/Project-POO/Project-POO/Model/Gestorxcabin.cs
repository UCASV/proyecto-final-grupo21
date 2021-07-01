using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO
{
    public partial class Gestorxcabin
    {
        public int Id { get; set; }
        public int IdGestor { get; set; }
        public int IdCabin { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Gestor IdGestorNavigation { get; set; }
    }
}
