using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO
{
    public partial class Register
    {
        public int Id { get; set; }
        public int IdGestor { get; set; }
        public string Gestor { get; set; }
        public string LoginDay { get; set; }
        public string LoginTime { get; set; }

        public virtual Gestor IdGestorNavigation { get; set; }
    }
}
