﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Striker : FootballPlayer
    {
        public Striker(string name, int age, string number, int height)
            : base(name, age, number, height)
        {
        }
    }
}