﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer()
        {
            CustomerID = 1;
            Name = "Cuong";
            Address = "HN";
        }
       


}
}
