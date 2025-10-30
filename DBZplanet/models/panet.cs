using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazzorDBZ.models
{
    public class Planeta
    {
        public int id { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public bool isDestroyed { get; set; }
        public string description { get; set; }
    }
}