﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab3Depart
{
    public class LinqExo
    {
        public IEnumerable<Fruit> ContientA(IEnumerable<Fruit> fruits)
        {
            return fruits.Where(f => f.Nom.ToUpper().Contains("A"));
        }
    }
}
