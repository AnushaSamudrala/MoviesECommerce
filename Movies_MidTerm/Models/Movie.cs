﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_MidTerm.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string title  { get; set; }
        public string description { get; set; }
        public string director { get; set; }
        public string writer { get; set; }
        public string stars { get; set; }
        public string trailer { get; set; }
        public string image { get; set; }
        public string price { get; set; }
    }
}
