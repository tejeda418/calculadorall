﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadorall
{
    internal class Classresta
    {
        public Classresta(int n1, int n2)
        {
            N1 = n1;
            N2 = n2;
        }
        public int N1 { get; set; }
        public int N2 { get; set; }

        public int restar()
        {
            return N1 - N2;
        }
    }
}
