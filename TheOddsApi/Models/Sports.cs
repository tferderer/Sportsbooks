﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOddsApi.Models
{
    public class Sports
    {
        public string key { get; set; }

        public string group { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public bool active { get; set; }
    }
}
