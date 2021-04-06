using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestASPNET_NET5.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LasName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}
