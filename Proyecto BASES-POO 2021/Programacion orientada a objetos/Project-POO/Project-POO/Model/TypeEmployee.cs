﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Project_POO
{
    public partial class TypeEmployee
    {
        public TypeEmployee()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string TypeEmployee1 { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
