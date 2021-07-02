using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO
{
    public partial class Employee
    {
        public int Id { get; set; }
        public int IdCabin { get; set; }
        public string EmployeeName { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public int IdTypeEmployee { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual TypeEmployee IdTypeEmployeeNavigation { get; set; }
    }
}
