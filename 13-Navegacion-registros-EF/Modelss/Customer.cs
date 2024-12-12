﻿using System;
using System.Collections.Generic;

namespace _13_Navegacion_registros_EF.Modelss
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? ContactName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
