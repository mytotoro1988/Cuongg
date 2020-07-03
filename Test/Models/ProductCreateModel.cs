using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class ProductCreateModel
    {
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Checkpassword { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime Date { get; set; }
        public string Build { get; set; }
    }
}
